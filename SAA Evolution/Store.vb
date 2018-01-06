Public Class Store
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As New SAAEvoDatasetTableAdapters.StoreTableAdapter
        Dim numCheck As New SAAEvoDatasetTableAdapters.NumberChecksTableAdapter
        Dim dt As New DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("Store is required")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("Location is required")
            ComboBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Store Manager is required")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("Prefix is required")
            TextBox3.Focus()
            Exit Sub
        Else
            dt = insert.GetDataByprefix(TextBox3.Text)
            If Not dt.Rows.Count = 0 Then
                MessageBox.Show("This prefix exists in the database")
                TextBox3.Clear()
                TextBox3.Focus()
                Exit Sub
            End If
        End If
        dt = insert.GetDataBy1(TextBox1.Text)
        If dt.Rows.Count = 0 Then
            insert.InsertQuery(TextBox1.Text, ComboBox1.Text, TextBox2.Text, DateTimePicker1.Value, TextBox3.Text)
            numCheck.InsertQuery(ComboBox1.Text, TextBox1.Text, 0, 0, 0, 0, 0, 0)
        Else
            MessageBox.Show("This Store exists in the database")
            TextBox1.Focus()
            Exit Sub
        End If
        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox2.Clear()
        TextBox3.Clear()
        DateTimePicker1.Value = Date.Today
        TextBox1.Focus()

    End Sub

    Private Sub Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter.Fill(Me.SAAEvoDataset.Location)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 5
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim insert As New SAAEvoDatasetTableAdapters.StoreTableAdapter
        Dim numCheck As New SAAEvoDatasetTableAdapters.NumberChecksTableAdapter
        Dim dt As New DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("Store is required")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MessageBox.Show("Location is required")
            ComboBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Store Manager is required")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("Prefix is required")
            TextBox3.Focus()
            Exit Sub
        Else
            dt = insert.GetDataByprefix(TextBox3.Text)
            If Not dt.Rows.Count = 0 Then
                MessageBox.Show("This prefix exists in the database")
                TextBox3.Clear()
                TextBox3.Focus()
                Exit Sub
            End If
        End If
       
        dt = insert.GetDataBy1(TextBox1.Text)
        If dt.Rows.Count = 0 Then
            insert.InsertQuery(TextBox1.Text, ComboBox1.Text, TextBox2.Text, DateTimePicker1.Value, TextBox3.Text)
            numCheck.InsertQuery(ComboBox1.Text, TextBox1.Text, 0, 0, 0, 0, 0, 0)
        Else
            MessageBox.Show("This Store exists in the database")
            TextBox1.Focus()
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class