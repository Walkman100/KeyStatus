Imports System.IO
Public Class KeyStatus
    Dim ResMan As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyStatus))
    
    Sub KeyStatus_Load() Handles Me.Shown
        
    End Sub
    
    Sub SetIcons()
        Me.Icon = CType(ResMan.GetObject("$this.Icon"),System.Drawing.Icon)
        KeyStatusNotifyIcon.Icon = CType(ResMan.GetObject("$this.Icon"),System.Drawing.Icon)
        If My.Computer.Keyboard.NumLock Then
            notifyIconNumLock.Icon = CType(ResMan.GetObject("NumLockOn"),System.Drawing.Icon)
        Else
            notifyIconNumLock.Icon = CType(ResMan.GetObject("NumLockOff"),System.Drawing.Icon)
        End If
        If My.Computer.Keyboard.CapsLock Then
            notifyIconCapsLock.Icon = CType(ResMan.GetObject("CapsLockOn"),System.Drawing.Icon)
        Else
            notifyIconCapsLock.Icon = CType(ResMan.GetObject("CapsLockOff"),System.Drawing.Icon)
        End If
        If My.Computer.Keyboard.ScrollLock Then
            notifyIconScrollLock.Icon = CType(ResMan.GetObject("ScrollLockOn"),System.Drawing.Icon)
        Else
            notifyIconScrollLock.Icon = CType(ResMan.GetObject("ScrollLockOff"),System.Drawing.Icon)
        End If
    End Sub
    
    Sub timerKeyChecker_Tick() Handles timerKeyChecker.Tick
        SetIcons
        If ShouldShow("Num") Then notifyIconNumLock.Visible = True Else notifyIconNumLock.Visible = False
        If ShouldShow("Caps") Then notifyIconCapsLock.Visible = True Else notifyIconCapsLock.Visible = False
        If ShouldShow("Scroll") Then notifyIconScrollLock.Visible = True Else notifyIconScrollLock.Visible = False
    End Sub
    
    Sub chkTraySelection_CheckedChanged() Handles chkTraySelection.CheckedChanged
        grpTraySelection.Enabled = chkTraySelection.Checked
    End Sub
    
    Sub KeyStatusNotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles KeyStatusNotifyIcon.MouseDoubleClick
        Me.Show
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.BringToFront
    End Sub
    
    Sub notifyIconNumLock_MouseUp(sender As Object, e As MouseEventArgs) Handles notifyIconNumLock.MouseUp
        If chkTrayClick.Checked Then SendKeys.Send("{NUMLOCK}")
    End Sub
    
    Sub notifyIconCapsLock_MouseUp(sender As Object, e As MouseEventArgs) Handles notifyIconCapsLock.MouseUp
        If chkTrayClick.Checked Then SendKeys.Send("{CAPSLOCK}")
    End Sub
    
    Sub notifyIconScrollLock_MouseUp(sender As Object, e As MouseEventArgs) Handles notifyIconScrollLock.MouseUp
        If chkTrayClick.Checked Then SendKeys.Send("{SCROLLLOCK}")
    End Sub
    
    Private Function ShouldShow(lock As String)
        Select Case lock
            Case "Num"
                
            Case "Caps"
                
            Case "Scroll"
                
        End Select
        
    End Function
End Class
