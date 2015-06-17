<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeyStatus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyStatus))
        Me.timerKeyChecker = New System.Windows.Forms.Timer(Me.components)
        Me.KeyStatusNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.notifyContextShowIcons = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyContextAllowToggle = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyContextSeperator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.notifyContextPopups = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyContextSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.notifyContextShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyContextHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyContextExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyIconNumLock = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyIconCapsLock = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyIconScrollLock = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.grpTray = New System.Windows.Forms.GroupBox()
        Me.chkTraySelection = New System.Windows.Forms.CheckBox()
        Me.grpTraySelection = New System.Windows.Forms.GroupBox()
        Me.chkTraySelectionScroll = New System.Windows.Forms.CheckBox()
        Me.chkTraySelectionCaps = New System.Windows.Forms.CheckBox()
        Me.chkTraySelectionNum = New System.Windows.Forms.CheckBox()
        Me.chkTrayClick = New System.Windows.Forms.CheckBox()
        Me.chkTrayEnabledOnly = New System.Windows.Forms.CheckBox()
        Me.chkTrayAppIcon = New System.Windows.Forms.CheckBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpPopup = New System.Windows.Forms.GroupBox()
        Me.numPopupCustLocExactY = New System.Windows.Forms.NumericUpDown()
        Me.numPopupCustLocExactX = New System.Windows.Forms.NumericUpDown()
        Me.numPopupCustLocFactY = New System.Windows.Forms.NumericUpDown()
        Me.numPopupCustLocFactX = New System.Windows.Forms.NumericUpDown()
        Me.lblPopupCustLocY = New System.Windows.Forms.Label()
        Me.lblPopupCustLocX = New System.Windows.Forms.Label()
        Me.chkColours = New System.Windows.Forms.CheckBox()
        Me.chkPopupTaskbar = New System.Windows.Forms.CheckBox()
        Me.lblPopupLocation = New System.Windows.Forms.Label()
        Me.cbxPopupLocation = New System.Windows.Forms.ComboBox()
        Me.numPopupDelay = New System.Windows.Forms.NumericUpDown()
        Me.lblPopupDelay = New System.Windows.Forms.Label()
        Me.chkPopup = New System.Windows.Forms.CheckBox()
        Me.timerPopupHide = New System.Windows.Forms.Timer(Me.components)
        Me.notifyContext.SuspendLayout
        Me.grpTray.SuspendLayout
        Me.grpTraySelection.SuspendLayout
        Me.grpPopup.SuspendLayout
        CType(Me.numPopupCustLocExactY,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numPopupCustLocExactX,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numPopupCustLocFactY,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numPopupCustLocFactX,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numPopupDelay,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'KeyStatusNotifyIcon
        '
        Me.KeyStatusNotifyIcon.ContextMenuStrip = Me.notifyContext
        Me.KeyStatusNotifyIcon.Text = "KeyStatus"
        '
        'notifyContext
        '
        Me.notifyContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.notifyContextShowIcons, Me.notifyContextAllowToggle, Me.notifyContextSeperator1, Me.notifyContextPopups, Me.notifyContextSeparator2, Me.notifyContextShow, Me.notifyContextHide, Me.notifyContextExit})
        Me.notifyContext.Name = "notifyContext"
        Me.notifyContext.Size = New System.Drawing.Size(251, 170)
        '
        'notifyContextShowIcons
        '
        Me.notifyContextShowIcons.AutoToolTip = true
        Me.notifyContextShowIcons.Checked = true
        Me.notifyContextShowIcons.CheckOnClick = true
        Me.notifyContextShowIcons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.notifyContextShowIcons.Name = "notifyContextShowIcons"
        Me.notifyContextShowIcons.Size = New System.Drawing.Size(250, 22)
        Me.notifyContextShowIcons.Text = "Show taskbar icons"
        '
        'notifyContextAllowToggle
        '
        Me.notifyContextAllowToggle.AutoToolTip = true
        Me.notifyContextAllowToggle.Checked = true
        Me.notifyContextAllowToggle.CheckOnClick = true
        Me.notifyContextAllowToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.notifyContextAllowToggle.Name = "notifyContextAllowToggle"
        Me.notifyContextAllowToggle.Size = New System.Drawing.Size(250, 22)
        Me.notifyContextAllowToggle.Text = "Allow toggling locks from icons"
        '
        'notifyContextSeperator1
        '
        Me.notifyContextSeperator1.Name = "notifyContextSeperator1"
        Me.notifyContextSeperator1.Size = New System.Drawing.Size(247, 6)
        '
        'notifyContextPopups
        '
        Me.notifyContextPopups.AutoToolTip = true
        Me.notifyContextPopups.Checked = true
        Me.notifyContextPopups.CheckOnClick = true
        Me.notifyContextPopups.CheckState = System.Windows.Forms.CheckState.Checked
        Me.notifyContextPopups.Name = "notifyContextPopups"
        Me.notifyContextPopups.Size = New System.Drawing.Size(250, 22)
        Me.notifyContextPopups.Text = "Show Popups"
        '
        'notifyContextSeparator2
        '
        Me.notifyContextSeparator2.Name = "notifyContextSeparator2"
        Me.notifyContextSeparator2.Size = New System.Drawing.Size(247, 6)
        '
        'notifyContextShow
        '
        Me.notifyContextShow.AutoToolTip = true
        Me.notifyContextShow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.notifyContextShow.Name = "notifyContextShow"
        Me.notifyContextShow.Size = New System.Drawing.Size(250, 22)
        Me.notifyContextShow.Text = "Show KeyStatus"
        '
        'notifyContextHide
        '
        Me.notifyContextHide.AutoToolTip = true
        Me.notifyContextHide.Name = "notifyContextHide"
        Me.notifyContextHide.Size = New System.Drawing.Size(250, 22)
        Me.notifyContextHide.Text = "Hide KeyStatus"
        '
        'notifyContextExit
        '
        Me.notifyContextExit.AutoToolTip = true
        Me.notifyContextExit.Name = "notifyContextExit"
        Me.notifyContextExit.Size = New System.Drawing.Size(250, 22)
        Me.notifyContextExit.Text = "Exit"
        '
        'notifyIconNumLock
        '
        Me.notifyIconNumLock.Text = "Num Lock"
        '
        'notifyIconCapsLock
        '
        Me.notifyIconCapsLock.Text = "Caps Lock"
        '
        'notifyIconScrollLock
        '
        Me.notifyIconScrollLock.Text = "Scroll Lock"
        '
        'grpTray
        '
        Me.grpTray.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpTray.Controls.Add(Me.chkTraySelection)
        Me.grpTray.Controls.Add(Me.grpTraySelection)
        Me.grpTray.Controls.Add(Me.chkTrayClick)
        Me.grpTray.Controls.Add(Me.chkTrayEnabledOnly)
        Me.grpTray.Controls.Add(Me.chkTrayAppIcon)
        Me.grpTray.Location = New System.Drawing.Point(12, 12)
        Me.grpTray.Name = "grpTray"
        Me.grpTray.Size = New System.Drawing.Size(462, 186)
        Me.grpTray.TabIndex = 1
        Me.grpTray.TabStop = false
        Me.grpTray.Text = "Notification Icons"
        '
        'chkTraySelection
        '
        Me.chkTraySelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkTraySelection.AutoSize = true
        Me.chkTraySelection.Checked = true
        Me.chkTraySelection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTraySelection.Location = New System.Drawing.Point(13, 88)
        Me.chkTraySelection.Name = "chkTraySelection"
        Me.chkTraySelection.Size = New System.Drawing.Size(178, 17)
        Me.chkTraySelection.TabIndex = 4
        Me.chkTraySelection.Text = "Show icons for these locks only:"
        Me.chkTraySelection.UseVisualStyleBackColor = true
        '
        'grpTraySelection
        '
        Me.grpTraySelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpTraySelection.Controls.Add(Me.chkTraySelectionScroll)
        Me.grpTraySelection.Controls.Add(Me.chkTraySelectionCaps)
        Me.grpTraySelection.Controls.Add(Me.chkTraySelectionNum)
        Me.grpTraySelection.Location = New System.Drawing.Point(6, 88)
        Me.grpTraySelection.Name = "grpTraySelection"
        Me.grpTraySelection.Size = New System.Drawing.Size(450, 92)
        Me.grpTraySelection.TabIndex = 3
        Me.grpTraySelection.TabStop = false
        '
        'chkTraySelectionScroll
        '
        Me.chkTraySelectionScroll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkTraySelectionScroll.AutoEllipsis = true
        Me.chkTraySelectionScroll.Location = New System.Drawing.Point(6, 69)
        Me.chkTraySelectionScroll.Name = "chkTraySelectionScroll"
        Me.chkTraySelectionScroll.Size = New System.Drawing.Size(438, 17)
        Me.chkTraySelectionScroll.TabIndex = 5
        Me.chkTraySelectionScroll.Text = "Scroll Lock"
        Me.chkTraySelectionScroll.UseVisualStyleBackColor = true
        '
        'chkTraySelectionCaps
        '
        Me.chkTraySelectionCaps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkTraySelectionCaps.AutoEllipsis = true
        Me.chkTraySelectionCaps.Checked = true
        Me.chkTraySelectionCaps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTraySelectionCaps.Location = New System.Drawing.Point(6, 46)
        Me.chkTraySelectionCaps.Name = "chkTraySelectionCaps"
        Me.chkTraySelectionCaps.Size = New System.Drawing.Size(438, 17)
        Me.chkTraySelectionCaps.TabIndex = 4
        Me.chkTraySelectionCaps.Text = "Caps Lock"
        Me.chkTraySelectionCaps.UseVisualStyleBackColor = true
        '
        'chkTraySelectionNum
        '
        Me.chkTraySelectionNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkTraySelectionNum.AutoEllipsis = true
        Me.chkTraySelectionNum.Checked = true
        Me.chkTraySelectionNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTraySelectionNum.Location = New System.Drawing.Point(6, 23)
        Me.chkTraySelectionNum.Name = "chkTraySelectionNum"
        Me.chkTraySelectionNum.Size = New System.Drawing.Size(438, 17)
        Me.chkTraySelectionNum.TabIndex = 3
        Me.chkTraySelectionNum.Text = "Num Lock"
        Me.chkTraySelectionNum.UseVisualStyleBackColor = true
        '
        'chkTrayClick
        '
        Me.chkTrayClick.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkTrayClick.AutoEllipsis = true
        Me.chkTrayClick.Checked = true
        Me.chkTrayClick.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrayClick.Location = New System.Drawing.Point(6, 65)
        Me.chkTrayClick.Name = "chkTrayClick"
        Me.chkTrayClick.Size = New System.Drawing.Size(450, 17)
        Me.chkTrayClick.TabIndex = 2
        Me.chkTrayClick.Text = "Click on icon to enable or disable locks"
        Me.chkTrayClick.UseVisualStyleBackColor = true
        '
        'chkTrayEnabledOnly
        '
        Me.chkTrayEnabledOnly.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkTrayEnabledOnly.AutoEllipsis = true
        Me.chkTrayEnabledOnly.Checked = true
        Me.chkTrayEnabledOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrayEnabledOnly.Location = New System.Drawing.Point(6, 42)
        Me.chkTrayEnabledOnly.Name = "chkTrayEnabledOnly"
        Me.chkTrayEnabledOnly.Size = New System.Drawing.Size(450, 17)
        Me.chkTrayEnabledOnly.TabIndex = 1
        Me.chkTrayEnabledOnly.Text = "Only show icon if lock is enabled"
        Me.chkTrayEnabledOnly.UseVisualStyleBackColor = true
        '
        'chkTrayAppIcon
        '
        Me.chkTrayAppIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkTrayAppIcon.AutoEllipsis = true
        Me.chkTrayAppIcon.Checked = true
        Me.chkTrayAppIcon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrayAppIcon.Location = New System.Drawing.Point(6, 19)
        Me.chkTrayAppIcon.Name = "chkTrayAppIcon"
        Me.chkTrayAppIcon.Size = New System.Drawing.Size(450, 17)
        Me.chkTrayAppIcon.TabIndex = 0
        Me.chkTrayAppIcon.Text = "Don't show application icon (will be shown if no other icons are and app window i"& _ 
        "s hidden)"
        Me.chkTrayAppIcon.UseVisualStyleBackColor = true
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAbout.Location = New System.Drawing.Point(125, 330)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = true
        '
        'btnHide
        '
        Me.btnHide.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnHide.Location = New System.Drawing.Point(206, 330)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 3
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(287, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'grpPopup
        '
        Me.grpPopup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpPopup.Controls.Add(Me.numPopupCustLocExactY)
        Me.grpPopup.Controls.Add(Me.numPopupCustLocExactX)
        Me.grpPopup.Controls.Add(Me.numPopupCustLocFactY)
        Me.grpPopup.Controls.Add(Me.numPopupCustLocFactX)
        Me.grpPopup.Controls.Add(Me.lblPopupCustLocY)
        Me.grpPopup.Controls.Add(Me.lblPopupCustLocX)
        Me.grpPopup.Controls.Add(Me.chkColours)
        Me.grpPopup.Controls.Add(Me.chkPopupTaskbar)
        Me.grpPopup.Controls.Add(Me.lblPopupLocation)
        Me.grpPopup.Controls.Add(Me.cbxPopupLocation)
        Me.grpPopup.Controls.Add(Me.numPopupDelay)
        Me.grpPopup.Controls.Add(Me.lblPopupDelay)
        Me.grpPopup.Location = New System.Drawing.Point(12, 204)
        Me.grpPopup.Name = "grpPopup"
        Me.grpPopup.Size = New System.Drawing.Size(462, 120)
        Me.grpPopup.TabIndex = 5
        Me.grpPopup.TabStop = false
        '
        'numPopupCustLocExactY
        '
        Me.numPopupCustLocExactY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.numPopupCustLocExactY.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numPopupCustLocExactY.Location = New System.Drawing.Point(264, 55)
        Me.numPopupCustLocExactY.Maximum = New Decimal(New Integer() {1, 1, 1, 0})
        Me.numPopupCustLocExactY.Minimum = New Decimal(New Integer() {1, 1, 1, -2147483648})
        Me.numPopupCustLocExactY.Name = "numPopupCustLocExactY"
        Me.numPopupCustLocExactY.Size = New System.Drawing.Size(192, 20)
        Me.numPopupCustLocExactY.TabIndex = 11
        Me.numPopupCustLocExactY.ThousandsSeparator = true
        Me.numPopupCustLocExactY.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.numPopupCustLocExactY.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'numPopupCustLocExactX
        '
        Me.numPopupCustLocExactX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.numPopupCustLocExactX.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numPopupCustLocExactX.Location = New System.Drawing.Point(264, 35)
        Me.numPopupCustLocExactX.Maximum = New Decimal(New Integer() {1, 1, 1, 0})
        Me.numPopupCustLocExactX.Minimum = New Decimal(New Integer() {1, 1, 1, -2147483648})
        Me.numPopupCustLocExactX.Name = "numPopupCustLocExactX"
        Me.numPopupCustLocExactX.Size = New System.Drawing.Size(192, 20)
        Me.numPopupCustLocExactX.TabIndex = 10
        Me.numPopupCustLocExactX.ThousandsSeparator = true
        Me.numPopupCustLocExactX.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.numPopupCustLocExactX.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'numPopupCustLocFactY
        '
        Me.numPopupCustLocFactY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.numPopupCustLocFactY.DecimalPlaces = 2
        Me.numPopupCustLocFactY.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.numPopupCustLocFactY.Location = New System.Drawing.Point(275, 55)
        Me.numPopupCustLocFactY.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numPopupCustLocFactY.Minimum = New Decimal(New Integer() {105, 0, 0, 131072})
        Me.numPopupCustLocFactY.Name = "numPopupCustLocFactY"
        Me.numPopupCustLocFactY.Size = New System.Drawing.Size(181, 20)
        Me.numPopupCustLocFactY.TabIndex = 9
        Me.numPopupCustLocFactY.ThousandsSeparator = true
        Me.numPopupCustLocFactY.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.numPopupCustLocFactY.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'numPopupCustLocFactX
        '
        Me.numPopupCustLocFactX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.numPopupCustLocFactX.DecimalPlaces = 2
        Me.numPopupCustLocFactX.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.numPopupCustLocFactX.Location = New System.Drawing.Point(275, 35)
        Me.numPopupCustLocFactX.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numPopupCustLocFactX.Minimum = New Decimal(New Integer() {105, 0, 0, 131072})
        Me.numPopupCustLocFactX.Name = "numPopupCustLocFactX"
        Me.numPopupCustLocFactX.Size = New System.Drawing.Size(181, 20)
        Me.numPopupCustLocFactX.TabIndex = 8
        Me.numPopupCustLocFactX.ThousandsSeparator = true
        Me.numPopupCustLocFactX.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.numPopupCustLocFactX.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblPopupCustLocY
        '
        Me.lblPopupCustLocY.AutoSize = true
        Me.lblPopupCustLocY.Location = New System.Drawing.Point(191, 55)
        Me.lblPopupCustLocY.Name = "lblPopupCustLocY"
        Me.lblPopupCustLocY.Size = New System.Drawing.Size(0, 13)
        Me.lblPopupCustLocY.TabIndex = 7
        '
        'lblPopupCustLocX
        '
        Me.lblPopupCustLocX.AutoSize = true
        Me.lblPopupCustLocX.Location = New System.Drawing.Point(191, 42)
        Me.lblPopupCustLocX.Name = "lblPopupCustLocX"
        Me.lblPopupCustLocX.Size = New System.Drawing.Size(0, 13)
        Me.lblPopupCustLocX.TabIndex = 6
        '
        'chkColours
        '
        Me.chkColours.AutoSize = true
        Me.chkColours.Checked = true
        Me.chkColours.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColours.Location = New System.Drawing.Point(6, 95)
        Me.chkColours.Name = "chkColours"
        Me.chkColours.Size = New System.Drawing.Size(103, 17)
        Me.chkColours.TabIndex = 5
        Me.chkColours.Text = "Colour-code text"
        Me.chkColours.UseVisualStyleBackColor = true
        '
        'chkPopupTaskbar
        '
        Me.chkPopupTaskbar.AutoSize = true
        Me.chkPopupTaskbar.Location = New System.Drawing.Point(6, 72)
        Me.chkPopupTaskbar.Name = "chkPopupTaskbar"
        Me.chkPopupTaskbar.Size = New System.Drawing.Size(235, 17)
        Me.chkPopupTaskbar.TabIndex = 4
        Me.chkPopupTaskbar.Text = "Whole screen (alternative is without taskbar)"
        Me.chkPopupTaskbar.UseVisualStyleBackColor = true
        '
        'lblPopupLocation
        '
        Me.lblPopupLocation.AutoSize = true
        Me.lblPopupLocation.Location = New System.Drawing.Point(6, 48)
        Me.lblPopupLocation.Name = "lblPopupLocation"
        Me.lblPopupLocation.Size = New System.Drawing.Size(81, 13)
        Me.lblPopupLocation.TabIndex = 3
        Me.lblPopupLocation.Text = "Popup location:"
        '
        'cbxPopupLocation
        '
        Me.cbxPopupLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPopupLocation.FormattingEnabled = true
        Me.cbxPopupLocation.Items.AddRange(New Object() {"Top Left", "Top Center", "Top Right", "Center Left", "Center", "Center Right", "Bottom Left", "Bottom Center", "Bottom Right", "Custom Division Factor", "Custom Co-ordinates"})
        Me.cbxPopupLocation.Location = New System.Drawing.Point(93, 45)
        Me.cbxPopupLocation.Name = "cbxPopupLocation"
        Me.cbxPopupLocation.Size = New System.Drawing.Size(92, 21)
        Me.cbxPopupLocation.TabIndex = 2
        '
        'numPopupDelay
        '
        Me.numPopupDelay.Increment = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numPopupDelay.Location = New System.Drawing.Point(135, 19)
        Me.numPopupDelay.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.numPopupDelay.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numPopupDelay.Name = "numPopupDelay"
        Me.numPopupDelay.Size = New System.Drawing.Size(90, 20)
        Me.numPopupDelay.TabIndex = 1
        Me.numPopupDelay.ThousandsSeparator = true
        Me.numPopupDelay.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.numPopupDelay.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'lblPopupDelay
        '
        Me.lblPopupDelay.AutoSize = true
        Me.lblPopupDelay.Location = New System.Drawing.Point(6, 21)
        Me.lblPopupDelay.Name = "lblPopupDelay"
        Me.lblPopupDelay.Size = New System.Drawing.Size(123, 13)
        Me.lblPopupDelay.TabIndex = 0
        Me.lblPopupDelay.Text = "Delay before hiding (ms):"
        '
        'chkPopup
        '
        Me.chkPopup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkPopup.AutoSize = true
        Me.chkPopup.Checked = true
        Me.chkPopup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPopup.Location = New System.Drawing.Point(20, 204)
        Me.chkPopup.Name = "chkPopup"
        Me.chkPopup.Size = New System.Drawing.Size(189, 17)
        Me.chkPopup.TabIndex = 6
        Me.chkPopup.Text = "Show popup on lock state change"
        Me.chkPopup.UseVisualStyleBackColor = true
        '
        'KeyStatus
        '
        Me.AcceptButton = Me.btnHide
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(486, 365)
        Me.Controls.Add(Me.chkPopup)
        Me.Controls.Add(Me.grpPopup)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.grpTray)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "KeyStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeyStatus"
        Me.notifyContext.ResumeLayout(false)
        Me.grpTray.ResumeLayout(false)
        Me.grpTray.PerformLayout
        Me.grpTraySelection.ResumeLayout(false)
        Me.grpPopup.ResumeLayout(false)
        Me.grpPopup.PerformLayout
        CType(Me.numPopupCustLocExactY,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numPopupCustLocExactX,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numPopupCustLocFactY,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numPopupCustLocFactX,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numPopupDelay,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private numPopupCustLocExactX As System.Windows.Forms.NumericUpDown
    Private numPopupCustLocExactY As System.Windows.Forms.NumericUpDown
    Private lblPopupCustLocY As System.Windows.Forms.Label
    Private numPopupCustLocFactX As System.Windows.Forms.NumericUpDown
    Private numPopupCustLocFactY As System.Windows.Forms.NumericUpDown
    Private lblPopupCustLocX As System.Windows.Forms.Label
    Private notifyContextSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents notifyContextPopups As System.Windows.Forms.ToolStripMenuItem
    Private notifyContextSeperator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents notifyContextAllowToggle As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents notifyContextShowIcons As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents timerPopupHide As System.Windows.Forms.Timer
    Private chkColours As System.Windows.Forms.CheckBox
    Private lblPopupDelay As System.Windows.Forms.Label
    Private numPopupDelay As System.Windows.Forms.NumericUpDown
    Private WithEvents cbxPopupLocation As System.Windows.Forms.ComboBox
    Private lblPopupLocation As System.Windows.Forms.Label
    Private WithEvents chkPopupTaskbar As System.Windows.Forms.CheckBox
    Private WithEvents chkPopup As System.Windows.Forms.CheckBox
    Private grpPopup As System.Windows.Forms.GroupBox
    Private WithEvents notifyContextHide As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents notifyContextExit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents notifyContextShow As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnHide As System.Windows.Forms.Button
    Private WithEvents btnAbout As System.Windows.Forms.Button
    Private WithEvents chkTraySelectionNum As System.Windows.Forms.CheckBox
    Private WithEvents chkTraySelectionCaps As System.Windows.Forms.CheckBox
    Private WithEvents chkTraySelectionScroll As System.Windows.Forms.CheckBox
    Private chkTrayEnabledOnly As System.Windows.Forms.CheckBox
    Private WithEvents chkTrayClick As System.Windows.Forms.CheckBox
    Private grpTraySelection As System.Windows.Forms.GroupBox
    Private WithEvents chkTraySelection As System.Windows.Forms.CheckBox
    Private chkTrayAppIcon As System.Windows.Forms.CheckBox
    Private grpTray As System.Windows.Forms.GroupBox
    Private notifyContext As System.Windows.Forms.ContextMenuStrip
    Private WithEvents notifyIconScrollLock As System.Windows.Forms.NotifyIcon
    Private WithEvents notifyIconCapsLock As System.Windows.Forms.NotifyIcon
    Private WithEvents notifyIconNumLock As System.Windows.Forms.NotifyIcon
    Private WithEvents KeyStatusNotifyIcon As System.Windows.Forms.NotifyIcon
    Private WithEvents timerKeyChecker As System.Windows.Forms.Timer
End Class
