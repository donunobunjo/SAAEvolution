<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class brandList
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
        Me.BrandIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.BrandTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.BrandTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandIDDataGridViewTextBoxColumn, Me.BrandNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BrandBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(413, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'BrandIDDataGridViewTextBoxColumn
        '
        Me.BrandIDDataGridViewTextBoxColumn.DataPropertyName = "BrandID"
        Me.BrandIDDataGridViewTextBoxColumn.HeaderText = "BrandID"
        Me.BrandIDDataGridViewTextBoxColumn.Name = "BrandIDDataGridViewTextBoxColumn"
        Me.BrandIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandIDDataGridViewTextBoxColumn.Visible = False
        '
        'BrandNameDataGridViewTextBoxColumn
        '
        Me.BrandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName"
        Me.BrandNameDataGridViewTextBoxColumn.HeaderText = "Brand Name"
        Me.BrandNameDataGridViewTextBoxColumn.Name = "BrandNameDataGridViewTextBoxColumn"
        Me.BrandNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandNameDataGridViewTextBoxColumn.Width = 300
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "Brand"
        Me.BrandBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'brandList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "brandList"
        Me.Text = "Brand List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents BrandTableAdapter As SAAEvoDatasetTableAdapters.BrandTableAdapter
    Friend WithEvents BrandIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
