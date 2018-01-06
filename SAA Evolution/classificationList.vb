Public Class classificationList

    Private Sub classificationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Clasification' table. You can move, or remove it, as needed.
        Me.ClasificationTableAdapter.Fill(Me.SAAEvoDataset.Clasification)
        Me.CenterToScreen()
        Me.Top = 100
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class