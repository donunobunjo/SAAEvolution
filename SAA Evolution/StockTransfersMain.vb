Public Class StockTransfersMain
    Public Property user As String
    Public Property dlocation As String
    Public Property dstore As String
    Dim source, destination As String
    Dim transdate As Date

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub StockTransfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BrandTableAdapter.Fill(Me.SAAEvoDataset.Brand)
        Me.SalesRepStoreTableAdapter.FillByLocationAndStore(Me.SAAEvoDataset.SalesRepStore, dlocation, dstore)
        Me.CenterToScreen()
        Me.Top = 2
        ComboBox9.SelectedIndex = -1
        ComboBox10.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
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
            ' bulkins.InsertQuery1(item, transdate, 0, quantity, 0, "", "", "", "", 0, source, destination, user)
            ' bulkins.InsertQuery1(item, transdate, 0, 0, quantity, "", "", "", "", 0, source, destination, user)
            bulkins.InsertQuery1(item, transdate, 0, quantity, 0, ComboBox5.Text, dlocation, dstore, "", 0, dstore, ComboBox5.Text, user)
            bulkins.InsertQuery1(item, transdate, 0, 0, quantity, ComboBox5.Text, dlocation, dstore, "", 0, dstore, ComboBox5.Text, user)
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
        Dim brand, item As String
        Dim quantity As Decimal
        Dim bulkins As New SAAEvoDatasetTableAdapters.ItemTransTableAdapter
        For j = 0 To (Me.DataGridView1.RowCount - 1) - 1
            brand = DataGridView1.Item(2, j).Value.ToString
            item = DataGridView1.Item(3, j).Value.ToString
            quantity = Convert.ToDecimal(DataGridView1.Item(4, j).Value.ToString)
            transdate = DateTimePicker1.Value
            ' bulkins.InsertQuery1(item, transdate, 0, quantity, 0, "", "", "", "", 0, source, destination, user)
            ' bulkins.InsertQuery1(item, transdate, 0, 0, quantity, "", "", "", "", 0, source, destination, user)
            bulkins.InsertQuery1(item, transdate, 0, quantity, 0, ComboBox5.Text, dlocation, dstore, "", 0, dstore, ComboBox5.Text, user)
            bulkins.InsertQuery1(item, transdate, 0, 0, quantity, ComboBox5.Text, dlocation, dstore, "", 0, dstore, ComboBox5.Text, user)
        Next
        ComboBox5.Enabled = True
        ComboBox5.SelectedIndex = -1
        ComboBox9.SelectedIndex = -1
        ComboBox10.SelectedIndex = -1
        TextBox1.Text = ""
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim itemcount As Int32
       

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
      
        DateTimePicker1.Enabled = False
        ComboBox5.Enabled = False
        ComboBox9.SelectedIndex = -1
        ComboBox10.SelectedIndex = -1
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox5.SelectedIndex = -1
        ComboBox9.SelectedIndex = -1
        ComboBox10.SelectedIndex = -1
        TextBox1.Clear()
    End Sub
End Class