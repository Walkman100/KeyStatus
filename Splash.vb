Public Class Splash

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelX1.ForeColor = Color.Gray
        LabelX1.Text = My.Application.Info.ProductName
    End Sub
End Class