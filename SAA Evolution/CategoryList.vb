Public Class CategoryList
    Private Sub CategoryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.ItemCategory' table. You can move, or remove it, as needed.
        Me.ItemCategoryTableAdapter.Fill(Me.SAAEvoDataset.ItemCategory)
        Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 50
    End Sub
End Class