Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.RadioButton1.Checked Then
            MsgBox("Correct Answer")
        Else
            MsgBox("Wrong Answer")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Label1.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Italic)
        End If
        If Me.CheckBox1.Checked Then
            RadioButton1.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Italic)
            RadioButton2.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Italic)
            RadioButton3.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Italic)
            RadioButton4.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Italic)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked Then
            Label1.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Strikeout)
        End If
        If Me.CheckBox2.Checked Then
            RadioButton1.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Strikeout)
            RadioButton2.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Strikeout)
            RadioButton3.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Strikeout)
            RadioButton4.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Strikeout)
        End If
    End Sub
End Class
