<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorList
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.VendorTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.VendorTableAdapter()
        Me.VendorNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebsiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpeningBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditLimitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailPreferenceDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SMSPreferenceDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InactiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VendorNumberDataGridViewTextBoxColumn, Me.VendorNameDataGridViewTextBoxColumn, Me.CompanyDataGridViewTextBoxColumn, Me.WebsiteDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn, Me.StreetDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.AcccountDataGridViewTextBoxColumn, Me.OpeningBalanceDataGridViewTextBoxColumn, Me.CreditLimitDataGridViewTextBoxColumn, Me.EmailPreferenceDataGridViewCheckBoxColumn, Me.SMSPreferenceDataGridViewCheckBoxColumn, Me.InactiveDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.VendorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1088, 473)
        Me.DataGridView1.TabIndex = 0
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataMember = "Vendor"
        Me.VendorBindingSource.DataSource = Me.SAAEvoDataset
        '
        'VendorTableAdapter
        '
        '  Me.VendorTableAdapter.ClearBeforeFill = True
        '
        'VendorNumberDataGridViewTextBoxColumn
        '
        Me.VendorNumberDataGridViewTextBoxColumn.DataPropertyName = "VendorNumber"
        Me.VendorNumberDataGridViewTextBoxColumn.HeaderText = "Vendor Num"
        Me.VendorNumberDataGridViewTextBoxColumn.Name = "VendorNumberDataGridViewTextBoxColumn"
        Me.VendorNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendorNumberDataGridViewTextBoxColumn.Width = 50
        '
        'VendorNameDataGridViewTextBoxColumn
        '
        Me.VendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName"
        Me.VendorNameDataGridViewTextBoxColumn.HeaderText = "Vendor Name"
        Me.VendorNameDataGridViewTextBoxColumn.Name = "VendorNameDataGridViewTextBoxColumn"
        Me.VendorNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendorNameDataGridViewTextBoxColumn.Width = 150
        '
        'CompanyDataGridViewTextBoxColumn
        '
        Me.CompanyDataGridViewTextBoxColumn.DataPropertyName = "Company"
        Me.CompanyDataGridViewTextBoxColumn.HeaderText = "Company"
        Me.CompanyDataGridViewTextBoxColumn.Name = "CompanyDataGridViewTextBoxColumn"
        Me.CompanyDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompanyDataGridViewTextBoxColumn.Width = 150
        '
        'WebsiteDataGridViewTextBoxColumn
        '
        Me.WebsiteDataGridViewTextBoxColumn.DataPropertyName = "Website"
        Me.WebsiteDataGridViewTextBoxColumn.HeaderText = "Website"
        Me.WebsiteDataGridViewTextBoxColumn.Name = "WebsiteDataGridViewTextBoxColumn"
        Me.WebsiteDataGridViewTextBoxColumn.ReadOnly = True
        Me.WebsiteDataGridViewTextBoxColumn.Visible = False
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Visible = False
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        Me.FaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.FaxDataGridViewTextBoxColumn.Visible = False
        '
        'StreetDataGridViewTextBoxColumn
        '
        Me.StreetDataGridViewTextBoxColumn.DataPropertyName = "Street"
        Me.StreetDataGridViewTextBoxColumn.HeaderText = "Street"
        Me.StreetDataGridViewTextBoxColumn.Name = "StreetDataGridViewTextBoxColumn"
        Me.StreetDataGridViewTextBoxColumn.ReadOnly = True
        Me.StreetDataGridViewTextBoxColumn.Visible = False
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcccountDataGridViewTextBoxColumn
        '
        Me.AcccountDataGridViewTextBoxColumn.DataPropertyName = "Acccount"
        Me.AcccountDataGridViewTextBoxColumn.HeaderText = "Acccount"
        Me.AcccountDataGridViewTextBoxColumn.Name = "AcccountDataGridViewTextBoxColumn"
        Me.AcccountDataGridViewTextBoxColumn.ReadOnly = True
        Me.AcccountDataGridViewTextBoxColumn.Visible = False
        '
        'OpeningBalanceDataGridViewTextBoxColumn
        '
        Me.OpeningBalanceDataGridViewTextBoxColumn.DataPropertyName = "OpeningBalance"
        Me.OpeningBalanceDataGridViewTextBoxColumn.HeaderText = "OpeningBalance"
        Me.OpeningBalanceDataGridViewTextBoxColumn.Name = "OpeningBalanceDataGridViewTextBoxColumn"
        Me.OpeningBalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpeningBalanceDataGridViewTextBoxColumn.Visible = False
        '
        'CreditLimitDataGridViewTextBoxColumn
        '
        Me.CreditLimitDataGridViewTextBoxColumn.DataPropertyName = "CreditLimit"
        Me.CreditLimitDataGridViewTextBoxColumn.HeaderText = "Credit Limit"
        Me.CreditLimitDataGridViewTextBoxColumn.Name = "CreditLimitDataGridViewTextBoxColumn"
        Me.CreditLimitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailPreferenceDataGridViewCheckBoxColumn
        '
        Me.EmailPreferenceDataGridViewCheckBoxColumn.DataPropertyName = "EmailPreference"
        Me.EmailPreferenceDataGridViewCheckBoxColumn.HeaderText = "EmailPreference"
        Me.EmailPreferenceDataGridViewCheckBoxColumn.Name = "EmailPreferenceDataGridViewCheckBoxColumn"
        Me.EmailPreferenceDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SMSPreferenceDataGridViewCheckBoxColumn
        '
        Me.SMSPreferenceDataGridViewCheckBoxColumn.DataPropertyName = "SMSPreference"
        Me.SMSPreferenceDataGridViewCheckBoxColumn.HeaderText = "SMSPreference"
        Me.SMSPreferenceDataGridViewCheckBoxColumn.Name = "SMSPreferenceDataGridViewCheckBoxColumn"
        Me.SMSPreferenceDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'InactiveDataGridViewCheckBoxColumn
        '
        Me.InactiveDataGridViewCheckBoxColumn.DataPropertyName = "Inactive"
        Me.InactiveDataGridViewCheckBoxColumn.HeaderText = "Inactive"
        Me.InactiveDataGridViewCheckBoxColumn.Name = "InactiveDataGridViewCheckBoxColumn"
        Me.InactiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'VendorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 497)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "VendorList"
        Me.Text = "Vendor List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents VendorBindingSource As BindingSource
    '  Friend WithEvents VendorTableAdapter As SAAEvoDatasetTableAdapters.VendorTableAdapter
    Friend WithEvents VendorNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WebsiteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpeningBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditLimitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailPreferenceDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SMSPreferenceDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents InactiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
