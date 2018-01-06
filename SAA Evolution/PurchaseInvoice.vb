Public Class PurchaseInvoice
    Public Property user As String
    Public Property dlocation As String
    Public Property dstore As String
    Private Sub SalesInvoiceMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Top = 5
        Dim ponum As New SAAEvoDatasetTableAdapters.PurchaseOrderSummaryPONumberTableAdapter
        Dim vendor As New SAAEvoDatasetTableAdapters.PurchaseOrderSummaryVendorTableAdapter
        Dim dts As DataTable
        Dim dtc As DataTable
        Dim cnt As Int32
        Dim cnt1 As Int32
        dts = ponum.GetData(dstore, dlocation)
        cnt = dts.Rows.Count
        For i = 0 To cnt - 1
            ComboBox1.Items.Add(dts.Rows(i).Item(0).ToString)
        Next
        dtc = vendor.GetData(dstore, dlocation)
        cnt1 = dtc.Rows.Count
        For i = 0 To cnt1 - 1
            ComboBox2.Items.Add(dtc.Rows(i).Item(0).ToString)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Me.SalesOrderSummaryTableAdapter.FillBySONumber(Me.SAAEvoDataset.SalesOrderSummary, ComboBox1.Text)
        Me.PurchaseOrderSummaryTableAdapter.FillByPONumber(Me.SAAEvoDataset.PurchaseOrderSummary, ComboBox1.Text, dlocation, dstore)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.SelectedIndex = -1
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.SelectedIndex = -1
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Me.SalesOrderSummaryTableAdapter.FillByCustomer(Me.SAAEvoDataset.SalesOrderSummary, ComboBox2.Text)
        Me.PurchaseOrderSummaryTableAdapter.FillByVendor(Me.SAAEvoDataset.PurchaseOrderSummary, ComboBox2.Text, dlocation, dstore)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim recievePurchaseOrder As New RecievePurchaseOrder

        If DataGridView1.SelectedRows.Count > 0 Then
            recievePurchaseOrder.ponumber = DataGridView1.SelectedRows(0).Cells(0).Value
            recievePurchaseOrder.vendor = DataGridView1.SelectedRows(0).Cells(1).Value
            recievePurchaseOrder.user = user
            recievePurchaseOrder.dstore = dstore
            recievePurchaseOrder.dlocation = dlocation
            recievePurchaseOrder.ShowDialog()
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Invoice")
            Exit Sub
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class