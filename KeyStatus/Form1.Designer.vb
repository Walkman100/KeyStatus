<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.KeyStatusNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.KeyStatusNotifyIconContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewActiveKeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyStatusService = New System.Windows.Forms.Timer(Me.components)
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.HideButton = New System.Windows.Forms.Button()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EnterACommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevCommander = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CapsLockOff = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CapsLockOn = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NumLockOn = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NumLockOff = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ScrollLockOn = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ScrollLockOff = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyStatusNotifyIconContextMenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(130, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(334, 52)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Name"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(130, 70)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(334, 27)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Version"
        Me.LabelX2.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(-3, 100)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(485, 23)
        Me.Line1.TabIndex = 3
        Me.Line1.Text = "Line1"
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(-3, 339)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(485, 10)
        Me.Line2.TabIndex = 4
        Me.Line2.Text = "Line2"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(356, 352)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(108, 27)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(12, 129)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(218, 27)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "Flip The Switch To Begin:"
        Me.LabelX3.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Location = New System.Drawing.Point(236, 129)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.Size = New System.Drawing.Size(83, 27)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.TabIndex = 8
        '
        'AboutButton
        '
        Me.AboutButton.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.Location = New System.Drawing.Point(242, 352)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(108, 27)
        Me.AboutButton.TabIndex = 9
        Me.AboutButton.Text = "&About"
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'KeyStatusNotifyIcon
        '
        Me.KeyStatusNotifyIcon.ContextMenuStrip = Me.KeyStatusNotifyIconContextMenuStrip
        Me.KeyStatusNotifyIcon.Icon = CType(resources.GetObject("KeyStatusNotifyIcon.Icon"), System.Drawing.Icon)
        Me.KeyStatusNotifyIcon.Visible = True
        '
        'KeyStatusNotifyIconContextMenuStrip
        '
        Me.KeyStatusNotifyIconContextMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.KeyStatusNotifyIconContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewActiveKeysToolStripMenuItem, Me.ShowToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckForUpdatesToolStripMenuItem, Me.AboutToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.KeyStatusNotifyIconContextMenuStrip.Name = "KeyStatusNotifyIconContextMenuStrip"
        Me.KeyStatusNotifyIconContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.KeyStatusNotifyIconContextMenuStrip.Size = New System.Drawing.Size(177, 142)
        '
        'ViewActiveKeysToolStripMenuItem
        '
        Me.ViewActiveKeysToolStripMenuItem.Image = Global.KeyStatus.My.Resources.Resources._1371918331_keyboard
        Me.ViewActiveKeysToolStripMenuItem.Name = "ViewActiveKeysToolStripMenuItem"
        Me.ViewActiveKeysToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ViewActiveKeysToolStripMenuItem.Text = "&View ActiveKeys"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check For Updates"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RestartToolStripMenuItem.Text = "&Restart"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'KeyStatusService
        '
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(12, 352)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(110, 27)
        Me.LabelX4.TabIndex = 10
        Me.LabelX4.Text = "Time"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX4.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'Clock
        '
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(12, 162)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(452, 171)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Once Activated KeyStatus Will Show You Which" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keys Are Active."
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'HideButton
        '
        Me.HideButton.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideButton.Location = New System.Drawing.Point(128, 352)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(108, 27)
        Me.HideButton.TabIndex = 12
        Me.HideButton.Text = "&Hide"
        Me.HideButton.UseVisualStyleBackColor = False
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Image = Global.KeyStatus.My.Resources.Resources._1371918331_keyboard
        Me.ReflectionImage1.Location = New System.Drawing.Point(11, 12)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(112, 97)
        Me.ReflectionImage1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterACommandToolStripMenuItem, Me.ToolStripTextBox1, Me.RunToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(476, 25)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'EnterACommandToolStripMenuItem
        '
        Me.EnterACommandToolStripMenuItem.Name = "EnterACommandToolStripMenuItem"
        Me.EnterACommandToolStripMenuItem.Size = New System.Drawing.Size(25, 21)
        Me.EnterACommandToolStripMenuItem.Text = "&X"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(38, 21)
        Me.RunToolStripMenuItem.Text = "&Run"
        '
        'DevCommander
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Command Line"
        '
        'CapsLockOff
        '
        Me.CapsLockOff.Icon = CType(resources.GetObject("CapsLockOff.Icon"), System.Drawing.Icon)
        Me.CapsLockOff.Text = "Caps Lock deactivated"
        '
        'CapsLockOn
        '
        Me.CapsLockOn.Icon = CType(resources.GetObject("CapsLockOn.Icon"), System.Drawing.Icon)
        Me.CapsLockOn.Text = "Caps Lock activated"
        '
        'NumLockOn
        '
        Me.NumLockOn.Icon = CType(resources.GetObject("NumLockOn.Icon"), System.Drawing.Icon)
        Me.NumLockOn.Text = "Num Lock activated"
        '
        'NumLockOff
        '
        Me.NumLockOff.Icon = CType(resources.GetObject("NumLockOff.Icon"), System.Drawing.Icon)
        Me.NumLockOff.Text = "Num Lock deactivated"
        '
        'ScrollLockOn
        '
        Me.ScrollLockOn.Icon = CType(resources.GetObject("ScrollLockOn.Icon"), System.Drawing.Icon)
        Me.ScrollLockOn.Text = "Scroll Lock activated"
        '
        'ScrollLockOff
        '
        Me.ScrollLockOff.Icon = CType(resources.GetObject("ScrollLockOff.Icon"), System.Drawing.Icon)
        Me.ScrollLockOff.Text = "Scroll Lock deactivated"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ShowToolStripMenuItem.Text = "&Show"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(476, 385)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.HideButton)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.SwitchButton1)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ReflectionImage1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Name Goes Here"
        Me.KeyStatusNotifyIconContextMenuStrip.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents KeyStatusNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents KeyStatusService As System.Windows.Forms.Timer
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Clock As System.Windows.Forms.Timer
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents KeyStatusNotifyIconContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewActiveKeysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EnterACommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevCommander As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CapsLockOff As System.Windows.Forms.NotifyIcon
    Friend WithEvents CapsLockOn As System.Windows.Forms.NotifyIcon
    Friend WithEvents NumLockOn As System.Windows.Forms.NotifyIcon
    Friend WithEvents NumLockOff As System.Windows.Forms.NotifyIcon
    Friend WithEvents ScrollLockOn As System.Windows.Forms.NotifyIcon
    Friend WithEvents ScrollLockOff As System.Windows.Forms.NotifyIcon
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
