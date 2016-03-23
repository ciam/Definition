Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("https://en.wikipedia.org/wiki/" + TextBox1.Text)

        'n If WebBrowser1.Document.Body.InnerHtml.Contains("") Then
    End Sub
End Class
