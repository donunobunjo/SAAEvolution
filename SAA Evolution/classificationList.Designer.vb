<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class classificationList
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
        Me.ClasificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClasificationTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.ClasificationTableAdapter()
        Me.ClassificationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClasificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassificationIDDataGridViewTextBoxColumn, Me.ClassificationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClasificationBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(302, 298)
        Me.DataGridView1.TabIndex = 0
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClasificationBindingSource
        '
        Me.ClasificationBindingSource.DataMember = "Clasification"
        Me.ClasificationBindingSource.DataSource = Me.SAAEvoDataset
        '
        'ClasificationTableAdapter
        '
        Me.ClasificationTableAdapter.ClearBeforeFill = True
        '
        'ClassificationIDDataGridViewTextBoxColumn
        '
        Me.ClassificationIDDataGridViewTextBoxColumn.DataPropertyName = "ClassificationID"
        Me.ClassificationIDDataGridViewTextBoxColumn.HeaderText = "ClassificationID"
        Me.ClassificationIDDataGridViewTextBoxColumn.Name = "ClassificationIDDataGridViewTextBoxColumn"
        Me.ClassificationIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClassificationIDDataGridViewTextBoxColumn.Visible = False
        '
        'ClassificationDataGridViewTextBoxColumn
        '
        Me.ClassificationDataGridViewTextBoxColumn.DataPropertyName = "Classification"
        Me.ClassificationDataGridViewTextBoxColumn.HeaderText = "Classification"
        Me.ClassificationDataGridViewTextBoxColumn.Name = "ClassificationDataGridViewTextBoxColumn"
        Me.ClassificationDataGridViewTextBoxColumn.Width = 200
        '
        'classificationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 298)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "classificationList"
        Me.Text = "Classification List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClasificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SAAEvoDataset As SAA_Evolution.SAAEvoDataset
    Friend WithEvents ClasificationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClasificationTableAdapter As SAA_Evolution.SAAEvoDatasetTableAdapters.ClasificationTableAdapter
    Friend WithEvents ClassificationIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
