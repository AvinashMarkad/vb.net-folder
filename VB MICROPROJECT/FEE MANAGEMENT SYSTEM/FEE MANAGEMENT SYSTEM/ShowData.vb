Public Class ShowData

    Private Sub ShowData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3DataSet.Fee' table. You can move, or remove it, as needed.
        Me.FeeTableAdapter.Fill(Me.Database3DataSet.Fee)
        'TODO: This line of code loads data into the 'Database3DataSet.College' table. You can move, or remove it, as needed.
        Me.CollegeTableAdapter.Fill(Me.Database3DataSet.College)
        'TODO: This line of code loads data into the 'Database3DataSet.Address' table. You can move, or remove it, as needed.
        Me.AddressTableAdapter.Fill(Me.Database3DataSet.Address)
        'TODO: This line of code loads data into the 'Database3DataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Database3DataSet.Student)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        StudentBindingSource.MovePrevious()
        AddressBindingSource.MovePrevious()
        CollegeBindingSource.MovePrevious()
        FeeBindingSource.MovePrevious()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        StudentBindingSource.MoveNext()
        AddressBindingSource.MoveNext()
        CollegeBindingSource.MoveNext()
        FeeBindingSource.MoveNext()
    End Sub
End Class