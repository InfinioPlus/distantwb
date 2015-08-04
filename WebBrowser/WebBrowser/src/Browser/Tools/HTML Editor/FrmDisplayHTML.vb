Namespace org.distantwb.tools.editors.html
    Public Class FrmDisplayHTML
        ' variable que contendra el html obtenido 
        ' de la accion de qurer ver el resultado del html
        Public html As String

        Private Sub FrmDisplayHTML_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' si hay algo que leer, mostramos el resultado final
            If Not html Is Nothing Then
                browser.DocumentText = html
            Else
                ' sino algo malo habra sucedido...
                MsgBox("can't obtain the html source")
            End If
        End Sub
    End Class
End Namespace