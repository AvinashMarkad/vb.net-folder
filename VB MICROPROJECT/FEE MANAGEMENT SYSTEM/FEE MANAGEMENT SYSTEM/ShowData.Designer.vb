<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowData
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
        Me.Database3DataSet = New FEE_MANAGEMENT_SYSTEM.database3DataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.StudentTableAdapter()
        Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressTableAdapter = New FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.AddressTableAdapter()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PincodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MinorityDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EMailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.CollegeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollegeTableAdapter = New FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.CollegeTableAdapter()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NdDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RdDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearOfAdmissionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.FeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeeTableAdapter = New FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.FeeTableAdapter()
        Me.IDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidFeedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CardDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database3DataSet
        '
        Me.Database3DataSet.DataSetName = "database3DataSet"
        Me.Database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Database3DataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'AddressBindingSource
        '
        Me.AddressBindingSource.DataMember = "Address"
        Me.AddressBindingSource.DataSource = Me.Database3DataSet
        '
        'AddressTableAdapter
        '
        Me.AddressTableAdapter.ClearBeforeFill = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.DataGridView4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(803, 531)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "FEE"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(803, 531)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "COLLEGE"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(803, 531)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADDRESS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.CityDataGridViewTextBoxColumn, Me.TalDataGridViewTextBoxColumn, Me.DistDataGridViewTextBoxColumn, Me.PincodeDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.AddressBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(7, 7)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(790, 463)
        Me.DataGridView2.TabIndex = 0
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PincodeDataGridViewTextBoxColumn
        '
        Me.PincodeDataGridViewTextBoxColumn.DataPropertyName = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.HeaderText = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.Name = "PincodeDataGridViewTextBoxColumn"
        Me.PincodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DistDataGridViewTextBoxColumn
        '
        Me.DistDataGridViewTextBoxColumn.DataPropertyName = "Dist"
        Me.DistDataGridViewTextBoxColumn.HeaderText = "Dist"
        Me.DistDataGridViewTextBoxColumn.Name = "DistDataGridViewTextBoxColumn"
        Me.DistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TalDataGridViewTextBoxColumn
        '
        Me.TalDataGridViewTextBoxColumn.DataPropertyName = "Tal"
        Me.TalDataGridViewTextBoxColumn.HeaderText = "Tal"
        Me.TalDataGridViewTextBoxColumn.Name = "TalDataGridViewTextBoxColumn"
        Me.TalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(803, 531)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "STUDENT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EMailDataGridViewTextBoxColumn, Me.MinorityDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(790, 337)
        Me.DataGridView1.TabIndex = 0
        '
        'MinorityDataGridViewCheckBoxColumn
        '
        Me.MinorityDataGridViewCheckBoxColumn.DataPropertyName = "Minority"
        Me.MinorityDataGridViewCheckBoxColumn.HeaderText = "Minority"
        Me.MinorityDataGridViewCheckBoxColumn.Name = "MinorityDataGridViewCheckBoxColumn"
        Me.MinorityDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'EMailDataGridViewTextBoxColumn
        '
        Me.EMailDataGridViewTextBoxColumn.DataPropertyName = "E-Mail"
        Me.EMailDataGridViewTextBoxColumn.HeaderText = "E-Mail"
        Me.EMailDataGridViewTextBoxColumn.Name = "EMailDataGridViewTextBoxColumn"
        Me.EMailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SNameDataGridViewTextBoxColumn
        '
        Me.SNameDataGridViewTextBoxColumn.DataPropertyName = "S_Name"
        Me.SNameDataGridViewTextBoxColumn.HeaderText = "S_Name"
        Me.SNameDataGridViewTextBoxColumn.Name = "SNameDataGridViewTextBoxColumn"
        Me.SNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
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
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.StDataGridViewCheckBoxColumn, Me.NdDataGridViewCheckBoxColumn, Me.RdDataGridViewCheckBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.YearOfAdmissionDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.CollegeBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(4, 4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(796, 466)
        Me.DataGridView3.TabIndex = 0
        '
        'CollegeBindingSource
        '
        Me.CollegeBindingSource.DataMember = "College"
        Me.CollegeBindingSource.DataSource = Me.Database3DataSet
        '
        'CollegeTableAdapter
        '
        Me.CollegeTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        Me.IDDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'StDataGridViewCheckBoxColumn
        '
        Me.StDataGridViewCheckBoxColumn.DataPropertyName = "1st"
        Me.StDataGridViewCheckBoxColumn.HeaderText = "1st"
        Me.StDataGridViewCheckBoxColumn.Name = "StDataGridViewCheckBoxColumn"
        Me.StDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'NdDataGridViewCheckBoxColumn
        '
        Me.NdDataGridViewCheckBoxColumn.DataPropertyName = "2nd"
        Me.NdDataGridViewCheckBoxColumn.HeaderText = "2nd"
        Me.NdDataGridViewCheckBoxColumn.Name = "NdDataGridViewCheckBoxColumn"
        Me.NdDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'RdDataGridViewCheckBoxColumn
        '
        Me.RdDataGridViewCheckBoxColumn.DataPropertyName = "3rd"
        Me.RdDataGridViewCheckBoxColumn.HeaderText = "3rd"
        Me.RdDataGridViewCheckBoxColumn.Name = "RdDataGridViewCheckBoxColumn"
        Me.RdDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearOfAdmissionDataGridViewTextBoxColumn
        '
        Me.YearOfAdmissionDataGridViewTextBoxColumn.DataPropertyName = "Year_Of_Admission"
        Me.YearOfAdmissionDataGridViewTextBoxColumn.HeaderText = "Year_Of_Admission"
        Me.YearOfAdmissionDataGridViewTextBoxColumn.Name = "YearOfAdmissionDataGridViewTextBoxColumn"
        Me.YearOfAdmissionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToOrderColumns = True
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn3, Me.TotalFeeDataGridViewTextBoxColumn, Me.PaidFeeDataGridViewTextBoxColumn, Me.RemainFeeDataGridViewTextBoxColumn, Me.PaidFeedateDataGridViewTextBoxColumn, Me.CashDataGridViewCheckBoxColumn, Me.CardDataGridViewCheckBoxColumn, Me.CheckDataGridViewCheckBoxColumn})
        Me.DataGridView4.DataSource = Me.FeeBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(4, 4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(796, 466)
        Me.DataGridView4.TabIndex = 0
        '
        'FeeBindingSource
        '
        Me.FeeBindingSource.DataMember = "Fee"
        Me.FeeBindingSource.DataSource = Me.Database3DataSet
        '
        'FeeTableAdapter
        '
        Me.FeeTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn3
        '
        Me.IDDataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn3.Name = "IDDataGridViewTextBoxColumn3"
        Me.IDDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'TotalFeeDataGridViewTextBoxColumn
        '
        Me.TotalFeeDataGridViewTextBoxColumn.DataPropertyName = "Total_Fee"
        Me.TotalFeeDataGridViewTextBoxColumn.HeaderText = "Total_Fee"
        Me.TotalFeeDataGridViewTextBoxColumn.Name = "TotalFeeDataGridViewTextBoxColumn"
        Me.TotalFeeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaidFeeDataGridViewTextBoxColumn
        '
        Me.PaidFeeDataGridViewTextBoxColumn.DataPropertyName = "Paid_Fee"
        Me.PaidFeeDataGridViewTextBoxColumn.HeaderText = "Paid_Fee"
        Me.PaidFeeDataGridViewTextBoxColumn.Name = "PaidFeeDataGridViewTextBoxColumn"
        Me.PaidFeeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemainFeeDataGridViewTextBoxColumn
        '
        Me.RemainFeeDataGridViewTextBoxColumn.DataPropertyName = "Remain_Fee"
        Me.RemainFeeDataGridViewTextBoxColumn.HeaderText = "Remain_Fee"
        Me.RemainFeeDataGridViewTextBoxColumn.Name = "RemainFeeDataGridViewTextBoxColumn"
        Me.RemainFeeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaidFeedateDataGridViewTextBoxColumn
        '
        Me.PaidFeedateDataGridViewTextBoxColumn.DataPropertyName = "Paid_Fee_date"
        Me.PaidFeedateDataGridViewTextBoxColumn.HeaderText = "Paid_Fee_date"
        Me.PaidFeedateDataGridViewTextBoxColumn.Name = "PaidFeedateDataGridViewTextBoxColumn"
        Me.PaidFeedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CashDataGridViewCheckBoxColumn
        '
        Me.CashDataGridViewCheckBoxColumn.DataPropertyName = "Cash"
        Me.CashDataGridViewCheckBoxColumn.HeaderText = "Cash"
        Me.CashDataGridViewCheckBoxColumn.Name = "CashDataGridViewCheckBoxColumn"
        Me.CashDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CardDataGridViewCheckBoxColumn
        '
        Me.CardDataGridViewCheckBoxColumn.DataPropertyName = "Card"
        Me.CardDataGridViewCheckBoxColumn.HeaderText = "Card"
        Me.CardDataGridViewCheckBoxColumn.Name = "CardDataGridViewCheckBoxColumn"
        Me.CardDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CheckDataGridViewCheckBoxColumn
        '
        Me.CheckDataGridViewCheckBoxColumn.DataPropertyName = "Check"
        Me.CheckDataGridViewCheckBoxColumn.HeaderText = "Check"
        Me.CheckDataGridViewCheckBoxColumn.Name = "CheckDataGridViewCheckBoxColumn"
        Me.CheckDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "PREVIOUS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(320, 52)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "PREVIOUS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(480, 479)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(320, 52)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "NEXT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(480, 479)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(320, 52)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "NEXT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(4, 476)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(320, 52)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "PREVIOUS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(241, 473)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(320, 52)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "NEXT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(849, 93)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(301, 46)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "PREVIOUS"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(849, 290)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(301, 46)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "NEXT"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(849, 510)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(301, 46)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "EXIT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ShowData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 584)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(12, 12)
        Me.Name = "ShowData"
        Me.Text = "ShowData"
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database3DataSet As FEE_MANAGEMENT_SYSTEM.database3DataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.StudentTableAdapter
    Friend WithEvents AddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddressTableAdapter As FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.AddressTableAdapter
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinorityDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents CollegeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CollegeTableAdapter As FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.CollegeTableAdapter
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NdDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RdDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearOfAdmissionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FeeTableAdapter As FEE_MANAGEMENT_SYSTEM.database3DataSetTableAdapters.FeeTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemainFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidFeedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CardDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
