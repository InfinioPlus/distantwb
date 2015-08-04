' Copyright Jorge Alberto Gomez Lopez 2011

Imports System.Net

Namespace org.distantwb.tools.downloader
    Public Class frmDownloadManager
        ' variable que guardara la locacion de donde se guardara el archivo
        Dim savePath As String

        Delegate Sub changeStatsSafe(ByVal fileLength As Long, ByVal position As Integer, ByVal downloadPercent As Integer, ByVal speed As Double)
        Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)



        ' funcion que limpia cuando la descarga se ha terminado
        Public Sub download_complete(ByVal cancelled As Boolean)
            txtUrl.Enabled = True
            btnDownload.Enabled = True
            btnCancel.Enabled = False

            If cancelled Then
                ' se despliega cuando ha sido cancelada la descarga
                MsgBox("Download cancelled")
            Else
                ' se despliega cuando ha sido completada la descarga
                MsgBox("Download Successfull!!")
            End If

            ' limpieza de las etiquetas...
            lblSaveLocation.Text = ""
            lblFileSize.Text = ""
            pgrBar.Value = 0
        End Sub

        ' funcion que contiene todo el proceso de cambio de las etiquetas
        ' sobre la informacion de la descarga
        Private Sub changeStats(ByVal fileLength As Long, ByVal position As Integer, ByVal downloadPercent As Integer, ByVal speed As Double)
            ' hacemos el calculo del tamaño del archivo a descargar y lo mostramos
            lblFileSize.Text = Math.Round((fileLength / 1024), 2) & " KB"
            ' mostramos la cantidad de bytes que se han descargado
            lblStats.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((fileLength / 1024), 2) & "KB (" & pgrBar.Value & "%)"
            ' si la velocidad es menor a 0 (cuando no es calculada)
            If speed < 0 Then
                ' mostramos que la estamos calculando
                lblSpeed.Text = "Calculating.."
            Else
                ' sino mostramos la velocidad de descarga
                lblSpeed.Text = Math.Round((speed / 1024), 2) & " KB/s"
            End If
            ' cambiamos el porcentaje descargado desplegado
            pgrBar.Value = downloadPercent
        End Sub

        ' el usuario quiere descargar algo... asi que procedemos
        Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
            ' comprobamos que la URL sea valida
            If txtUrl.Text <> "" AndAlso valid_protocol(txtUrl.Text) Then
                ' damos la sugerencia del nombre del archivo...
                SaveDialog.FileName = txtUrl.Text.Split("/"c)(txtUrl.Text.Split("/"c).Length - 1)
                ' mostramos el dialogo de guardado
                If SaveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' guardamos la ruta en donde se guardara el archivo
                    savePath = SaveDialog.FileName
                    ' desplegamos la ruta en donde se guardara
                    lblSaveLocation.Text = savePath
                    ' deshabilitamos los botones para que no pueda hacer nada
                    ' mientras procede la descarga
                    btnDownload.Enabled = False
                    txtUrl.Enabled = False
                    btnCancel.Enabled = True

                    ' corremos asincronicamente el proceso de descarga
                    worker.RunWorkerAsync()
                End If
            Else
                MsgBox("please enter a valid URL")
            End If
        End Sub

        ' funcion que devuelve si la url dada tiene un protocolo valido
        Private Function valid_protocol(ByVal url As String) As Boolean
            If url.StartsWith("http://") Then
                Return True
            End If
        End Function

        ' funcion que realiza el trabajo de descarga
        Private Sub worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles worker.DoWork
            ' variables usadas para obtener el archivo a descargar
            Dim theResponse As HttpWebResponse
            Dim theRequest As HttpWebRequest

            ' lo encerramos en try..catch ya que hay la posibilidad de que el
            ' archivo no exista en el servidor dado...
            Try
                theRequest = WebRequest.Create(txtUrl.Text)
                theResponse = theRequest.GetResponse()
            Catch ex As Exception
                MsgBox("file doesn't exist or server error")
            End Try
            ' si ha pasado la prueba proseguimos....
            Dim fileLength As Long = theResponse.ContentLength()
            ' creamos una invocacion segura....
            Dim delegates As New changeStatsSafe(AddressOf changeStats)
            ' desplegamos la informacion obtenida hasta ahora
            Invoke(delegates, fileLength, 0, 0, 0)

            ' variable en la que escribiremos los datos del archivo a descargar
            Dim wStream As New System.IO.FileStream(savePath, IO.FileMode.Create)
            ' variable que guarda la cantidad de bytes ya leidos...
            Dim bytesReaded As Integer = 0

            ' variable ayudante para calcular la velocidad de descarga
            Dim speedTimer As New Stopwatch
            ' variable que guardara el calculo obtenido de la velocidad de descarga
            Dim currentSpeed As Double = -1
            ' variable que ira contando las veces que se repite el proceso de
            ' leida-guardado de los datos...
            Dim readings As Integer = 0

            ' comenzamos el trabajo.....
            Do
                ' si se ha detectado que el usuario ha clicado el boton cancelar...
                ' salimos del proceso automaticamente
                If worker.CancellationPending Then
                    Exit Do
                End If

                ' sino continuamos...
                ' comenzamos el tiempo...
                speedTimer.Start()
                ' variable que guardara la data que estamos leyendo del archivo en el server
                Dim readBytes(4095) As Byte
                ' variable que guarda la cantidad de bytes que acabamos de leer
                Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)
                ' guardamos la cantidad de bytes leidos en total
                bytesReaded += bytesread
                ' calculamos el porcentaje descargado del archivo
                Dim percent As Short = (bytesReaded * 100) / fileLength
                ' llamamos a la funcion que despliega los datos de la descarga...
                Invoke(delegates, fileLength, bytesReaded, percent, currentSpeed)

                ' si no hemos leido ningun byte (o sea no hay mas bytes que leer)
                ' salimos del proceso de leida-escritura de datos...
                If bytesread = 0 Then
                    Exit Do
                End If

                ' escribimos la data obtenida.....
                wStream.Write(readBytes, 0, bytesread)
                ' detenemos el tiempo...
                speedTimer.Stop()
                ' aumentamos las veces que hemos realizado la leida-escritura de datos
                readings += 1
                ' si ya llegamos y/o pasamos las 5 veces... actualizamos
                ' la velocidad de descarga
                If readings >= 5 Then
                    currentSpeed = 20480 / (speedTimer.ElapsedMilliseconds / 1000)
                    speedTimer.Reset()
                    readings = 0
                End If
            Loop

            ' terminamos el trabajo cerramos todo....
            theResponse.GetResponseStream.Close()
            wStream.Close()

            ' si el usuario ha cancelado... borramos el archivo....
            If worker.CancellationPending Then
                IO.File.Delete(savePath)
                Dim cancelDelegate As New DownloadCompleteSafe(AddressOf download_complete)
                Invoke(cancelDelegate, True)
                Exit Sub
            End If
            Dim downloadCompleteDelegate As New DownloadCompleteSafe(AddressOf download_complete)
            Invoke(downloadCompleteDelegate, False)
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            worker.CancelAsync()
        End Sub

        Private Sub AboutBarAboutItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBarAboutItem.Click
            FrmAbout.Show()
        End Sub
    End Class
End Namespace