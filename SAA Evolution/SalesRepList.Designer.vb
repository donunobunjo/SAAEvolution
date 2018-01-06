<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesRepList
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SalesRepIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesRepNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoreNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOpenedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SalesRepStoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.SalesRepStoreTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.SalesRepStoreTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesRepStoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalesRepIDDataGridViewTextBoxColumn, Me.SalesRepNameDataGridViewTextBoxColumn, Me.LocationNameDataGridViewTextBoxColumn, Me.StoreNameDataGridViewTextBoxColumn, Me.DateOpenedDataGridViewTextBoxColumn, Me.ActiveDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesRepStoreBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(613, 417)
        Me.DataGridView1.TabIndex = 0
        '
        'SalesRepIDDataGridViewTextBoxColumn
        '
        Me.SalesRepIDDataGridViewTextBoxColumn.DataPropertyName = "SalesRepID"
        Me.SalesRepIDDataGridViewTextBoxColumn.HeaderText = "SalesRepID"
        Me.SalesRepIDDataGridViewTextBoxColumn.Name = "SalesRepIDDataGridViewTextBoxColumn"
        Me.SalesRepIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalesRepNameDataGridViewTextBoxColumn
        '
        Me.SalesRepNameDataGridViewTextBoxColumn.DataPropertyName = "SalesRepName"
        Me.SalesRepNameDataGridViewTextBoxColumn.HeaderText = "SalesRepName"
        Me.SalesRepNameDataGridViewTextBoxColumn.Name = "SalesRepNameDataGridViewTextBoxColumn"
        Me.SalesRepNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocationNameDataGridViewTextBoxColumn
        '
        Me.LocationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName"
        Me.LocationNameDataGridViewTextBoxColumn.HeaderText = "LocationName"
        Me.LocationNameDataGridViewTextBoxColumn.Name = "LocationNameDataGridViewTextBoxColumn"
        Me.LocationNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StoreNameDataGridViewTextBoxColumn
        '
        Me.StoreNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName"
        Me.StoreNameDataGridViewTextBoxColumn.HeaderText = "StoreName"
        Me.StoreNameDataGridViewTextBoxColumn.Name = "StoreNameDataGridViewTextBoxColumn"
        Me.StoreNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOpenedDataGridViewTextBoxColumn
        '
        Me.DateOpenedDataGridViewTextBoxColumn.DataPropertyName = "DateOpened"
        Me.DateOpenedDataGridViewTextBoxColumn.HeaderText = "DateOpened"
        Me.DateOpenedDataGridViewTextBoxColumn.Name = "DateOpenedDataGridViewTextBoxColumn"
        Me.DateOpenedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveDataGridViewCheckBoxColumn
        '
        Me.ActiveDataGridViewCheckBoxColumn.DataPropertyName = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.HeaderText = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.Name = "ActiveDataGridViewCheckBoxColumn"
        Me.ActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SalesRepStoreBindingSource
        '
        Me.SalesRepStoreBindingSource.DataMember = "SalesRepStore"
        Me.SalesRepStoreBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesRepStoreTableAdapter
        '
        Me.SalesRepStoreTableAdapter.ClearBeforeFill = True
        '
        'SalesRepList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 417)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SalesRepList"
        Me.Text = "Sales Rep List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesRepStoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents SalesRepStoreBindingSource As BindingSource
    Friend WithEvents SalesRepStoreTableAdapter As SAAEvoDatasetTableAdapters.SalesRepStoreTableAdapter
    Friend WithEvents SalesRepIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesRepNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StoreNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOpenedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
