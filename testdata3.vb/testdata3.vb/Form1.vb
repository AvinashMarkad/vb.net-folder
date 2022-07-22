Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database4DataSet.Table1' table. You can move, or remove it, as needed.
        ' Me.Table1TableAdapter.Fill(Me.Database4DataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Table1BindingSource.AddNew()

    End Sub
End Class
