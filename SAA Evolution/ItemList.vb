Public Class ItemList
    Private Sub ItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.SAAEvoDataset.Items)
        'TODO: This line of code loads data into the 'SAAEvoDataset.Item' table. You can move, or remove it, as needed.
        ' Me.ItemTableAdapter.Fill(Me.SAAEvoDataset.Item)
        Me.ItemsTableAdapter.Fill(Me.SAAEvoDataset.Items)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 50
    End Sub
End Class