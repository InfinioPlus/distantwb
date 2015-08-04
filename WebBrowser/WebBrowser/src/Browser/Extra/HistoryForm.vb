' Copyright 2011 Jorge Alberto Gomez Lopez

Public Class HistoryForm

    ' guarda la referencia de la instancia actual del programa
    Public dad As org.distantwb.main.FrmBrowser

    ' cuando se abre la form... actualizamos el historial...
    Private Sub HistoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' borramos todos los items que haya en la lista
        lista.Items.Clear()
        ' actualizamos la lista
        get_History()
    End Sub

    ' funcion que sirve para obtener historial
    Private Sub get_History()
        For Each item As String In My.Settings.History
            lista.Items.Add(item)
        Next
    End Sub

    ' borra el historial....
    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        My.Settings.History.Clear()
        ' ya que ya no hay items en History... borramos lo que haya en la lista
        lista.Items.Clear()
    End Sub

    ' funcion que abre en una nueva pestaña la URL seleccionada en el historial
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        ' si no hay referencia del quien la llamo (o sea el FrmBrowser)
        ' despliega un mensaje de error
        If (dad Is Nothing) Then
            MsgBox("Hubo un error!!!")
        Else
            ' si el usuario no ha seleccionado nada de la lista
            ' despliega un error
            If (lista.SelectedItem Is Nothing) Then
                MsgBox("por favor seleccione una URL de la lista!!")
                ' sino procede a abrir la URL
            Else
                dad.external_Call(lista.SelectedItem.ToString)
            End If
        End If
    End Sub
End Class