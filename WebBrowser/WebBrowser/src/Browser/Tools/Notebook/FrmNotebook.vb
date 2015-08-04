' Copyright 2011 Jorge Alberto Gomez Lopez

Namespace org.distantwb.tools.notebook
    Public Class FrmNotebook
        Dim textchanged As String

        ' antes de que se cierre, necesitamos hacer antes un proceso
        Private Sub FrmNotebook_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            ' si se ha agregado o quitado algo en el textbox, preguntamos...
            If textchanged <> txtText.Text Then
                Dim message As String = "Would you like to save changes"
                Dim caption As String = "Notebook"
                Dim button As MessageBoxButtons = MessageBoxButtons.YesNoCancel
                Dim icon As MessageBoxIcon = MessageBoxIcon.Warning
                ' capturamos el resultado
                Dim result As DialogResult = MessageBox.Show(message, caption, button, icon)

                Select Case result
                    ' si, guardamos cambios
                    Case Windows.Forms.DialogResult.Yes
                        save_changes()
                    Case Windows.Forms.DialogResult.No
                        ' no hacemos nada
                    Case Windows.Forms.DialogResult.Cancel
                        ' cancelamos el cierre
                        e.Cancel = True
                End Select
            End If
        End Sub

        ' cargamos el texto en el textbox y en la variable que comprueba los cambios
        Private Sub FrmNotebook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            txtText.Text = My.Settings.Notebook
            textchanged = My.Settings.Notebook
        End Sub

        ' guardamos los cambios 
        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            save_changes()
            ' actualizamos la variable....
            textchanged = txtText.Text
        End Sub

        ' funcion que guarda los cambios
        Public Sub save_changes()
            My.Settings.Notebook = txtText.Text
        End Sub
    End Class
End Namespace