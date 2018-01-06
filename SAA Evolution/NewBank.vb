Public Class NewBank

    Private Sub NewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 40

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class