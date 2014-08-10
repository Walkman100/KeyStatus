<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActiveKeys
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.CapsLockStatusText = New DevComponents.DotNetBar.LabelX()
        Me.NumLockStatusText = New DevComponents.DotNetBar.LabelX()
        Me.ScrollLockStatusText = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(258, 38)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "ActiveKeys"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(-9, 56)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(305, 10)
        Me.Line1.TabIndex = 1
        Me.Line1.Text = "Line1"
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Image = Global.KeyStatus.My.Resources.Resources._1371918331_keyboard
        Me.ReflectionImage1.Location = New System.Drawing.Point(12, 12)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.ReflectionEnabled = False
        Me.ReflectionImage1.Size = New System.Drawing.Size(39, 38)
        Me.ReflectionImage1.TabIndex = 2
        '
        'CapsLockStatusText
        '
        '
        '
        '
        Me.CapsLockStatusText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CapsLockStatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapsLockStatusText.Location = New System.Drawing.Point(12, 72)
        Me.CapsLockStatusText.Name = "CapsLockStatusText"
        Me.CapsLockStatusText.Size = New System.Drawing.Size(258, 31)
        Me.CapsLockStatusText.TabIndex = 3
        Me.CapsLockStatusText.Text = "Title"
        Me.CapsLockStatusText.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'NumLockStatusText
        '
        '
        '
        '
        Me.NumLockStatusText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NumLockStatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumLockStatusText.Location = New System.Drawing.Point(12, 103)
        Me.NumLockStatusText.Name = "NumLockStatusText"
        Me.NumLockStatusText.Size = New System.Drawing.Size(258, 31)
        Me.NumLockStatusText.TabIndex = 4
        Me.NumLockStatusText.Text = "Title"
        Me.NumLockStatusText.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ScrollLockStatusText
        '
        '
        '
        '
        Me.ScrollLockStatusText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ScrollLockStatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScrollLockStatusText.Location = New System.Drawing.Point(12, 134)
        Me.ScrollLockStatusText.Name = "ScrollLockStatusText"
        Me.ScrollLockStatusText.Size = New System.Drawing.Size(258, 31)
        Me.ScrollLockStatusText.TabIndex = 5
        Me.ScrollLockStatusText.Text = "Title"
        Me.ScrollLockStatusText.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ActiveKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(282, 181)
        Me.Controls.Add(Me.ScrollLockStatusText)
        Me.Controls.Add(Me.NumLockStatusText)
        Me.Controls.Add(Me.CapsLockStatusText)
        Me.Controls.Add(Me.ReflectionImage1)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActiveKeys"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActiveKeys"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents CapsLockStatusText As DevComponents.DotNetBar.LabelX
    Friend WithEvents NumLockStatusText As DevComponents.DotNetBar.LabelX
    Friend WithEvents ScrollLockStatusText As DevComponents.DotNetBar.LabelX
End Class
