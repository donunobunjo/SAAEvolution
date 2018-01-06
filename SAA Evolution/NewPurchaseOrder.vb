Public Class NewPurchaseOrder
    Public Property user As String
    Public Property dlocation As String
    Public Property dstore As String
    Dim total As Decimal
    Dim newPONumber As Int32?
    Dim oldPONumber As Int32?
    Dim numcheck As New SAAEvoDatasetTableAdapters.NumberChecksTableAdapter
    Dim insertPOSummary As New SAAEvoDatasetTableAdapters.PurchaseOrderSummaryTableAdapter
    Dim storeprfix As New SAAEvoDatasetTableAdapters.StoreTableAdapter
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim str As String
    Private Sub NewSalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Vendor' table. You can move, or remove it, as needed.
        Me.VendorTableAdapter.Fill(Me.SAAEvoDataset.Vendor)


        Me.ItemsTableAdapter.Fill(Me.SAAEvoDataset.Items)
        ' Me.CustomerTableAdapter.Fill(Me.SAAEvoDataset.Customer)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 1
        dt = numcheck.GetDataByPurchaseOrder(dlocation, dstore)
        ' oldSONumber = Convert.ToInt32(dt.Rows(0).Item(0))
        oldPONumber = Convert.ToInt32(dt.Rows(0).Item(5).ToString)
        newPONumber = oldPONumber + 1
        str = Convert.ToString(newPONumber)
        dt1 = storeprfix.GetDataByPrefixx(dstore, dlocation)
        Dim pref = dt1.Rows(0).Item(5).ToString
        str = Trim(pref) + "PO" + str
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
        If ComboBox1.Text = "" Then
            MessageBox.Show("Vendor is reqiured")
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
        Dim itemsCount As Int32
        Dim amount, rate, quantity As Double
        itemsCount = dgvPOitemsDetails.RowCount
        dgvPOitemsDetails.Rows.Add()
        dgvPOitemsDetails.Rows(itemsCount - 1).Cells(0).Value = TextBox1.Text
        dgvPOitemsDetails.Rows(itemsCount - 1).Cells(1).Value = ComboBox1.Text
        dgvPOitemsDetails.Rows(itemsCount - 1).Cells(2).Value = DateTimePicker1.Text
        dgvPOitemsDetails.Rows(itemsCount - 1).Cells(3).Value = ComboBox2.Text
        dgvPOitemsDetails.Rows(itemsCount - 1).Cells(4).Value = TextBox2.Text
        dgvPOitemsDetails.Rows(itemsCount - 1).Cells(5).Value = TextBox3.Text
        rate = Convert.ToDouble(TextBox3.Text)
        quantity = Convert.ToDouble(TextBox2.Text)
        amount = rate * quantity
        total = total + amount
        TextBox5.Text = Convert.ToString(total)
        dgvPOitemsDetails.Rows(itemsCount - 1).Cells(6).Value = amount
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
        If dgvPOitemsDetails.SelectedRows.Count > 0 Then
            deduct = Convert.ToDecimal(dgvPOitemsDetails.SelectedRows(0).Cells(6).Value)
            total = total - deduct
            TextBox5.Text = Convert.ToString(total)
            dgvPOitemsDetails.Rows.Remove(dgvPOitemsDetails.SelectedRows(0))
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Remove Button")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ponumber, vendor, item, comment, username As String
        Dim quantity, rate, amount As Decimal
        Dim podate As Date
        Dim bulkinsert As New SAAEvoDatasetTableAdapters.PurchaseOrderDetailTableAdapter
        Dim insertPOSUmmary As New SAAEvoDatasetTableAdapters.PurchaseOrderSummaryTableAdapter
        Dim updateOldSONumber As New SAAEvoDatasetTableAdapters.SONumberCheckTableAdapter
        For j = 0 To (Me.dgvPOitemsDetails.RowCount - 1) - 1
            ponumber = dgvPOitemsDetails.Item(0, j).Value.ToString
            vendor = dgvPOitemsDetails.Item(1, j).Value.ToString
            podate = Convert.ToDateTime(dgvPOitemsDetails.Item(2, j).Value)
            item = dgvPOitemsDetails.Item(3, j).Value.ToString
            quantity = Convert.ToDecimal(dgvPOitemsDetails.Item(4, j).Value.ToString)
            rate = Convert.ToDecimal(dgvPOitemsDetails.Item(5, j).Value.ToString)
            amount = Convert.ToDecimal(dgvPOitemsDetails.Item(6, j).Value.ToString)
            comment = ""
            username = user
            bulkinsert.InsertQuery(ponumber, vendor, podate, item, quantity, rate, amount, comment, username, False, quantity, 0, dlocation, dstore, "", podate, "CREDIT", 0, 0)
        Next
        insertPOSUmmary.InsertQuery(ponumber, vendor, podate, "OUTSTANDING", total, 0.0, user, "", dstore, dlocation)
        numcheck.UpdateQueryPONumber(newPONumber, dlocation, dstore)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ponumber, vendor, item, comment, username As String
        Dim quantity, rate, amount As Decimal
        Dim podate As Date
        Dim bulkinsert As New SAAEvoDatasetTableAdapters.PurchaseOrderDetailTableAdapter
        Dim insertPOSUmmary As New SAAEvoDatasetTableAdapters.PurchaseOrderSummaryTableAdapter
        Dim updateOldSONumber As New SAAEvoDatasetTableAdapters.SONumberCheckTableAdapter
        For j = 0 To (Me.dgvPOitemsDetails.RowCount - 1) - 1
            ponumber = dgvPOitemsDetails.Item(0, j).Value.ToString
            vendor = dgvPOitemsDetails.Item(1, j).Value.ToString
            podate = Convert.ToDateTime(dgvPOitemsDetails.Item(2, j).Value)
            item = dgvPOitemsDetails.Item(3, j).Value.ToString
            quantity = Convert.ToDecimal(dgvPOitemsDetails.Item(4, j).Value.ToString)
            rate = Convert.ToDecimal(dgvPOitemsDetails.Item(5, j).Value.ToString)
            amount = Convert.ToDecimal(dgvPOitemsDetails.Item(6, j).Value.ToString)
            comment = ""
            username = user
            bulkinsert.InsertQuery(ponumber, vendor, podate, item, quantity, rate, amount, comment, username, False, quantity, 0, dlocation, dstore, "", podate, "CREDIT", 0, 0)
        Next

        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox2.Clear()
        TextBox3.Clear()
        ' TextBox5.ReadOnly = False
        TextBox5.Clear()
        ' TextBox5.ReadOnly = True
        dgvPOitemsDetails.Rows.Clear()
        insertPOSUmmary.InsertQuery(ponumber, vendor, podate, "OUTSTANDING", total, 0.0, user, "", dstore, dlocation)
        numcheck.UpdateQueryPONumber(newPONumber, dlocation, dstore)
        total = 0
        ' dt = highestQueryNumber.GetData()
        ' dt = numcheck.GetDataBySalesOrder(dlocation, dstore)
        dt = numcheck.GetDataBypurchaseOrder(dlocation, dstore)
        oldPONumber = Convert.ToInt32(dt.Rows(0).Item(5).ToString)
        newPONumber = oldPONumber + 1
        str = Convert.ToString(newPONumber)
        dt1 = storeprfix.GetDataByPrefixx(dstore, dlocation)
        Dim pref = dt1.Rows(0).Item(5).ToString
        str = Trim(pref) + "PO" + str
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
        dgvPOitemsDetails.Rows.Clear()
        ComboBox1.Enabled = True
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Enabled = True
        ComboBox2.SelectedIndex = -1
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Label9_TextChanged(sender As Object, e As EventArgs)
    End Sub
End Class