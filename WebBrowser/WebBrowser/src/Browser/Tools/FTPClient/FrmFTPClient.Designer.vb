Namespace org.distantwb.tools.clients.ftpclient
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmFTPClient
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
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtUrl = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtUsername = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtPassword = New System.Windows.Forms.TextBox
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
            Me.SessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.AboutBar = New System.Windows.Forms.ToolStripMenuItem
            Me.AboutBarAboutItem = New System.Windows.Forms.ToolStripMenuItem
            Me.btnConnect = New System.Windows.Forms.Button
            Me.txtOutput = New System.Windows.Forms.TextBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtUploadFile = New System.Windows.Forms.TextBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtDestination = New System.Windows.Forms.TextBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.txtDownloadRoute = New System.Windows.Forms.TextBox
            Me.btnDownload = New System.Windows.Forms.Button
            Me.btnUpload = New System.Windows.Forms.Button
            Me.btnListAll = New System.Windows.Forms.Button
            Me.txtGetDetailsOf = New System.Windows.Forms.TextBox
            Me.btnBrowse = New System.Windows.Forms.Button
            Me.OpenDialog = New System.Windows.Forms.OpenFileDialog
            Me.UploadWorker = New System.ComponentModel.BackgroundWorker
            Me.DownloadWorker = New System.ComponentModel.BackgroundWorker
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 45)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(32, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "URL:"
            '
            'txtUrl
            '
            Me.txtUrl.Location = New System.Drawing.Point(50, 38)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(460, 20)
            Me.txtUrl.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 70)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(58, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Username:"
            '
            'txtUsername
            '
            Me.txtUsername.Location = New System.Drawing.Point(76, 70)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(202, 20)
            Me.txtUsername.TabIndex = 3
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(300, 73)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(56, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Password:"
            '
            'txtPassword
            '
            Me.txtPassword.Location = New System.Drawing.Point(362, 70)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Size = New System.Drawing.Size(216, 20)
            Me.txtPassword.TabIndex = 5
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SessionToolStripMenuItem, Me.AboutBar})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(602, 24)
            Me.MenuStrip1.TabIndex = 6
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'SessionToolStripMenuItem
            '
            Me.SessionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
            Me.SessionToolStripMenuItem.Name = "SessionToolStripMenuItem"
            Me.SessionToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
            Me.SessionToolStripMenuItem.Text = "Session"
            '
            'NewToolStripMenuItem
            '
            Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
            Me.NewToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
            Me.NewToolStripMenuItem.Text = "New.."
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
            Me.AboutBarAboutItem.Size = New System.Drawing.Size(114, 22)
            Me.AboutBarAboutItem.Text = "About"
            '
            'btnConnect
            '
            Me.btnConnect.Location = New System.Drawing.Point(516, 38)
            Me.btnConnect.Name = "btnConnect"
            Me.btnConnect.Size = New System.Drawing.Size(62, 20)
            Me.btnConnect.TabIndex = 7
            Me.btnConnect.Text = "Connect"
            Me.btnConnect.UseVisualStyleBackColor = True
            '
            'txtOutput
            '
            Me.txtOutput.Location = New System.Drawing.Point(12, 243)
            Me.txtOutput.Multiline = True
            Me.txtOutput.Name = "txtOutput"
            Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtOutput.Size = New System.Drawing.Size(578, 165)
            Me.txtOutput.TabIndex = 14
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(9, 118)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(44, 13)
            Me.Label4.TabIndex = 15
            Me.Label4.Text = "Upload:"
            '
            'txtUploadFile
            '
            Me.txtUploadFile.Location = New System.Drawing.Point(50, 120)
            Me.txtUploadFile.Name = "txtUploadFile"
            Me.txtUploadFile.Size = New System.Drawing.Size(158, 20)
            Me.txtUploadFile.TabIndex = 16
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(282, 123)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(23, 13)
            Me.Label5.TabIndex = 17
            Me.Label5.Text = "To:"
            '
            'txtDestination
            '
            Me.txtDestination.Location = New System.Drawing.Point(311, 120)
            Me.txtDestination.Name = "txtDestination"
            Me.txtDestination.Size = New System.Drawing.Size(199, 20)
            Me.txtDestination.TabIndex = 18
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(12, 171)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(58, 13)
            Me.Label6.TabIndex = 19
            Me.Label6.Text = "Download:"
            '
            'txtDownloadRoute
            '
            Me.txtDownloadRoute.Location = New System.Drawing.Point(76, 171)
            Me.txtDownloadRoute.Name = "txtDownloadRoute"
            Me.txtDownloadRoute.Size = New System.Drawing.Size(188, 20)
            Me.txtDownloadRoute.TabIndex = 20
            '
            'btnDownload
            '
            Me.btnDownload.Location = New System.Drawing.Point(277, 171)
            Me.btnDownload.Name = "btnDownload"
            Me.btnDownload.Size = New System.Drawing.Size(69, 20)
            Me.btnDownload.TabIndex = 21
            Me.btnDownload.Text = "Download"
            Me.btnDownload.UseVisualStyleBackColor = True
            '
            'btnUpload
            '
            Me.btnUpload.Location = New System.Drawing.Point(516, 118)
            Me.btnUpload.Name = "btnUpload"
            Me.btnUpload.Size = New System.Drawing.Size(59, 22)
            Me.btnUpload.TabIndex = 22
            Me.btnUpload.Text = "Upload"
            Me.btnUpload.UseVisualStyleBackColor = True
            '
            'btnListAll
            '
            Me.btnListAll.Location = New System.Drawing.Point(277, 208)
            Me.btnListAll.Name = "btnListAll"
            Me.btnListAll.Size = New System.Drawing.Size(100, 20)
            Me.btnListAll.TabIndex = 23
            Me.btnListAll.Text = "List directories"
            Me.btnListAll.UseVisualStyleBackColor = True
            '
            'txtGetDetailsOf
            '
            Me.txtGetDetailsOf.Location = New System.Drawing.Point(15, 208)
            Me.txtGetDetailsOf.Name = "txtGetDetailsOf"
            Me.txtGetDetailsOf.Size = New System.Drawing.Size(256, 20)
            Me.txtGetDetailsOf.TabIndex = 24
            '
            'btnBrowse
            '
            Me.btnBrowse.Location = New System.Drawing.Point(214, 118)
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.Size = New System.Drawing.Size(64, 22)
            Me.btnBrowse.TabIndex = 25
            Me.btnBrowse.Text = "Browse.."
            Me.btnBrowse.UseVisualStyleBackColor = True
            '
            'OpenDialog
            '
            Me.OpenDialog.FileName = "OpenDialog"
            '
            'UploadWorker
            '
            '
            'DownloadWorker
            '
            '
            'FrmFTPClient
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(602, 420)
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.txtGetDetailsOf)
            Me.Controls.Add(Me.btnListAll)
            Me.Controls.Add(Me.btnUpload)
            Me.Controls.Add(Me.btnDownload)
            Me.Controls.Add(Me.txtDownloadRoute)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.txtDestination)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtUploadFile)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtOutput)
            Me.Controls.Add(Me.btnConnect)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.MaximizeBox = False
            Me.Name = "FrmFTPClient"
            Me.Text = "Distant FTP Client BETA 1"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtUrl As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnConnect As System.Windows.Forms.Button
        Friend WithEvents txtOutput As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtUploadFile As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtDestination As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtDownloadRoute As System.Windows.Forms.TextBox
        Friend WithEvents btnDownload As System.Windows.Forms.Button
        Friend WithEvents btnUpload As System.Windows.Forms.Button
        Friend WithEvents btnListAll As System.Windows.Forms.Button
        Friend WithEvents txtGetDetailsOf As System.Windows.Forms.TextBox
        Friend WithEvents btnBrowse As System.Windows.Forms.Button
        Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
        Friend WithEvents UploadWorker As System.ComponentModel.BackgroundWorker
        Friend WithEvents DownloadWorker As System.ComponentModel.BackgroundWorker
        Friend WithEvents SessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AboutBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AboutBarAboutItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
