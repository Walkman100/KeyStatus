'Manually merged from the Designer file
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Popup
    Inherits System.Windows.Forms.Form
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
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLock = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'lblLock
        '
        Me.lblLock.Name = "lblLock"
        lblLock.Location = New System.Drawing.Point(-4, -1)
        lblLock.Size = New System.Drawing.Size(134, 34)
        lblLock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        lblLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblLock.AutoEllipsis = true
        lblLock.Text = "CAPS LOCK: DISABLED"
        lblLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'Popup
        '
        Me.Name = "Popup"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(126, 32)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblLock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Opacity = 0R
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = true
        Me.ResumeLayout(false)
    End Sub
    Friend lblLock As System.Windows.Forms.Label
End Class
