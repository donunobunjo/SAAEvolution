Public Class Category


    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.ItemCategory' table. You can move, or remove it, as needed.
        Me.ItemCategoryTableAdapter.Fill(Me.SAAEvoDataset.ItemCategory)
        Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 50
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class