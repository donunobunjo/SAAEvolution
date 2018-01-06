<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesInvoice
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SONumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SODiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesOrderSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.SalesOrderSummaryTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(425, 15)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(276, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(109, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton2.Location = New System.Drawing.Point(335, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Customer"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "S.O. Number"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(719, 276)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose a sales order"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(599, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sales Invoice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SONumberDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn, Me.SODateDataGridViewTextBoxColumn, Me.SOAmountDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn, Me.SOStatusDataGridViewTextBoxColumn, Me.SODiscountDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesOrderSummaryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(37, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 229)
        Me.DataGridView1.TabIndex = 0
        '
        'SONumberDataGridViewTextBoxColumn
        '
        Me.SONumberDataGridViewTextBoxColumn.DataPropertyName = "SONumber"
        Me.SONumberDataGridViewTextBoxColumn.HeaderText = "S.O.Number"
        Me.SONumberDataGridViewTextBoxColumn.Name = "SONumberDataGridViewTextBoxColumn"
        Me.SONumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerDataGridViewTextBoxColumn.Width = 200
        '
        'SODateDataGridViewTextBoxColumn
        '
        Me.SODateDataGridViewTextBoxColumn.DataPropertyName = "SODate"
        Me.SODateDataGridViewTextBoxColumn.HeaderText = "S.O.Date"
        Me.SODateDataGridViewTextBoxColumn.Name = "SODateDataGridViewTextBoxColumn"
        Me.SODateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SOAmountDataGridViewTextBoxColumn
        '
        Me.SOAmountDataGridViewTextBoxColumn.DataPropertyName = "SOAmount"
        Me.SOAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.SOAmountDataGridViewTextBoxColumn.Name = "SOAmountDataGridViewTextBoxColumn"
        Me.SOAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "Comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "Comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.Visible = False
        Me.CommentDataGridViewTextBoxColumn.Width = 250
        '
        'SOStatusDataGridViewTextBoxColumn
        '
        Me.SOStatusDataGridViewTextBoxColumn.DataPropertyName = "SOStatus"
        Me.SOStatusDataGridViewTextBoxColumn.HeaderText = "SOStatus"
        Me.SOStatusDataGridViewTextBoxColumn.Name = "SOStatusDataGridViewTextBoxColumn"
        Me.SOStatusDataGridViewTextBoxColumn.Visible = False
        '
        'SODiscountDataGridViewTextBoxColumn
        '
        Me.SODiscountDataGridViewTextBoxColumn.DataPropertyName = "SODiscount"
        Me.SODiscountDataGridViewTextBoxColumn.HeaderText = "SODiscount"
        Me.SODiscountDataGridViewTextBoxColumn.Name = "SODiscountDataGridViewTextBoxColumn"
        Me.SODiscountDataGridViewTextBoxColumn.Visible = False
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.Visible = False
        '
        'SalesOrderSummaryBindingSource
        '
        Me.SalesOrderSummaryBindingSource.DataMember = "SalesOrderSummary"
        Me.SalesOrderSummaryBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesOrderSummaryTableAdapter
        '
        Me.SalesOrderSummaryTableAdapter.ClearBeforeFill = True
        '
        'SalesInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 423)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SalesInvoice"
        Me.Text = "Sales Invoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents SalesOrderSummaryBindingSource As BindingSource
    Friend WithEvents SalesOrderSummaryTableAdapter As SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter
    Friend WithEvents SONumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SODateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SODiscountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
