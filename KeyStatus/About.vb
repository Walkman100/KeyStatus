Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Setup The Form's Title To Be The Product's Name
        Me.Text = "About " & My.Application.Info.ProductName
        'Setup The Labels Text To Equal ProductName and Description Respectively
        LabelX1.Text = My.Application.Info.ProductName
        LabelX5.Text = My.Application.Info.Description
        'Navigate Browsers To Their Respective Web Pages
        WebBrowser1.Navigate("http://gnu.org/licenses/gpl.txt")
    End Sub
End Class