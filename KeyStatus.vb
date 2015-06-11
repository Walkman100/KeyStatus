Imports System.IO
Public Class KeyStatus
    
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyStatus))
    Sub KeyStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '(trayIconName).Icon = CType(resources.GetObject("e.g. CapsLockOff"),System.Drawing.Icon)
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
