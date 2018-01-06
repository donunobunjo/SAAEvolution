Public Class PrintSalesInvoice
    Public Property invNumber As String
    Private Sub PrintSalesInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesInvoice' table. You can move, or remove it, as needed.
        'Me.SalesInvoiceTableAdapter.Fill(Me.SAAEvoDataset.SalesInvoice)
        Me.SalesInvoiceTableAdapter.FillBy(Me.SAAEvoDataset.SalesInvoice, invNumber)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class