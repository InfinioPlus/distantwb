Namespace org.distantwb.tools.editors.html
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmDisplayHTML
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
            Me.browser = New System.Windows.Forms.WebBrowser
            Me.SuspendLayout()
            '
            'browser
            '
            Me.browser.Dock = System.Windows.Forms.DockStyle.Fill
            Me.browser.Location = New System.Drawing.Point(0, 0)
            Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
            Me.browser.Name = "browser"
            Me.browser.Size = New System.Drawing.Size(673, 440)
            Me.browser.TabIndex = 0
            '
            'FrmDisplayHTML
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(673, 440)
            Me.Controls.Add(Me.browser)
            Me.Name = "FrmDisplayHTML"
            Me.Text = "Preview"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents browser As System.Windows.Forms.WebBrowser
    End Class
End Namespace
