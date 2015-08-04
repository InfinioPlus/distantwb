Namespace org.distantwb.tools.notebook
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmNotebook
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
            Me.txtText = New System.Windows.Forms.TextBox
            Me.btnSave = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'txtText
            '
            Me.txtText.Location = New System.Drawing.Point(12, 12)
            Me.txtText.Multiline = True
            Me.txtText.Name = "txtText"
            Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtText.Size = New System.Drawing.Size(365, 258)
            Me.txtText.TabIndex = 0
            '
            'btnSave
            '
            Me.btnSave.Location = New System.Drawing.Point(132, 288)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(91, 22)
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'FrmNotebook
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(389, 322)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.txtText)
            Me.Name = "FrmNotebook"
            Me.Text = "Notebook"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtText As System.Windows.Forms.TextBox
        Friend WithEvents btnSave As System.Windows.Forms.Button
    End Class
End Namespace
