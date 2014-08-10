Public Class License

    Private Sub License_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://gnu.org/licenses/gpl.txt")
        'Set Up Text For Labels
        LabelX1.Text = My.Application.Info.ProductName
        LabelX2.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.FirstStartup = "false"
        My.Settings.Save()
        MsgBox("Application Will Now Restart!")
        Application.Restart()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("You Have To Agree To The License Agreement. KeyStatus Will Now Quit.")
        Application.Exit()
    End Sub
End Class