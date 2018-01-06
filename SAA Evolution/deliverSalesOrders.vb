Public Class deliverSalesOrders
    Public Property user As String
    Public Property sonumber As String
    Public Property customer As String
    Public Property dlocation As String
    Public Property dstore As String
    Dim w, x, y, z As Decimal
    Dim invnum As New SAAEvoDatasetTableAdapters.NumberChecksTableAdapter
    Dim storePrfix As New SAAEvoDatasetTableAdapters.StoreTableAdapter
    Dim oldSalesInvoiceNumber As Integer
    Dim newSalesInvoiceNumber As Integer
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim str As String
    Dim prinnt As New PrintSalesInvoice
    
    Private Sub deliverSalesOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SalesOrderDetailTableAdapter.FillBySalesOrder(Me.SAAEvoDataset.SalesOrderDetail, sonumber, customer)
        TextBox1.Text = customer
        TextBox2.Text = sonumber
        dt = invnum.GetDataBySalesInvoice(dlocation, dstore)
        oldSalesInvoiceNumber = Convert.ToInt32(dt.Rows(0).Item(4).ToString)
        newSalesInvoiceNumber = oldSalesInvoiceNumber + 1
        str = Convert.ToString(newSalesInvoiceNumber)
        dt1 = storePrfix.GetDataByPrefixx(dstore, dlocation)
        Dim pref = dt1.Rows(0).Item(5).ToString
        str = Trim(pref) + "SI" + str
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '''''''newww
        Dim sonumber1, customer1, item1, comment1, SInumber1 As String
        Dim quantity1, rate1, amount1 As Decimal
        Dim Invdate As Date
        Dim BulkSInv As New SAAEvoDatasetTableAdapters.SalesInvoiceTableAdapter




        '''''''''''''
        Dim percentTax As Decimal
        Dim percentDiscount As Decimal
        Dim actualTax As Decimal
        Dim actualDiscount As Decimal
        Dim cnt As Int32
        Dim source As String
        Dim item As String
        Dim deldate As Date
        Dim issue As Decimal
        Dim destination As String
        Dim bulkins As New SAAEvoDatasetTableAdapters.ItemTransTableAdapter
        Dim dtDeliveredComplete As DataTable
        Dim dtAllItemInSalesOrder As DataTable
        Dim delivedComplete As New SAAEvoDatasetTableAdapters.SalesOrderDetailTableAdapter
        cnt = DataGridView1.RowCount
        For j = 0 To (cnt - 1)
            w = Convert.ToDecimal(DataGridView1.Item(2, j).Value.ToString)
            Try
                x = Convert.ToDecimal(DataGridView1.Item(3, j).Value.ToString)
            Catch
                x = 0D
            End Try
            y = Convert.ToDecimal(DataGridView1.Item(11, j).Value.ToString)
            z = Convert.ToDecimal(DataGridView1.Item(12, j).Value.ToString)
            If z = 0 Then
                w = w - x
                DataGridView1.Item(2, j).Value = w.ToString
                DataGridView1.Item(12, j).Value = x.ToString
                z = x
            Else
                w = w - x
                z = x + z
                DataGridView1.Item(2, j).Value = w.ToString
                DataGridView1.Item(12, j).Value = z.ToString
            End If
            If y = z Then
                DataGridView1.Item(13, j).Value = True
            End If
            DataGridView1.Item(14, j).Value = str
            source = dstore

            item = DataGridView1.Item(1, j).Value.ToString
            deldate = DateTimePicker1.Value
            issue = Convert.ToDecimal(DataGridView1.Item(3, j).Value)
            destination = customer
            bulkins.InsertQuery(item, deldate, 0, issue, 0, "", dlocation, dstore, "", 0, source, destination, user)

        Next
        Me.SalesOrderDetailTableAdapter.Update(Me.SAAEvoDataset.SalesOrderDetail)
        ''''''''''''''
        'new
        For j = 0 To (Me.DataGridView1.RowCount - 1)
            sonumber1 = DataGridView1.Item(7, j).Value.ToString
            SInumber1 = DataGridView1.Item(7, j).Value.ToString
            item1 = DataGridView1.Item(1, j).Value.ToString
            customer1 = DataGridView1.Item(6, j).Value.ToString
            Try
                quantity1 = Convert.ToDecimal(DataGridView1.Item(3, j).Value.ToString)
            Catch
                quantity1 = 0
            End Try
            rate1 = Convert.ToDecimal(DataGridView1.Item(4, j).Value.ToString)
            ' amount1 = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            amount1 = quantity1 * rate1
            If TextBox3.Text = "" Then
                percentDiscount = 0
            Else
                percentDiscount = Convert.ToDecimal(TextBox3.Text)
            End If
            If TextBox4.Text = "" Then
                percentTax = 0
            Else

                percentTax = Convert.ToDecimal(TextBox4.Text)
            End If
            actualDiscount = (percentDiscount / 100) * amount1
            actualTax = (percentTax / 100) * amount1
            BulkSInv.InsertQuery(str, sonumber, DateTimePicker1.Value, customer1, item1, quantity1, rate1, amount1, dlocation, dstore, actualDiscount, actualTax, user, "CREDIT")
        Next
        ''''''''''''''
        dtDeliveredComplete = delivedComplete.GetDataByDeliveredComplete(sonumber)
        dtAllItemInSalesOrder = delivedComplete.GetDataByAllItemsInAsalesOrder(sonumber)
        Dim all As Int32
        Dim del As Int32
        del = dtDeliveredComplete.Rows.Count
        all = dtAllItemInSalesOrder.Rows.Count
        If del = all Then
            ' MessageBox.Show("Fulfilled")
            Me.SalesOrderSummaryTableAdapter.UpdateQuery("FULFILLED", sonumber)
        Else
            'MessageBox.Show("Partial")
            Me.SalesOrderSummaryTableAdapter.UpdateQuery("PARTIAL", sonumber)
        End If
        invnum.UpdateQuerySINumber(newSalesInvoiceNumber, dlocation, dstore)
        '  MessageBox.Show("Database Updated")
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

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

    Private Sub DataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        '       If e.ColumnIndex = 3 Then
        '' w = Convert.ToDecimal(DataGridView1.Item(2, j).Value.ToString)
        '       w = Convert.ToDecimal(DataGridView1.CurrentRow.Cells.Item(2).ToString)
        '      Try
        ' x = Convert.ToDecimal(DataGridView1.Item(3, j).Value.ToString)
        '       x = Convert.ToDecimal(DataGridView1.CurrentRow.Cells.Item(3).ToString)
        '      Catch
        'x = 0D
        '        End Try
        ' y = Convert.ToDecimal(DataGridView1.Item(11, j).Value.ToString)
        ' y = Convert.ToDecimal(DataGridView1.CurrentRow.Cells.Item(11).ToString)
        ' z = Convert.ToDecimal(DataGridView1.Item(12, j).Value.ToString)
        'z = Convert.ToDecimal(DataGridView1.CurrentRow.Cells.Item(12).ToString)
        'MessageBox.Show("Yayayayayay")

        'End If

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        '       If e.ColumnIndex = 3 Then
        '       w = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
        '      x = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
        '     '        'MessageBox.Show("cell end edit")
        '    If x > w Then
        '       MessageBox.Show("Quantity Recieved can't be greater than quantity ordered")
        '      '         DataGridView1.Rows(e.RowIndex).Cells(3).Selected = True

        '' 'DataGridView1.CurrentCell = DataGridView1.CurrentRow.Cells(3)
        '''Exit Sub
        '''  e.Cancel = True
        ' End If

        '        End If



    End Sub

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        Dim itemtran As New SAAEvoDatasetTableAdapters.ItemTransTableAdapter
        Dim headerText As String = DataGridView1.Columns(e.ColumnIndex).HeaderText
        Dim dtIssue As DataTable
        Dim dtRecieved As DataTable
        Dim issued As Decimal
        Dim recieved As Decimal
        Dim bal As Decimal
        Dim item As String
        If Not headerText.Equals("Qty Delivered") Then Return
        item = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        dtIssue = itemtran.getTIssued(dlocation, dstore, item)
        dtRecieved = itemtran.GetTRecieved(dlocation, dstore, item)
        issued = Convert.ToDecimal(dtIssue.Rows(0).Item(0).ToString)
        recieved = Convert.ToDecimal(dtRecieved(0).Item(0).ToString)
        bal = recieved - issued

        ' w = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
        ' x = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
        'x = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
        '        'MessageBox.Show("cell end edit")
        '        If x > w Then
        '      MessageBox.Show("Quantity Delivered can't be greater than quantity ordered")

        'e.Cancel = True
        ' End If
        Debug.Print(issued)
        Debug.Print("Hello")
        Debug.Print(recieved)
    End Sub

    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
       
    End Sub

    Private Sub DataGridView1_Validated(sender As Object, e As EventArgs) Handles DataGridView1.Validated

    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

            End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        '''''''newww
        Dim sonumber1, customer1, item1, comment1, SInumber1 As String
        Dim quantity1, rate1, amount1 As Decimal
        Dim Invdate As Date
        Dim BulkSInv As New SAAEvoDatasetTableAdapters.SalesInvoiceTableAdapter




        '''''''''''''
        Dim percentTax As Decimal
        Dim percentDiscount As Decimal
        Dim actualTax As Decimal
        Dim actualDiscount As Decimal
        Dim cnt As Int32
        Dim source As String
        Dim item As String
        Dim deldate As Date
        Dim issue As Decimal
        Dim destination As String
        Dim bulkins As New SAAEvoDatasetTableAdapters.ItemTransTableAdapter
        Dim dtDeliveredComplete As DataTable
        Dim dtAllItemInSalesOrder As DataTable
        Dim delivedComplete As New SAAEvoDatasetTableAdapters.SalesOrderDetailTableAdapter
        cnt = DataGridView1.RowCount
        For j = 0 To (cnt - 1)
            w = Convert.ToDecimal(DataGridView1.Item(2, j).Value.ToString)
            Try
                x = Convert.ToDecimal(DataGridView1.Item(3, j).Value.ToString)
            Catch
                x = 0D
            End Try
            y = Convert.ToDecimal(DataGridView1.Item(11, j).Value.ToString)
            z = Convert.ToDecimal(DataGridView1.Item(12, j).Value.ToString)
            If z = 0 Then
                w = w - x
                DataGridView1.Item(2, j).Value = w.ToString
                DataGridView1.Item(12, j).Value = x.ToString
                z = x
            Else
                w = w - x
                z = x + z
                DataGridView1.Item(2, j).Value = w.ToString
                DataGridView1.Item(12, j).Value = z.ToString
            End If
            If y = z Then
                DataGridView1.Item(13, j).Value = True
            End If
            DataGridView1.Item(14, j).Value = str
            source = dstore

            item = DataGridView1.Item(1, j).Value.ToString
            deldate = DateTimePicker1.Value
            issue = Convert.ToDecimal(DataGridView1.Item(3, j).Value)
            destination = customer
            bulkins.InsertQuery(item, deldate, 0, issue, 0, "", dlocation, dstore, "", 0, source, destination, user)

        Next
        Me.SalesOrderDetailTableAdapter.Update(Me.SAAEvoDataset.SalesOrderDetail)
        ''''''''''''''
        'new
        For j = 0 To (Me.DataGridView1.RowCount - 1)
            sonumber1 = DataGridView1.Item(7, j).Value.ToString
            SInumber1 = DataGridView1.Item(7, j).Value.ToString
            item1 = DataGridView1.Item(1, j).Value.ToString
            customer1 = DataGridView1.Item(6, j).Value.ToString
            Try
                quantity1 = Convert.ToDecimal(DataGridView1.Item(3, j).Value.ToString)
            Catch
                quantity1 = 0
            End Try
            rate1 = Convert.ToDecimal(DataGridView1.Item(4, j).Value.ToString)
            ' amount1 = Convert.ToDecimal(DataGridView1.Item(5, j).Value.ToString)
            amount1 = quantity1 * rate1
            If TextBox3.Text = "" Then
                percentDiscount = 0
            Else
                percentDiscount = Convert.ToDecimal(TextBox3.Text)
            End If
            If TextBox4.Text = "" Then
                percentTax = 0
            Else

                percentTax = Convert.ToDecimal(TextBox4.Text)
            End If
            actualDiscount = (percentDiscount / 100) * amount1
            actualTax = (percentTax / 100) * amount1
            BulkSInv.InsertQuery(str, sonumber, DateTimePicker1.Value, customer1, item1, quantity1, rate1, amount1, dlocation, dstore, actualDiscount, actualTax, user, "CREDIT")
        Next
        ''''''''''''''
        dtDeliveredComplete = delivedComplete.GetDataByDeliveredComplete(sonumber)
        dtAllItemInSalesOrder = delivedComplete.GetDataByAllItemsInAsalesOrder(sonumber)
        Dim all As Int32
        Dim del As Int32
        del = dtDeliveredComplete.Rows.Count
        all = dtAllItemInSalesOrder.Rows.Count
        If del = all Then
            ' MessageBox.Show("Fulfilled")
            Me.SalesOrderSummaryTableAdapter.UpdateQuery("FULFILLED", sonumber)
        Else
            'MessageBox.Show("Partial")
            Me.SalesOrderSummaryTableAdapter.UpdateQuery("PARTIAL", sonumber)
        End If
        invnum.UpdateQuerySINumber(newSalesInvoiceNumber, dlocation, dstore)
        '  MessageBox.Show("Database Updated")
        prinnt.invNumber = str
        prinnt.ShowDialog()
        Me.Close()
    End Sub
End Class