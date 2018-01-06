<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class storeList
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
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.StoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.StoreTableAdapter()
        Me.StoreIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoreNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoremanagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOpenedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StoreIDDataGridViewTextBoxColumn, Me.StoreNameDataGridViewTextBoxColumn, Me.LocationNameDataGridViewTextBoxColumn, Me.StoremanagerDataGridViewTextBoxColumn, Me.DateOpenedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StoreBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(551, 343)
        Me.DataGridView1.TabIndex = 0
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StoreBindingSource
        '
        Me.StoreBindingSource.DataMember = "Store"
        Me.StoreBindingSource.DataSource = Me.SAAEvoDataset
        '
        'StoreTableAdapter
        '
        Me.StoreTableAdapter.ClearBeforeFill = True
        '
        'StoreIDDataGridViewTextBoxColumn
        '
        Me.StoreIDDataGridViewTextBoxColumn.DataPropertyName = "StoreID"
        Me.StoreIDDataGridViewTextBoxColumn.HeaderText = "StoreID"
        Me.StoreIDDataGridViewTextBoxColumn.Name = "StoreIDDataGridViewTextBoxColumn"
        Me.StoreIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StoreIDDataGridViewTextBoxColumn.Visible = False
        '
        'StoreNameDataGridViewTextBoxColumn
        '
        Me.StoreNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName"
        Me.StoreNameDataGridViewTextBoxColumn.HeaderText = "Store"
        Me.StoreNameDataGridViewTextBoxColumn.Name = "StoreNameDataGridViewTextBoxColumn"
        Me.StoreNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocationNameDataGridViewTextBoxColumn
        '
        Me.LocationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName"
        Me.LocationNameDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationNameDataGridViewTextBoxColumn.Name = "LocationNameDataGridViewTextBoxColumn"
        Me.LocationNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StoremanagerDataGridViewTextBoxColumn
        '
        Me.StoremanagerDataGridViewTextBoxColumn.DataPropertyName = "Storemanager"
        Me.StoremanagerDataGridViewTextBoxColumn.HeaderText = "Store Manager"
        Me.StoremanagerDataGridViewTextBoxColumn.Name = "StoremanagerDataGridViewTextBoxColumn"
        Me.StoremanagerDataGridViewTextBoxColumn.ReadOnly = True
        Me.StoremanagerDataGridViewTextBoxColumn.Width = 200
        '
        'DateOpenedDataGridViewTextBoxColumn
        '
        Me.DateOpenedDataGridViewTextBoxColumn.DataPropertyName = "DateOpened"
        Me.DateOpenedDataGridViewTextBoxColumn.HeaderText = "Date Opened"
        Me.DateOpenedDataGridViewTextBoxColumn.Name = "DateOpenedDataGridViewTextBoxColumn"
        Me.DateOpenedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'storeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 343)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "storeList"
        Me.Text = "Store List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents StoreBindingSource As BindingSource
    Friend WithEvents StoreTableAdapter As SAAEvoDatasetTableAdapters.StoreTableAdapter
    Friend WithEvents StoreIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StoreNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StoremanagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOpenedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
