<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deliverSalesOrders
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SalesOrderDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAAEvoDataset = New SAA_Evolution.SAAEvoDataset()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SalesRepStoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderDetailTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.SalesOrderDetailTableAdapter()
        Me.LocationTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.LocationTableAdapter()
        Me.StoreTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.StoreTableAdapter()
        Me.SalesRepStoreTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.SalesRepStoreTableAdapter()
        Me.SalesOrderSummaryUpdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderSummaryUpdateTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.SalesOrderSummaryUpdateTableAdapter()
        Me.SalesOrderSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderSummaryTableAdapter = New SAA_Evolution.SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SODateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDelivered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesOrderNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyOrdered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delivered = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SalesInvoiceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesRepStoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderSummaryUpdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "S. O.Number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(301, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(486, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(183, 20)
        Me.TextBox2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SODateDataGridViewTextBoxColumn, Me.ItemDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.QtyDelivered, Me.RateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn, Me.SalesOrderNumberDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.QtyOrdered, Me.DataGridViewTextBoxColumn1, Me.Delivered, Me.SalesInvoiceNumber})
        Me.DataGridView1.DataSource = Me.SalesOrderDetailBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(671, 288)
        Me.DataGridView1.TabIndex = 5
        '
        'SalesOrderDetailBindingSource
        '
        Me.SalesOrderDetailBindingSource.DataMember = "SalesOrderDetail"
        Me.SalesOrderDetailBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SAAEvoDataset
        '
        Me.SAAEvoDataset.DataSetName = "SAAEvoDataset"
        Me.SAAEvoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Invoice Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Discount %"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tax %"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(372, 41)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(70, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(567, 41)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(76, 20)
        Me.TextBox4.TabIndex = 13
        '
        'SalesRepStoreBindingSource
        '
        Me.SalesRepStoreBindingSource.DataMember = "SalesRepStore"
        Me.SalesRepStoreBindingSource.DataSource = Me.SAAEvoDataset
        '
        'StoreBindingSource
        '
        Me.StoreBindingSource.DataMember = "Store"
        Me.StoreBindingSource.DataSource = Me.SAAEvoDataset
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SalesOrderDetailTableAdapter
        '
        Me.SalesOrderDetailTableAdapter.ClearBeforeFill = True
        '
        'LocationTableAdapter
        '
        Me.LocationTableAdapter.ClearBeforeFill = True
        '
        'StoreTableAdapter
        '
        Me.StoreTableAdapter.ClearBeforeFill = True
        '
        'SalesRepStoreTableAdapter
        '
        Me.SalesRepStoreTableAdapter.ClearBeforeFill = True
        '
        'SalesOrderSummaryUpdateBindingSource
        '
        Me.SalesOrderSummaryUpdateBindingSource.DataMember = "SalesOrderSummaryUpdate"
        Me.SalesOrderSummaryUpdateBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SalesOrderSummaryUpdateTableAdapter
        '
        Me.SalesOrderSummaryUpdateTableAdapter.ClearBeforeFill = True
        '
        'SalesOrderSummaryBindingSource
        '
        Me.SalesOrderSummaryBindingSource.DataMember = "SalesOrderSummary"
        Me.SalesOrderSummaryBindingSource.DataSource = Me.SAAEvoDataset
        '
        'SalesOrderSummaryTableAdapter
        '
        Me.SalesOrderSummaryTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Image = Global.SAA_Evolution.My.Resources.Resources.email
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(372, 393)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 42)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Save and Email"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.SAA_Evolution.My.Resources.Resources.print
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(213, 393)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 46)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Save and Print"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.SAA_Evolution.My.Resources.Resources.close
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(540, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 46)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SAA_Evolution.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(55, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save and Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SODateDataGridViewTextBoxColumn
        '
        Me.SODateDataGridViewTextBoxColumn.DataPropertyName = "SODate"
        Me.SODateDataGridViewTextBoxColumn.HeaderText = "S.O.Date"
        Me.SODateDataGridViewTextBoxColumn.Name = "SODateDataGridViewTextBoxColumn"
        Me.SODateDataGridViewTextBoxColumn.ReadOnly = True
        Me.SODateDataGridViewTextBoxColumn.Width = 75
        '
        'ItemDataGridViewTextBoxColumn
        '
        Me.ItemDataGridViewTextBoxColumn.DataPropertyName = "Item"
        Me.ItemDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.ItemDataGridViewTextBoxColumn.Name = "ItemDataGridViewTextBoxColumn"
        Me.ItemDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemDataGridViewTextBoxColumn.Width = 150
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quan"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 50
        '
        'QtyDelivered
        '
        Me.QtyDelivered.HeaderText = "Qty Delivered"
        Me.QtyDelivered.Name = "QtyDelivered"
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        Me.RateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RateDataGridViewTextBoxColumn.Width = 50
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.AmountDataGridViewTextBoxColumn.Width = 50
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerDataGridViewTextBoxColumn.Width = 150
        '
        'SalesOrderNumberDataGridViewTextBoxColumn
        '
        Me.SalesOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderNumber"
        Me.SalesOrderNumberDataGridViewTextBoxColumn.HeaderText = "SalesOrderNumber"
        Me.SalesOrderNumberDataGridViewTextBoxColumn.Name = "SalesOrderNumberDataGridViewTextBoxColumn"
        Me.SalesOrderNumberDataGridViewTextBoxColumn.Visible = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "Comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "Comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.Visible = False
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.Visible = False
        '
        'QtyOrdered
        '
        Me.QtyOrdered.DataPropertyName = "QtyOrdered"
        Me.QtyOrdered.HeaderText = "QtyOrdered"
        Me.QtyOrdered.Name = "QtyOrdered"
        Me.QtyOrdered.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "QtyDelivered"
        Me.DataGridViewTextBoxColumn1.HeaderText = "QtyDelivered"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Delivered
        '
        Me.Delivered.DataPropertyName = "Delivered"
        Me.Delivered.HeaderText = "Delivered"
        Me.Delivered.Name = "Delivered"
        Me.Delivered.Visible = False
        '
        'SalesInvoiceNumber
        '
        Me.SalesInvoiceNumber.DataPropertyName = "SalesInvoiceNumber"
        Me.SalesInvoiceNumber.HeaderText = "SalesInvoiceNumber"
        Me.SalesInvoiceNumber.Name = "SalesInvoiceNumber"
        Me.SalesInvoiceNumber.Visible = False
        '
        'deliverSalesOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 461)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "deliverSalesOrders"
        Me.Text = "Sales Invoice"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAEvoDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesRepStoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderSummaryUpdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderSummaryBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SAAEvoDataset As SAAEvoDataset
    Friend WithEvents SalesOrderDetailBindingSource As BindingSource
    Friend WithEvents SalesOrderDetailTableAdapter As SAAEvoDatasetTableAdapters.SalesOrderDetailTableAdapter
    Friend WithEvents LocationBindingSource As BindingSource
    Friend WithEvents LocationTableAdapter As SAAEvoDatasetTableAdapters.LocationTableAdapter
    Friend WithEvents StoreBindingSource As BindingSource
    Friend WithEvents StoreTableAdapter As SAAEvoDatasetTableAdapters.StoreTableAdapter
    Friend WithEvents SalesRepStoreBindingSource As BindingSource
    Friend WithEvents SalesRepStoreTableAdapter As SAAEvoDatasetTableAdapters.SalesRepStoreTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SalesOrderSummaryUpdateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesOrderSummaryUpdateTableAdapter As SAA_Evolution.SAAEvoDatasetTableAdapters.SalesOrderSummaryUpdateTableAdapter
    Friend WithEvents SalesOrderSummaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesOrderSummaryTableAdapter As SAA_Evolution.SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    ' Friend WithEvents AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SODateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDelivered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalesOrderNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyOrdered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Delivered As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SalesInvoiceNumber As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
