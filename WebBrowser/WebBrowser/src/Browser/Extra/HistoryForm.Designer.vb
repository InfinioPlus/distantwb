<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Me.lista = New System.Windows.Forms.ListBox
        Me.btnClearAll = New System.Windows.Forms.Button
        Me.btnGo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(12, 23)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(417, 251)
        Me.lista.TabIndex = 0
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(12, 280)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(59, 26)
        Me.btnClearAll.TabIndex = 1
        Me.btnClearAll.Text = "Clear All!"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(77, 280)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(59, 26)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 314)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.lista)
        Me.MaximizeBox = False
        Me.Name = "HistoryForm"
        Me.Text = "History"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lista As System.Windows.Forms.ListBox
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
End Class
