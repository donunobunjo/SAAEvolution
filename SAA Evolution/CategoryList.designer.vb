<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryList
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
        Me.ItemCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemCategoryTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.ItemCategoryTableAdapter()
        Me.ItemCategoryCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCategoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCategoryCodeDataGridViewTextBoxColumn, Me.ItemCategoryNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemCategoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(354, 255)
        Me.DataGridView1.TabIndex = 0
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemCategoryBindingSource
        '
        Me.ItemCategoryBindingSource.DataMember = "ItemCategory"
        Me.ItemCategoryBindingSource.DataSource = Me.SAAEvoDataset
        '
        'ItemCategoryTableAdapter
        '
        Me.ItemCategoryTableAdapter.ClearBeforeFill = True
        '
        'ItemCategoryCodeDataGridViewTextBoxColumn
        '
        Me.ItemCategoryCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCategoryCode"
        Me.ItemCategoryCodeDataGridViewTextBoxColumn.HeaderText = "ItemCategoryCode"
        Me.ItemCategoryCodeDataGridViewTextBoxColumn.Name = "ItemCategoryCodeDataGridViewTextBoxColumn"
        Me.ItemCategoryCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemCategoryCodeDataGridViewTextBoxColumn.Visible = False
        '
        'ItemCategoryNameDataGridViewTextBoxColumn
        '
        Me.ItemCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "ItemCategoryName"
        Me.ItemCategoryNameDataGridViewTextBoxColumn.HeaderText = "Item Category"
        Me.ItemCategoryNameDataGridViewTextBoxColumn.Name = "ItemCategoryNameDataGridViewTextBoxColumn"
        Me.ItemCategoryNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemCategoryNameDataGridViewTextBoxColumn.Width = 300
        '
        'CategoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 301)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CategoryList"
        Me.Text = "Category List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents ItemCategoryBindingSource As BindingSource
    Friend WithEvents ItemCategoryTableAdapter As SAAEvoDatasetTableAdapters.ItemCategoryTableAdapter
    Friend WithEvents ItemCategoryCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCategoryNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
