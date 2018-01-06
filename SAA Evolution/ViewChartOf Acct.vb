Public Class ViewChartOf_Acct
    Private Sub ViewChartOf_Acct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.allChartOfAcct' table. You can move, or remove it, as needed.
        Me.AllChartOfAcctTableAdapter.Fill(Me.SAAEvoDataset.allChartOfAcct)
        'Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 1

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class