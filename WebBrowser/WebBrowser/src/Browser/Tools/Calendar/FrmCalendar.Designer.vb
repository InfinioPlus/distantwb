Namespace org.distantwb.tools.calendar
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCalendar
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
            Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
            Me.SuspendLayout()
            '
            'MonthCalendar1
            '
            Me.MonthCalendar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MonthCalendar1.Location = New System.Drawing.Point(13, 18)
            Me.MonthCalendar1.Name = "MonthCalendar1"
            Me.MonthCalendar1.TabIndex = 0
            '
            'FrmCalendar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(197, 189)
            Me.Controls.Add(Me.MonthCalendar1)
            Me.Name = "FrmCalendar"
            Me.Text = "Calendar"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    End Class
End Namespace
