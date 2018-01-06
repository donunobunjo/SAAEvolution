Public Class storeList
    Private Sub storeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Store' table. You can move, or remove it, as needed.
        Me.StoreTableAdapter.Fill(Me.SAAEvoDataset.Store)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class