Public Class SalesReciept
    Public Property user As String
    Public Property dlocation As String
    Public Property dstore As String

    Dim total As Decimal
    Dim newCashSalesInvNumber As Int32?
    Dim oldCashSalesInvNumber As Int32?
    Dim numcheck As New SAAEvoDatasetTableAdapters.NumberChecksTableAdapter
    Dim storeprfix As New SAAEvoDatasetTableAdapters.StoreTableAdapter
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim str As String
    Private Sub NewSalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.SAAEvoDataset.Items)
        Me.CustomerTableAdapter.Fill(Me.SAAEvoDataset.Customer)
        Me.CenterToScreen()
        Me.Top = 1
        dt = numcheck.GetDataByCashSalesInvoice(dlocation, dstore)
        oldCashSalesInvNumber = Convert.ToInt32(dt.Rows(0).Item(7))
        newCashSalesInvNumber = oldCashSalesInvNumber + 1
        str = Convert.ToString(newCashSalesInvNumber)
        dt1 = storeprfix.GetDataByPrefixx(dstore, dlocation)
        Dim pref = dt1.Rows(0).Item(5).ToString
        str = Trim(pref) + "CSI" + str
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
        Dim itemsCount As Int32
        Dim amount, rate, quantity As Double
        itemsCount = dgvSOitemsDetails.RowCount
        dgvSOitemsDetails.Rows.Add()
        dgvSOitemsDetails.Rows(itemsCount - 1).Cells(0).Value = TextBox1.Text
        If ComboBox1.Text = "" Then
            dgvSOitemsDetails.Rows(itemsCount - 1).Cells(1).Value = "Anonymous"
        Else
            dgvSOitemsDetails.Rows(itemsCount - 1).Cells(1).Value = ComboBox1.Text
        End If
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
      
        TextBox4.Enabled = False
        TextBox6.Enabled = False
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
        Dim salesReciept As New rptSalesReciept
        '''''''''''''''''''''''''''''''''''
        Dim sonumber1, customer1, item1, comment1, SInumber1 As String
        Dim quantity1, rate1, amount1 As Decimal
        Dim Invdate As Date
        Dim BulkSInv As New SAAEvoDatasetTableAdapters.SalesInvoiceTableAdapter


        ''''''new''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim sonumber, customer, item, comment, username As String
        Dim quantity, rate, amount, discount, tax, txt4, txt6 As Decimal
        Dim sodate As Date
        Dim bulkinsert As New SAAEvoDatasetTableAdapters.SalesOrderDetailTableAdapter
        Dim insertSOSUmmary As New SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter
        Dim updateCashSI As New SAAEvoDatasetTableAdapters.NumberChecksTableAdapter
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
            If TextBox4.Text = "" Then
                discount = 0
            Else
                txt4 = Convert.ToDecimal(TextBox4.Text)
                discount = (txt4 / 100) * amount
            End If
            If TextBox6.Text = "" Then
                tax = 0
            Else
                txt6 = Convert.ToDecimal(TextBox6.Text)
                tax = (txt6 / 100) * amount
            End If
            bulkinsert.InsertQuery(sonumber, customer, sodate, item, 0, rate, amount, comment, username, True, quantity, quantity, dlocation, dstore, "", sodate, "CASH", discount, tax)
        Next
        ''''''''''''''''''''''
        For j = 0 To (Me.dgvSOitemsDetails.RowCount - 1) - 1
           
            item1 = dgvSOitemsDetails.Item(3, j).Value.ToString
            customer1 = dgvSOitemsDetails.Item(1, j).Value.ToString
            Try
                quantity1 = Convert.ToDecimal(dgvSOitemsDetails.Item(4, j).Value.ToString)
            Catch
                quantity1 = 0
            End Try
            rate1 = Convert.ToDecimal(dgvSOitemsDetails.Item(5, j).Value.ToString)

            amount1 = quantity1 * rate1
            BulkSInv.InsertQuery(str, "", DateTimePicker1.Value, customer1, item1, quantity1, rate1, amount1, dlocation, dstore, discount, tax, user, "CASH")
        Next
        ''''''''new
        
        updateCashSI.UpdateQueryCashSI(newCashSalesInvNumber, dlocation, dstore)
        salesReciept.invnum = TextBox1.Text
        ' salesReciept.MdiParent = Main
        salesReciept.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''''''nnnneeeewwwwww
        Dim sonumber1, customer1, item1, comment1, SInumber1 As String
        Dim quantity1, rate1, amount1 As Decimal
        Dim Invdate As Date
        Dim BulkSInv As New SAAEvoDatasetTableAdapters.SalesInvoiceTableAdapter
        ''''''''''''''''

        Dim sonumber, customer, item, comment, username As String
        Dim quantity, rate, amount, discount, tax, txt4, txt6 As Decimal
        Dim sodate As Date
        Dim bulkinsert As New SAAEvoDatasetTableAdapters.SalesOrderDetailTableAdapter
        Dim insertSOSUmmary As New SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter
        Dim updateOldSONumber As New SAAEvoDatasetTableAdapters.SalesInvNumberCheckTableAdapter
        Dim updateCashSI As New SAAEvoDatasetTableAdapters.NumberChecksTableAdapter
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
            If TextBox4.Text = "" Then
                discount = 0
            Else
                txt4 = Convert.ToDecimal(TextBox4.Text)
                discount = (txt4 / 100) * amount
            End If
            If TextBox6.Text = "" Then
                tax = 0
            Else
                txt6 = Convert.ToDecimal(TextBox6.Text)
                tax = (txt6 / 100) * amount
            End If
            bulkinsert.InsertQuery(sonumber, customer, sodate, item, 0, rate, amount, comment, username, True, quantity, quantity, dlocation, dstore, "", sodate, "CASH", discount, tax)
        Next
        For j = 0 To (Me.dgvSOitemsDetails.RowCount - 1) - 1
            ' sonumber1 = dgvSOitemsDetails.Item(0, j).Value.ToString
            ' SInumber1 = dgvSOitemsDetails.Item(7, j).Value.ToString
            item1 = dgvSOitemsDetails.Item(3, j).Value.ToString
            customer1 = dgvSOitemsDetails.Item(1, j).Value.ToString
            Try
                quantity1 = Convert.ToDecimal(dgvSOitemsDetails.Item(4, j).Value.ToString)
            Catch
                quantity1 = 0
            End Try
            rate1 = Convert.ToDecimal(dgvSOitemsDetails.Item(5, j).Value.ToString)
            ' amount1 = Convert.ToDecimal(dgvSOitemsDetails.Item(6, j).Value.ToString)
            amount1 = rate1 * quantity1
            BulkSInv.InsertQuery(str, "", DateTimePicker1.Value, customer1, item1, quantity1, rate1, amount1, dlocation, dstore, discount, tax, user, "CASH")
        Next
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        dgvSOitemsDetails.Rows.Clear()
        '  insertSOSUmmary.InsertQuery(sonumber, customer, sodate, "FULFILLED", total, 0.0, user, "")
        'updateOldSONumber.UpdateQuery(newSalesInvNumber, oldSalesInvNumber)
        updateCashSI.UpdateQueryCashSI(newCashSalesInvNumber, dlocation, dstore)
        total = 0
        dt = numcheck.GetDataByCashSalesInvoice(dlocation, dstore)
        oldCashSalesInvNumber = Convert.ToInt32(dt.Rows(0).Item(7))
        newCashSalesInvNumber = oldCashSalesInvNumber + 1
        str = Convert.ToString(newCashSalesInvNumber)
        dt1 = storeprfix.GetDataByPrefixx(dstore, dlocation)
        Dim pref = dt1.Rows(0).Item(5).ToString
        str = Trim(pref) + "CSI" + str
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

   
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox4.Text.Contains(".") Then
                    If Me.TextBox4.Text.Split(".")(1).Length < 2 Then
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

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox6.Text.Contains(".") Then
                    If Me.TextBox6.Text.Split(".")(1).Length < 2 Then
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox5.Text = FormatNumber(total, 2, TriState.True)
    End Sub
End Class