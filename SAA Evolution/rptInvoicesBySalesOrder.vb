Public Class rptInvoicesBySalesOrder

    Private Sub rptInvoicesBySalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesInvoice' table. You can move, or remove it, as needed.
        ' Me.SalesInvoiceTableAdapter.Fill(Me.SAAEvoDataset.SalesInvoice)
        Me.CenterToScreen()
        Me.Top = 5

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SalesInvoiceTableAdapter.FillBySalesOrderNumber(Me.SAAEvoDataset.SalesInvoice, TextBox1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class