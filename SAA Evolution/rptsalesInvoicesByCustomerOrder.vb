Public Class rptsalesInvoicesByCustomerOrder

    Private Sub salesInvoicesByCustomerOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesInvoice' table. You can move, or remove it, as needed.
        ' Me.SalesInvoiceTableAdapter.Fill(Me.SAAEvoDataset.SalesInvoice)

        'Me.ReportViewer1.RefreshReport()
        Me.CustomerTableAdapter.Fill(Me.SAAEvoDataset.Customer)
        ComboBox1.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.SalesInvoiceTableAdapter.FillByCustomer(Me.SAAEvoDataset.SalesInvoice, ComboBox1.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class