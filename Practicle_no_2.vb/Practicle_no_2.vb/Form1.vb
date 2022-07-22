
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim obj As New p2.Class1

        obj.show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Single

        num1 = InputBox("Enter the value of num1 :")

        num2 = InputBox("Enter the value of num2 :")


        MsgBox("Addition of num1 & num2 :" & (num1 + num2))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2 As Single

        num1 = InputBox("Enter the value of num1 :")

        num2 = InputBox("Enter the value of num2 :")


        MsgBox("Substraction of num1 & num2 :" & (num1 - num2))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2 As Single

        num1 = InputBox("Enter the value of num1 :")

        num2 = InputBox("Enter the value of num2 :")


        MsgBox("Multiplication of num1 & num2 :" & (num1 * num2))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2 As Single

        num1 = InputBox("Enter the value of num1 :")

        num2 = InputBox("Enter the value of num2 :")


        MsgBox("Division of num1 & num2 :" & (num1 / num2))
    End Sub
End Class
