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
        notifyIconNumLock.Visible = ShouldShow("Num")
        notifyIconCapsLock.Visible = ShouldShow("Caps")
        notifyIconScrollLock.Visible = ShouldShow("Scroll")
        If chkTrayAppIcon.Checked Then
            If notifyIconNumLock.Visible = False And notifyIconCapsLock.Visible = False And notifyIconScrollLock.Visible = False Then
                KeyStatusNotifyIcon.Visible = True
            Else
                KeyStatusNotifyIcon.Visible = False
            End If
        Else
            KeyStatusNotifyIcon.Visible = True
        End If
    End Sub
    
    Sub chkTraySelection_CheckedChanged() Handles chkTraySelection.CheckedChanged
        grpTraySelection.Enabled = chkTraySelection.Checked
    End Sub
    
    Sub KeyStatusNotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles KeyStatusNotifyIcon.MouseDoubleClick
        Me.Show
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.BringToFront
    End Sub
    
    Sub notifyIconNumLock_MouseUp(sender As Object, e As MouseEventArgs) Handles notifyIconNumLock.Click
        If chkTrayClick.Checked Then SendKeys.Send("{NUMLOCK}")
    End Sub
    
    Sub notifyIconCapsLock_MouseUp(sender As Object, e As MouseEventArgs) Handles notifyIconCapsLock.Click
        If chkTrayClick.Checked Then SendKeys.Send("{CAPSLOCK}")
    End Sub
    
    Sub notifyIconScrollLock_MouseUp(sender As Object, e As MouseEventArgs) Handles notifyIconScrollLock.Click
        If chkTrayClick.Checked Then SendKeys.Send("{SCROLLLOCK}")
    End Sub
    
    Private Function ShouldShow(lock As String)
        Select Case lock
            Case "Num"
                If chkTraySelection.Checked Then
                    If chkTraySelectionNum.Checked Then
                        If chkTrayEnabledOnly.Checked Then
                            If My.Computer.Keyboard.NumLock Then
                                Return True
                            Else
                                Return False
                            End If
                        Else
                            Return True
                        End If
                    Else
                        Return False
                    End If
                Else
                    If chkTrayEnabledOnly.Checked Then
                        If My.Computer.Keyboard.NumLock Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return True
                    End If
                End If
            Case "Caps"
                If chkTraySelection.Checked Then
                    If chkTraySelectionCaps.Checked Then
                        If chkTrayEnabledOnly.Checked Then
                            If My.Computer.Keyboard.CapsLock Then
                                Return True
                            Else
                                Return False
                            End If
                        Else
                            Return True
                        End If
                    Else
                        Return False
                    End If
                Else
                    If chkTrayEnabledOnly.Checked Then
                        If My.Computer.Keyboard.CapsLock Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return True
                    End If
                End If
            Case "Scroll"
                If chkTraySelection.Checked Then
                    If chkTraySelectionScroll.Checked Then
                        If chkTrayEnabledOnly.Checked Then
                            If My.Computer.Keyboard.ScrollLock Then
                                Return True
                            Else
                                Return False
                            End If
                        Else
                            Return True
                        End If
                    Else
                        Return False
                    End If
                Else
                    If chkTrayEnabledOnly.Checked Then
                        If My.Computer.Keyboard.ScrollLock Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return True
                    End If
                End If
        End Select
    End Function
End Class
