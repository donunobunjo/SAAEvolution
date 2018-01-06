<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewChartOf_Acct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllChartOfAcctBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.AllChartOfAcctTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.allChartOfAcctTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllChartOfAcctBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GroupNameDataGridViewTextBoxColumn, Me.SubNameDataGridViewTextBoxColumn, Me.AccountNameDataGridViewTextBoxColumn, Me.AccountCodeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AllChartOfAcctBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(780, 294)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupNameDataGridViewTextBoxColumn
        '
        Me.GroupNameDataGridViewTextBoxColumn.DataPropertyName = "groupName"
        Me.GroupNameDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.GroupNameDataGridViewTextBoxColumn.Name = "GroupNameDataGridViewTextBoxColumn"
        Me.GroupNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.GroupNameDataGridViewTextBoxColumn.Width = 200
        '
        'SubNameDataGridViewTextBoxColumn
        '
        Me.SubNameDataGridViewTextBoxColumn.DataPropertyName = "subName"
        Me.SubNameDataGridViewTextBoxColumn.HeaderText = "Sub Type"
        Me.SubNameDataGridViewTextBoxColumn.Name = "SubNameDataGridViewTextBoxColumn"
        Me.SubNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubNameDataGridViewTextBoxColumn.Width = 200
        '
        'AccountNameDataGridViewTextBoxColumn
        '
        Me.AccountNameDataGridViewTextBoxColumn.DataPropertyName = "accountName"
        Me.AccountNameDataGridViewTextBoxColumn.HeaderText = "Account Name"
        Me.AccountNameDataGridViewTextBoxColumn.Name = "AccountNameDataGridViewTextBoxColumn"
        Me.AccountNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountNameDataGridViewTextBoxColumn.Width = 150
        '
        'AccountCodeDataGridViewTextBoxColumn
        '
        Me.AccountCodeDataGridViewTextBoxColumn.DataPropertyName = "accountCode"
        Me.AccountCodeDataGridViewTextBoxColumn.HeaderText = "Account Code"
        Me.AccountCodeDataGridViewTextBoxColumn.Name = "AccountCodeDataGridViewTextBoxColumn"
        Me.AccountCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountCodeDataGridViewTextBoxColumn.Width = 150
        '
        'AllChartOfAcctBindingSource
        '
        Me.AllChartOfAcctBindingSource.DataMember = "allChartOfAcct"
        Me.AllChartOfAcctBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AllChartOfAcctTableAdapter
        '
        Me.AllChartOfAcctTableAdapter.ClearBeforeFill = True
        '
        'ViewChartOf_Acct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 294)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewChartOf_Acct"
        Me.Text = "Account List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllChartOfAcctBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents AllChartOfAcctBindingSource As BindingSource
    Friend WithEvents AllChartOfAcctTableAdapter As SAAEvoDatasetTableAdapters.allChartOfAcctTableAdapter
    Friend WithEvents GroupNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
