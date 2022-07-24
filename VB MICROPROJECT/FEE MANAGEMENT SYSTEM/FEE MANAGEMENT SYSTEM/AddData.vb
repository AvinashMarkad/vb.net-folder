Public Class AddData

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or RadioButton1.Checked = False Or RadioButton2.Checked = False Or RadioButton3.Checked = False Or RadioButton4.Checked = False Or RadioButton5.Checked = False Or RadioButton6.Checked = False Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or CheckBox1.Checked = False Then
            MsgBox("please all the information ..!")
        Else

            On Error GoTo addError
            StudentBindingSource.EndEdit()
            StudentTableAdapter.Update(Database3DataSet.Student)

            AddressBindingSource.EndEdit()
            AddressTableAdapter.Update(Database3DataSet.Address)

            CollegeBindingSource.EndEdit()
            CollegeTableAdapter.Update(Database3DataSet.College)

            FeeBindingSource.EndEdit()
            FeeTableAdapter.Update(Database3DataSet.Fee)

            MsgBox("data addedd successfully..!")


        End If

addError:
        Exit Sub


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()

    End Sub

    Private Sub AddData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3DataSet.Fee' table. You can move, or remove it, as needed.
        Me.FeeTableAdapter.Fill(Me.Database3DataSet.Fee)
        'TODO: This line of code loads data into the 'Database3DataSet.College' table. You can move, or remove it, as needed.
        Me.CollegeTableAdapter.Fill(Me.Database3DataSet.College)
        'TODO: This line of code loads data into the 'Database3DataSet.Address' table. You can move, or remove it, as needed.
        Me.AddressTableAdapter.Fill(Me.Database3DataSet.Address)
        'TODO: This line of code loads data into the 'Database3DataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Database3DataSet.Student)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or RadioButton1.Checked = False Or RadioButton2.Checked = False Or RadioButton3.Checked = False Or RadioButton4.Checked = False Or RadioButton5.Checked = False Or RadioButton6.Checked = False Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or CheckBox1.Checked = False Then
            MsgBox("please all the information ..!")
        Else
            On Error GoTo saveError
            StudentBindingSource.EndEdit()
            StudentTableAdapter.Update(Database3DataSet.Student)

            AddressBindingSource.EndEdit()
            AddressTableAdapter.Update(Database3DataSet.Address)

            CollegeBindingSource.EndEdit()
            CollegeTableAdapter.Update(Database3DataSet.College)

            FeeBindingSource.EndEdit()
            FeeTableAdapter.Update(Database3DataSet.Fee)

            MsgBox("data saved successfully..!")


        End If

saveError:
        Exit Sub


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        StudentBindingSource.AddNew()
        AddressBindingSource.AddNew()
        CollegeBindingSource.AddNew()
        FeeBindingSource.AddNew()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "fill the name !")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "fill the phone no. !")
        Else
            ErrorProvider1.SetError(TextBox3, "")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "fill the e-mail !")
        Else
            ErrorProvider1.SetError(TextBox4, "")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ErrorProvider1.SetError(CheckBox1, "")
        Else
            ErrorProvider1.SetError(CheckBox1, "fill the checkbox !")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then
            ErrorProvider1.SetError(TextBox5, "fill the city !")
        Else
            ErrorProvider1.SetError(TextBox5, "")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then
            ErrorProvider1.SetError(TextBox6, "fill the tal !")
        Else
            ErrorProvider1.SetError(TextBox6, "")
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Then
            ErrorProvider1.SetError(TextBox7, "fill the dist !")
        Else
            ErrorProvider1.SetError(TextBox7, "")
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "" Then
            ErrorProvider1.SetError(TextBox8, "fill the e-mail !")
        Else
            ErrorProvider1.SetError(TextBox8, "")
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text = "co" Or TextBox10.Text = "CO" Or TextBox10.Text = "me" Or TextBox10.Text = "ME" Or TextBox10.Text = "ci" Or TextBox10.Text = "CI" Or TextBox10.Text = "ej" Or TextBox10.Text = "EJ" Or TextBox10.Text = "auto" Or TextBox10.Text = "AUTO" Then
            ErrorProvider1.SetError(TextBox10, "")

        Else
            ErrorProvider1.SetError(TextBox10, "fill correct branch ..!")

        End If
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        If IsNumeric(TextBox11.Text) Then
            ErrorProvider1.SetError(TextBox11, "")
        Else
            ErrorProvider1.SetError(TextBox11, "fill the fee")
        End If
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        If IsNumeric(TextBox12.Text) Then
            ErrorProvider1.SetError(TextBox12, "")
        Else
            ErrorProvider1.SetError(TextBox12, "fill the remaining fee")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Or RadioButton5.Checked Or RadioButton6.Checked Then
            ErrorProvider1.SetError(RadioButton4, "")
        Else
            ErrorProvider1.SetError(RadioButton4, "choose option")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked Then
            ErrorProvider1.SetError(RadioButton3, "")
        Else
            ErrorProvider1.SetError(RadioButton3, "choose option")
        End If
    End Sub
End Class