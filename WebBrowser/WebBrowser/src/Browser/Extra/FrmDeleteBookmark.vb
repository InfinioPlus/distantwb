' Copyright 2011 Jorge Alberto Gomez Lopez

Public Class FrmDeleteBookmark

    ' al cargar el form obtenemos los bookmarks guardados
    Private Sub FrmDeleteBookmark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        get_bookmarks()
    End Sub

    ' funcion que tiene como objetivo cargar los bookmarks en la lista
    Private Sub get_bookmarks()
        lista.Items.Clear()
        For Each Item As String In My.Settings.Bookmarks
            lista.Items.Add(Item)
        Next
    End Sub

    ' funcion que borra todos los bookmarks guardados
    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        My.Settings.Bookmarks.Clear()
        lista.Items.Clear()
    End Sub

    ' funcion que borra el bookmark seleccionado
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' si no ha seleccionado nada no hagamos nada
        If (lista.SelectedItem Is Nothing) Then
            MsgBox("por favor seleccione una de las opciones")
        Else
            ' enecrrado en try..catch para evitar errores
            Try
                ' buscamos el string en bookmarks(StringCollection)
                ' si es encontrado lo remueve
                My.Settings.Bookmarks.Remove(lista.SelectedItem.ToString)
                MsgBox("bookmark removido con exito!!")
                get_bookmarks()
            Catch ex As Exception
                MsgBox("Error al remover bookmark")
                get_bookmarks()
            End Try
        End If
    End Sub
End Class