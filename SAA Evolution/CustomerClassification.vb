Public Class CustomerClassification

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim classi As New SAAEvoDatasetTableAdapters.ClasificationTableAdapter
        classi.InsertQuery(TextBox1.Text)
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cls As New SAAEvoDatasetTableAdapters.ClasificationTableAdapter
        cls.InsertQuery(TextBox1.Text)
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub CustomerClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Top = 100
    End Sub
End Class