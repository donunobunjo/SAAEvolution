Public Class PrintPurchaseInvoice
    Public Property invnumber As String
    Private Sub PrintPurchaseInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.PurchaseInvoice' table. You can move, or remove it, as needed.
        ' Me.PurchaseInvoiceTableAdapter.Fill(Me.SAAEvoDataset.PurchaseInvoice)
        Me.PurchaseInvoiceTableAdapter.FillBy(Me.SAAEvoDataset.PurchaseInvoice, invnumber)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class