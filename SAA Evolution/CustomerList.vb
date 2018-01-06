Public Class CustomerList


    Private Sub CustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.SAAEvoDataset.Customer)
        'Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 2
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class