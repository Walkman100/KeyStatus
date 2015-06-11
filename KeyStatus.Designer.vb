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
        Me.notifyIconNumLock = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyIconCapsLock = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyIconScrollLock = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuspendLayout
        '
        'timerKeyChecker
        '
        Me.timerKeyChecker.Enabled = true
        Me.timerKeyChecker.Interval = 1000
        '
        'KeyStatusNotifyIcon
        '
        Me.KeyStatusNotifyIcon.Text = "KeyStatus"
        Me.KeyStatusNotifyIcon.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
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
        Me.notifyIconScrollLock.Visible = true
        '
        'notifyContext
        '
        Me.notifyContext.Name = "notifyContext"
        Me.notifyContext.Size = New System.Drawing.Size(61, 4)
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
    Private WithEvents notifyContext As System.Windows.Forms.ContextMenuStrip
    Private WithEvents notifyIconScrollLock As System.Windows.Forms.NotifyIcon
    Private WithEvents notifyIconCapsLock As System.Windows.Forms.NotifyIcon
    Private WithEvents notifyIconNumLock As System.Windows.Forms.NotifyIcon
    Private WithEvents KeyStatusNotifyIcon As System.Windows.Forms.NotifyIcon
    Private WithEvents timerKeyChecker As System.Windows.Forms.Timer

End Class
