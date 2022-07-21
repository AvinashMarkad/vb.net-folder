Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        add(TextBox1.Text, TextBox2.Text)

    End Sub

    Function add(ByVal a As Integer, ByVal b As Integer) As Integer

        Dim sum As Integer

        sum = a + b

        MsgBox("Addition of a and b :" & sum)


        Return sum

    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
