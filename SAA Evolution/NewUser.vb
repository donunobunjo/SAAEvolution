Public Class NewUser
    Public Property dlocation As String
    Public Property dstore As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        txtUser.Clear()
        dtpDate.Value = Date.Today
        txtUser.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim insertuser As New SAAEvoDatasetTableAdapters.UsersTableAdapter
        Dim assignfn As New AssignFuctionsToUser
        Dim dt As DataTable
        If txtUser.Text = "" Then
            MessageBox.Show("User name required")
            txtUser.Focus()
            Exit Sub
        End If
        dt = insertuser.GetDataBy1(txtUser.Text)
        If dt.Rows.Count = 0 Then
            insertuser.InsertQuery(txtUser.Text, "", "", dtpDate.Value, True, dlocation, dstore)
        Else
            MessageBox.Show("This user exists in the database")
            txtUser.Focus()
            Exit Sub
        End If
        ' Me.Close()
        assignfn.user = txtUser.Text
        assignfn.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
       
    End Sub

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StoreTableAdapter.Fill(Me.SAAEvoDataset.Store)
        Me.LocationTableAdapter.Fill(Me.SAAEvoDataset.Location)
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

  
End Class