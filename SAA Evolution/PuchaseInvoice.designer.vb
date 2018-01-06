<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PuchaseInvoice
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PONumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrderSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.PurchaseOrderSummaryTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.PurchaseOrderSummaryTableAdapter()
        '  Me.VendorTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.VendorTableAdapter()
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendor"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.VendorBindingSource
        Me.ComboBox1.DisplayMember = "VendorName"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(300, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'VendorBindingSource
        '
        Me.VendorBindingSource.DataMember = "Vendor"
        Me.VendorBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 342)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Purchase Order to recieve"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(667, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 63)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Recieve Puchase Order Items"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PONumberDataGridViewTextBoxColumn, Me.VendorDataGridViewTextBoxColumn, Me.PODateDataGridViewTextBoxColumn, Me.POStatusDataGridViewTextBoxColumn, Me.POAmountDataGridViewTextBoxColumn, Me.PODiscountDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurchaseOrderSummaryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(629, 295)
        Me.DataGridView1.TabIndex = 0
        '
        'PONumberDataGridViewTextBoxColumn
        '
        Me.PONumberDataGridViewTextBoxColumn.DataPropertyName = "PONumber"
        Me.PONumberDataGridViewTextBoxColumn.HeaderText = "P.O.Number"
        Me.PONumberDataGridViewTextBoxColumn.Name = "PONumberDataGridViewTextBoxColumn"
        Me.PONumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendorDataGridViewTextBoxColumn
        '
        Me.VendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.HeaderText = "Vendor"
        Me.VendorDataGridViewTextBoxColumn.Name = "VendorDataGridViewTextBoxColumn"
        Me.VendorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PODateDataGridViewTextBoxColumn
        '
        Me.PODateDataGridViewTextBoxColumn.DataPropertyName = "PODate"
        Me.PODateDataGridViewTextBoxColumn.HeaderText = "P.O.Date"
        Me.PODateDataGridViewTextBoxColumn.Name = "PODateDataGridViewTextBoxColumn"
        Me.PODateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POStatusDataGridViewTextBoxColumn
        '
        Me.POStatusDataGridViewTextBoxColumn.DataPropertyName = "POStatus"
        Me.POStatusDataGridViewTextBoxColumn.HeaderText = "P.O.Status"
        Me.POStatusDataGridViewTextBoxColumn.Name = "POStatusDataGridViewTextBoxColumn"
        Me.POStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POAmountDataGridViewTextBoxColumn
        '
        Me.POAmountDataGridViewTextBoxColumn.DataPropertyName = "POAmount"
        Me.POAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.POAmountDataGridViewTextBoxColumn.Name = "POAmountDataGridViewTextBoxColumn"
        Me.POAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PODiscountDataGridViewTextBoxColumn
        '
        Me.PODiscountDataGridViewTextBoxColumn.DataPropertyName = "PODiscount"
        Me.PODiscountDataGridViewTextBoxColumn.HeaderText = "PODiscount"
        Me.PODiscountDataGridViewTextBoxColumn.Name = "PODiscountDataGridViewTextBoxColumn"
        Me.PODiscountDataGridViewTextBoxColumn.ReadOnly = True
        Me.PODiscountDataGridViewTextBoxColumn.Visible = False
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserNameDataGridViewTextBoxColumn.Visible = False
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "Comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "Comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommentDataGridViewTextBoxColumn.Visible = False
        '
        'PurchaseOrderSummaryBindingSource
        '
        Me.PurchaseOrderSummaryBindingSource.DataMember = "PurchaseOrderSummary"
        Me.PurchaseOrderSummaryBindingSource.DataSource = Me.SAAEvoDataset
        '
        'PurchaseOrderSummaryTableAdapter
        '
        '  Me.PurchaseOrderSummaryTableAdapter.ClearBeforeFill = True
        '
        'VendorTableAdapter
        '
        'Me.VendorTableAdapter.ClearBeforeFill = True
        '
        'PuchaseInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 417)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PuchaseInvoice"
        Me.Text = "Puchase Invoice"
        CType(Me.VendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents PurchaseOrderSummaryBindingSource As BindingSource
    'Friend WithEvents PurchaseOrderSummaryTableAdapter As SAAEvoDatasetTableAdapters.PurchaseOrderSummaryTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents VendorBindingSource As BindingSource
    ' Friend WithEvents VendorTableAdapter As SAAEvoDatasetTableAdapters.VendorTableAdapter
    Friend WithEvents PONumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PODateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PODiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
