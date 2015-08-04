Imports System.Windows.Forms

Namespace org.distantwb.tools.editors.html
    Public Class sure
        Public dad As FrmHTMLEditor

        Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
            If Not dad Is Nothing Then
                dad.Save_changes()
            Else
                MsgBox("Error getting form caller")
            End If
            Me.Close()
        End Sub

        Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
            If Not dad Is Nothing Then
                dad.close_tab()
            Else
                MsgBox("Error getting form caller")
            End If
            Me.Close()
        End Sub

        Private Sub sure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
