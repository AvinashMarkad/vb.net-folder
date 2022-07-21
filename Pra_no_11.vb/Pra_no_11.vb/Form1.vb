Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' PictureBox1.Image = Image.FromFile("C:\Users\marka\Pictures\Saved Pictures\arohi1.jpg", PictureBoxSizeMode.Normal)

        'PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

    End Sub

    Private Sub PictureBox1_ControlRemoved(sender As Object, e As ControlEventArgs) Handles PictureBox1.ControlRemoved

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        PictureBox1.Image = Image.FromFile("C:\Users\marka\Pictures\Saved Pictures\arohi1.jpg", PictureBoxSizeMode.Normal)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

    End Sub
End Class
