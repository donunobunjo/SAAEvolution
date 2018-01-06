Public Class NewLocation
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As New SAAEvoDatasetTableAdapters.LocationTableAdapter
        Dim dt As New DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("Location is required")
            TextBox1.Focus()
            Exit Sub

        End If
       
        dt = insert.GetDataBy1(TextBox1.Text)
        If dt.Rows.Count = 0 Then
            insert.InsertQuery(TextBox1.Text)
        Else
            MessageBox.Show("This Location exists in the database")
            TextBox1.Focus()
            Exit Sub
        End If

        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim insert As New SAAEvoDatasetTableAdapters.LocationTableAdapter
        Dim dt As New DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("Location is required")
            TextBox1.Focus()
            Exit Sub

        End If
        dt = insert.GetDataBy1(TextBox1.Text)
        If dt.Rows.Count = 0 Then
            insert.InsertQuery(TextBox1.Text)
        Else
            MessageBox.Show("This Location exists in the database")
            TextBox1.Focus()
            Exit Sub
        End If

        Me.Close()
    End Sub

    Private Sub NewLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 5
    End Sub
End Class