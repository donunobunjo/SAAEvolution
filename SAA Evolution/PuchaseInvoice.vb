Public Class PuchaseInvoice
    Private Sub PuchaseInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Vendor' table. You can move, or remove it, as needed.
        ' Me.VendorTableAdapter.Fill(Me.SAAEvoDataset.Vendor)
        'TODO: This line of code loads data into the 'SAAEvoDataset.PurchaseOrderSummary' table. You can move, or remove it, as needed.
        ' Me.PurchaseOrderSummaryTableAdapter.Fill(Me.SAAEvoDataset.PurchaseOrderSummary)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 1
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '  Dim displayPO As New SAAEvoDatasetTableAdapters.PurchaseOrderSummaryTableAdapter
        ' displayPO.FillBy(Me.SAAEvoDataset.PurchaseOrderSummary, ComboBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim recievepurchaseOrders As New RecievePurchaseOrder
        recievepurchaseOrders.vendor = ComboBox1.Text
        If DataGridView1.SelectedRows.Count > 0 Then

            recievepurchaseOrders.PONumber = DataGridView1.SelectedRows(0).Cells(0).Value
            recievepurchaseOrders.ShowDialog()
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit recieve the purchase order")
            Exit Sub
        End If

    End Sub
End Class