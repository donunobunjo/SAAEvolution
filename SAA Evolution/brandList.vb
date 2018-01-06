Public Class brandList
    Private Sub brandList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.SAAEvoDataset.Brand)
        '  Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 10
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class