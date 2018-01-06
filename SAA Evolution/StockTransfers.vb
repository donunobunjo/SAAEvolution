Public Class StockTransfers
    Public Property user As String
    Dim source, destination As String
    Dim transdate As Date
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub StockTransfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Items' table. You can move, or remove it, as needed.
        'Me.ItemsTableAdapter.Fill(Me.SAAEvoDataset.Items)

        'TODO: This line of code loads data into the 'SAAEvoDataset.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.SAAEvoDataset.Brand)
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesRepStore' table. You can move, or remove it, as needed.
        ' Me.SalesRepStoreTableAdapter.Fill(Me.SAAEvoDataset.SalesRepStore)
        Me.SalesRepStoreTableAdapter.FillByActiveReps(Me.SAAEvoDataset.SalesRepStore)
        'TODO: This line of code loads data into the 'SAAEvoDataset.Store' table. You can move, or remove it, as needed.
        Me.StoreTableAdapter.Fill(Me.SAAEvoDataset.Store)
        'TODO: This line of code loads data into the 'SAAEvoDataset.Location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter.Fill(Me.SAAEvoDataset.Location)
        'Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 2
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        ComboBox6.SelectedIndex = -1
        ComboBox7.SelectedIndex = -1
        ComboBox9.SelectedIndex = -1
        ComboBox10.SelectedIndex = -1
    End Sub



    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            ComboBox3.Enabled = True
        Else
            ComboBox3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            ComboBox4.Enabled = True
        Else
            ComboBox4.Enabled = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            ComboBox8.Enabled = True
        Else
            ComboBox8.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            ComboBox7.Enabled = True
        Else
            ComboBox7.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            ComboBox6.Enabled = True
        Else
            ComboBox6.Enabled = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            ComboBox5.Enabled = True
        Else
            ComboBox5.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox1.Text.Contains(".") Then
                    If Me.TextBox1.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim brand, item As String
        Dim quantity As Decimal
        Dim bulkins As New SAAEvoDatasetTableAdapters.ItemTransTableAdapter
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            brand = DataGridView1.Item(2, j).Value.ToString
            item = DataGridView1.Item(3, j).Value.ToString
            quantity = Convert.ToDecimal(DataGridView1.Item(4, j).Value.ToString)
            transdate = DateTimePicker1.Value
            ' bulkins.InsertQuery(item, transdate, 0, quantity, 0, "", "", "", "", 0, source, destination)
            ' bulkins.InsertQuery(item, transdate, 0, 0, quantity, "", "", "", "", 0, source, destination)
            bulkins.InsertQuery1(item, transdate, 0, quantity, 0, "", "", "", "", 0, source, destination, user)
            bulkins.InsertQuery1(item, transdate, 0, 0, quantity, "", "", "", "", 0, source, destination, user)
        Next
        Me.Close()

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        Me.ItemsTableAdapter.FillBy(Me.SAAEvoDataset.Items, ComboBox9.Text)
        ComboBox10.SelectedIndex = -1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Remove Button")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim itemcount As Int32
        '        If Not (RadioButton1.Checked And RadioButton2.Checked And RadioButton3.Checked And RadioButton4.Checked) Then
        '       MessageBox.Show("Destination is require")
        '      Exit Sub
        '     End If
        '    If Not (RadioButton5.Checked And RadioButton6.Checked And RadioButton7.Checked And RadioButton8.Checked) Then
        '   MessageBox.Show("Source is require")
        '  Exit Sub
        ' End If
        If RadioButton1.Checked = True Then
            If ComboBox1.Text = "" Then
                MessageBox.Show("Source shipping site is required")
                ComboBox1.Focus()
                Exit Sub
            Else
                source = ComboBox1.Text
            End If
        End If
        If RadioButton2.Checked = True Then
            If ComboBox2.Text = "" Then
                MessageBox.Show("Source location is required")
                ComboBox2.Focus()
                Exit Sub
            Else
                source = ComboBox2.Text
            End If
        End If
        If RadioButton3.Checked = True Then
            If ComboBox3.Text = "" Then
                MessageBox.Show("Source store is required")
                ComboBox3.Focus()
                Exit Sub
            Else
                source = ComboBox3.Text
            End If
        End If
        If RadioButton4.Checked = True Then
            If ComboBox4.Text = "" Then
                MessageBox.Show("Source sales rep  is required")
                ComboBox4.Focus()
                Exit Sub
            Else
                source = ComboBox4.Text
            End If
        End If
        If RadioButton8.Checked = True Then
            If ComboBox8.Text = "" Then
                MessageBox.Show("Destination shipping site is required")
                ComboBox8.Focus()
                Exit Sub
            Else
                destination = ComboBox8.Text
            End If
        End If
        If RadioButton7.Checked = True Then
            If ComboBox7.Text = "" Then
                MessageBox.Show("Destination location is required")
                ComboBox7.Focus()
                Exit Sub
            Else
                destination = ComboBox7.Text
            End If
        End If
        If RadioButton6.Checked = True Then
            If ComboBox6.Text = "" Then
                MessageBox.Show("Destination store is required")
                ComboBox6.Focus()
                Exit Sub
            Else
                destination = ComboBox6.Text
            End If
        End If
        If RadioButton5.Checked = True Then
            If ComboBox5.Text = "" Then
                MessageBox.Show("Destination sale rep is required")
                ComboBox5.Focus()
                Exit Sub
            Else
                destination = ComboBox5.Text
            End If
        End If

        If ComboBox9.Text = "" Then
            MessageBox.Show("Brand is required")
            ComboBox9.Focus()
            Exit Sub
        End If
        If ComboBox10.Text = "" Then
            MessageBox.Show("Item is required")
            ComboBox10.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("Quantity is required")
            TextBox1.Focus()
            Exit Sub
        End If
        itemcount = DataGridView1.RowCount
        DataGridView1.Rows.Add()
        DataGridView1.Rows(itemcount - 1).Cells(0).Value = source
        DataGridView1.Rows(itemcount - 1).Cells(1).Value = destination
        DataGridView1.Rows(itemcount - 1).Cells(2).Value = ComboBox9.Text
        DataGridView1.Rows(itemcount - 1).Cells(3).Value = ComboBox10.Text
        DataGridView1.Rows(itemcount - 1).Cells(4).Value = TextBox1.Text
        transdate = DateTimePicker1.Value
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton6.Enabled = False
        RadioButton7.Enabled = False
        RadioButton8.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        ComboBox5.Enabled = False
        ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox9.SelectedIndex = -1
        ComboBox10.SelectedIndex = -1
        TextBox1.Clear()
    End Sub
End Class