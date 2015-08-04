' Copyright 2011 Jorge Alberto Gomez Lopez

Imports System.IO

Namespace org.distantwb.tools.editors.html
    Public Class FrmHTMLEditor
        ' variable que sirve como contador para saber cuantas pestañas hay
        ' actualmente
        Dim i As Integer = 1

        ' el usuario quiere crear una nueva area de trabajo, asi que lo hacemos
        Private Sub ArchiveBarAddTabItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarAddTabItem.Click
            addTab()
        End Sub

        ' ya que cada pestaña tiene su propio numberedtextbox, solo creamos una nueva
        Private Sub addTab()
            i = i + 1
            Dim htmlPage As New NumberedTextBox
            Tab.TabPages.Add(i, "Page " & i)
            Tab.SelectTab(i - 1)
            htmlPage.Name = "txtBox"
            htmlPage.Dock = DockStyle.Fill
            Tab.SelectedTab.Controls.Add(htmlPage)
        End Sub

        ' creamos una pestaña por default
        Private Sub FrmHTMLEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim htmlPage As New NumberedTextBox
            Tab.TabPages.Add(i, "Page " & i)
            Tab.SelectTab(i - 1)
            htmlPage.Name = "txtBox"
            htmlPage.Dock = DockStyle.Fill
            Tab.SelectedTab.Controls.Add(htmlPage)
        End Sub

        ' el usuario quiere cerrar un area de trabajo, pero no estamos seguros
        ' si ha sido guardado el documento, asi que mostramos dialogo
        ' de guardado
        Private Sub ArchiveBarCloseTabItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarCloseTabItem.Click
            ' pasamos una referencia al dialogo, ya que el dialogo llamara a los metodos de esta
            ' form para realizar los cambios debidos
            sure.dad = Me
            sure.Show()
        End Sub

        ' en el dialogo el usuario ha aceptado guardar el archivo
        ' asi que con la referencia de esta form obtenida anteriormente
        ' por el dialogo, llama a este metodo
        Public Sub Save_changes()
            SaveDialog.Filter = "html page (*.html)|*.html"
            If SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Dim myStream As StreamWriter = New StreamWriter(SaveDialog.FileName, True)
                    myStream.Write(CType(Tab.SelectedTab.Controls.Item(0), NumberedTextBox).get_text())
                    myStream.Close()
                Catch ex As Exception
                    MsgBox("Error saving file " & ex.ToString)
                End Try
            End If
        End Sub

        ' en el dialogo el usuario se ha negado guardar el archivo
        ' asi que con la referencia de esta form obtenida anteriormente
        ' por el dialogo, llama a este metodo
        Public Sub close_tab()
            Tab.Controls.Remove(Tab.SelectedTab)
            i = i - 1
        End Sub

        ' el usuario quiere guardar manualmente el archivo, asi que lo guardamos...
        Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarSaveItem.Click
            Save_changes()
        End Sub

        ' el usuario quiere abrir un *.html ya existente, asi que proseguimos
        Private Sub ArchiveBarOpenItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchiveBarOpenItem.Click
            ' creamos una area de trabajo nueva
            addTab()
            ' y en esta ponemos los datos del archivo html obtenido
            OpenDialog.Filter = "HTML pages (*.html)|*.html"
            If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Dim myStream As StreamReader = New StreamReader(OpenDialog.FileName)
                    Dim text As String = myStream.ReadToEnd()
                    CType(Tab.SelectedTab.Controls.Item(0), NumberedTextBox).set_text(text)
                    Tab.SelectedTab.Text = OpenDialog.FileName.Split("\"c)(OpenDialog.FileName.Split("\"c).Length - 1)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End Sub

        ' el usuario quiere ver el resultado final de tal html, asi que lo
        ' mostramos
        Private Sub archiveBarPreviewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles archiveBarPreviewItem.Click
            ' le pasamos el texto actual que posee NumberedTextBox a la form que lo desplegara...
            FrmDisplayHTML.html = CType(Tab.SelectedTab.Controls.Item(0), NumberedTextBox).get_text()
            FrmDisplayHTML.Show()
        End Sub
    End Class
End Namespace