Namespace org.distantwb.tools.calculator
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCalculator
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.pantalla = New System.Windows.Forms.TextBox
            Me.btn7 = New System.Windows.Forms.Button
            Me.btn8 = New System.Windows.Forms.Button
            Me.btn9 = New System.Windows.Forms.Button
            Me.btn6 = New System.Windows.Forms.Button
            Me.btn5 = New System.Windows.Forms.Button
            Me.btn4 = New System.Windows.Forms.Button
            Me.btn3 = New System.Windows.Forms.Button
            Me.btn2 = New System.Windows.Forms.Button
            Me.btn1 = New System.Windows.Forms.Button
            Me.btn0 = New System.Windows.Forms.Button
            Me.btnClean = New System.Windows.Forms.Button
            Me.btnDot = New System.Windows.Forms.Button
            Me.btnDivided = New System.Windows.Forms.Button
            Me.btnTimes = New System.Windows.Forms.Button
            Me.btnMinus = New System.Windows.Forms.Button
            Me.btnPlus = New System.Windows.Forms.Button
            Me.btnResult = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'pantalla
            '
            Me.pantalla.Location = New System.Drawing.Point(10, 12)
            Me.pantalla.Name = "pantalla"
            Me.pantalla.Size = New System.Drawing.Size(338, 20)
            Me.pantalla.TabIndex = 0
            '
            'btn7
            '
            Me.btn7.Location = New System.Drawing.Point(12, 38)
            Me.btn7.Name = "btn7"
            Me.btn7.Size = New System.Drawing.Size(71, 31)
            Me.btn7.TabIndex = 1
            Me.btn7.Text = "7"
            Me.btn7.UseVisualStyleBackColor = True
            '
            'btn8
            '
            Me.btn8.Location = New System.Drawing.Point(104, 38)
            Me.btn8.Name = "btn8"
            Me.btn8.Size = New System.Drawing.Size(71, 31)
            Me.btn8.TabIndex = 2
            Me.btn8.Text = "8"
            Me.btn8.UseVisualStyleBackColor = True
            '
            'btn9
            '
            Me.btn9.Location = New System.Drawing.Point(196, 38)
            Me.btn9.Name = "btn9"
            Me.btn9.Size = New System.Drawing.Size(71, 31)
            Me.btn9.TabIndex = 3
            Me.btn9.Text = "9"
            Me.btn9.UseVisualStyleBackColor = True
            '
            'btn6
            '
            Me.btn6.Location = New System.Drawing.Point(196, 84)
            Me.btn6.Name = "btn6"
            Me.btn6.Size = New System.Drawing.Size(71, 31)
            Me.btn6.TabIndex = 6
            Me.btn6.Text = "6"
            Me.btn6.UseVisualStyleBackColor = True
            '
            'btn5
            '
            Me.btn5.Location = New System.Drawing.Point(104, 84)
            Me.btn5.Name = "btn5"
            Me.btn5.Size = New System.Drawing.Size(71, 31)
            Me.btn5.TabIndex = 5
            Me.btn5.Text = "5"
            Me.btn5.UseVisualStyleBackColor = True
            '
            'btn4
            '
            Me.btn4.Location = New System.Drawing.Point(12, 84)
            Me.btn4.Name = "btn4"
            Me.btn4.Size = New System.Drawing.Size(71, 31)
            Me.btn4.TabIndex = 4
            Me.btn4.Text = "4"
            Me.btn4.UseVisualStyleBackColor = True
            '
            'btn3
            '
            Me.btn3.Location = New System.Drawing.Point(196, 130)
            Me.btn3.Name = "btn3"
            Me.btn3.Size = New System.Drawing.Size(71, 31)
            Me.btn3.TabIndex = 9
            Me.btn3.Text = "3"
            Me.btn3.UseVisualStyleBackColor = True
            '
            'btn2
            '
            Me.btn2.Location = New System.Drawing.Point(104, 130)
            Me.btn2.Name = "btn2"
            Me.btn2.Size = New System.Drawing.Size(71, 31)
            Me.btn2.TabIndex = 8
            Me.btn2.Text = "2"
            Me.btn2.UseVisualStyleBackColor = True
            '
            'btn1
            '
            Me.btn1.Location = New System.Drawing.Point(12, 130)
            Me.btn1.Name = "btn1"
            Me.btn1.Size = New System.Drawing.Size(71, 31)
            Me.btn1.TabIndex = 7
            Me.btn1.Text = "1"
            Me.btn1.UseVisualStyleBackColor = True
            '
            'btn0
            '
            Me.btn0.Location = New System.Drawing.Point(196, 178)
            Me.btn0.Name = "btn0"
            Me.btn0.Size = New System.Drawing.Size(71, 31)
            Me.btn0.TabIndex = 12
            Me.btn0.Text = "0"
            Me.btn0.UseVisualStyleBackColor = True
            '
            'btnClean
            '
            Me.btnClean.Location = New System.Drawing.Point(104, 178)
            Me.btnClean.Name = "btnClean"
            Me.btnClean.Size = New System.Drawing.Size(71, 31)
            Me.btnClean.TabIndex = 11
            Me.btnClean.Text = "C"
            Me.btnClean.UseVisualStyleBackColor = True
            '
            'btnDot
            '
            Me.btnDot.Location = New System.Drawing.Point(12, 178)
            Me.btnDot.Name = "btnDot"
            Me.btnDot.Size = New System.Drawing.Size(71, 31)
            Me.btnDot.TabIndex = 10
            Me.btnDot.Text = "."
            Me.btnDot.UseVisualStyleBackColor = True
            '
            'btnDivided
            '
            Me.btnDivided.Location = New System.Drawing.Point(277, 178)
            Me.btnDivided.Name = "btnDivided"
            Me.btnDivided.Size = New System.Drawing.Size(71, 31)
            Me.btnDivided.TabIndex = 16
            Me.btnDivided.Text = "/"
            Me.btnDivided.UseVisualStyleBackColor = True
            '
            'btnTimes
            '
            Me.btnTimes.Location = New System.Drawing.Point(277, 130)
            Me.btnTimes.Name = "btnTimes"
            Me.btnTimes.Size = New System.Drawing.Size(71, 31)
            Me.btnTimes.TabIndex = 15
            Me.btnTimes.Text = "*"
            Me.btnTimes.UseVisualStyleBackColor = True
            '
            'btnMinus
            '
            Me.btnMinus.Location = New System.Drawing.Point(277, 84)
            Me.btnMinus.Name = "btnMinus"
            Me.btnMinus.Size = New System.Drawing.Size(71, 31)
            Me.btnMinus.TabIndex = 14
            Me.btnMinus.Text = "-"
            Me.btnMinus.UseVisualStyleBackColor = True
            '
            'btnPlus
            '
            Me.btnPlus.Location = New System.Drawing.Point(277, 38)
            Me.btnPlus.Name = "btnPlus"
            Me.btnPlus.Size = New System.Drawing.Size(71, 31)
            Me.btnPlus.TabIndex = 13
            Me.btnPlus.Text = "+"
            Me.btnPlus.UseVisualStyleBackColor = True
            '
            'btnResult
            '
            Me.btnResult.Location = New System.Drawing.Point(10, 220)
            Me.btnResult.Name = "btnResult"
            Me.btnResult.Size = New System.Drawing.Size(337, 48)
            Me.btnResult.TabIndex = 17
            Me.btnResult.Text = "="
            Me.btnResult.UseVisualStyleBackColor = True
            '
            'FrmCalculator
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(365, 277)
            Me.Controls.Add(Me.btnResult)
            Me.Controls.Add(Me.btnDivided)
            Me.Controls.Add(Me.btnTimes)
            Me.Controls.Add(Me.btnMinus)
            Me.Controls.Add(Me.btnPlus)
            Me.Controls.Add(Me.btn0)
            Me.Controls.Add(Me.btnClean)
            Me.Controls.Add(Me.btnDot)
            Me.Controls.Add(Me.btn3)
            Me.Controls.Add(Me.btn2)
            Me.Controls.Add(Me.btn1)
            Me.Controls.Add(Me.btn6)
            Me.Controls.Add(Me.btn5)
            Me.Controls.Add(Me.btn4)
            Me.Controls.Add(Me.btn9)
            Me.Controls.Add(Me.btn8)
            Me.Controls.Add(Me.btn7)
            Me.Controls.Add(Me.pantalla)
            Me.Name = "FrmCalculator"
            Me.Text = "Calculator"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents pantalla As System.Windows.Forms.TextBox
        Friend WithEvents btn7 As System.Windows.Forms.Button
        Friend WithEvents btn8 As System.Windows.Forms.Button
        Friend WithEvents btn9 As System.Windows.Forms.Button
        Friend WithEvents btn6 As System.Windows.Forms.Button
        Friend WithEvents btn5 As System.Windows.Forms.Button
        Friend WithEvents btn4 As System.Windows.Forms.Button
        Friend WithEvents btn3 As System.Windows.Forms.Button
        Friend WithEvents btn2 As System.Windows.Forms.Button
        Friend WithEvents btn1 As System.Windows.Forms.Button
        Friend WithEvents btn0 As System.Windows.Forms.Button
        Friend WithEvents btnClean As System.Windows.Forms.Button
        Friend WithEvents btnDot As System.Windows.Forms.Button
        Friend WithEvents btnDivided As System.Windows.Forms.Button
        Friend WithEvents btnTimes As System.Windows.Forms.Button
        Friend WithEvents btnMinus As System.Windows.Forms.Button
        Friend WithEvents btnPlus As System.Windows.Forms.Button
        Friend WithEvents btnResult As System.Windows.Forms.Button
    End Class
End Namespace
