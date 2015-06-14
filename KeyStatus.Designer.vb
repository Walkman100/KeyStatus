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
        Me.notifyContextShow = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.notifyContextHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.notifyContext.SuspendLayout
        Me.grpTray.SuspendLayout
        Me.grpTraySelection.SuspendLayout
        Me.SuspendLayout
        '
        'KeyStatusNotifyIcon
        '
        Me.KeyStatusNotifyIcon.ContextMenuStrip = Me.notifyContext
        Me.KeyStatusNotifyIcon.Text = "KeyStatus"
        '
        'notifyContext
        '
        Me.notifyContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.notifyContextShow, Me.notifyContextHide, Me.notifyContextExit})
        Me.notifyContext.Name = "notifyContext"
        Me.notifyContext.Size = New System.Drawing.Size(168, 92)
        '
        'notifyContextShow
        '
        Me.notifyContextShow.Name = "notifyContextShow"
        Me.notifyContextShow.Size = New System.Drawing.Size(167, 22)
        Me.notifyContextShow.Text = "Show KeyStatus"
        '
        'notifyContextExit
        '
        Me.notifyContextExit.Name = "notifyContextExit"
        Me.notifyContextExit.Size = New System.Drawing.Size(167, 22)
        Me.notifyContextExit.Text = "Close"
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
        AddHandler Me.chkTraySelection.CheckedChanged, AddressOf Me.ChkTraySelection_CheckedChanged
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
        Me.btnAbout.Location = New System.Drawing.Point(125, 208)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = true
        '
        'btnHide
        '
        Me.btnHide.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnHide.Location = New System.Drawing.Point(206, 208)
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
        Me.btnExit.Location = New System.Drawing.Point(287, 208)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'notifyContextHide
        '
        Me.notifyContextHide.Name = "notifyContextHide"
        Me.notifyContextHide.Size = New System.Drawing.Size(167, 22)
        Me.notifyContextHide.Text = "Hide KeyStatus"
        '
        'KeyStatus
        '
        Me.AcceptButton = Me.btnHide
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(486, 243)
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
        Me.ResumeLayout(false)
    End Sub
    Private WithEvents notifyContextHide As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents notifyContextExit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents notifyContextShow As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnHide As System.Windows.Forms.Button
    Private WithEvents btnAbout As System.Windows.Forms.Button
    Private WithEvents chkTraySelectionNum As System.Windows.Forms.CheckBox
    Private WithEvents chkTraySelectionCaps As System.Windows.Forms.CheckBox
    Private WithEvents chkTraySelectionScroll As System.Windows.Forms.CheckBox
    Private WithEvents chkTrayEnabledOnly As System.Windows.Forms.CheckBox
    Private WithEvents chkTrayClick As System.Windows.Forms.CheckBox
    Private WithEvents grpTraySelection As System.Windows.Forms.GroupBox
    Private WithEvents chkTraySelection As System.Windows.Forms.CheckBox
    Private WithEvents chkTrayAppIcon As System.Windows.Forms.CheckBox
    Private WithEvents grpTray As System.Windows.Forms.GroupBox
    Private WithEvents notifyContext As System.Windows.Forms.ContextMenuStrip
    Private WithEvents notifyIconScrollLock As System.Windows.Forms.NotifyIcon
    Private WithEvents notifyIconCapsLock As System.Windows.Forms.NotifyIcon
    Private WithEvents notifyIconNumLock As System.Windows.Forms.NotifyIcon
    Private WithEvents KeyStatusNotifyIcon As System.Windows.Forms.NotifyIcon
    Private WithEvents timerKeyChecker As System.Windows.Forms.Timer

End Class
