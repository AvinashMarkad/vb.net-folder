Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        Dim b As Integer = TextBox2.Text

        Dim c As Integer = a + b

        MsgBox("Addition of a and b :" & c)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Integer = TextBox3.Text
        Dim y As Integer = TextBox4.Text

        Dim z As Integer = x - y

        MsgBox("Substraction of x and y :" & z)

    End Sub
End Class
