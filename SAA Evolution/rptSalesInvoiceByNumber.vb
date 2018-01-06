Public Class rptSalesInvoiceByNumber

    Private Sub rptSalesInvoiceByNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesInvoice' table. You can move, or remove it, as needed.
        ' Me.SalesInvoiceTableAdapter.Fill(Me.SAAEvoDataset.SalesInvoice)

        ' Me.ReportViewer1.RefreshReport()
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SalesInvoiceTableAdapter.FillBy(Me.SAAEvoDataset.SalesInvoice, TextBox1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class