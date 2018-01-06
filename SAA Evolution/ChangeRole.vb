Public Class ChangeRole
    Public Property username As String
    Private Sub ChangeRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = username
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim updaterole As New SAAEvoDatasetTableAdapters.UsersTableAdapter
        If ComboBox1.Text = "" Then
            MessageBox.Show("The new role is required")
            ComboBox1.Focus()
            Exit Sub
        End If
        updaterole.UpdateRole(ComboBox1.Text, TextBox1.Text)
        MessageBox.Show("The new role as been assigned to " + TextBox1.Text)
        Me.Close()
    End Sub
End Class