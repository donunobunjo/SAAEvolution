Public Class itemsMain
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub itemsMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 200
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtDescription.Clear()
        txtItemCode.Clear()
        txtReOrderLevel.Clear()
        txtSKU.Clear()
        txtUnitPrice.Clear()
        txtItemCode.Focus()
    End Sub

    Private Sub cmbIncomeAcct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIncomeAcct.SelectedIndexChanged

    End Sub

    Private Sub Button5_Enter(sender As Object, e As EventArgs) Handles Button5.Enter

    End Sub

    Private Sub cmbIncomeAcct_Enter(sender As Object, e As EventArgs) Handles cmbIncomeAcct.Enter
        MessageBox.Show("This is related to the chart of acct, its still WIP")
    End Sub

    Private Sub cmbAssetAcct_Enter(sender As Object, e As EventArgs) Handles cmbAssetAcct.Enter
        MessageBox.Show("This is related to the chart of acct, its still WIP")
    End Sub

    Private Sub cmbIncomeAcct_LostFocus(sender As Object, e As EventArgs) Handles cmbIncomeAcct.LostFocus
        cmbIncomeAcct.Text = "Income"
    End Sub

    Private Sub cmbAssetAcct_LostFocus(sender As Object, e As EventArgs) Handles cmbAssetAcct.LostFocus
        cmbAssetAcct.Text = "Asset"
    End Sub

    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.txtUnitPrice.Text.Contains(".") Then
                    If Me.txtUnitPrice.Text.Split(".")(1).Length < 2 Then
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

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged

    End Sub

    Private Sub txtReOrderLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReOrderLevel.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.txtReOrderLevel.Text.Contains(".") Then
                    If Me.txtReOrderLevel.Text.Split(".")(1).Length < 2 Then
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

    Private Sub txtReOrderLevel_TextChanged(sender As Object, e As EventArgs) Handles txtReOrderLevel.TextChanged

    End Sub
End Class