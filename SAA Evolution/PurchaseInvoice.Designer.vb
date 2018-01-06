<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseInvoice
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
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.PurchaseOrderSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrderSummaryTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.PurchaseOrderSummaryTableAdapter()
        Me.PONumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Vendor"
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
        Me.RadioButton1.Text = "P.O. Number"
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
        Me.GroupBox2.Text = "Choose a Purchase order"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Purchase Invoice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PONumberDataGridViewTextBoxColumn, Me.VendorDataGridViewTextBoxColumn, Me.PODateDataGridViewTextBoxColumn, Me.POAmountDataGridViewTextBoxColumn, Me.POStatusDataGridViewTextBoxColumn, Me.PODiscountDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurchaseOrderSummaryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 229)
        Me.DataGridView1.TabIndex = 0
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchaseOrderSummaryBindingSource
        '
        Me.PurchaseOrderSummaryBindingSource.DataMember = "PurchaseOrderSummary"
        Me.PurchaseOrderSummaryBindingSource.DataSource = Me.SAAEvoDataset
        '
        'PurchaseOrderSummaryTableAdapter
        '
        Me.PurchaseOrderSummaryTableAdapter.ClearBeforeFill = True
        '
        'PONumberDataGridViewTextBoxColumn
        '
        Me.PONumberDataGridViewTextBoxColumn.DataPropertyName = "PONumber"
        Me.PONumberDataGridViewTextBoxColumn.HeaderText = "P.O.Number"
        Me.PONumberDataGridViewTextBoxColumn.Name = "PONumberDataGridViewTextBoxColumn"
        '
        'VendorDataGridViewTextBoxColumn
        '
        Me.VendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.HeaderText = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.Name = "VendorDataGridViewTextBoxColumn"
        Me.VendorDataGridViewTextBoxColumn.Width = 200
        '
        'PODateDataGridViewTextBoxColumn
        '
        Me.PODateDataGridViewTextBoxColumn.DataPropertyName = "PODate"
        Me.PODateDataGridViewTextBoxColumn.HeaderText = "P.O.Date"
        Me.PODateDataGridViewTextBoxColumn.Name = "PODateDataGridViewTextBoxColumn"
        '
        'POAmountDataGridViewTextBoxColumn
        '
        Me.POAmountDataGridViewTextBoxColumn.DataPropertyName = "POAmount"
        Me.POAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.POAmountDataGridViewTextBoxColumn.Name = "POAmountDataGridViewTextBoxColumn"
        '
        'POStatusDataGridViewTextBoxColumn
        '
        Me.POStatusDataGridViewTextBoxColumn.DataPropertyName = "POStatus"
        Me.POStatusDataGridViewTextBoxColumn.HeaderText = "POStatus"
        Me.POStatusDataGridViewTextBoxColumn.Name = "POStatusDataGridViewTextBoxColumn"
        Me.POStatusDataGridViewTextBoxColumn.Visible = False
        '
        'PODiscountDataGridViewTextBoxColumn
        '
        Me.PODiscountDataGridViewTextBoxColumn.DataPropertyName = "PODiscount"
        Me.PODiscountDataGridViewTextBoxColumn.HeaderText = "PODiscount"
        Me.PODiscountDataGridViewTextBoxColumn.Name = "PODiscountDataGridViewTextBoxColumn"
        Me.PODiscountDataGridViewTextBoxColumn.Visible = False
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.Visible = False
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "Comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "Comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.Visible = False
        '
        'PurchaseInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 423)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PurchaseInvoice"
        Me.Text = "Purchase Invoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SAAEvoDataset As SAA_Evolution.SAAEvoDataset
    Friend WithEvents PurchaseOrderSummaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseOrderSummaryTableAdapter As SAA_Evolution.SAAEvoDatasetTableAdapters.PurchaseOrderSummaryTableAdapter
    Friend WithEvents PONumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PODateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PODiscountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
