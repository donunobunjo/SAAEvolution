Public Class InvoicesByOrders

    Private Sub InvoicesByOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesInvoice' table. You can move, or remove it, as needed.
        Me.SalesInvoiceTableAdapter.FillByInvoicesByOrders(Me.SAAEvoDataset.SalesInvoice)
        Me.CenterToScreen()
        Me.Top = 5

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class