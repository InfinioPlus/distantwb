' Copyright 2011 Jorge Alberto Gomez Lopez

Imports System.Collections.Specialized

Public Class FrmSourceHTML
    ' variable que va a guardar el source pasado por la form principal
    Public source As String

    Private Sub FrmSourceHTML_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' si no tiene nada la variable... ha sucedido algo incorrecto
        If source Is Nothing Then
            MsgBox("Error al obtener codigo HTML")
        Else
            txtArea.Text = source
        End If
        ' hacemos que el usuario no pueda cambiar nada de lo devuelto
        txtArea.ReadOnly = True
        txtArea.BackColor = Color.White
    End Sub
End Class