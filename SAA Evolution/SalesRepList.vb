Public Class SalesRepList
    Public Property dlocation As String
    Public Property dstore As String
    Private Sub SalesRepList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesRepStore' table. You can move, or remove it, as needed.
        Me.SalesRepStoreTableAdapter.FillByLocationAndStore(Me.SAAEvoDataset.SalesRepStore, dlocation, dstore)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 100
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class