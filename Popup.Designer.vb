<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Popup
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
        Me.lblLock = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'lblLock
        '
        Me.lblLock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblLock.AutoEllipsis = true
        Me.lblLock.Location = New System.Drawing.Point(-4, -1)
        Me.lblLock.Name = "lblLock"
        Me.lblLock.Size = New System.Drawing.Size(134, 34)
        Me.lblLock.TabIndex = 0
        Me.lblLock.Text = "CAPS LOCK: DISABLED"
        Me.lblLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(126, 32)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblLock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Popup"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = true
        Me.ResumeLayout(false)
    End Sub
    Friend lblLock As System.Windows.Forms.Label
End Class
