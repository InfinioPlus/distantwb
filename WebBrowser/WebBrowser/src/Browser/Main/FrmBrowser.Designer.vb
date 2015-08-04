Namespace org.distantwb.main
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBrowser
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBrowser))
            Me.lblDone = New System.Windows.Forms.Label
            Me.pgrBar = New System.Windows.Forms.ProgressBar
            Me.Tab = New System.Windows.Forms.TabControl
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
            Me.menuBar = New System.Windows.Forms.ToolStripMenuItem
            Me.menuItemAddTab = New System.Windows.Forms.ToolStripMenuItem
            Me.menuItemCloseTab = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarSaveSessionItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarOpenSessionItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarGetSourceItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarSaveAsItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarPrintItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarPropertiesItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchiveBarOtherItem = New System.Windows.Forms.ToolStripMenuItem
            Me.OtherItemOpenPDFSubItem = New System.Windows.Forms.ToolStripMenuItem
            Me.bookmarkBar = New System.Windows.Forms.ToolStripMenuItem
            Me.bookmarkTxtBox = New System.Windows.Forms.ToolStripTextBox
            Me.bookmarkBarAddItem = New System.Windows.Forms.ToolStripMenuItem
            Me.BookmarkBarPagesItem = New System.Windows.Forms.ToolStripMenuItem
            Me.BookmarkBarDeleteItem = New System.Windows.Forms.ToolStripMenuItem
            Me.historyBar = New System.Windows.Forms.ToolStripMenuItem
            Me.historyBarViewItem = New System.Windows.Forms.ToolStripMenuItem
            Me.addOnsBar = New System.Windows.Forms.ToolStripMenuItem
            Me.addOnsBarAddComponentItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ToolsBar = New System.Windows.Forms.ToolStripMenuItem
            Me.ToolsBarDefaultItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defaultItemDMsubItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defaultItemCalendarSubItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defaultItemFTPClientSubItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defaultItemHTMEditorSubItem = New System.Windows.Forms.ToolStripMenuItem
            Me.defaultItemCalculatorSubItem = New System.Windows.Forms.ToolStripMenuItem
            Me.AboutBar = New System.Windows.Forms.ToolStripMenuItem
            Me.AboutBarAboutItem = New System.Windows.Forms.ToolStripMenuItem
            Me.SaveDialog = New System.Windows.Forms.SaveFileDialog
            Me.OpenDialog = New System.Windows.Forms.OpenFileDialog
            Me.Timer = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.cmbRapidSearch = New System.Windows.Forms.ComboBox
            Me.btnSearch = New System.Windows.Forms.Button
            Me.txtSearchQuery = New System.Windows.Forms.TextBox
            Me.btnCloseTab = New System.Windows.Forms.Button
            Me.btnAddTab = New System.Windows.Forms.Button
            Me.txtUrl = New System.Windows.Forms.TextBox
            Me.btnStop = New System.Windows.Forms.Button
            Me.btnRecharge = New System.Windows.Forms.Button
            Me.btnFwrd = New System.Windows.Forms.Button
            Me.btnBack = New System.Windows.Forms.Button
            Me.lblTime = New System.Windows.Forms.Label
            Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.defaultItemNotebookSubItem = New System.Windows.Forms.ToolStripMenuItem
            Me.MenuStrip1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblDone
            '
            Me.lblDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblDone.AutoSize = True
            Me.lblDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.lblDone.Location = New System.Drawing.Point(12, 597)
            Me.lblDone.Name = "lblDone"
            Me.lblDone.Size = New System.Drawing.Size(52, 13)
            Me.lblDone.TabIndex = 2
            Me.lblDone.Text = "               "
            '
            'pgrBar
            '
            Me.pgrBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pgrBar.Location = New System.Drawing.Point(743, 597)
            Me.pgrBar.Name = "pgrBar"
            Me.pgrBar.Size = New System.Drawing.Size(167, 13)
            Me.pgrBar.TabIndex = 7
            '
            'Tab
            '
            Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Tab.Location = New System.Drawing.Point(-1, 115)
            Me.Tab.Name = "Tab"
            Me.Tab.SelectedIndex = 0
            Me.Tab.Size = New System.Drawing.Size(921, 476)
            Me.Tab.TabIndex = 8
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuBar, Me.bookmarkBar, Me.historyBar, Me.addOnsBar, Me.ToolsBar, Me.AboutBar})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(920, 24)
            Me.MenuStrip1.TabIndex = 11
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'menuBar
            '
            Me.menuBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemAddTab, Me.menuItemCloseTab, Me.ArchiveBarSaveSessionItem, Me.ArchiveBarOpenSessionItem, Me.ArchiveBarGetSourceItem, Me.ArchiveBarSaveAsItem, Me.ArchiveBarPrintItem, Me.ArchiveBarPropertiesItem, Me.ArchiveBarOtherItem})
            Me.menuBar.Name = "menuBar"
            Me.menuBar.Size = New System.Drawing.Size(55, 20)
            Me.menuBar.Text = "Archivo"
            '
            'menuItemAddTab
            '
            Me.menuItemAddTab.Name = "menuItemAddTab"
            Me.menuItemAddTab.Size = New System.Drawing.Size(158, 22)
            Me.menuItemAddTab.Text = "New tab.."
            '
            'menuItemCloseTab
            '
            Me.menuItemCloseTab.Name = "menuItemCloseTab"
            Me.menuItemCloseTab.Size = New System.Drawing.Size(158, 22)
            Me.menuItemCloseTab.Text = "Close tab.."
            '
            'ArchiveBarSaveSessionItem
            '
            Me.ArchiveBarSaveSessionItem.Name = "ArchiveBarSaveSessionItem"
            Me.ArchiveBarSaveSessionItem.Size = New System.Drawing.Size(158, 22)
            Me.ArchiveBarSaveSessionItem.Text = "Save Session.."
            '
            'ArchiveBarOpenSessionItem
            '
            Me.ArchiveBarOpenSessionItem.Name = "ArchiveBarOpenSessionItem"
            Me.ArchiveBarOpenSessionItem.Size = New System.Drawing.Size(158, 22)
            Me.ArchiveBarOpenSessionItem.Text = "Open Session.."
            '
            'ArchiveBarGetSourceItem
            '
            Me.ArchiveBarGetSourceItem.Name = "ArchiveBarGetSourceItem"
            Me.ArchiveBarGetSourceItem.Size = New System.Drawing.Size(158, 22)
            Me.ArchiveBarGetSourceItem.Text = "Get Source.."
            '
            'ArchiveBarSaveAsItem
            '
            Me.ArchiveBarSaveAsItem.Name = "ArchiveBarSaveAsItem"
            Me.ArchiveBarSaveAsItem.Size = New System.Drawing.Size(158, 22)
            Me.ArchiveBarSaveAsItem.Text = "Save page as.."
            '
            'ArchiveBarPrintItem
            '
            Me.ArchiveBarPrintItem.Name = "ArchiveBarPrintItem"
            Me.ArchiveBarPrintItem.Size = New System.Drawing.Size(158, 22)
            Me.ArchiveBarPrintItem.Text = "Print.."
            '
            'ArchiveBarPropertiesItem
            '
            Me.ArchiveBarPropertiesItem.Name = "ArchiveBarPropertiesItem"
            Me.ArchiveBarPropertiesItem.Size = New System.Drawing.Size(158, 22)
            Me.ArchiveBarPropertiesItem.Text = "Properties.."
            '
            'ArchiveBarOtherItem
            '
            Me.ArchiveBarOtherItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtherItemOpenPDFSubItem})
            Me.ArchiveBarOtherItem.Name = "ArchiveBarOtherItem"
            Me.ArchiveBarOtherItem.Size = New System.Drawing.Size(158, 22)
            Me.ArchiveBarOtherItem.Text = "Other.."
            '
            'OtherItemOpenPDFSubItem
            '
            Me.OtherItemOpenPDFSubItem.Name = "OtherItemOpenPDFSubItem"
            Me.OtherItemOpenPDFSubItem.Size = New System.Drawing.Size(141, 22)
            Me.OtherItemOpenPDFSubItem.Text = "Open PDF.."
            '
            'bookmarkBar
            '
            Me.bookmarkBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bookmarkTxtBox, Me.bookmarkBarAddItem, Me.BookmarkBarPagesItem, Me.BookmarkBarDeleteItem})
            Me.bookmarkBar.Name = "bookmarkBar"
            Me.bookmarkBar.Size = New System.Drawing.Size(65, 20)
            Me.bookmarkBar.Text = "Bookmark"
            '
            'bookmarkTxtBox
            '
            Me.bookmarkTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.bookmarkTxtBox.Name = "bookmarkTxtBox"
            Me.bookmarkTxtBox.Size = New System.Drawing.Size(100, 21)
            '
            'bookmarkBarAddItem
            '
            Me.bookmarkBarAddItem.Name = "bookmarkBarAddItem"
            Me.bookmarkBarAddItem.Size = New System.Drawing.Size(160, 22)
            Me.bookmarkBarAddItem.Text = "Add!"
            '
            'BookmarkBarPagesItem
            '
            Me.BookmarkBarPagesItem.Name = "BookmarkBarPagesItem"
            Me.BookmarkBarPagesItem.Size = New System.Drawing.Size(160, 22)
            Me.BookmarkBarPagesItem.Text = "Pages"
            '
            'BookmarkBarDeleteItem
            '
            Me.BookmarkBarDeleteItem.Name = "BookmarkBarDeleteItem"
            Me.BookmarkBarDeleteItem.Size = New System.Drawing.Size(160, 22)
            Me.BookmarkBarDeleteItem.Text = "Delete.."
            '
            'historyBar
            '
            Me.historyBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.historyBarViewItem})
            Me.historyBar.Name = "historyBar"
            Me.historyBar.Size = New System.Drawing.Size(53, 20)
            Me.historyBar.Text = "History"
            '
            'historyBarViewItem
            '
            Me.historyBarViewItem.Name = "historyBarViewItem"
            Me.historyBarViewItem.Size = New System.Drawing.Size(152, 22)
            Me.historyBarViewItem.Text = "View History.."
            '
            'addOnsBar
            '
            Me.addOnsBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addOnsBarAddComponentItem})
            Me.addOnsBar.Name = "addOnsBar"
            Me.addOnsBar.Size = New System.Drawing.Size(61, 20)
            Me.addOnsBar.Text = "Add-Ons"
            '
            'addOnsBarAddComponentItem
            '
            Me.addOnsBarAddComponentItem.Name = "addOnsBarAddComponentItem"
            Me.addOnsBarAddComponentItem.Size = New System.Drawing.Size(116, 22)
            Me.addOnsBarAddComponentItem.Text = "Add..."
            '
            'ToolsBar
            '
            Me.ToolsBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsBarDefaultItem})
            Me.ToolsBar.Name = "ToolsBar"
            Me.ToolsBar.Size = New System.Drawing.Size(44, 20)
            Me.ToolsBar.Text = "Tools"
            '
            'ToolsBarDefaultItem
            '
            Me.ToolsBarDefaultItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.defaultItemDMsubItem, Me.defaultItemCalendarSubItem, Me.defaultItemFTPClientSubItem, Me.defaultItemHTMEditorSubItem, Me.defaultItemCalculatorSubItem, Me.defaultItemNotebookSubItem})
            Me.ToolsBarDefaultItem.Name = "ToolsBarDefaultItem"
            Me.ToolsBarDefaultItem.Size = New System.Drawing.Size(152, 22)
            Me.ToolsBarDefaultItem.Text = "Default"
            '
            'defaultItemDMsubItem
            '
            Me.defaultItemDMsubItem.Name = "defaultItemDMsubItem"
            Me.defaultItemDMsubItem.Size = New System.Drawing.Size(185, 22)
            Me.defaultItemDMsubItem.Text = "Download Manager.."
            '
            'defaultItemCalendarSubItem
            '
            Me.defaultItemCalendarSubItem.Name = "defaultItemCalendarSubItem"
            Me.defaultItemCalendarSubItem.Size = New System.Drawing.Size(185, 22)
            Me.defaultItemCalendarSubItem.Text = "Calendar.."
            '
            'defaultItemFTPClientSubItem
            '
            Me.defaultItemFTPClientSubItem.Name = "defaultItemFTPClientSubItem"
            Me.defaultItemFTPClientSubItem.Size = New System.Drawing.Size(185, 22)
            Me.defaultItemFTPClientSubItem.Text = "FTP Client.."
            '
            'defaultItemHTMEditorSubItem
            '
            Me.defaultItemHTMEditorSubItem.Name = "defaultItemHTMEditorSubItem"
            Me.defaultItemHTMEditorSubItem.Size = New System.Drawing.Size(185, 22)
            Me.defaultItemHTMEditorSubItem.Text = "HTML Editor.."
            '
            'defaultItemCalculatorSubItem
            '
            Me.defaultItemCalculatorSubItem.Name = "defaultItemCalculatorSubItem"
            Me.defaultItemCalculatorSubItem.Size = New System.Drawing.Size(185, 22)
            Me.defaultItemCalculatorSubItem.Text = "Calculator.."
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
            'Timer
            '
            Me.Timer.Enabled = True
            '
            'Panel1
            '
            Me.Panel1.AutoSize = True
            Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.Panel1.Controls.Add(Me.cmbRapidSearch)
            Me.Panel1.Controls.Add(Me.btnSearch)
            Me.Panel1.Controls.Add(Me.txtSearchQuery)
            Me.Panel1.Controls.Add(Me.btnCloseTab)
            Me.Panel1.Controls.Add(Me.btnAddTab)
            Me.Panel1.Controls.Add(Me.txtUrl)
            Me.Panel1.Controls.Add(Me.btnStop)
            Me.Panel1.Controls.Add(Me.btnRecharge)
            Me.Panel1.Controls.Add(Me.btnFwrd)
            Me.Panel1.Controls.Add(Me.btnBack)
            Me.Panel1.Controls.Add(Me.lblTime)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 24)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(920, 86)
            Me.Panel1.TabIndex = 29
            '
            'cmbRapidSearch
            '
            Me.cmbRapidSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmbRapidSearch.FormattingEnabled = True
            Me.cmbRapidSearch.Location = New System.Drawing.Point(554, 13)
            Me.cmbRapidSearch.Name = "cmbRapidSearch"
            Me.cmbRapidSearch.Size = New System.Drawing.Size(78, 21)
            Me.cmbRapidSearch.TabIndex = 33
            '
            'btnSearch
            '
            Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSearch.AutoSize = True
            Me.btnSearch.Location = New System.Drawing.Point(719, 13)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(51, 24)
            Me.btnSearch.TabIndex = 32
            Me.btnSearch.Text = "Search"
            Me.btnSearch.UseVisualStyleBackColor = True
            '
            'txtSearchQuery
            '
            Me.txtSearchQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSearchQuery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.txtSearchQuery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
            Me.txtSearchQuery.Location = New System.Drawing.Point(605, 15)
            Me.txtSearchQuery.Name = "txtSearchQuery"
            Me.txtSearchQuery.Size = New System.Drawing.Size(118, 20)
            Me.txtSearchQuery.TabIndex = 31
            '
            'btnCloseTab
            '
            Me.btnCloseTab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCloseTab.Location = New System.Drawing.Point(850, 46)
            Me.btnCloseTab.Name = "btnCloseTab"
            Me.btnCloseTab.Size = New System.Drawing.Size(23, 22)
            Me.btnCloseTab.TabIndex = 30
            Me.btnCloseTab.Text = "X"
            Me.btnCloseTab.UseVisualStyleBackColor = True
            '
            'btnAddTab
            '
            Me.btnAddTab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddTab.Location = New System.Drawing.Point(821, 46)
            Me.btnAddTab.Name = "btnAddTab"
            Me.btnAddTab.Size = New System.Drawing.Size(23, 22)
            Me.btnAddTab.TabIndex = 29
            Me.btnAddTab.Text = "+"
            Me.btnAddTab.UseVisualStyleBackColor = True
            '
            'txtUrl
            '
            Me.txtUrl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
            Me.txtUrl.Location = New System.Drawing.Point(327, 48)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(488, 20)
            Me.txtUrl.TabIndex = 28
            '
            'btnStop
            '
            Me.btnStop.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.btnStop.BackgroundImage = Global.distantWB.My.Resources.Resources.stop2
            Me.btnStop.Enabled = False
            Me.btnStop.Location = New System.Drawing.Point(222, 15)
            Me.btnStop.Name = "btnStop"
            Me.btnStop.Size = New System.Drawing.Size(68, 66)
            Me.btnStop.TabIndex = 24
            Me.btnStop.UseVisualStyleBackColor = False
            '
            'btnRecharge
            '
            Me.btnRecharge.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.btnRecharge.BackgroundImage = Global.distantWB.My.Resources.Resources.refresh2
            Me.btnRecharge.Location = New System.Drawing.Point(149, 15)
            Me.btnRecharge.Name = "btnRecharge"
            Me.btnRecharge.Size = New System.Drawing.Size(67, 66)
            Me.btnRecharge.TabIndex = 23
            Me.btnRecharge.UseVisualStyleBackColor = False
            '
            'btnFwrd
            '
            Me.btnFwrd.BackColor = System.Drawing.SystemColors.Control
            Me.btnFwrd.BackgroundImage = Global.distantWB.My.Resources.Resources.next21
            Me.btnFwrd.Enabled = False
            Me.btnFwrd.Location = New System.Drawing.Point(78, 15)
            Me.btnFwrd.Name = "btnFwrd"
            Me.btnFwrd.Size = New System.Drawing.Size(65, 67)
            Me.btnFwrd.TabIndex = 22
            Me.btnFwrd.UseVisualStyleBackColor = False
            '
            'btnBack
            '
            Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.btnBack.BackgroundImage = Global.distantWB.My.Resources.Resources.back2
            Me.btnBack.Enabled = False
            Me.btnBack.Location = New System.Drawing.Point(3, 16)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New System.Drawing.Size(69, 67)
            Me.btnBack.TabIndex = 21
            Me.btnBack.UseVisualStyleBackColor = False
            '
            'lblTime
            '
            Me.lblTime.AutoSize = True
            Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.lblTime.Location = New System.Drawing.Point(364, 16)
            Me.lblTime.Name = "lblTime"
            Me.lblTime.Size = New System.Drawing.Size(0, 29)
            Me.lblTime.TabIndex = 13
            '
            'ImageList
            '
            Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList.Images.SetKeyName(0, "Google-icon.png")
            '
            'defaultItemNotebookSubItem
            '
            Me.defaultItemNotebookSubItem.Name = "defaultItemNotebookSubItem"
            Me.defaultItemNotebookSubItem.Size = New System.Drawing.Size(185, 22)
            Me.defaultItemNotebookSubItem.Text = "Notebook.."
            '
            'FrmBrowser
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.ClientSize = New System.Drawing.Size(920, 620)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Tab)
            Me.Controls.Add(Me.pgrBar)
            Me.Controls.Add(Me.lblDone)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "FrmBrowser"
            Me.Text = "DistantWB V1.8"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblDone As System.Windows.Forms.Label
        Friend WithEvents pgrBar As System.Windows.Forms.ProgressBar
        Friend WithEvents Tab As System.Windows.Forms.TabControl
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents menuBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents menuItemAddTab As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents menuItemCloseTab As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents bookmarkBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents bookmarkTxtBox As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents bookmarkBarAddItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents BookmarkBarPagesItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents historyBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents historyBarViewItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ArchiveBarSaveSessionItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ArchiveBarOpenSessionItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
        Friend WithEvents ArchiveBarGetSourceItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents BookmarkBarDeleteItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents addOnsBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents addOnsBarAddComponentItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Timer As System.Windows.Forms.Timer
        Friend WithEvents ArchiveBarSaveAsItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ArchiveBarPrintItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ArchiveBarPropertiesItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cmbRapidSearch As System.Windows.Forms.ComboBox
        Friend WithEvents btnSearch As System.Windows.Forms.Button
        Friend WithEvents txtSearchQuery As System.Windows.Forms.TextBox
        Friend WithEvents btnCloseTab As System.Windows.Forms.Button
        Friend WithEvents btnAddTab As System.Windows.Forms.Button
        Friend WithEvents txtUrl As System.Windows.Forms.TextBox
        Friend WithEvents btnStop As System.Windows.Forms.Button
        Friend WithEvents btnRecharge As System.Windows.Forms.Button
        Friend WithEvents btnFwrd As System.Windows.Forms.Button
        Friend WithEvents btnBack As System.Windows.Forms.Button
        Friend WithEvents lblTime As System.Windows.Forms.Label
        Friend WithEvents ToolsBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolsBarDefaultItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents defaultItemDMsubItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents defaultItemCalendarSubItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents defaultItemFTPClientSubItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AboutBar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AboutBarAboutItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents defaultItemHTMEditorSubItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ArchiveBarOtherItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents OtherItemOpenPDFSubItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents defaultItemCalculatorSubItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ImageList As System.Windows.Forms.ImageList
        Friend WithEvents defaultItemNotebookSubItem As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace
