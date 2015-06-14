Imports System.IO
Public Class KeyStatus
    Dim ResMan As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyStatus))
    
    Sub KeyStatus_Shown() Handles Me.Shown
        FileNotFound("All")
        timerKeyChecker.Start
        cbxPopupLocation.SelectedIndex = 8
        Popup.Show
        Me.Focus
    End Sub
    
    Sub SetIcons()
        Me.Icon = CType(ResMan.GetObject("$this.Icon"),System.Drawing.Icon)
        KeyStatusNotifyIcon.Icon = CType(ResMan.GetObject("$this.Icon"),System.Drawing.Icon)
        
        Try
            If CType(ResMan.GetObject("NumLockOn"),System.Drawing.Icon).ToString = vbNull Then
                Throw New System.NullReferenceException
            End If
        Catch ex As Exception
            If ex.GetType.ToString = "System.NullReferenceException" Then
                timerKeyChecker.Stop
                MsgBox("Error loading tray icon resources! Please check the git diff and revert the changes to 'KeyStatus.resx' before recompiling.", MsgBoxStyle.Critical)
                Application.Exit
                End
            End If
        End Try
        
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
                KeyStatusNotifyIcon.Visible = Not Me.Visible
            Else
                KeyStatusNotifyIcon.Visible = False
            End If
        Else
            KeyStatusNotifyIcon.Visible = True
        End If
    End Sub
    
    Sub timerPopupHide_Tick() Handles timerPopupHide.Tick
        timerPopupHide.Interval = 100
        Select Case Popup.Opacity
            Case 1
                Popup.Opacity = .9
            Case .9
                Popup.Opacity = .8
            Case .8
                Popup.Opacity = .7
            Case .7
                Popup.Opacity = .6
            Case .6
                Popup.Opacity = .5
            Case .5
                Popup.Opacity = .4
            Case .4
                Popup.Opacity = .3
            Case .3
                Popup.Opacity = .2
            Case .2
                Popup.Opacity = .1
            Case .1
                Popup.Opacity = 0
            Case 0
                timerPopupHide.Stop
        End Select
    End Sub
    
    Sub chkTraySelection_CheckedChanged() Handles chkTraySelection.CheckedChanged
        grpTraySelection.Enabled = chkTraySelection.Checked
    End Sub
    
    Sub chkPopup_CheckedChanged() Handles chkPopup.CheckedChanged
        grpPopup.Enabled = chkPopup.Checked
    End Sub
    
    Sub ShowKeyStatus() Handles KeyStatusNotifyIcon.DoubleClick, notifyContextShow.Click, _
      notifyIconNumLock.DoubleClick, notifyIconCapsLock.DoubleClick, notifyIconScrollLock.DoubleClick
        Me.Show
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.BringToFront
        Me.Focus
        Me.Activate
    End Sub
    
    Sub HideKeyStatus() Handles btnHide.Click, notifyContextHide.Click
        Popup.Opacity = 1
        timerPopupHide.Interval = numPopupDelay.Value
        timerPopupHide.Start
        'Me.Hide
    End Sub
    
    Sub CloseKeyStatus() Handles btnExit.Click, notifyContextExit.Click
        Application.Exit
    End Sub
    
    Sub OpenAbout() Handles btnAbout.Click
        Try
            Process.Start("https://github.com/Walkman100/KeyStatus/blob/master/README.md#keystatus-")
        Catch ex As Exception
            If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Clipboard.SetText("https://github.com/Walkman100/KeyStatus/blob/master/README.md#keystatus-")
        End Try
    End Sub
    
    'Credits to http://www.ultimateprogrammingtutorials.info/2012/12/switch-onoff-numlockcapslockscrolllock.html
    Private Declare Sub keybd_event Lib "user32" (bVk As Byte, bScan As Byte, dwFlags As Integer, Optional dwExtraInfo As Integer = 0)
    Sub toggleNumLock
        If My.Computer.Keyboard.NumLock Then
            If File.Exists("toggleNumLock.exe") Then
                Process.Start("toggleNumLock.exe")
            ElseIf File.Exists("toggleNumLock.ahk") Then
                Process.Start("toggleNumLock.ahk")
            Else
                FileNotFound("Num")
            End If
        Else
            keybd_event(&H90, &H45, &H1 Or 0)
            keybd_event(&H90, &H45, &H1 Or &H2)
            '"Disable" code (line above) was added, since for some reason if you don't run it you have to press the lock button twice to disable it manually
        End If
    End Sub
    
    Sub toggleCapsLock
        If My.Computer.Keyboard.CapsLock Then
            If File.Exists("toggleCapsLock.exe") Then
                Process.Start("toggleCapsLock.exe")
            ElseIf File.Exists("toggleCapsLock.ahk") Then
                Process.Start("toggleCapsLock.ahk")
            Else
                FileNotFound("Caps")
            End If
        Else
            keybd_event(&H14, &H45, &H1 Or 0)
            keybd_event(&H14, &H45, &H1 Or &H2)
        End If
    End Sub
    
    Sub toggleScrollLock
        If My.Computer.Keyboard.ScrollLock Then
            If File.Exists("toggleScrollLock.exe") Then
                Process.Start("toggleScrollLock.exe")
            ElseIf File.Exists("toggleScrollLock.ahk") Then
                Process.Start("toggleScrollLock.ahk")
            Else
                FileNotFound("Scroll")
            End If
        Else
            keybd_event(&H91, &H45, &H1 Or 0)
            keybd_event(&H91, &H45, &H1 Or &H2)
        End If
    End Sub
    
    Sub notifyIconNumLock_Click(sender As Object, e As MouseEventArgs) Handles notifyIconNumLock.Click
        If chkTrayClick.Checked Then toggleNumLock Else ShowKeyStatus
    End Sub
    
    Sub notifyIconCapsLock_Click(sender As Object, e As MouseEventArgs) Handles notifyIconCapsLock.Click
        If chkTrayClick.Checked Then toggleCapsLock Else ShowKeyStatus
    End Sub
    
    Sub notifyIconScrollLock_Click(sender As Object, e As MouseEventArgs) Handles notifyIconScrollLock.Click
        If chkTrayClick.Checked Then toggleScrollLock Else ShowKeyStatus
    End Sub
    
    Sub FileNotFound(lock As String)
        Select Case lock
            Case "Num"
                If Not File.Exists("toggleNumLock.exe") And Not File.Exists("toggleNumLock.ahk") Then
                    MsgBox("AHK script 'toggleNumLock.ahk' and backup binary 'toggleNumLock.exe' not found! Disabling Num Lock will not work unless you download " & _
                        "a portable release from the Releases page and put the scripts or binaries in the same folder as this program", MsgBoxStyle.Exclamation)
                End If
            Case "Caps"
                If Not File.Exists("toggleCapsLock.exe") And Not File.Exists("toggleCapsLock.ahk") Then
                    MsgBox("AHK script 'toggleCapsLock.ahk' and backup binary 'toggleCapsLock.exe' not found! Disabling Caps Lock will not work unless you download " & _
                        "a portable release from the Releases page and put the scripts or binaries in the same folder as this program", MsgBoxStyle.Exclamation)
                End If
            Case "Scroll"
                If Not File.Exists("toggleScrollLock.exe") And Not File.Exists("toggleScrollLock.ahk") Then
                    MsgBox("AHK script 'toggleScrollLock.ahk' and backup binary 'toggleScrollLock.exe' not found! Disabling Scroll Lock will not work unless you " & _
                        "download a portable release from the Releases page and put the scripts or binaries in the same folder as this program", MsgBoxStyle.Exclamation)
                End If
            Case "All"
                FileNotFound("Num")
                FileNotFound("Caps")
                FileNotFound("Scroll")
        End Select
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
            Case Else
                Return False
        End Select
    End Function
End Class
