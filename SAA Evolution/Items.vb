Public Class Items
    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.SAAEvoDataset.Brand)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 2
        cmbBrand.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim itemscount As Integer
        itemscount = dgvItems.RowCount
        If txtItemId.Text = "" Then
            MessageBox.Show("FPC Required")
            txtItemId.Focus()
            Exit Sub
        End If
        If txtDescription.Text = "" Then
            MessageBox.Show("Description Required")
            txtDescription.Focus()
            Exit Sub
        End If
        If cmbBrand.Text = "" Then
            MessageBox.Show("Brand Required")
            cmbBrand.Focus()
            Exit Sub
        End If
        If txtPrice.Text = "" Then
            MessageBox.Show("Cost Price Required")
            txtPrice.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("Selling Price Required")
            TextBox1.Focus()
            Exit Sub
        End If
        If txtSU.Text = "" Then
            MessageBox.Show("SU Required")
            txtSU.Focus()
            Exit Sub
        End If
        If txtCaseCount.Text = "" Then
            MessageBox.Show("Case Count Required")
            txtCaseCount.Focus()
            Exit Sub
        End If
        If txtSKU.Text = "" Then
            MessageBox.Show("SKU Required")
            txtSKU.Focus()
            Exit Sub
        End If
        dgvItems.Rows.Add()
        dgvItems.Rows(itemscount - 1).Cells(0).Value = txtItemId.Text
        dgvItems.Rows(itemscount - 1).Cells(1).Value = txtDescription.Text
        dgvItems.Rows(itemscount - 1).Cells(2).Value = cmbBrand.Text
        dgvItems.Rows(itemscount - 1).Cells(3).Value = txtPrice.Text
        dgvItems.Rows(itemscount - 1).Cells(4).Value = txtSU.Text
        dgvItems.Rows(itemscount - 1).Cells(5).Value = txtCaseCount.Text
        dgvItems.Rows(itemscount - 1).Cells(6).Value = txtSKU.Text
        dgvItems.Rows(itemscount - 1).Cells(7).Value = dtpDateOpened.Text
        dgvItems.Rows(itemscount - 1).Cells(8).Value = TextBox1.Text
        txtItemId.Clear()
        txtDescription.Clear()
        cmbBrand.SelectedIndex = -1
        txtPrice.Clear()
        txtCaseCount.Clear()
        txtSU.Clear()
        txtSKU.Clear()
        TextBox1.Clear()
        dtpDateOpened.Value = Today.Date
        txtItemId.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim fpc, description, brand, su, casecount, sku As String
        Dim quantity, price, sellingprice As Decimal
        Dim datecreated As Date
        Dim bulkinsert As New SAAEvoDatasetTableAdapters.ItemsTableAdapter
        For j = 0 To (Me.dgvItems.RowCount - 1) - 1
            fpc = dgvItems.Item(0, j).Value.ToString
            description = dgvItems.Item(1, j).Value.ToString
            brand = dgvItems.Item(2, j).Value.ToString
            price = Convert.ToDecimal(dgvItems.Item(3, j).Value.ToString)
            sellingprice = Convert.ToDecimal(dgvItems.Item(8, j).Value.ToString)
            su = dgvItems.Item(4, j).Value.ToString
            casecount = Convert.ToDecimal(dgvItems.Item(5, j).Value)
            datecreated = Convert.ToDateTime(dgvItems.Item(7, j).Value)
            quantity = 0
            sku = dgvItems.Item(6, j).Value.ToString
            bulkinsert.InsertQuery(fpc, description, brand, price, su, casecount, quantity, datecreated, sku, sellingprice)

        Next
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim fpc, description, brand, su, casecount, sku As String
        Dim quantity, price, sellingprice As Decimal
        Dim datecreated As Date
        Dim bulkinsert As New SAAEvoDatasetTableAdapters.ItemsTableAdapter
        For j = 0 To (Me.dgvItems.RowCount - 1) - 1
            fpc = dgvItems.Item(0, j).Value.ToString
            description = dgvItems.Item(1, j).Value.ToString
            brand = dgvItems.Item(2, j).Value.ToString
            price = Convert.ToDecimal(dgvItems.Item(3, j).Value.ToString)
            su = dgvItems.Item(4, j).Value.ToString
            casecount = Convert.ToDecimal(dgvItems.Item(5, j).Value)
            datecreated = Convert.ToDateTime(dgvItems.Item(7, j).Value)
            quantity = 0
            sku = dgvItems.Item(6, j).Value.ToString
            sellingprice = Convert.ToDecimal(dgvItems.Item(8, j).Value.ToString)
            bulkinsert.InsertQuery(fpc, description, brand, price, su, casecount, quantity, datecreated, sku, sellingprice)
        Next
        dgvItems.Rows.Clear()
        txtItemId.Clear()
        txtDescription.Clear()
        cmbBrand.SelectedIndex = -1
        txtSKU.Clear()
        txtPrice.Clear()
        txtSU.Clear()
        txtCaseCount.Clear()
        txtItemId.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If dgvItems.SelectedRows.Count > 0 Then
            dgvItems.Rows.Remove(dgvItems.SelectedRows(0))
        Else
            MessageBox.Show("Select a row, by clicking the row marker, before you hit Remove Button")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dgvItems.Rows.Clear()
        txtItemId.Clear()
        txtDescription.Clear()
        cmbBrand.SelectedIndex = -1
        txtPrice.Clear()
        txtCaseCount.Clear()
        txtSU.Clear()
        TextBox1.Clear()
        dtpDateOpened.Value = Today.Date
        txtItemId.Focus()
    End Sub

    Private Sub dgvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.txtPrice.Text.Contains(".") Then
                    If Me.txtPrice.Text.Split(".")(1).Length < 2 Then
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

    Private Sub txtSU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSU.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.txtSU.Text.Contains(".") Then
                    If Me.txtSU.Text.Split(".")(1).Length < 2 Then
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
End Class