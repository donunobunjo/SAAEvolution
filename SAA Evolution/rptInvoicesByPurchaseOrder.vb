Public Class rptInvoicesByPurchaseOrder
    Public Property dlocation As String
    Public Property dstore As String
    Private Sub rptInvoicesByPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.PurchaseInvoice' table. You can move, or remove it, as needed.
        Me.PurchaseInvoiceTableAdapter.Fill(Me.SAAEvoDataset.PurchaseInvoice)

        Me.ReportViewer1.RefreshReport()
        Me.CenterToScreen()
        Me.Top = 3
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class