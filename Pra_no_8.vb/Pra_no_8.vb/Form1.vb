Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer

        a = TextBox1.Text

        If a Mod 2 = 0 Then
            Label2.Text = "Given number is Even number"

        Else
            Label2.Text = "Given number is odd number"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
