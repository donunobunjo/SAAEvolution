Public Class Locationlist
    Private Sub Locationlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter.Fill(Me.SAAEvoDataset.Location)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 20
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class