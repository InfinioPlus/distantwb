Namespace org.distantwb.tools.downloader
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDownloadManager
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
            Me.txtUrl = New System.Windows.Forms.TextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.btnDownload = New System.Windows.Forms.Button
            Me.Label3 = New System.Windows.Forms.Label
            Me.lblSaveLocation = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.lblFileSize = New System.Windows.Forms.Label
            Me.pgrBar = New System.Windows.Forms.ProgressBar
            Me.Label5 = New System.Windows.Forms.Label
            Me.lblStats = New System.Windows.Forms.Label
            Me.btnCancel = New System.Windows.Forms.Button
            Me.worker = New System.ComponentModel.BackgroundWorker
            Me.SaveDialog = New System.Windows.Forms.SaveFileDialog
            Me.lblSpeed = New System.Windows.Forms.Label
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
            Me.AboutBar = New System.Windows.Forms.ToolStripMenuItem
            Me.AboutBarAboutItem = New System.Windows.Forms.ToolStripMenuItem
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtUrl
            '
            Me.txtUrl.Location = New System.Drawing.Point(50, 33)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(386, 20)
            Me.txtUrl.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(18, 36)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(26, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "File:"
            '
            'btnDownload
            '
            Me.btnDownload.Location = New System.Drawing.Point(454, 28)
            Me.btnDownload.Name = "btnDownload"
            Me.btnDownload.Size = New System.Drawing.Size(65, 25)
            Me.btnDownload.TabIndex = 2
            Me.btnDownload.Text = "Download"
            Me.btnDownload.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(20, 134)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(47, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Save to:"
            '
            'lblSaveLocation
            '
            Me.lblSaveLocation.Location = New System.Drawing.Point(73, 129)
            Me.lblSaveLocation.Name = "lblSaveLocation"
            Me.lblSaveLocation.Size = New System.Drawing.Size(461, 18)
            Me.lblSaveLocation.TabIndex = 6
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(20, 98)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(30, 13)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "Size:"
            '
            'lblFileSize
            '
            Me.lblFileSize.Location = New System.Drawing.Point(73, 98)
            Me.lblFileSize.Name = "lblFileSize"
            Me.lblFileSize.Size = New System.Drawing.Size(435, 24)
            Me.lblFileSize.TabIndex = 8
            '
            'pgrBar
            '
            Me.pgrBar.Location = New System.Drawing.Point(23, 161)
            Me.pgrBar.Name = "pgrBar"
            Me.pgrBar.Size = New System.Drawing.Size(559, 24)
            Me.pgrBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
            Me.pgrBar.TabIndex = 9
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(20, 72)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(41, 13)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "Speed:"
            '
            'lblStats
            '
            Me.lblStats.Location = New System.Drawing.Point(20, 238)
            Me.lblStats.Name = "lblStats"
            Me.lblStats.Size = New System.Drawing.Size(507, 19)
            Me.lblStats.TabIndex = 11
            '
            'btnCancel
            '
            Me.btnCancel.Location = New System.Drawing.Point(525, 28)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(65, 25)
            Me.btnCancel.TabIndex = 12
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'worker
            '
            '
            'lblSpeed
            '
            Me.lblSpeed.AutoSize = True
            Me.lblSpeed.Location = New System.Drawing.Point(73, 72)
            Me.lblSpeed.Name = "lblSpeed"
            Me.lblSpeed.Size = New System.Drawing.Size(0, 13)
            Me.lblSpeed.TabIndex = 13
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutBar})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(601, 24)
            Me.MenuStrip1.TabIndex = 14
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'AboutBar
            '
            Me.AboutBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutBarAboutItem})
            Me.AboutBar.Name = "AboutBar"
            Me.AboutBar.Size = New System.Drawing.Size(48, 20)
            Me.AboutBar.Text = "About"
            '
            'AboutBarAboutItem
            '
            Me.AboutBarAboutItem.Name = "AboutBarAboutItem"
            Me.AboutBarAboutItem.Size = New System.Drawing.Size(122, 22)
            Me.AboutBarAboutItem.Text = "About.."
            '
            'frmDownloadManager
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(601, 205)
            Me.Controls.Add(Me.lblSpeed)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.lblStats)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.pgrBar)
            Me.Controls.Add(Me.lblFileSize)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.lblSaveLocation)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.btnDownload)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.MenuStrip1)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.MaximizeBox = False
            Me.Name = "frmDownloadManager"
            Me.Text = "DistantDownloadManager V1.0"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtUrl As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnDownload As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblSaveLocation As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblFileSize As System.Windows.Forms.Label
        Friend WithEvents pgrBar As System.Windows.Forms.ProgressBar
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents lblStats As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents worker As System.ComponentModel.BackgroundWorker
        Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
        Friend WithEvents lblSpeed As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents AboutBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AboutBarAboutItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
