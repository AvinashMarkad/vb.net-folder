<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database3DataSet = New FEE_MANAGEMENT_SYSTEM.database3DataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CollegeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.FeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.StudentTableAdapter = New FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.StudentTableAdapter()
        Me.AddressTableAdapter = New FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.AddressTableAdapter()
        Me.CollegeTableAdapter = New FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.CollegeTableAdapter()
        Me.FeeTableAdapter = New FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.FeeTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.CollegeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.FeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(811, 560)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DateTimePicker3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(803, 531)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "STUDENT INFO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentBindingSource, "Date_Of_Birth", True))
        Me.DateTimePicker3.Location = New System.Drawing.Point(406, 126)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(272, 22)
        Me.DateTimePicker3.TabIndex = 12
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Database3DataSet
        '
        'Database3DataSet
        '
        Me.Database3DataSet.DataSetName = "database3DataSet"
        Me.Database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(312, 492)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 33)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "NEXT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.StudentBindingSource, "Minority", True))
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(477, 414)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 27)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "YES/NO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "E-Mail", True))
        Me.TextBox4.Location = New System.Drawing.Point(406, 308)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(272, 23)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Phone", True))
        Me.TextBox3.Location = New System.Drawing.Point(406, 212)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(272, 23)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "S_Name", True))
        Me.TextBox1.Location = New System.Drawing.Point(406, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 23)
        Me.TextBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "MINORITY : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "STUDENT'S E-MAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STUDENT'S PHONE NO. : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DATE OF BIRTH : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT NAME : "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox9)
        Me.TabPage2.Controls.Add(Me.TextBox8)
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(803, 531)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADDRESS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "State", True))
        Me.TextBox9.Location = New System.Drawing.Point(331, 348)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(263, 23)
        Me.TextBox9.TabIndex = 11
        '
        'AddressBindingSource
        '
        Me.AddressBindingSource.DataMember = "Address"
        Me.AddressBindingSource.DataSource = Me.Database3DataSet
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "Pincode", True))
        Me.TextBox8.Location = New System.Drawing.Point(331, 272)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(263, 23)
        Me.TextBox8.TabIndex = 10
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "Dist", True))
        Me.TextBox7.Location = New System.Drawing.Point(331, 193)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(263, 23)
        Me.TextBox7.TabIndex = 9
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "Tal", True))
        Me.TextBox6.Location = New System.Drawing.Point(331, 112)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(263, 23)
        Me.TextBox6.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddressBindingSource, "City", True))
        Me.TextBox5.Location = New System.Drawing.Point(331, 46)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(263, 23)
        Me.TextBox5.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(544, 455)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "NEXT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "PREVIOUS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 23)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "STATE : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 23)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "PINCODE : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "DIST : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "TAL : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CITY : "
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.TextBox10)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.RadioButton3)
        Me.TabPage3.Controls.Add(Me.RadioButton2)
        Me.TabPage3.Controls.Add(Me.RadioButton1)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(803, 531)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "COLLEGE INFO"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(544, 455)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(198, 35)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "NEXT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(50, 455)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(198, 35)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "PREVIOUS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CollegeBindingSource, "Year_Of_Admission", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(336, 327)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(370, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'CollegeBindingSource
        '
        Me.CollegeBindingSource.DataMember = "College"
        Me.CollegeBindingSource.DataSource = Me.Database3DataSet
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeBindingSource, "Class", True))
        Me.TextBox10.Location = New System.Drawing.Point(336, 210)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(370, 22)
        Me.TextBox10.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(46, 327)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(241, 23)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "DATE OF ADDMISSION : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(46, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 23)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "CLASS : "
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CollegeBindingSource, "3rd", True))
        Me.RadioButton3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(649, 83)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(69, 27)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3RD"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CollegeBindingSource, "2nd", True))
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(485, 83)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 27)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2ND"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CollegeBindingSource, "1st", True))
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(336, 83)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 27)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1ST"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "YEAR : "
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.RadioButton6)
        Me.TabPage4.Controls.Add(Me.RadioButton5)
        Me.TabPage4.Controls.Add(Me.RadioButton4)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.DateTimePicker2)
        Me.TabPage4.Controls.Add(Me.TextBox12)
        Me.TabPage4.Controls.Add(Me.TextBox11)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(803, 531)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "FEE"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FeeBindingSource, "Check", True))
        Me.RadioButton6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(604, 370)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(101, 27)
        Me.RadioButton6.TabIndex = 16
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "CHECK"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'FeeBindingSource
        '
        Me.FeeBindingSource.DataMember = "Fee"
        Me.FeeBindingSource.DataSource = Me.Database3DataSet
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FeeBindingSource, "Card", True))
        Me.RadioButton5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(496, 370)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(87, 27)
        Me.RadioButton5.TabIndex = 15
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "CARD"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FeeBindingSource, "Cash", True))
        Me.RadioButton4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(392, 372)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(85, 27)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "CASH"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(53, 372)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 23)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "PAID BY : "
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(312, 492)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(179, 33)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "PREVIOUS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FeeBindingSource, "Paid_Fee_date", True))
        Me.DateTimePicker2.Location = New System.Drawing.Point(392, 283)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(297, 22)
        Me.DateTimePicker2.TabIndex = 5
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeeBindingSource, "Remain_Fee", True))
        Me.TextBox12.Location = New System.Drawing.Point(392, 189)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(297, 23)
        Me.TextBox12.TabIndex = 4
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeeBindingSource, "Paid_Fee", True))
        Me.TextBox11.Location = New System.Drawing.Point(392, 94)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(297, 23)
        Me.TextBox11.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(53, 283)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(173, 23)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "PAID FEE DATE : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(53, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 23)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "REMAIN FEE : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(53, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "PAID FEE : "
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(874, 58)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(261, 48)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "A D D "
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(874, 201)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(261, 48)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "A D D   N E W "
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(874, 346)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(261, 48)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "S A V E"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(874, 484)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(261, 48)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = " E X I T"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'AddressTableAdapter
        '
        Me.AddressTableAdapter.ClearBeforeFill = True
        '
        'CollegeTableAdapter
        '
        Me.CollegeTableAdapter.ClearBeforeFill = True
        '
        'FeeTableAdapter
        '
        Me.FeeTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 584)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "AddData"
        Me.Text = "AddData"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.CollegeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.FeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Database3DataSet As FEE_MANAGEMENT_SYSTEM.database3DataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.StudentTableAdapter
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddressTableAdapter As FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.AddressTableAdapter
    Friend WithEvents CollegeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CollegeTableAdapter As FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.CollegeTableAdapter
    Friend WithEvents FeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FeeTableAdapter As FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.FeeTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
