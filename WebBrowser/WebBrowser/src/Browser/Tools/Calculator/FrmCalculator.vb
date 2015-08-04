' Copyright 2011 Jorge Alberto Gomez Lopez

' NOTA: no documento este codigo por su sencillez.
Namespace org.distantwb.tools.calculator
    Public Class FrmCalculator
        Dim n1 As Integer
        Dim n2 As Integer
        Dim op As Integer

        Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
            pantalla.Text = pantalla.Text + btn7.Text
        End Sub

        Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
            pantalla.Text = pantalla.Text + btn8.Text
        End Sub

        Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
            pantalla.Text = pantalla.Text + btn9.Text
        End Sub

        Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
            pantalla.Text = pantalla.Text + btn4.Text
        End Sub

        Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
            pantalla.Text = pantalla.Text + btn5.Text
        End Sub

        Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
            pantalla.Text = pantalla.Text + btn6.Text
        End Sub

        Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
            pantalla.Text = pantalla.Text + btn1.Text
        End Sub

        Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
            pantalla.Text = pantalla.Text + btn2.Text
        End Sub

        Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
            pantalla.Text = pantalla.Text + btn3.Text
        End Sub

        Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
            pantalla.Text = pantalla.Text + btn0.Text
        End Sub

        Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
            n1 = Nothing
            n2 = Nothing
            pantalla.Text = ""
        End Sub

        Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
            op = 1
            n1 = Int(pantalla.Text)
            pantalla.Text = ""
        End Sub

        Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
            op = 2
            n1 = Int(pantalla.Text)
            pantalla.Text = ""
        End Sub

        Private Sub btnTimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimes.Click
            op = 3
            n1 = Int(pantalla.Text)
            pantalla.Text = ""
        End Sub

        Private Sub btnDivided_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivided.Click
            op = 4
            n1 = Int(pantalla.Text)
            pantalla.Text = ""
        End Sub

        Private Sub btnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResult.Click
            n2 = Int(pantalla.Text)
            Select Case op
                Case 1
                    pantalla.Text = n1 + n2
                Case 2
                    pantalla.Text = n1 - n2
                Case 3
                    pantalla.Text = n1 * n2
                Case 4
                    pantalla.Text = n1 / n2
            End Select
        End Sub
    End Class
End Namespace