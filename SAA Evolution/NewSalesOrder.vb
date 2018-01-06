Public Class NewSalesOrder
    Public Property user As String
    Public Property dlocation As String
    Public Property dstore As String
    Dim total As Decimal
    Dim newSONumber As Int32?
    Dim oldSONumber As Int32?
    Dim numcheck As New SAAEvoDatasetTableAdapters.NumberChecksTableAdapter
    Dim insertSOSummary As New SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter
    Dim storeprfix As New SAAEvoDatasetTableAdapters.StoreTableAdapter
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim str As String
    Private Sub NewSalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.SAAEvoDataset.Items)
        Me.CustomerTableAdapter.Fill(Me.SAAEvoDataset.Customer)
        Me.CenterToScreen()
        Me.Top = 1
        dt = numcheck.GetDataBySalesOrder(dlocation, dstore)
        oldSONumber = Convert.ToInt32(dt.Rows(0).Item(3).ToString)
        newSONumber = oldSONumber + 1
        str = Convert.ToString(newSONumber)
        dt1 = storeprfix.GetDataByPrefixx(dstore, dlocation)
        Dim pref = dt1.Rows(0).Item(5).ToString
        str = Trim(pref) + "SO" + str
            TextBox1.Text = str
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
       

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox2.Text.Contains(".") Then
                    If Me.TextBox2.Text.Split(".")(1).Length < 2 Then
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

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox3.Text.Contains(".") Then
                    If Me.TextBox3.Text.Split(".")(1).Length < 2 Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim items, itemscheck As String
        If ComboBox1.Text = "" Then
            MessageBox.Show("Customer is reqiured")
            ComboBox1.Focus()
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("Item is required")
            ComboBox2.Focus()
            Exit Sub

        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Quantity is required")
            TextBox2.Focus()
            Exit Sub

        End If
        ' For j = 0 To dgvSOitemsDetails.RowCount - 1
        ' items = dgvSOitemsDetails(3, j).Value.ToString
        '        items = dgvSOitemsDetails.Item(2, j).Value.ToString
        '       itemscheck = ComboBox2.Text
        '      If items = itemscheck Then
        'MessageBox.Show("You have already entered this item")
        '       ComboBox2.SelectedIndex = -1
        '      Exit Sub
        '     End If
        '    Next

        Dim itemsCount As Int32
        Dim amount, rate, quantity As Double
        itemsCount = dgvSOitemsDetails.RowCount
        dgvSOitemsDetails.Rows.Add()
        dgvSOitemsDetails.Rows(itemsCount - 1).Cells(0).Value = TextBox1.Text
        dgvSOitemsDetails.Rows(itemsCount - 1).Cells(1).Value = ComboBox1.Text
        dgvSOitemsDetails.Rows(itemsCount - 1).Cells(2).Value = DateTimePicker1.Text
        dgvSOitemsDetails.Rows(itemsCount - 1).Cells(3).Value = ComboBox2.Text
        dgvSOitemsDetails.Rows(itemsCount - 1).Cells(4).Value = TextBox2.Text
        dgvSOitemsDetails.Rows(itemsCount - 1).Cells(5).Value = TextBox3.Text
        rate = Convert.ToDouble(TextBox3.Text)
        quantity = Convert.ToDouble(TextBox2.Text)
        amount = rate * quantity
        total = total + amount
        TextBox5.Text = Convert.ToString(total)
        dgvSOitemsDetails.Rows(itemsCount - 1).Cells(6).Value = amount
        TextBox1.Enabled = False
        DateTimePicker1.Enabled = False
        ComboBox1.Enabled = False
        Button6.Enabled = False
        ComboBox2.SelectedIndex = -1
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim deduct As Decimal
        If dgvSOitemsDetails.SelectedRows.Count > 0 Then
            deduct = Convert.ToDecimal(dgvSOitemsDetails.SelectedRows(0).Cells(6).Value)
            total = total - deduct
            TextBox5.Text = Convert.ToString(total)
            dgvSOitemsDetails.Rows.Remove(dgvSOitemsDetails.SelectedRows(0))
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Remove Button")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sonumber, customer, item, comment, username As String
        Dim quantity, rate, amount As Decimal
        Dim sodate As Date
        Dim bulkinsert As New SAAEvoDatasetTableAdapters.SalesOrderDetailTableAdapter
        Dim insertSOSUmmary As New SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter
        Dim updateOldSONumber As New SAAEvoDatasetTableAdapters.SONumberCheckTableAdapter
        For j = 0 To (Me.dgvSOitemsDetails.RowCount - 1) - 1
            sonumber = dgvSOitemsDetails.Item(0, j).Value.ToString
            customer = dgvSOitemsDetails.Item(1, j).Value.ToString
            sodate = Convert.ToDateTime(dgvSOitemsDetails.Item(2, j).Value)
            item = dgvSOitemsDetails.Item(3, j).Value.ToString
            quantity = Convert.ToDecimal(dgvSOitemsDetails.Item(4, j).Value.ToString)
            rate = Convert.ToDecimal(dgvSOitemsDetails.Item(5, j).Value.ToString)
            amount = Convert.ToDecimal(dgvSOitemsDetails.Item(6, j).Value.ToString)
            comment = ""
            username = user
            bulkinsert.InsertQuery(sonumber, customer, sodate, item, quantity, rate, amount, comment, username, False, quantity, 0, dlocation, dstore, "", sodate, "CREDIT", 0, 0)
        Next
        insertSOSUmmary.InsertQuery(sonumber, customer, sodate, "OUTSTANDING", total, 0.0, user, "", dlocation, dstore)
        numcheck.UpdateQuerySONumber(newSONumber, dlocation, dstore)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sonumber, customer, item, comment, username As String
        Dim quantity, rate, amount As Decimal
        Dim sodate As Date
        Dim bulkinsert As New SAAEvoDatasetTableAdapters.SalesOrderDetailTableAdapter
        Dim insertSOSUmmary As New SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter
        Dim updateOldSONumber As New SAAEvoDatasetTableAdapters.SONumberCheckTableAdapter
        For j = 0 To (Me.dgvSOitemsDetails.RowCount - 1) - 1
            sonumber = dgvSOitemsDetails.Item(0, j).Value.ToString
            customer = dgvSOitemsDetails.Item(1, j).Value.ToString
            sodate = Convert.ToDateTime(dgvSOitemsDetails.Item(2, j).Value)
            item = dgvSOitemsDetails.Item(3, j).Value.ToString
            quantity = Convert.ToDecimal(dgvSOitemsDetails.Item(4, j).Value.ToString)
            rate = Convert.ToDecimal(dgvSOitemsDetails.Item(5, j).Value.ToString)
            amount = Convert.ToDecimal(dgvSOitemsDetails.Item(6, j).Value.ToString)
            comment = ""
            username = user
            bulkinsert.InsertQuery(sonumber, customer, sodate, item, quantity, rate, amount, comment, username, False, quantity, 0, dlocation, dstore, "", sodate, "CREDIT", 0, 0)
        Next

        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        dgvSOitemsDetails.Rows.Clear()
        insertSOSUmmary.InsertQuery(sonumber, customer, sodate, "OUTSTANDING", total, 0.0, user, "", dlocation, dstore)
        ' updateOldSONumber.UpdateOldSONumber(highestSONumber, oldSONumber)
        numcheck.UpdateQuerySONumber(newSONumber, dlocation, dstore)
        total = 0
        ' dt = highestQueryNumber.GetData()
        dt = numcheck.GetDataBySalesOrder(dlocation, dstore)
        oldSONumber = Convert.ToInt32(dt.Rows(0).Item(3).ToString)
        newSONumber = oldSONumber + 1
        str = Convert.ToString(newSONumber)
        dt1 = storeprfix.GetDataByPrefixx(dstore, dlocation)
        Dim pref = dt1.Rows(0).Item(5).ToString
        str = Trim(pref) + "SO" + str
        TextBox1.Text = str
        Button6.Enabled = True
        ComboBox1.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If ComboBox2.Text = "" Then
            MessageBox.Show("You need to select an item")
            ComboBox2.Focus()
            Exit Sub
        End If
        Dim prices As New SAAEvoDatasetTableAdapters.PricesTableAdapter
        Dim dtprices As DataTable
        dtprices = prices.GetData(ComboBox2.Text)
        TextBox3.Text = dtprices.Rows(0).Item(0).ToString
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox5.Text = FormatNumber(total, 2, TriState.True)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox5.Text = ""
        total = 0D
        dgvSOitemsDetails.Rows.Clear()
        ComboBox1.Enabled = True
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Enabled = True
        ComboBox2.SelectedIndex = -1
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class