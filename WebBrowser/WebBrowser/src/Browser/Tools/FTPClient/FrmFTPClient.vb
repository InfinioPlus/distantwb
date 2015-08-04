' Copyright Jorge Alberto Gomez Lopez 2011

Imports System.IO
Imports System.Net

Namespace org.distantwb.tools.clients.ftpclient
    Public Class FrmFTPClient
        ' variable que guardara el nombre de usuario dado
        Dim user As String
        ' variable que guardara la direccion ftp
        Dim url As String
        ' guardara la contraseña del usuario
        Dim password As String

        ' el usuario quiere conectarse al ftp asi que procedemos
        Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
            ' lo encerramos en un try..catch por si sucede un error
            Try
                ' creamos la peticion al servidor ftp
                Dim request As FtpWebRequest
                ' creamos la peticion dando la url del ftp
                request = CType(WebRequest.Create(New Uri(txtUrl.Text)), FtpWebRequest)
                ' proporcionamos la informacion basica requerida(usuario-contraseña)
                request.Credentials = New NetworkCredential(txtUsername.Text, txtPassword.Text)
                ' guardamos la info en las variables 
                user = txtUsername.Text
                password = txtPassword.Text
                url = txtUrl.Text
                ' limpiamos los datos de txtPassword, txtUsername y los desactivamos
                ' par que el usuario no pueda cambiar ninguna data sensible
                clean_fields()
                txtOutput.AppendText("OK, please start to work")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        ' funcion que limpia y desactiva los campos que contienen data sensible para que
        ' el usuario no pueda cambiarlos en el transcurso de la sesion....
        Private Sub clean_fields()
            txtUrl.Text = ""
            txtUrl.Enabled = False
            txtUsername.Text = ""
            txtUsername.Enabled = False
            txtPassword.Text = ""
            txtPassword.Enabled = False
        End Sub

        ' el usuario quiere ver los directorios y archivos de la ruta dada.. asi que procdemos
        ' NOTA: no hay que dar la url del ftp, solo la ruta de donde quiere buscar
        ' EJ: directorio/directorio2
        ' ya que el programa interpreta esto automaticamente como
        ' ftp://direccion.tal/directorio/directorio2
        Private Sub btnListAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListAll.Click
            ' comprobamos que el usuario halla llenado los campos con informacion basica
            If preview_requisites() Then
                ' si el usuario no ha escrito nada, interpretamos que el usuario quiere
                ' quiere ver los archivos y directorios del root del sitio
                If txtGetDetailsOf.Text = "" Then
                    txtOutput.AppendText(Environment.NewLine)
                    txtOutput.AppendText(Environment.NewLine)
                    txtOutput.AppendText("Listing root directory....")
                    ' creamos request dando solamente la url ftp dada al programa
                    Dim request As FtpWebRequest
                    request = CType(WebRequest.Create(New Uri(url)), FtpWebRequest)
                    ' ponemos los credenciales ya dados
                    request.Credentials = New NetworkCredential(user, password)
                    ' le decimos al servidor ftp que queremos obtener una lista de archivos/directorios
                    ' de la ruta dada
                    request.Method = WebRequestMethods.Ftp.ListDirectoryDetails
                    ' obtenemos la respuesta del servidor ftp
                    Dim response As FtpWebResponse = request.GetResponse
                    ' obtenemos el stream de la respuesta
                    Dim sr As New StreamReader(response.GetResponseStream())
                    ' obtenemos la data y hacemos algunos formateos de datos
                    Dim str As String = sr.ReadToEnd()
                    str = str.Replace(vbCrLf, vbCr).TrimEnd(Chr(13))
                    txtOutput.AppendText(Environment.NewLine)
                    txtOutput.AppendText(Environment.NewLine)
                    ' desplegamos en el log los resultados
                    txtOutput.AppendText(str)
                Else
                    ' si no esta vacio, comprobamos que no haya escrito en el principio de la ruta un / o \
                    If txtGetDetailsOf.Text.StartsWith("/") Or txtGetDetailsOf.Text.StartsWith("\") Then
                        MsgBox("Please delete \ or / on the directory search textbox")
                    Else
                        ' creamos request con la url del ftp + la ruta dada en el txtGetDetailsOf
                        Dim request As FtpWebRequest
                        request = CType(WebRequest.Create(New Uri(url & txtGetDetailsOf.Text)), FtpWebRequest)
                        ' damos credenciales
                        request.Credentials = New NetworkCredential(user, password)
                        ' le decimos al servidor ftp que queremos obtener la lista de archivos/directorios
                        ' de la ruta dada
                        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails
                        ' obtenemos response, su stream
                        Dim response As FtpWebResponse = request.GetResponse
                        Dim sr As New StreamReader(response.GetResponseStream())
                        ' obtenemos la data del stream
                        Dim str As String = sr.ReadToEnd()
                        ' formateamos y devolvemos...
                        str = str.Replace(vbCrLf, vbCr).TrimEnd(Chr(13))
                        txtOutput.AppendText(Environment.NewLine)
                        txtOutput.AppendText(Environment.NewLine)
                        txtOutput.AppendText(str)
                    End If
                End If
            Else
                MsgBox("Please start a new session and fill url, username, password and click connect")
            End If
        End Sub

        ' el usuario quiere subir un archivo asi que le da a browse
        ' simplemente ponemos en el txtUploadFile la ruta dada
        Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
            OpenDialog.Filter = "All files (*.*)|*.*"
            If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtUploadFile.Text = OpenDialog.FileName
            End If
        End Sub

        ' el usuario esta listo para subir el archivo asi que procedemos...
        Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
            ' deshabilitamos los controles relacionados al trabajo de subida
            ' para que el usuario no pueda modificar nada mientras trabajamos...
            txtDestination.Enabled = False
            txtUploadFile.Enabled = False
            btnBrowse.Enabled = False
            btnUpload.Enabled = False
            ' llamamos al proceso que hara el trabajo
            UploadWorker.RunWorkerAsync()
            txtDestination.Enabled = True
            txtUploadFile.Enabled = True
            btnBrowse.Enabled = True
            btnUpload.Enabled = True
        End Sub

        Private Sub UploadWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles UploadWorker.DoWork
            ' comprobamos que los requisitos previos hayan sido cumplidos
            If preview_requisites() Then
                If txtUploadFile.Text <> "" Then
                    ' comprobamos que la ruta de destino no comienze con / o \
                    If txtDestination.Text.StartsWith("/") Or txtDestination.Text.StartsWith("\") Then
                        MsgBox("Please delete \ or / on the destination path textbox")
                    Else
                        ' comenzamos el trabajo de subida
                        Try
                            ' creamos request
                            Dim request As FtpWebRequest
                            ' obtenemos en memoria el archivo que sera leido
                            Dim infoFichero As New FileInfo(txtUploadFile.Text)
                            ' le damos al request la url del ftp + la ruta de destino dada por el usuario
                            request = CType(WebRequest.Create(New Uri(url & txtDestination.Text)), FtpWebRequest)
                            ' damos credenciales
                            request.Credentials = New NetworkCredential(user, password)
                            ' le decimos al servidor ftp que queremos subir un archivo
                            request.Method = WebRequestMethods.Ftp.UploadFile
                            request.UseBinary = True
                            ' le decimos al servidor ftp el tamaño del contenido
                            request.ContentLength = infoFichero.Length
                            ' variable que contiene en numero el tamaño del buffer
                            Dim buffer As Integer
                            buffer = 2048
                            ' variable que servira como lectora del archivo
                            Dim read As Byte() = New Byte(2048) {}
                            ' contiene el numero de bytes leidos
                            Dim num As Integer
                            ' contendra en memoria el archivo
                            Dim file As FileStream
                            file = infoFichero.OpenRead
                            ' encerramos en try.. catch por si sucede un error
                            Try
                                ' obtenemos el stream en el que escribiremos
                                Dim write As Stream
                                write = request.GetRequestStream
                                ' leemos
                                num = file.Read(read, 0, 2049)

                                ' mientras el numero de bytes leidos sea diferente de 0
                                ' (o sea mientras tengamos bytes que leer), escribimos
                                While (num <> 0)
                                    write.Write(read, 0, 2049)
                                    num = file.Read(read, 0, 2049)
                                End While
                                ' cerramos.....
                                write.Close()
                                file.Close()
                                MsgBox("Upload successfull!!")
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                End If
            Else
                MsgBox("Please start a new session and fill url, username and password")
            End If
        End Sub

        ' quiere bajar un archivo.. procedemos
        Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
            ' comprobamos que la ruta no comienze con / o \
            If txtDownloadRoute.Text.StartsWith("/") Or txtDownloadRoute.Text.StartsWith("\") Then
                MsgBox("Delete the / or \")
            Else
                ' comprobamos los requisitos previos
                If preview_requisites() Then
                    ' deshabilitamos los controles relacionados al trabajo de descarga
                    ' para que el usuario no pueda modificar nada mientras trabajamos...
                    txtDownloadRoute.Enabled = False
                    btnDownload.Enabled = False
                    ' si son cumplidos procdemos al proceso que hace el trabajo de descarga
                    DownloadWorker.RunWorkerAsync()
                    txtDownloadRoute.Enabled = True
                    btnDownload.Enabled = True
                Else
                    MsgBox("Please start a new session and fill url, username, password and click connect")
                End If
            End If
        End Sub

        ' proceso que hace el trabajo de descargar el archivo
        Private Sub DownloadWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles DownloadWorker.DoWork
            ' por si sucede un error....
            Try
                ' creamos request
                Dim request As FtpWebRequest
                ' le damos la url del ftp + la ruta en donde se encuentra el archivo a descargar
                ' (dada por el usuario)
                request = CType(FtpWebRequest.Create(url & txtDownloadRoute.Text), FtpWebRequest)
                ' damos credenciales...
                request.Credentials = New NetworkCredential(user, password)
                ' le decimos al servidor ftp que queremos descargar algo d el
                request.Method = WebRequestMethods.Ftp.DownloadFile
                request.UseBinary = True
                ' creamos en la computadora del usuario el archivo que contendra la data devuelta por el servidor
                ' por default la guardamos en C:\
                Dim target As New FileInfo("C:\" + txtDownloadRoute.Text.Split("/")(txtDownloadRoute.Text.Split("/").Length - 1))
                target.Delete()
                ' obtenemos la respuesta
                Dim response As FtpWebResponse = CType(request.GetResponse, FtpWebResponse)
                ' obtenemos stream de la respuesta
                Dim stream As Stream = response.GetResponseStream
                ' preparamos el archivo que contendra la data devuelta por el servidor ftp
                Dim fileStream As FileStream = target.OpenWrite()
                ' creamos buffer(lo que contendra la data leida)
                Dim buffer(2048) As Byte
                ' variable que conrtendra cuantos bytes hemos leido
                Dim read As Integer = 0
                ' comenzamos a escribir
                Do
                    read = stream.Read(buffer, 0, 2049)
                    ' escribimos mientras que los bytes leidos sean diferente de 0
                    ' (o sea mientras tengamos algo que leer)
                    If (read <> 0) Then
                        fileStream.Write(buffer, 0, 2049)
                    End If
                Loop Until read = 0
                ' cerramos
                fileStream.Close()
                stream.Close()
                ' mostramos mensaje de que todo ha procedido correctamente
                MsgBox("Download successfull!!!")
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End Sub

        ' el usuario quiere iniciar nueva session
        Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
            ' habilitamos de nuevo todo lo que tiene que ver con la conexion
            ' (o sea url, usuario, contraseña), a la vez limpiamos la data que teniamos
            ' antes para accesar al ftp (url, user, pass)
            txtUrl.Enabled = True
            url = Nothing
            txtUsername.Enabled = True
            user = Nothing
            txtPassword.Enabled = True
            password = Nothing
        End Sub

        ' funcion que comprueba que todos los datos esenciales hallan sido llenados
        Private Function preview_requisites() As Boolean
            If url <> Nothing Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub AboutBarAboutItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBarAboutItem.Click
            FrmAbout.Show()
            Dim test As New WebClient
        End Sub
    End Class
End Namespace