Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Setup The Form's Title To Be The Product's Name
        Me.Text = "About " & My.Application.Info.ProductName
        'Setup The Labels Text To Equal ProductName and Description Respectively
        LabelX1.Text = My.Application.Info.ProductName
        LabelX5.Text = My.Application.Info.Description
        LabelX6.Text = My.Application.Info.Version.ToString
        LabelX8.Text = My.Application.Info.Copyright
    End Sub

    Private Sub LabelX10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX10.Click
        Process.Start("http://twitter.com/deavmi")
    End Sub

    Private Sub LabelX9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX9.Click
        Process.Start("http://deavmi.github.io/KeyStatus/")
    End Sub
End Class