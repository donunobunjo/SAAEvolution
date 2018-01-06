Public Class NewBrand
    Private Sub NewBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Brand' table. You can move, or remove it, as needed.
        ' Me.BrandTableAdapter.Fill(Me.SAAEvoDataset.Brand)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 2
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ins As New SAAEvoDatasetTableAdapters.BrandTableAdapter
        Dim dt As DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("Brand is required")
            TextBox1.Focus()
            Exit Sub

        End If
        dt = ins.GetDataBy1(TextBox1.Text)
        If dt.Rows.Count = 0 Then
            ins.InsertQuery(TextBox1.Text)
        Else
            MessageBox.Show("This Brand exists in the database")
            TextBox1.Focus()
            Exit Sub
        End If

        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ins As New SAAEvoDatasetTableAdapters.BrandTableAdapter
        If TextBox1.Text = "" Then
            MessageBox.Show("Brand is required")
            TextBox1.Focus()
            Exit Sub

        End If
        ins.InsertQuery(TextBox1.Text)
        Me.Close()
    End Sub
End Class