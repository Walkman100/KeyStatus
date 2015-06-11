Imports System.IO
Public Class KeyStatus
    
    Sub KeyStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
    
    
    
    
    
    
    
    
    'Hope You Enjoy The Source Code.
    'All Done Very Cleanly and Very Damn Awesome.

    '########################################################################################################
    '########################################################################################################
    '################################################ Deavmi ################################################
    '########################################################################################################
    '########################################################################################################
    '################# Visit http://deavmi.3owl.com/projects For A List of All Deavmi's Stuff ###############
    '# Copyright (C) KeyStatus 2013. All Rights Reserved. KeyStatus Is A Registered Trademark of Deavmi Inc.#
    '################### This Source Code Is Released To You With No Warranty What So Ever ##################
    '################### Released and Licensed Under GNU's General Public License v3 (GPL) ##################
    '########################################################################################################
    '########################################################################################################

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles MyBase.Load
        'Setup The Form Title To Be The Product Name of The Application
        'Me.Text = My.Application.Info.ProductName
        'Set The Title Text of The Notify Icon To Be The Application Product Name
        KeyStatusNotifyIcon.Text = My.Application.Info.ProductName
        'Set Up Text For Labels
        'LabelX1.Text = My.Application.Info.ProductName
        'LabelX2.Text = My.Application.Info.Version.ToString
        'Setup Context Menu Items Text
        'ExitToolStripMenuItem.Text = "&Exit " & My.Application.Info.ProductName
        'RestartToolStripMenuItem.Text = "&Restart " & My.Application.Info.ProductName
        'AboutToolStripMenuItem.Text = "&About " & My.Application.Info.ProductName
        'ShowToolStripMenuItem.Text = "&Show " & My.Application.Info.ProductName
        'Setup The Color
        'LabelX1.ForeColor = Color.Black
        'LabelX2.ForeColor = Color.White
        'LabelX3.ForeColor = Color.Black
        'LabelX4.ForeColor = Color.White
        'LabelX5.ForeColor = Color.White
        'Start The Clock Timer To Display The Current Time For LabelX4
        'Clock.Start()
        'Sets The Timer's Refresh Rate Accorind To A Settings String
        'KeyStatusService.Interval = My.Settings.TimerRefreshRate.ToString
        'Checks Settings and Sets The Value of The Switchbutton and If Settings 'KeyStatusServiceActive' Equals "1" Then It Goes To The Provate Sub 'StartService()'
        'If My.Settings.KeyStatusServiceActive = "0" Then
        '    SwitchButton1.Enabled = False
        'End If
        'If My.Settings.KeyStatusServiceActive = "1" Then
        '    SwitchButton1.Enabled = True
        '    StartService()
        'End If
        'If My.Settings.KeyStatusServiceActive = "0" Then
        '    SwitchButton1.Enabled = False
        '    KillService()
        'End If

        'Checks The Settings To See If The User Wants The Command Line Tool Visibility Button To Be Shown
        'If My.Settings.commandline = "true" Then
        '    Label1.Visible = True
        'End If
        'If My.Settings.commandline = "false" Then
        '    Label1.Visible = False
        'End If
        'Other Stuff To Make Everything Seems Normal, To Lazy To Explain
        'If My.Settings.KeyStatusServiceActive = "0" Then
        '    KeyStatusNotifyIcon.Text = My.Application.Info.ProductName & " [Service activated]"
        'End If
        'If My.Settings.KeyStatusServiceActive = "1" Then
        '    KeyStatusNotifyIcon.Text = My.Application.Info.ProductName & " [Service deactivated]"
        'End If
        'Checks If The User Wants KeyStatus To Minimize Itself To The Tray On Sta\rtup
        'If My.Settings.HideOnStartup = "true" Then
        '    Me.Hide()
        'End If
    End Sub
    
    Private Sub SwitchButton1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles SwitchButton1.VisibleChanged
        'If SwitchButton1.Enabled = True Then
        '    My.Settings.KeyStatusServiceActive = "1"
        '    My.Settings.Save()
        '    'Add the stuff here for Active Keys
        'End If
        'If SwitchButton1.Enabled = False Then
        '    My.Settings.KeyStatusServiceActive = "0"
        '    My.Settings.Save()
        '    'Add the stuff here for Active Keys
        'End If
        'If My.Settings.KeyStatusServiceActive = "1" Then
        '    StartService()
        'End If
        'If My.Settings.KeyStatusServiceActive = "0" Then
        '    KillService()
        'End If
    End Sub

    Private Sub StartService()
        'KeyStatusService.Start()
        'KeyStatusNotifyIcon.BalloonTipText = "Service is running..."
        'KeyStatusNotifyIcon.ShowBalloonTip(10)
        'KeyStatusNotifyIcon.Text = My.Application.Info.ProductName & " [Service activated]"
    End Sub

    Private Sub KillService()
        'KeyStatusService.Stop()
        'ScrollLockOff.Visible = False
        'ScrollLockOn.Visible = False
        'NumLockOff.Visible = False
        'NumLockOn.Visible = False
        'CapsLockOff.Visible = False
        'CapsLockOn.Visible = False
        'KeyStatusNotifyIcon.BalloonTipText = "Service is not running."
        'KeyStatusNotifyIcon.ShowBalloonTip(10)
        'KeyStatusNotifyIcon.Text = My.Application.Info.ProductName & " [Service deactivated]"
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles ExitButton.Click
        'Exits The Application
        'Application.Exit()
    End Sub

    Private Sub Clock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Clock.Tick
        'This Timer Continuously Checks What The Time Is and Sets 'LabelX4 's' Text To The Current Time
        'LabelX4.Text = TimeOfDay
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Restart()
    End Sub

    Private Sub HideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles HideButton.Click
        Me.Hide()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles CheckForUpdatesToolStripMenuItem.Click
        Process.Start("http://deavmi.github.io/KeyStatus/")
    End Sub

    Private Sub EnterACommandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles EnterACommandToolStripMenuItem.Click
        'MenuStrip1.Visible = False
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles RunToolStripMenuItem.Click
        DevCommander.RunWorkerAsync()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Label1.Click
        'MenuStrip1.Visible = True
    End Sub

    Private Sub DevCommander_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) 'Handles DevCommander.DoWork
        'If ToolStripTextBox1.Text = "quit" Then
        '    Application.Exit()
        'End If
        'If ToolStripTextBox1.Text = "restart" Then
        '    Application.Restart()
        'End If
        'If ToolStripTextBox1.Text = "getpackage" Then
        '    If File.Exists("keystatus.zip") Then
        '        File.Delete("keystatus.zip")
        '        My.Computer.Network.DownloadFile("https://sites.google.com/site/filehostingservice000/home/deavmi/keystatus/keystatus.zip?attredirects=0&d=1", Application.StartupPath & "\keystatus.zip")
        '    Else
        '        My.Computer.Network.DownloadFile("https://sites.google.com/site/filehostingservice000/home/deavmi/keystatus/keystatus.zip?attredirects=0&d=1", Application.StartupPath & "\keystatus.zip")
        '    End If
        'End If
        'If ToolStripTextBox1.Text = "reset" Then
        '    My.Settings.Reset()
        'End If
        'If ToolStripTextBox1.Text = "config" Then
        '    Process.Start("KeyStatus.exe.config")
        'End If
        'If ToolStripTextBox1.Text = "hide" Then
        '    Me.Hide()
        'End If
        'If ToolStripTextBox1.Text = "about" Then
        '    About.ShowDialog()
        'End If
        'If ToolStripTextBox1.Text = "startuppath" Then
        '    MsgBox(My.Application.Info.DirectoryPath)
        'End If
        'If ToolStripTextBox1.Text = "startservice" Then
        '    SwitchButton1.Enabled = True
        'End If
        'If ToolStripTextBox1.Text = "stopservice" Then
        '    SwitchButton1.Enabled = False
        'End If
        'Refresh-rate values will be changed soon, in time. Mabye, idk :P
        'If ToolStripTextBox1.Text = "refreshrate=lowest" Then
        '    My.Settings.TimerRefreshRate = "2500"
        '    My.Settings.Save()
        'End If
        'If ToolStripTextBox1.Text = "refreshrate=verylow" Then
        '    My.Settings.TimerRefreshRate = "1000"
        '    My.Settings.Save()
        'End If
        'If ToolStripTextBox1.Text = "refreshrate=low" Then
        '    My.Settings.TimerRefreshRate = "500"
        '    My.Settings.Save()
        'End If
        'If ToolStripTextBox1.Text = "refreshrate=normal" Then
        '    My.Settings.TimerRefreshRate = "100"
        '    My.Settings.Save()
        'End If
        'If ToolStripTextBox1.Text = "refreshrate=high" Then
        '    My.Settings.TimerRefreshRate = "50"
        '    My.Settings.Save()
        'End If
        'If ToolStripTextBox1.Text = "refreshrate=veryhigh" Then
        '    My.Settings.TimerRefreshRate = "20"
        '    My.Settings.Save()
        'End If
        'If ToolStripTextBox1.Text = "refreshrate=max" Then
        '    My.Settings.TimerRefreshRate = "1"
        '    My.Settings.Save()
        'End If
        'If ToolStripTextBox1.Text = "break" Then
        '    Debugger.Break()
        'End If
        'If ToolStripTextBox1.Text = "upgrade-config" Then
        '    My.Settings.Upgrade()
        'End If
        'If ToolStripTextBox1.Text = "hideonstartup=true" Then
        '    My.Settings.HideOnStartup = "true"
        '    My.Settings.Save()
        'End If
        'If ToolStripTextBox1.Text = "hideonstartup=false" Then
        '    My.Settings.HideOnStartup = "false"
        '    My.Settings.Save()
        'End If
    End Sub

    Private Sub RestartToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles RestartToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub KeyStatusService_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles KeyStatusService.Tick
        ' Caps Lock 'If' Statement Goes Below
        'If My.Computer.Keyboard.CapsLock = True Then
        '    CapsLockOn.Visible = True
        '    CapsLockOff.Visible = False
        'Else
        '    CapsLockOff.Visible = True
        '    CapsLockOn.Visible = False
        'End If
        ' Num Lock 'If' Statement Goes Below
        'If My.Computer.Keyboard.NumLock = True Then
        '    NumLockOn.Visible = True
        '    NumLockOff.Visible = False
        'Else
        '    NumLockOff.Visible = True
        '    NumLockOn.Visible = False
        'End If
        ' Scroll Lock 'If' Statement Goes Below
        'If My.Computer.Keyboard.ScrollLock = True Then
        '    ScrollLockOn.Visible = True
        '    ScrollLockOff.Visible = False
        'Else
        '    ScrollLockOff.Visible = True
        '    ScrollLockOn.Visible = False
        'End If
    End Sub
End Class
