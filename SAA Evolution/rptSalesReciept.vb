Public Class rptSalesReciept
    Public Property invnum As String

    Private Sub rptSalesReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesInvoice' table. You can move, or remove it, as needed.
        Me.SalesInvoiceTableAdapter.Fill(Me.SAAEvoDataset.SalesInvoice)
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesOrderDetail' table. You can move, or remove it, as needed.
        Me.SalesOrderDetailTableAdapter.Fill(Me.SAAEvoDataset.SalesOrderDetail)
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesInvoice' table. You can move, or remove it, as needed.
        '  Me.SalesInvoiceTableAdapter.Fill(Me.SAAEvoDataset.SalesInvoice)
        Me.SalesInvoiceTableAdapter.FillBy(Me.SAAEvoDataset.SalesInvoice, invnum)
        Me.CenterToScreen()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class