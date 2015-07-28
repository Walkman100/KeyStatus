Imports System.IO
Public Class KeyStatus
    Sub KeyStatus_Shown() Handles Me.Shown
        FileNotFound("All")
        timerKeyChecker.Start
        Popup.Show
        Me.Focus
        cbxPopupLocation.SelectedIndex = 8
        
        ' Command line flags: Hide ShowAppIcon AlwaysShowIcons NoToggle NoIcons AllIcons NoPopup ShowBalloons PopupDelay=1000 PopupLocation=2
        ' See https://github.com/Walkman100/KeyStatus/blob/master/README.md#command-line-arguments for full explanation
        For Each s As String In My.Application.CommandLineArgs
            Select Case s.ToLower
                Case "hide"
                    HideKeyStatus
                Case "showappicon"
                    chkTrayAppIcon.Checked = False
                Case "alwaysshowicons"
                    chkTrayEnabledOnly.Checked = False
                Case "notoggle"
                    chkTrayClick.Checked = False
                Case "noicons"
                    notifyContextShowIcons.Checked = False
                    notifyContextShowIcons_Click
                Case "allicons"
                    notifyContextShowIcons.Checked = True
                    notifyContextShowIcons_Click
                Case "nopopup"
                    chkPopup.Checked = False
                Case "showballoons"
                    chkBalloon.Checked = True
                Case Else
                    If s.ToLower.StartsWith("popupdelay=") Then
                        If s.Substring(11).Length > 0 And IsNumeric(s.Substring(11)) AndAlso s.Substring(11) >= 100 Then
                            numPopupDelay.Value = s.Substring(11)
                        Else
                            MsgBox("Please use a valid value to set Popup Delay to!"&vbNewLine &"Invalid value: """&s.Substring(11)&"""", MsgBoxStyle.Exclamation)
                        End If
                    ElseIf s.ToLower.StartsWith("popuplocation=") Then
                        If s.Substring(14).Length > 0 And IsNumeric(s.Substring(14)) AndAlso s.Substring(14) >= 0 AndAlso s.Substring(14) <= 10.5 Then
                            cbxPopupLocation.SelectedIndex = s.Substring(14)
                        Else
                            MsgBox("Please use a valid index to set Popup Location to!"&vbNewLine &"Invalid index: """&s.Substring(14)&"""", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Unrecognised argument """&s &"""!", MsgBoxStyle.Exclamation)
                    End If
            End Select
        Next
    End Sub
    
    ' Timers
    
    Sub SetIcons()
        If My.Computer.Keyboard.NumLock Then
            notifyIconNumLock.Icon = Global.KeyStatus.My.Resources.Resources.NumLockOn
        Else
            notifyIconNumLock.Icon = Global.KeyStatus.My.Resources.Resources.NumLockOff
        End If
        If My.Computer.Keyboard.CapsLock Then
            notifyIconCapsLock.Icon = Global.KeyStatus.My.Resources.Resources.CapsLockOn
        Else
            notifyIconCapsLock.Icon = Global.KeyStatus.My.Resources.Resources.CapsLockOff
        End If
        If My.Computer.Keyboard.ScrollLock Then
            notifyIconScrollLock.Icon = Global.KeyStatus.My.Resources.Resources.ScrollLockOn
        Else
            notifyIconScrollLock.Icon = Global.KeyStatus.My.Resources.Resources.ScrollLockOff
        End If
    End Sub
    
    Dim numLastOn, capsLastOn, scrollLastOn As Boolean
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
        
        If chkPopup.Checked Then
            If My.Computer.Keyboard.NumLock <> numLastOn Then
                If My.Computer.Keyboard.NumLock Then
                    If chkColours.Checked Then Popup.lblLock.ForeColor = System.Drawing.Color.Green _
                        Else Popup.lblLock.ForeColor = System.Drawing.SystemColors.ControlText
                    Popup.lblLock.Text = "NUM LOCK: ENABLED"
                Else
                    If chkColours.Checked Then Popup.lblLock.ForeColor = System.Drawing.Color.Red _
                        Else Popup.lblLock.ForeColor = System.Drawing.SystemColors.ControlText
                    Popup.lblLock.Text = "NUM LOCK: DISABLED"
                End If
                Popup.Opacity = 1
                timerPopupHide.Interval = numPopupDelay.Value
                timerPopupHide.Start
            End If
            If My.Computer.Keyboard.CapsLock <> capsLastOn Then
                If My.Computer.Keyboard.CapsLock Then
                    If chkColours.Checked Then Popup.lblLock.ForeColor = System.Drawing.Color.Green _
                        Else Popup.lblLock.ForeColor = System.Drawing.SystemColors.ControlText
                    Popup.lblLock.Text = "CAPS LOCK: ENABLED"
                Else
                    If chkColours.Checked Then Popup.lblLock.ForeColor = System.Drawing.Color.Red _
                        Else Popup.lblLock.ForeColor = System.Drawing.SystemColors.ControlText
                    Popup.lblLock.Text = "CAPS LOCK: DISABLED"
                End If
                Popup.Opacity = 1
                timerPopupHide.Interval = numPopupDelay.Value
                timerPopupHide.Start
            End If
            If My.Computer.Keyboard.ScrollLock <> scrollLastOn Then
                If My.Computer.Keyboard.ScrollLock Then
                    If chkColours.Checked Then Popup.lblLock.ForeColor = System.Drawing.Color.Green _
                        Else Popup.lblLock.ForeColor = System.Drawing.SystemColors.ControlText
                    Popup.lblLock.Text = "SCROLL LOCK: ENABLED"
                Else
                    If chkColours.Checked Then Popup.lblLock.ForeColor = System.Drawing.Color.Red _
                        Else Popup.lblLock.ForeColor = System.Drawing.SystemColors.ControlText
                    Popup.lblLock.Text = "SCROLL LOCK: DISABLED"
                End If
                Popup.Opacity = 1
                timerPopupHide.Interval = numPopupDelay.Value
                timerPopupHide.Start
            End If
        End If
        
        If chkBalloon.Checked Then
            If My.Computer.Keyboard.NumLock <> numLastOn Then
                If My.Computer.Keyboard.NumLock Then
                    KeyStatusNotifyIcon.BalloonTipTitle = "Lock Enabled"
                    KeyStatusNotifyIcon.BalloonTipText = "Num Lock: Enabled"
                Else
                    KeyStatusNotifyIcon.BalloonTipTitle = "Lock Disabled"
                    KeyStatusNotifyIcon.BalloonTipText = "Num Lock: Disabled"
                End If
                KeyStatusNotifyIcon.Visible = True
                KeyStatusNotifyIcon.ShowBalloonTip(numBalloonTimeout.Value)
            End If
            If My.Computer.Keyboard.CapsLock <> capsLastOn Then
                If My.Computer.Keyboard.CapsLock Then
                    KeyStatusNotifyIcon.BalloonTipTitle = "Lock Enabled"
                    KeyStatusNotifyIcon.BalloonTipText = "Caps Lock: Enabled"
                Else
                    KeyStatusNotifyIcon.BalloonTipTitle = "Lock Disabled"
                    KeyStatusNotifyIcon.BalloonTipText = "Caps Lock: Disabled"
                End If
                KeyStatusNotifyIcon.Visible = True
                KeyStatusNotifyIcon.ShowBalloonTip(numBalloonTimeout.Value)
            End If
            If My.Computer.Keyboard.ScrollLock <> scrollLastOn Then
                If My.Computer.Keyboard.ScrollLock Then
                    KeyStatusNotifyIcon.BalloonTipTitle = "Lock Enabled"
                    KeyStatusNotifyIcon.BalloonTipText = "Scroll Lock: Enabled"
                Else
                    KeyStatusNotifyIcon.BalloonTipTitle = "Lock Disabled"
                    KeyStatusNotifyIcon.BalloonTipText = "Scroll Lock: Disabled"
                End If
                KeyStatusNotifyIcon.Visible = True
                KeyStatusNotifyIcon.ShowBalloonTip(numBalloonTimeout.Value)
            End If
        End If
        
        numLastOn = My.Computer.Keyboard.NumLock
        capsLastOn = My.Computer.Keyboard.CapsLock
        scrollLastOn = My.Computer.Keyboard.ScrollLock
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
    
    ' UI options
    
    Sub chkTrayClick_CheckedChanged() Handles chkTrayClick.CheckedChanged
        notifyContextAllowToggle.Checked = chkTrayClick.Checked
    End Sub
    
    Sub chkTraySelection_CheckedChanged() Handles chkTraySelection.CheckedChanged
        grpTraySelection.Enabled = chkTraySelection.Checked
        If chkTraySelection.Checked = False Then notifyContextShowIcons.Checked = True
    End Sub
    
    Sub chkTrayAnyLock_Click() Handles chkTraySelectionNum.Click, chkTraySelectionCaps.Click, chkTraySelectionScroll.Click
        notifyContextShowIcons.Checked = True
    End Sub
    
    Sub chkPopup_CheckedChanged() Handles chkPopup.CheckedChanged
        grpPopup.Enabled = chkPopup.Checked
        notifyContextPopups.Checked = chkPopup.Checked
    End Sub
    
    Sub chkBalloon_CheckedChanged() Handles chkBalloon.CheckedChanged
        grpBalloon.Enabled = chkBalloon.Checked
        notifyContextBalloons.Checked = chkBalloon.Checked
        If chkBalloon.Checked Then chkTrayAppIcon.Checked = False
    End Sub
    
    Dim dispArea As System.Drawing.Rectangle
    Sub SetPopupLocation() Handles cbxPopupLocation.SelectedIndexChanged, chkPopupTaskbar.CheckedChanged
        'My.Computer.Screen.Bounds
        'My.Computer.Screen.WorkingArea
        'Popup.Width/2 = 66
        'Popup.Height/2 = 19
        If chkPopupTaskbar.Checked Then
            dispArea = My.Computer.Screen.Bounds
        Else
            dispArea = My.Computer.Screen.WorkingArea
        End If
        lblPopupCustLocX.Visible = False
        lblPopupCustLocY.Visible = False
        numPopupCustLocFactX.Visible = False
        numPopupCustLocFactY.Visible = False
        numPopupCustLocExactX.Visible = False
        numPopupCustLocExactY.Visible = False
        Select Case cbxPopupLocation.SelectedIndex
            Case 0 ' Top Left
                Popup.Location = New Size((dispArea.Width/20) - 66, (dispArea.Height/20) - 19)
            Case 1 ' Top Center
                Popup.Location = New Size((dispArea.Width/2) - 66, (dispArea.Height/20) - 19)
            Case 2 ' Top Right
                Popup.Location = New Size((dispArea.Width/1.05) - 66, (dispArea.Height/20) - 19)
            Case 3 ' Center Left
                Popup.Location = New Size((dispArea.Width/20) - 66, (dispArea.Height/2) - 19)
            Case 4 ' Center
                Popup.Location = New Size((dispArea.Width/2) - 66, (dispArea.Height/2) - 19)
            Case 5 ' Center Right
                Popup.Location = New Size((dispArea.Width/1.05) - 66, (dispArea.Height/2) - 19)
            Case 6 ' Bottom Left
                Popup.Location = New Size((dispArea.Width/20) - 66, (dispArea.Height/1.05) - 19)
            Case 7 ' Bottom Center
                Popup.Location = New Size((dispArea.Width/2) - 66, (dispArea.Height/1.05) - 19)
            Case 8 ' Bottom Right
                Popup.Location = New Size((dispArea.Width/1.05) - 66, (dispArea.Height/1.05) - 19)
            Case 9 ' Custom Division Factor
                lblPopupCustLocX.Visible = True
                lblPopupCustLocY.Visible = True
                lblPopupCustLocY.Text = "Y Division factor:"
                lblPopupCustLocX.Text = "X Division factor:"
                numPopupCustLocFactX.Visible = True
                numPopupCustLocFactY.Visible = True
                Popup.Location = New Size((dispArea.Width/numPopupCustLocFactX.Value) - 66, (dispArea.Height/numPopupCustLocFactY.Value) - 19)
            Case 10' Custom Co-ordinates
                lblPopupCustLocX.Visible = True
                lblPopupCustLocY.Visible = True
                lblPopupCustLocY.Text = "Y Co-ordinate:"
                lblPopupCustLocX.Text = "X Co-ordinate:"
                numPopupCustLocExactX.Visible = True
                numPopupCustLocExactY.Visible = True
                Popup.Location = New Size(numPopupCustLocExactX.Value, numPopupCustLocExactY.Value)
        End Select
    End Sub
    
    ' Notification icon context menu items and buttons on form
    
    Sub notifyContextShowIcons_Click() Handles notifyContextShowIcons.Click
        If notifyContextShowIcons.Checked Then
            chkTraySelection.Checked = False
        Else
            chkTraySelection.Checked = True
            chkTraySelectionNum.Checked = False
            chkTraySelectionCaps.Checked = False
            chkTraySelectionScroll.Checked = False
        End If
    End Sub
    
    Sub notifyContextAllowToggle_Click() Handles notifyContextAllowToggle.Click
        chkTrayClick.Checked = notifyContextAllowToggle.Checked
    End Sub
    
    Sub notifyContextPopups_Click() Handles notifyContextPopups.Click
        chkPopup.Checked = notifyContextPopups.Checked
    End Sub
    
    Sub notifyContextBalloons_Click() Handles notifyContextBalloons.Click
        chkBalloon.Checked = notifyContextBalloons.Checked
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
        Me.Hide
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
    
    ' Toggling locks: clicking on icons, checking if toggle scripts exist
    ' Checking if icons should be shown
    
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
    
    Sub notifyIconNumLock_Click() Handles notifyIconNumLock.Click
        If chkTrayClick.Checked Then toggleNumLock Else ShowKeyStatus
    End Sub
    
    Sub notifyIconCapsLock_Click() Handles notifyIconCapsLock.Click
        If chkTrayClick.Checked Then toggleCapsLock Else ShowKeyStatus
    End Sub
    
    Sub notifyIconScrollLock_Click() Handles notifyIconScrollLock.Click
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
                        If (chkTrayEnabledOnly.Checked) Then Return My.Computer.Keyboard.NumLock Else Return True
                    Else
                        Return False
                    End If
                Else
                    If (chkTrayEnabledOnly.Checked) Then Return My.Computer.Keyboard.NumLock Else Return True
                End If
            Case "Caps"
                If chkTraySelection.Checked Then
                    If chkTraySelectionCaps.Checked Then
                        If (chkTrayEnabledOnly.Checked) Then Return My.Computer.Keyboard.CapsLock Else Return True
                    Else
                        Return False
                    End If
                Else
                    If (chkTrayEnabledOnly.Checked) Then Return My.Computer.Keyboard.CapsLock Else Return True
                End If
            Case "Scroll"
                If chkTraySelection.Checked Then
                    If chkTraySelectionScroll.Checked Then
                        If (chkTrayEnabledOnly.Checked) Then Return My.Computer.Keyboard.ScrollLock Else Return True
                    Else
                        Return False
                    End If
                Else
                    If (chkTrayEnabledOnly.Checked) Then Return My.Computer.Keyboard.ScrollLock Else Return True
                End If
            Case Else
                Return False
        End Select
    End Function
End Class
