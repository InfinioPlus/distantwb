<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumberedTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lblNumbers3 = New System.Windows.Forms.Label
        Me.lblNumbers = New System.Windows.Forms.Label
        Me.rtb = New System.Windows.Forms.RichTextBox
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNumbers3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNumbers)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.rtb)
        Me.SplitContainer1.Size = New System.Drawing.Size(643, 372)
        Me.SplitContainer1.SplitterDistance = 63
        Me.SplitContainer1.TabIndex = 0
        '
        'lblNumbers3
        '
        Me.lblNumbers3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumbers3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumbers3.Location = New System.Drawing.Point(0, 0)
        Me.lblNumbers3.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.lblNumbers3.Name = "lblNumbers3"
        Me.lblNumbers3.Size = New System.Drawing.Size(63, 372)
        Me.lblNumbers3.TabIndex = 1
        '
        'lblNumbers
        '
        Me.lblNumbers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumbers.AutoSize = True
        Me.lblNumbers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumbers.Location = New System.Drawing.Point(0, 0)
        Me.lblNumbers.Margin = New System.Windows.Forms.Padding(5)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.lblNumbers.Size = New System.Drawing.Size(0, 20)
        Me.lblNumbers.TabIndex = 0
        '
        'rtb
        '
        Me.rtb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb.Location = New System.Drawing.Point(0, 0)
        Me.rtb.Margin = New System.Windows.Forms.Padding(0)
        Me.rtb.Name = "rtb"
        Me.rtb.Size = New System.Drawing.Size(576, 372)
        Me.rtb.TabIndex = 0
        Me.rtb.Text = ""
        '
        'NumberedTextBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "NumberedTextBox"
        Me.Size = New System.Drawing.Size(643, 372)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNumbers As System.Windows.Forms.Label

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lblNumbers.Font = New Font(rtb.Font.FontFamily, rtb.Font.Size)
    End Sub
    Friend WithEvents lblNumbers3 As System.Windows.Forms.Label
End Class
