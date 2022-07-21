Imports System.ComponentModel

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Plz Enter UserName")
            e.Cancel = True
        ElseIf IsNumeric(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "Plz do not enter only numbers")
            e.Cancel = True
        Else

            ErrorProvider1.SetError(TextBox1, "")
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Plz Enter Password")
            e.Cancel = True
        ElseIf Len(TextBox2.text) < 8 Then
            ErrorProvider1.SetError(TextBox2, "Plz Enter Valid Password")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("U R Loged In")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
