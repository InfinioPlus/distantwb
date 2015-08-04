' Copyright 2011 Jorge Alberto Gomez Lopez

Public Class FrmAddOnsManager

    ' obtenemos la ruta del addon (osea el .dll)
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        OpenDialog.Filter = "DLL files (*.dll)|*.dll"
        If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtPath.Text = OpenDialog.FileName
        End If
    End Sub

    ' el usuario esta seguro que quiere añadir el addon asi que guardamos la ruta de donde se encuentra
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        My.Settings.AddOns.Add(txtPath.Text)
        MsgBox("You need to restart your browser to use the new addon")
    End Sub

    Private Sub FrmAddOnsManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        get_Added_Components()
    End Sub

    ' despliega todos los addons que han sido registrados....
    Private Sub get_Added_Components()
        lista.Items.Clear()
        For Each item As String In My.Settings.AddOns
            lista.Items.Add(item)
        Next
    End Sub

    ' el usuario quiere eliminar una referencia... procedemos
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' comprobamos que halla seleccionado alguna referencia de la lista
        If lista.SelectedItem() Is Nothing Then
            ' si no ha seleccionado nada, mostramos mensaje de error
            MsgBox("Please select a reference to delete")
        Else
            ' sino procedemos a eliminar
            My.Settings.AddOns.Remove(lista.SelectedItem())
            ' cerramos la aplicacion para actualizar todo....
            Application.Exit()
        End If
    End Sub
End Class