' Copyright 2011 Jorge Alberto Gomez Lopez

Imports System.IO
Imports System.Collections.Specialized
Imports System.Collections.ArrayList

Namespace org.distantwb.main
    Public Class FrmBrowser

        ' variables:
        ' txtUrl: es un simple textbox
        ' btnBack: boton que regresa a la pagina anterior
        ' btnFwrd: boton que va a la sig. pagina
        ' btnRecharge: recarga la pagina que se esta viendo
        ' btnStop: detiene el request
        ' pgrBar: barra que muestra el progreso de los datos recibidos
        ' lblDone: muestra el estado actual de la navegacion
        ' i: un contador para ir recorriendo las pestañas del Tab control
        ' Tab: un tab control
        ' btnAddTab: crea una nueva pestaña
        ' btnCloseTab: cierra la pestaña actual
        ' OpenDialog: una instancia de OpenFileDialog
        ' SaveDialog: una instancia de SaveFileDialog
        ' lblTime: label que muestra la hora del sistema
        ' Timer: un timer que se activa cada 100 para cambiar la hora
        ' cmbRapidSearch: combobox que despliega los diferentes motores de busqueda
        ' que pueden ser usados para una busqueda rapida
        ' txtSearchQuery: un textbox que contendra lo que quiere buscar el usuario rapidamente
        ' btnSearch:  boton que sirve para realizar una busqueda rapida
        ' ImageList: control del tipo ImageList que contendrá las imagenes de los diferentes 
        '            motores de busqueda que puede usar el usuario para realizar busquedas rapidas
        ' MenuStrip1: un control del tipo MenuStrip

        '-----------------------------------------------------------------------------------------------------------
        ' variables usadas por todo el programa

        Dim i As Integer = 1
        ' guarda las referencias en memoria de las dll....
        Dim AddOnsComponents As New ArrayList
        ' guardamos las forms principales de todos los addons
        Dim AddOns As New Dictionary(Of String, Form)


        '------------------------------------------------------------------------------------------------------------
        ' metodos respectivos a esta form

        ' cuando se abra el programa creamos una pestaña por default...
        Private Sub FrmBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim browse As New WebBrowser
            Tab.TabPages.Add(i, "Page " & i)
            Tab.SelectTab(i - 1)
            browse.Name = "wb"
            browse.Dock = DockStyle.Fill
            Tab.SelectedTab.Controls.Add(browse)
            ' añadimos los manejadores a los botones y menus
            ' se ha hecho generica para no repetir codigo...
            ' por eso hay más AddHandler....
            AddHandler btnAddTab.Click, AddressOf AddTab_Click
            AddHandler menuItemAddTab.Click, AddressOf AddTab_Click
            AddHandler menuItemCloseTab.Click, AddressOf CloseTab_Click
            AddHandler btnCloseTab.Click, AddressOf CloseTab_Click
            ' aqui tambien añadimos los manejadores
            AddHandler browse.DocumentCompleted, AddressOf browse_complete
            AddHandler browse.ProgressChanged, AddressOf browse_progressChanged
            AddHandler browse.Navigating, AddressOf browse_navigating
            AddHandler browse.FileDownload, AddressOf file_download

            BookmarkBarPagesItem.DropDownItems.Clear()
            get_bookmarks()
            initialize_Components()

            ' snippet took it from http://www.devasp.net/net/articles/display/365.html
            ' creamos un array que contendra algun texto de las imagenes
            Dim items(Me.ImageList.Images.Count - 1) As String
            ' llenamos el array
            For i As Int32 = 0 To Me.ImageList.Images.Count - 1
                items(i) = "Item " & i.ToString
            Next
            ' agregamos anticipadamente cuantas imagenes contendra...
            Me.cmbRapidSearch.Items.AddRange(items)
            ' elegimos que se despliegue una lista
            Me.cmbRapidSearch.DropDownStyle = ComboBoxStyle.DropDownList
            ' el modo de dibujo(inicializacion)  lo definimos nosotros
            Me.cmbRapidSearch.DrawMode = DrawMode.OwnerDrawVariable
            ' ahora declaramos el alto y ancho
            Me.cmbRapidSearch.ItemHeight = Me.ImageList.ImageSize.Height
            ' le agregamos el "+24" ya que se cuenta que la flecha cubrira
            ' parte de la imagen y eso no lo queremos
            Me.cmbRapidSearch.Width = Me.ImageList.ImageSize.Width + 24
            Me.cmbRapidSearch.MaxDropDownItems = Me.ImageList.Images.Count
        End Sub

        ' ya que tuve problemas con cerrar la bienvenida, recurri a otra opcion:
        ' estado visible = false a welcome.vb, y cuando cierre el browser
        ' cerrara todo
        Private Sub FrmBrowser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            Application.Exit()
        End Sub


        '-----------------------------------------------------------------------------------------------------------
        ' Funciones usadas internamente

        ' esta funcion se ha hecho para no duplicar codigo....
        Private Sub addTab()
            i = i + 1
            ' creamos un nuevo objeto WebBrowser
            Dim browse As New WebBrowser
            ' añadimos la pestaña al tab control (Tab)
            Tab.TabPages.Add(i, "Page " & i)
            ' nos posicionamos en la pestaña nueva
            Tab.SelectTab(i - 1)
            browse.Name = "wb"
            browse.Dock = DockStyle.Fill
            ' añadimos el objeto WebBrowser a la pestaña actual
            Tab.SelectedTab.Controls.Add(browse)
            ' añadimos los manejadores al objeto WebBrowser
            AddHandler browse.DocumentCompleted, AddressOf browse_complete
            AddHandler browse.ProgressChanged, AddressOf browse_progressChanged
            AddHandler browse.Navigating, AddressOf browse_navigating
            ' aumentamos el contador
        End Sub

        ' funcion encargada de realizar la busqueda dependiendo de la seleccion del usuario
        Private Sub search()
            If cmbRapidSearch.SelectedIndex = 0 Then
                ' guarda el sring de consulta para luego ser desplegado como sugerencia
                My.Settings.SearchQueries.Add(txtSearchQuery.Text)
                CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" & txtSearchQuery.Text)
            Else
                MsgBox("Use a valid search engine in the selection")
            End If
        End Sub

        ' si el usuario quiere añadir una pestaña (Tab)...
        Private Sub AddTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            addTab()
        End Sub

        ' el usuario quiere cerrar una pestaña!!!
        Public Sub CloseTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Tab.Controls.Remove(Tab.SelectedTab)
            i = i - 1
        End Sub

        ' el objeto WebBrowser de la pestaña actual esta navegando... asi que
        Private Sub browse_navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs)
            ' activamos el boton btnStop para darle al usuario la opcion de 
            ' detener el pedido (request)
            btnStop.Enabled = True
            lblDone.Text = "Wait..."
        End Sub

        ' cualquier objeto WebBrowser que este navegando activa este manejador
        ' aca nada mas queremos reflejar el proceso de cuanto se ha completado
        Public Sub browse_progressChanged(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
            If e.MaximumProgress <> 0 And e.MaximumProgress >= e.CurrentProgress Then
                pgrBar.Value = Convert.ToInt32(100 * e.CurrentProgress / e.MaximumProgress)
            End If
        End Sub

        ' el objeto WebBrowser ha terminado la carga de la pagina.. asi que....
        Private Sub browse_complete(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
            ' cambiamos el texto de txtUrl para que refleje la URL actual
            txtUrl.Text = CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString()
            ' cambiamos el texto de la pestaña actual
            Tab.SelectedTab.Text = CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle.ToString()
            ' le preguntamos al objeto WebBrowser actual si puede regresar a la pagina anterior
            ' si es asi, el btnBack ya puede ser usado..
            btnBack.Enabled = CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack
            ' igualmente para este
            btnFwrd.Enabled = CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward
            ' ya termino todo, asi que volvemos a 0 al pgrBar
            pgrBar.Value = 0
            ' ya el usuario no puede detener la carga de la pagina, asi que ya no puede
            ' usar el boton.
            btnStop.Enabled = False
            lblDone.Text = "Done"
            ' la pagina ha terminado de cargar... ahora guardamos la url en el historial
            ' vemos si el historial ya posee la URL buscada
            If (My.Settings.History.Contains(CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)) Then
                ' si es asi, no hacemos nada ya que la pagina ya fue buscada....
            Else
                ' si no esta la agregamos....
                My.Settings.History.Add(CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
            End If
        End Sub

        ' funcion que obtiene las URLs de las pestañas
        Private Function get_URLs() As StringCollection
            ' crea la coleccion que va a ser devuelta
            Dim urls As New StringCollection
            ' recorremos las pestañas de una en una
            For Each item As TabPage In Tab.TabPages
                ' variable que contiene el objeto WebBrowser de la pestaña actual
                Dim actualWeb As WebBrowser
                actualWeb = CType(item.Controls.Item(0), WebBrowser)
                ' lo encerramos en un try..catch ya que puede ser que el objeto
                ' WebBrowser no haya navegado aun en una pagina, por ende
                ' puede no estar seteada la variable Url
                Try
                    urls.Add(actualWeb.Url.ToString)
                Catch ex As Exception

                End Try
            Next
            ' retornamos todas las URLs
            Return urls
        End Function

        Private Sub restore_Session(ByVal url As String)
            ' llamamos a crear pestaña
            addTab()
            ' nos pocisionamos en el tab actual y navegamos... el Try..Catch
            ' por si ocurre un error al navegar
            Try
                CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Navigate(url)
            Catch ex As Exception
                MsgBox("Error al abrir una de las pestañas de sesion guardada")
            End Try
        End Sub

        ' funcion que tiene como objetivo obtener todas las URL guardadas 
        Private Sub get_bookmarks()
            For Each item As String In My.Settings.Bookmarks
                Dim add As New ToolStripButton
                add.Text = item
                AddHandler add.Click, AddressOf bookmark_clicked
                BookmarkBarPagesItem.DropDownItems.Add(add)
            Next
        End Sub

        ' esta funcion es llamada por HistoryForm.... para poder abrir la
        ' URL seleccionada en el historial
        Public Sub external_Call(ByVal url As String)
            addTab()
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Navigate(url)
        End Sub

        ' funcion que es llamada por el metodo FrmBrowser_Load()
        ' esta funcion captura las rutas de los addons agregados
        ' y los muestra en addOnsBar
        Private Sub initialize_Components()
            ' capturamos las rutas de donde se encuentran los addons
            For Each item As String In My.Settings.AddOns
                ' si falla algo mostramos el error
                Try
                    ' cargamos en memoria el addon (o sea el .dll que hace funcion de addon)
                    Dim actual As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(item)
                    ' guardamos la referencia al dll por las dudas....
                    AddOnsComponents.Add(actual)
                    ' necesitamos saber el nombre del .dll asi que primero partimos la ruta
                    Dim parted() As String = item.Split(New Char() {"\"c})
                    Dim DLLName As String = parted(parted.Length - 1)
                    ' ahora que tenemos el nombre de la dll + la extension
                    ' quitamos la extension y tomamos el nombre en si
                    DLLName = DLLName.Split(New Char() {"."c})(0)
                    ' ya que tenemos el nombre simplemente creamos la instancia del form principal
                    ' (leer a que me refiero en el post de CPH donde encontrste esto...)
                    Dim p As Form = actual.CreateInstance(DLLName & ".FrmBase")
                    ' agregamos la form principal del addon al diccionario
                    ' nos referiremos al addon con el titulo de la form principal (o sea el key va a ser el titulo de la form principal)
                    ' asi es como lo buscaremos a la hora de intentar usarlo
                    AddOns.Add(p.Text, p)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Next
            ' ahora desplegaremos todos los addons cargados correctamente al addOnsBar
            display_components()
        End Sub

        Private Sub display_components()
            ' todo lo que esta dentro del diccionario ha sido cargado correctamente
            ' asi que ahora obtenemos todas las llaves....
            Dim list As New List(Of String)(AddOns.Keys)
            ' creamos un item para cada addon
            For Each item As String In list
                Dim add As New ToolStripButton
                add.Text = item
                ' la accion que realizara cuando sea clickada...
                AddHandler add.Click, AddressOf addOn_Clicked
                addOnsBar.DropDownItems.Add(add)
            Next
        End Sub

        ' el usuario quiere usar un addon!!!
        Private Sub addOn_Clicked(ByVal sender As Object, ByVal e As System.EventArgs)
            ' obtenemos la referencia actual del item del menu
            Dim actual As ToolStripItem
            actual = CType(sender, ToolStripItem)
            ' aunque el texto del item del menu es la llave en el diccionario
            ' comprobamos por las dudas que exista la llave
            If AddOns.ContainsKey(actual.Text) Then
                ' si existe obtenemos la form y la desplegamos
                ' para que el usuario pueda usar el addon
                Dim selected As Form = AddOns.Item(actual.Text)
                selected.Show()
            End If
        End Sub

        ' una de las URL guardadas ha sido seleccionada asi que
        ' vamos a la pagina que representa
        Public Sub bookmark_clicked(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim actual As ToolStripItem
            actual = CType(sender, ToolStripItem)
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Navigate(actual.Text)
        End Sub

        '-----------------------------------------------------------------------------------------------------------
        ' funciones respectivas al menustrip

        ' el usuario quiere ir al manager de descargas, asi que lo llevamos a el
        Private Sub DownloadManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultItemDMsubItem.Click
            org.distantwb.tools.downloader.frmDownloadManager.Show()
        End Sub

        ' el usuario quiere ir al calendario, asi que lo llevamos a el
        Private Sub defaultItemCalendarSubItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultItemCalendarSubItem.Click
            org.distantwb.tools.calendar.FrmCalendar.Show()
        End Sub

        ' el usuario quiere usar el cliente ftp, asi que lo llevamos a el
        Private Sub defaultItemFTPClientSubItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultItemFTPClientSubItem.Click
            org.distantwb.tools.clients.ftpclient.FrmFTPClient.Show()
        End Sub

        ' simplemente muestra los creditos
        Private Sub AboutBarAboutItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBarAboutItem.Click
            FrmAbout.Show()
            Dim test As New NumberedTextBox
        End Sub

        ' el usuario quiere entrar al editor html, asi que lo llevamos a el
        Private Sub defaultItemHTMEditorSubItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultItemHTMEditorSubItem.Click
            org.distantwb.tools.editors.html.FrmHTMLEditor.Show()
        End Sub

        ' el usuario quiere abrir un archivo pdf, comenzamos el proceso
        Private Sub OtherItemOpenPDFSubItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherItemOpenPDFSubItem.Click
            ' filtramos los archivos para ver solo los archivos pdf
            OpenDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' ya que el webbrowser control es capaz de abrir archivos pdf
                ' simplemente reutilizamos el codigo ya escrito
                addTab()
                ' navegamos a la ruta en donde se encuentra el pdf
                CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Navigate(OpenDialog.FileName)
            End If
        End Sub

        ' el usuario quiere acceder a la calculadora, asi que lo llevamos a ella
        Private Sub defaultItemCalculatorSubItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultItemCalculatorSubItem.Click
            org.distantwb.tools.calculator.FrmCalculator.Show()
        End Sub

        ' le damos la opcion al usuario de poder guardar la pagina que esta visualizando
        ' en ese momento
        Private Sub ArchiveBarSaveAsItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarSaveAsItem.Click
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).ShowSaveAsDialog()
        End Sub

        ' le damos la opcion al usuario de poder imprimir la vista actual de la pagina web
        Private Sub ArchiveBarPrintItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarPrintItem.Click
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
        End Sub

        ' le damos la opcion al usuario de poder ver las propiedades de la pagina
        Private Sub ArchiveBarPropertiesItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarPropertiesItem.Click
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
        End Sub

        ' funcion que abre "x" sesion guardada
        Private Sub ArchiveBarOpenSessionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarOpenSessionItem.Click
            ' guarda la linea que se lee en el momento
            Dim sLine As String
            ' guarda todas las URLs encontradas en el .txt
            Dim urls As New StringCollection
            ' Filtro para solo ver los archivos .txt
            OpenDialog.Filter = "Text files (*.txt)|*.txt"
            ' Si se pudo abrir el archivo prosigue
            If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' crea el stream de lectura del archivo
                Dim myStream As StreamReader = New StreamReader(OpenDialog.FileName)
                ' repite el proceso de leer-guardar linea en la coleccion de String
                Do
                    sLine = myStream.ReadLine
                    ' puede ser que la linea que se este leyendo no posea nada
                    ' para evitarnos de un error preguntamos primero si hay linea
                    If Not sLine Is Nothing Then
                        urls.Add(sLine)
                    End If
                Loop Until sLine Is Nothing
                ' ya que vamos a eliminar las pestañas que hay preparamos el contador
                ' para evitarnos de errores de referencia a las pestañas
                i = i - Tab.TabCount
                ' eliminamos todas las pestañas
                Tab.TabPages.Clear()
                ' leemos la coleccion de una en una y vamos creando las pestañas
                For Each url As String In urls
                    ' llama a la funcion que hace la creacion de las pestañas
                    restore_Session(url)
                Next
            End If
        End Sub

        ' el item Get Source es apretado por el usuario
        Private Sub ArchiveBarGetSourceItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarGetSourceItem.Click
            ' variable que guarda el string
            Dim code As String
            ' obtenemos el code de la pagina actual...
            code = CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Document.ActiveElement.InnerHtml
            ' le pasamos el code a la form que muestra el source
            FrmSourceHTML.source = code
            ' mostramos la form
            FrmSourceHTML.Show()
        End Sub

        ' el usuario quiere eliminar un(os) bookmark
        Private Sub BookmarkBarDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookmarkBarDeleteItem.Click
            ' lo llevamos a la form encargada
            FrmDeleteBookmark.Show()
        End Sub

        ' funcion que guarda las URL de las pestañas que hay para dar la sensacion
        ' de que se ha guardado la sesion
        Private Sub ArchiveBarSaveSessionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarSaveSessionItem.Click
            ' filtro para solo poder guardar archivos .txt
            SaveDialog.Filter = "Text files (*.txt)|*.txt"
            ' si el archivo puede ser guardado procede...
            If SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' creamos el stream para guardar las URLs
                Dim myStream As StreamWriter = New StreamWriter(SaveDialog.FileName, True)
                ' aca llamamos a la funcion que obtiene todas las URLs actuales y 
                ' las guarda en una coleccion de String
                Dim toSave As StringCollection = get_URLs()
                ' ahora hacemos un recorrido a todas las url
                For Each item As String In toSave
                    ' guardas las URLs de una en una
                    myStream.WriteLine(item)
                Next
                ' cerramos el stream
                myStream.Close()
                MsgBox("Session Saved Sucessfully")
            Else
                MsgBox("Hubo un error!!")
            End If

        End Sub

        ' el usuario quiere agregar un addOn
        ' asi que lo llevamos al asistente
        Private Sub addOnsBarAddComponentItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addOnsBarAddComponentItem.Click
            FrmAddOnsManager.Show()
        End Sub

        ' el usuario ha hecho click a "Add!", asi que guardamos el texto 
        ' que se encuentra en bookmarkTxtBox
        Private Sub bookmarkBarAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bookmarkBarAddItem.Click
            ' si la URL especificada ya existe no hacemos nada
            If (My.Settings.Bookmarks.Contains(bookmarkTxtBox.Text)) Then
                MsgBox("" & bookmarkTxtBox.Text & " ya existe en bookmark")
                ' pero si no existe la agregamos
            Else
                My.Settings.Bookmarks.Add(bookmarkTxtBox.Text)
            End If
        End Sub

        Private Sub historyBarViewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles historyBarViewItem.Click
            HistoryForm.dad = CType(Me, FrmBrowser)
            HistoryForm.Show()
        End Sub

        ' el usuario quiere ir a la libreta de notas... lo llevamos a el
        Private Sub defaultItemNotebookSubItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultItemNotebookSubItem.Click
            org.distantwb.tools.notebook.FrmNotebook.Show()
        End Sub

        '-----------------------------------------------------------------------------------------------------------


        ' el usuario quiere regresar a la pagina anterior.. has lo siguiente
        Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
            ' buscamos en el panel la vista actual,
            ' luego de econcontarla, le decimos a ese objeto
            ' que regrese a la pagina anterior
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        End Sub

        ' el usuario quiere ver las paginas que estaba viendo.. asi que has lo siguiente
        Private Sub btnFwrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFwrd.Click
            ' buscamos en el tab panel la vista actual
            ' luego de encontrarla, le decimos a ese objeto
            ' que vaya a la siguiente pag.
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        End Sub

        ' el usuario quiere recargar la pagina... has lo siguiente
        Private Sub btnRecharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecharge.Click
            ' buscamos en el tab panel la vista (WebBrowser control) actual
            ' luego de enconbtrarlo, le decimos a ese objeto
            ' que recargue la pagina
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        End Sub

        ' el usuario se arrepintió y ya no quiere la pagina, asi que has lo siguiente..
        Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
            ' buscamos en el tab panel la vista actual
            ' luego de encontrarla, le decimos a ese objeto
            ' que detenga el envio/recibimiento de datos
            CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Stop()
        End Sub

        ' el usuario ha digitado algo en el txtUrl!!!
        Private Sub txtUrl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUrl.KeyDown
            ' si lo digitado es un "Enter"...
            If e.KeyData = Keys.Enter Then
                ' revisamos si la url dada comienza con los protocolos ya conocidos
                ' si es asi navegamos normalmente
                If txtUrl.Text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) Or _
                txtUrl.Text.StartsWith("ftp://", StringComparison.OrdinalIgnoreCase) Or _
                txtUrl.Text.StartsWith("file://", StringComparison.OrdinalIgnoreCase) Or _
                txtUrl.Text.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
                    CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Navigate(txtUrl.Text)
                Else
                    ' si es lo contrario interpretamos que el usuario quiere hacer una busqueda rapida
                    ' asi que procedemos....
                    ' guardamos el string de la consulta en My.Settings.SearchQueries
                    ' para luego ser mostradas en las sugerencias....
                    My.Settings.SearchQueries.Add(txtUrl.Text)
                    CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.google.com/search?q=" & txtUrl.Text)
                End If
            End If
        End Sub

        ' snippet took it from http://www.devasp.net/net/articles/display/365.html
        Private Sub cmbRapidSearch_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmbRapidSearch.DrawItem
            ' si hay algo que dibujar lo hacemos
            If e.Index <> -1 Then
                e.Graphics.DrawImage(Me.ImageList.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
            End If
        End Sub

        ' snippet took it from http://www.devasp.net/net/articles/display/365.html
        Private Sub cmbRapidSearch_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles cmbRapidSearch.MeasureItem
            ' simplemente declaramos ancho y alto de cada item...
            e.ItemHeight = Me.ImageList.ImageSize.Height
            e.ItemWidth = Me.ImageList.ImageSize.Width
        End Sub

        ' el usuario ha seleccionado otra pestaña!!
        Private Sub tab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab.SelectedIndexChanged
            ' el try es porque este manejador se ejecuta cuando el usuario ha 
            ' seleccionado una pestaña o ha creado una nueva.. y cuando se crea
            ' una nueva el objeto WebBrowser no posee una url actual
            Try
                ' le preguntamos al objeto WebBrowser de la pestaña actual cual es 
                ' su URL
                txtUrl.Text = CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            Catch ex As Exception
                ' si no tuviera una URL actual... no muestres nada...
                txtUrl.Text = ""
            End Try
        End Sub

        ' La barra "Bookmark" ha sido seleccionada.. pero no sabemos si ha habido
        ' cambios en la lista de URLs (My.Settings.Bookmarks) asi que
        ' actualizamos
        Private Sub bookmarkBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bookmarkBar.Click
            Try
                ' set al texto por si el usuario quiere guardar la URL
                bookmarkTxtBox.Text = CType(Tab.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
                ' descartamos todos los items de "Pages" para no repetir
                BookmarkBarPagesItem.DropDownItems.Clear()
                ' actualizamos los items de "Pages"
                get_bookmarks()
            Catch ex As Exception
                bookmarkTxtBox.Text = ""
                BookmarkBarPagesItem.DropDownItems.Clear()
                get_bookmarks()
            End Try
        End Sub

        ' simplemente obtiene la hora cada 100.....
        Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
            lblTime.Text = Date.Now.ToLongTimeString
        End Sub

        ' el usuario quiere hacer una busqueda rapida, asi que procedemos
        Private Sub txtSearchQuery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchQuery.KeyDown
            If e.KeyData = Keys.Enter Then
                search()
            End If
        End Sub

        ' .... por si el usuario quiere buscar tambien usando el boton...
        Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            search()
        End Sub

        ' cada vez que el usuario use la barra de busqueda
        ' antes de que haga algo, cargamos todas las sugerencias para que se vayan
        ' mostrando mientras el usuario teclea
        Private Sub txtUrl_focused(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUrl.LostFocus
            txtUrl.AutoCompleteCustomSource.Clear()
            For Each suggestion As String In My.Settings.History
                txtUrl.AutoCompleteCustomSource.Add(suggestion)
            Next
            For Each query As String In My.Settings.SearchQueries
                txtUrl.AutoCompleteCustomSource.Add(query)
            Next
        End Sub

        ' cada vez que el usuario use la barra de busqueda rapida
        ' antes de que haga algo, cargamos todas las sugerencias para que se vayan
        ' mostrando mientras el usuario teclea
        Private Sub txtSearchQuery_focused(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchQuery.LostFocus
            txtSearchQuery.AutoCompleteCustomSource.Clear()
            For Each query As String In My.Settings.SearchQueries
                txtSearchQuery.AutoCompleteCustomSource.Add(query)
            Next
        End Sub

        Private Sub file_download(ByVal sender As Object, ByVal e As System.EventArgs)

        End Sub
    End Class
End Namespace