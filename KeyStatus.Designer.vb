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
        Me.KeyStatusNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.DevCommander = New System.ComponentModel.BackgroundWorker()
        Me.CapsLockOff = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CapsLockOn = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NumLockOn = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NumLockOff = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ScrollLockOn = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ScrollLockOff = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout
        '
        'KeyStatusNotifyIcon
        '
        Me.KeyStatusNotifyIcon.Icon = CType(resources.GetObject("KeyStatusNotifyIcon.Icon"),System.Drawing.Icon)
        Me.KeyStatusNotifyIcon.Visible = true
        '
        'CapsLockOff
        '
        Me.CapsLockOff.Icon = CType(resources.GetObject("CapsLockOff.Icon"),System.Drawing.Icon)
        Me.CapsLockOff.Text = "Caps Lock deactivated"
        '
        'CapsLockOn
        '
        Me.CapsLockOn.Icon = CType(resources.GetObject("CapsLockOn.Icon"),System.Drawing.Icon)
        Me.CapsLockOn.Text = "Caps Lock activated"
        '
        'NumLockOn
        '
        Me.NumLockOn.Icon = CType(resources.GetObject("NumLockOn.Icon"),System.Drawing.Icon)
        Me.NumLockOn.Text = "Num Lock activated"
        '
        'NumLockOff
        '
        Me.NumLockOff.Icon = CType(resources.GetObject("NumLockOff.Icon"),System.Drawing.Icon)
        Me.NumLockOff.Text = "Num Lock deactivated"
        '
        'ScrollLockOn
        '
        Me.ScrollLockOn.Icon = CType(resources.GetObject("ScrollLockOn.Icon"),System.Drawing.Icon)
        Me.ScrollLockOn.Text = "Scroll Lock activated"
        '
        'ScrollLockOff
        '
        Me.ScrollLockOff.Icon = CType(resources.GetObject("ScrollLockOff.Icon"),System.Drawing.Icon)
        Me.ScrollLockOff.Text = "Scroll Lock deactivated"
        '
        'KeyStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 385)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "KeyStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeyStatus"
        Me.ResumeLayout(false)
    End Sub
    Friend WithEvents KeyStatusNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents DevCommander As System.ComponentModel.BackgroundWorker
    Friend WithEvents CapsLockOff As System.Windows.Forms.NotifyIcon
    Friend WithEvents CapsLockOn As System.Windows.Forms.NotifyIcon
    Friend WithEvents NumLockOn As System.Windows.Forms.NotifyIcon
    Friend WithEvents NumLockOff As System.Windows.Forms.NotifyIcon
    Friend WithEvents ScrollLockOn As System.Windows.Forms.NotifyIcon
    Friend WithEvents ScrollLockOff As System.Windows.Forms.NotifyIcon

End Class
