Namespace org.distantwb.tools.editors.html
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmHTMLEditor
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
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
            Me.ArchiveBar = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarAddTabItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarCloseTabItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarSaveItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarOpenItem = New System.Windows.Forms.ToolStripMenuItem
            Me.Tab = New System.Windows.Forms.TabControl
            Me.SaveDialog = New System.Windows.Forms.SaveFileDialog
            Me.OpenDialog = New System.Windows.Forms.OpenFileDialog
            Me.archiveBarPreviewItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchiveBar})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(660, 24)
            Me.MenuStrip1.TabIndex = 0
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ArchiveBar
            '
            Me.ArchiveBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchiveBarAddTabItem, Me.ArchiveBarCloseTabItem, Me.ArchiveBarSaveItem, Me.ArchiveBarOpenItem, Me.archiveBarPreviewItem})
            Me.ArchiveBar.Name = "ArchiveBar"
            Me.ArchiveBar.Size = New System.Drawing.Size(55, 20)
            Me.ArchiveBar.Text = "Archive"
            '
            'ArchiveBarAddTabItem
            '
            Me.ArchiveBarAddTabItem.Name = "ArchiveBarAddTabItem"
            Me.ArchiveBarAddTabItem.Size = New System.Drawing.Size(152, 22)
            Me.ArchiveBarAddTabItem.Text = "New Tab.."
            '
            'ArchiveBarCloseTabItem
            '
            Me.ArchiveBarCloseTabItem.Name = "ArchiveBarCloseTabItem"
            Me.ArchiveBarCloseTabItem.Size = New System.Drawing.Size(152, 22)
            Me.ArchiveBarCloseTabItem.Text = "Close Tab.."
            '
            'ArchiveBarSaveItem
            '
            Me.ArchiveBarSaveItem.Name = "ArchiveBarSaveItem"
            Me.ArchiveBarSaveItem.Size = New System.Drawing.Size(152, 22)
            Me.ArchiveBarSaveItem.Text = "Save.."
            '
            'ArchiveBarOpenItem
            '
            Me.ArchiveBarOpenItem.Name = "ArchiveBarOpenItem"
            Me.ArchiveBarOpenItem.Size = New System.Drawing.Size(152, 22)
            Me.ArchiveBarOpenItem.Text = "Open.."
            '
            'Tab
            '
            Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Tab.Location = New System.Drawing.Point(0, 52)
            Me.Tab.Name = "Tab"
            Me.Tab.SelectedIndex = 0
            Me.Tab.Size = New System.Drawing.Size(660, 426)
            Me.Tab.TabIndex = 1
            '
            'OpenDialog
            '
            Me.OpenDialog.FileName = "OpenDialog"
            '
            'archiveBarPreviewItem
            '
            Me.archiveBarPreviewItem.Name = "archiveBarPreviewItem"
            Me.archiveBarPreviewItem.Size = New System.Drawing.Size(152, 22)
            Me.archiveBarPreviewItem.Text = "Preview.."
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(660, 25)
            Me.ToolStrip1.TabIndex = 2
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'FrmHTMLEditor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(660, 475)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.Tab)
            Me.Controls.Add(Me.MenuStrip1)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "FrmHTMLEditor"
            Me.Text = "Distant HTML Editor V1.0"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents Tab As System.Windows.Forms.TabControl
        Friend WithEvents ArchiveBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ArchiveBarAddTabItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ArchiveBarCloseTabItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ArchiveBarSaveItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ArchiveBarOpenItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
        Friend WithEvents archiveBarPreviewItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    End Class
End Namespace
