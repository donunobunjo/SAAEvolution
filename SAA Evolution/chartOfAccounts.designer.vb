<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chartOfAccounts
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
        Me.tabChartOfActs = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsno = New System.Windows.Forms.TextBox()
        Me.txtSubCode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtGroupCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTransDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSubName = New System.Windows.Forms.ComboBox()
        Me.SubNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset1 = New SAA_Evolution.SAAEvoDataset()
        Me.cmbGroupName = New System.Windows.Forms.ComboBox()
        Me.GroupNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.txtAccountNo = New System.Windows.Forms.TextBox()
        Me.tabGroupNames = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGrpClose = New System.Windows.Forms.Button()
        Me.btnGrpAdd = New System.Windows.Forms.Button()
        Me.btnGrpSave = New System.Windows.Forms.Button()
        Me.btnGrpDelete = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtGrpName = New System.Windows.Forms.TextBox()
        Me.txtGrpCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabSubNames = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnSbClose = New System.Windows.Forms.Button()
        Me.btnSbAdd = New System.Windows.Forms.Button()
        Me.btnSbSave = New System.Windows.Forms.Button()
        Me.btnSbDelete = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtSvNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbSubGrp = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubName = New System.Windows.Forms.TextBox()
        Me.txtSbCode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupNamesTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.groupNamesTableAdapter()
        Me.SubNamesTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.subNamesTableAdapter()
        Me.SaaEvoDataset2 = New SAA_Evolution.SAAEvoDataset()
        Me.BankTableAdapter1 = New SAA_Evolution.SAAEvoDatasetTableAdapters.BankTableAdapter()
        ' Me.VendorTableAdapter1 = New SAA_Evolution.SAAEvoDatasetTableAdapters.VendorTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.tabChartOfActs.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SubNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGroupNames.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabSubNames.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.SaaEvoDataset2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabChartOfActs)
        Me.TabControl1.Controls.Add(Me.tabGroupNames)
        Me.TabControl1.Controls.Add(Me.tabSubNames)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(620, 352)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'tabChartOfActs
        '
        Me.tabChartOfActs.BackColor = System.Drawing.SystemColors.Control
        Me.tabChartOfActs.Controls.Add(Me.GroupBox2)
        Me.tabChartOfActs.Controls.Add(Me.GroupBox1)
        Me.tabChartOfActs.Location = New System.Drawing.Point(4, 22)
        Me.tabChartOfActs.Name = "tabChartOfActs"
        Me.tabChartOfActs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChartOfActs.Size = New System.Drawing.Size(612, 326)
        Me.tabChartOfActs.TabIndex = 0
        Me.tabChartOfActs.Text = "Chart of Accounts"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 88)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Image = Global.SAA_Evolution.My.Resources.Resources.close
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(452, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 55)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Image = Global.SAA_Evolution.My.Resources.Resources.SaveandAdd
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(30, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 55)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.Image = Global.SAA_Evolution.My.Resources.Resources.save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(178, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 55)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDelete.Image = Global.SAA_Evolution.My.Resources.Resources.delete
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(309, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 55)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsno)
        Me.GroupBox1.Controls.Add(Me.txtSubCode)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtGroupCode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTransDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSubName)
        Me.GroupBox1.Controls.Add(Me.cmbGroupName)
        Me.GroupBox1.Controls.Add(Me.txtAccountName)
        Me.GroupBox1.Controls.Add(Me.txtAccountNo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 235)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtsno
        '
        Me.txtsno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsno.Location = New System.Drawing.Point(156, 129)
        Me.txtsno.Name = "txtsno"
        Me.txtsno.Size = New System.Drawing.Size(278, 23)
        Me.txtsno.TabIndex = 28
        '
        'txtSubCode
        '
        Me.txtSubCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCode.Location = New System.Drawing.Point(156, 104)
        Me.txtSubCode.Name = "txtSubCode"
        Me.txtSubCode.Size = New System.Drawing.Size(278, 23)
        Me.txtSubCode.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(121, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "SNo"
        '
        'txtGroupCode
        '
        Me.txtGroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupCode.Location = New System.Drawing.Point(156, 51)
        Me.txtGroupCode.Name = "txtGroupCode"
        Me.txtGroupCode.Size = New System.Drawing.Size(278, 23)
        Me.txtGroupCode.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Sub Code :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Group Code :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Date :"
        '
        'txtTransDate
        '
        Me.txtTransDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransDate.Location = New System.Drawing.Point(156, 206)
        Me.txtTransDate.Name = "txtTransDate"
        Me.txtTransDate.Size = New System.Drawing.Size(278, 23)
        Me.txtTransDate.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Account No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Account Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sub Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Group Name :"
        '
        'cmbSubName
        '
        Me.cmbSubName.DataSource = Me.SubNamesBindingSource
        Me.cmbSubName.DisplayMember = "subName"
        Me.cmbSubName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubName.FormattingEnabled = True
        Me.cmbSubName.Location = New System.Drawing.Point(156, 77)
        Me.cmbSubName.Name = "cmbSubName"
        Me.cmbSubName.Size = New System.Drawing.Size(278, 24)
        Me.cmbSubName.TabIndex = 11
        '
        'SubNamesBindingSource
        '
        Me.SubNamesBindingSource.DataMember = "subNames"
        Me.SubNamesBindingSource.DataSource = Me.SAAEvoDataset1
        '
        'SAAEvoDataset1
        '
        Me.SAAEvoDataset1.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbGroupName
        '
        Me.cmbGroupName.DataSource = Me.GroupNamesBindingSource
        Me.cmbGroupName.DisplayMember = "groupName"
        Me.cmbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupName.FormattingEnabled = True
        Me.cmbGroupName.Location = New System.Drawing.Point(156, 25)
        Me.cmbGroupName.Name = "cmbGroupName"
        Me.cmbGroupName.Size = New System.Drawing.Size(278, 24)
        Me.cmbGroupName.TabIndex = 10
        '
        'GroupNamesBindingSource
        '
        Me.GroupNamesBindingSource.DataMember = "groupNames"
        Me.GroupNamesBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtAccountName
        '
        Me.txtAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountName.Location = New System.Drawing.Point(156, 180)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(278, 23)
        Me.txtAccountName.TabIndex = 4
        '
        'txtAccountNo
        '
        Me.txtAccountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.Location = New System.Drawing.Point(156, 155)
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(278, 23)
        Me.txtAccountNo.TabIndex = 6
        '
        'tabGroupNames
        '
        Me.tabGroupNames.BackColor = System.Drawing.SystemColors.Control
        Me.tabGroupNames.Controls.Add(Me.GroupBox3)
        Me.tabGroupNames.Controls.Add(Me.GroupBox4)
        Me.tabGroupNames.Location = New System.Drawing.Point(4, 22)
        Me.tabGroupNames.Name = "tabGroupNames"
        Me.tabGroupNames.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGroupNames.Size = New System.Drawing.Size(612, 326)
        Me.tabGroupNames.TabIndex = 1
        Me.tabGroupNames.Text = "Account Type"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGrpClose)
        Me.GroupBox3.Controls.Add(Me.btnGrpAdd)
        Me.GroupBox3.Controls.Add(Me.btnGrpSave)
        Me.GroupBox3.Controls.Add(Me.btnGrpDelete)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(514, 88)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'btnGrpClose
        '
        Me.btnGrpClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGrpClose.Image = Global.SAA_Evolution.My.Resources.Resources.close
        Me.btnGrpClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrpClose.Location = New System.Drawing.Point(396, 19)
        Me.btnGrpClose.Name = "btnGrpClose"
        Me.btnGrpClose.Size = New System.Drawing.Size(99, 55)
        Me.btnGrpClose.TabIndex = 2
        Me.btnGrpClose.Text = "Close"
        Me.btnGrpClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrpClose.UseVisualStyleBackColor = True
        '
        'btnGrpAdd
        '
        Me.btnGrpAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGrpAdd.Image = Global.SAA_Evolution.My.Resources.Resources.SaveandAdd
        Me.btnGrpAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrpAdd.Location = New System.Drawing.Point(15, 19)
        Me.btnGrpAdd.Name = "btnGrpAdd"
        Me.btnGrpAdd.Size = New System.Drawing.Size(93, 55)
        Me.btnGrpAdd.TabIndex = 0
        Me.btnGrpAdd.Text = "Add New"
        Me.btnGrpAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrpAdd.UseVisualStyleBackColor = True
        '
        'btnGrpSave
        '
        Me.btnGrpSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGrpSave.Image = Global.SAA_Evolution.My.Resources.Resources.save
        Me.btnGrpSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrpSave.Location = New System.Drawing.Point(135, 19)
        Me.btnGrpSave.Name = "btnGrpSave"
        Me.btnGrpSave.Size = New System.Drawing.Size(95, 55)
        Me.btnGrpSave.TabIndex = 1
        Me.btnGrpSave.Text = "Save"
        Me.btnGrpSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrpSave.UseVisualStyleBackColor = True
        '
        'btnGrpDelete
        '
        Me.btnGrpDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGrpDelete.Image = Global.SAA_Evolution.My.Resources.Resources.delete
        Me.btnGrpDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrpDelete.Location = New System.Drawing.Point(259, 19)
        Me.btnGrpDelete.Name = "btnGrpDelete"
        Me.btnGrpDelete.Size = New System.Drawing.Size(105, 55)
        Me.btnGrpDelete.TabIndex = 3
        Me.btnGrpDelete.Text = "Delete"
        Me.btnGrpDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrpDelete.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtGrpName)
        Me.GroupBox4.Controls.Add(Me.txtGrpCode)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(518, 91)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'txtGrpName
        '
        Me.txtGrpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrpName.Location = New System.Drawing.Point(156, 25)
        Me.txtGrpName.Name = "txtGrpName"
        Me.txtGrpName.Size = New System.Drawing.Size(278, 23)
        Me.txtGrpName.TabIndex = 22
        '
        'txtGrpCode
        '
        Me.txtGrpCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrpCode.Location = New System.Drawing.Point(156, 54)
        Me.txtGrpCode.Name = "txtGrpCode"
        Me.txtGrpCode.Size = New System.Drawing.Size(278, 23)
        Me.txtGrpCode.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Group Code :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(79, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Group Name :"
        '
        'tabSubNames
        '
        Me.tabSubNames.BackColor = System.Drawing.SystemColors.Control
        Me.tabSubNames.Controls.Add(Me.GroupBox5)
        Me.tabSubNames.Controls.Add(Me.GroupBox6)
        Me.tabSubNames.Location = New System.Drawing.Point(4, 22)
        Me.tabSubNames.Name = "tabSubNames"
        Me.tabSubNames.Size = New System.Drawing.Size(612, 326)
        Me.tabSubNames.TabIndex = 2
        Me.tabSubNames.Text = "Sub Type"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnSbClose)
        Me.GroupBox5.Controls.Add(Me.btnSbAdd)
        Me.GroupBox5.Controls.Add(Me.btnSbSave)
        Me.GroupBox5.Controls.Add(Me.btnSbDelete)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 147)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(514, 88)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        '
        'btnSbClose
        '
        Me.btnSbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSbClose.Image = Global.SAA_Evolution.My.Resources.Resources.close
        Me.btnSbClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSbClose.Location = New System.Drawing.Point(396, 19)
        Me.btnSbClose.Name = "btnSbClose"
        Me.btnSbClose.Size = New System.Drawing.Size(87, 55)
        Me.btnSbClose.TabIndex = 2
        Me.btnSbClose.Text = "Close"
        Me.btnSbClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSbClose.UseVisualStyleBackColor = True
        '
        'btnSbAdd
        '
        Me.btnSbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSbAdd.Image = Global.SAA_Evolution.My.Resources.Resources.SaveandAdd
        Me.btnSbAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSbAdd.Location = New System.Drawing.Point(25, 19)
        Me.btnSbAdd.Name = "btnSbAdd"
        Me.btnSbAdd.Size = New System.Drawing.Size(93, 55)
        Me.btnSbAdd.TabIndex = 0
        Me.btnSbAdd.Text = "Add New"
        Me.btnSbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSbAdd.UseVisualStyleBackColor = True
        '
        'btnSbSave
        '
        Me.btnSbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSbSave.Image = Global.SAA_Evolution.My.Resources.Resources.save
        Me.btnSbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSbSave.Location = New System.Drawing.Point(153, 19)
        Me.btnSbSave.Name = "btnSbSave"
        Me.btnSbSave.Size = New System.Drawing.Size(80, 55)
        Me.btnSbSave.TabIndex = 1
        Me.btnSbSave.Text = "Save"
        Me.btnSbSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSbSave.UseVisualStyleBackColor = True
        '
        'btnSbDelete
        '
        Me.btnSbDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSbDelete.Image = Global.SAA_Evolution.My.Resources.Resources.delete
        Me.btnSbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSbDelete.Location = New System.Drawing.Point(266, 19)
        Me.btnSbDelete.Name = "btnSbDelete"
        Me.btnSbDelete.Size = New System.Drawing.Size(87, 55)
        Me.btnSbDelete.TabIndex = 3
        Me.btnSbDelete.Text = "Delete"
        Me.btnSbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSbDelete.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtSvNumber)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.CmbSubGrp)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.txtSubName)
        Me.GroupBox6.Controls.Add(Me.txtSbCode)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(518, 138)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        '
        'txtSvNumber
        '
        Me.txtSvNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSvNumber.Location = New System.Drawing.Point(156, 99)
        Me.txtSvNumber.Name = "txtSvNumber"
        Me.txtSvNumber.Size = New System.Drawing.Size(278, 23)
        Me.txtSvNumber.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(120, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "SNo"
        '
        'CmbSubGrp
        '
        Me.CmbSubGrp.DataSource = Me.GroupNamesBindingSource
        Me.CmbSubGrp.DisplayMember = "groupName"
        Me.CmbSubGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSubGrp.FormattingEnabled = True
        Me.CmbSubGrp.Location = New System.Drawing.Point(156, 20)
        Me.CmbSubGrp.Name = "CmbSubGrp"
        Me.CmbSubGrp.Size = New System.Drawing.Size(278, 21)
        Me.CmbSubGrp.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(79, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Group Name :"
        '
        'txtSubName
        '
        Me.txtSubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubName.Location = New System.Drawing.Point(156, 46)
        Me.txtSubName.Name = "txtSubName"
        Me.txtSubName.Size = New System.Drawing.Size(278, 23)
        Me.txtSubName.TabIndex = 2
        '
        'txtSbCode
        '
        Me.txtSbCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSbCode.Location = New System.Drawing.Point(156, 75)
        Me.txtSbCode.Name = "txtSbCode"
        Me.txtSbCode.Size = New System.Drawing.Size(278, 23)
        Me.txtSbCode.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(90, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Sub Code :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(86, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 13)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Sub Name :"
        '
        'GroupNamesTableAdapter
        '
        Me.GroupNamesTableAdapter.ClearBeforeFill = True
        '
        'SubNamesTableAdapter
        '
        Me.SubNamesTableAdapter.ClearBeforeFill = True
        '
        'SaaEvoDataset2
        '
        Me.SaaEvoDataset2.DataSetName = "SAAEvoDataset"
        Me.SaaEvoDataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BankTableAdapter1
        '
        Me.BankTableAdapter1.ClearBeforeFill = True
        '
        'VendorTableAdapter1
        '
        'Me.VendorTableAdapter1.ClearBeforeFill = True
        '
        'chartOfAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 359)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "chartOfAccounts"
        Me.Text = "Chart Of Accounts"
        Me.TabControl1.ResumeLayout(False)
        Me.tabChartOfActs.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SubNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGroupNames.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabSubNames.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.SaaEvoDataset2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabChartOfActs As TabPage
    Friend WithEvents tabGroupNames As TabPage
    Friend WithEvents tabSubNames As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSubCode As TextBox
    Friend WithEvents txtGroupCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTransDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSubName As ComboBox
    Friend WithEvents cmbGroupName As ComboBox
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents txtAccountNo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnGrpClose As Button
    Friend WithEvents btnGrpAdd As Button
    Friend WithEvents btnGrpSave As Button
    Friend WithEvents btnGrpDelete As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtGrpCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnSbClose As Button
    Friend WithEvents btnSbAdd As Button
    Friend WithEvents btnSbSave As Button
    Friend WithEvents btnSbDelete As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtSbCode As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtGrpName As TextBox
    Friend WithEvents txtSubName As TextBox
    Friend WithEvents CmbSubGrp As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSvNumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents GroupNamesBindingSource As BindingSource
    Friend WithEvents GroupNamesTableAdapter As SAAEvoDatasetTableAdapters.groupNamesTableAdapter
    Friend WithEvents txtsno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SAAEvoDataset1 As SAAEvoDataset
    Friend WithEvents SubNamesBindingSource As BindingSource
    Friend WithEvents SubNamesTableAdapter As SAAEvoDatasetTableAdapters.subNamesTableAdapter
    Friend WithEvents SaaEvoDataset2 As SAAEvoDataset
    Friend WithEvents BankTableAdapter1 As SAAEvoDatasetTableAdapters.BankTableAdapter
    ' Friend WithEvents VendorTableAdapter1 As SAAEvoDatasetTableAdapters.VendorTableAdapter
End Class
