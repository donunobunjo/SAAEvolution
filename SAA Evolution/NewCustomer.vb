Public Class NewCustomer

    Private Sub NewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Clasification' table. You can move, or remove it, as needed.
        Me.ClasificationTableAdapter.Fill(Me.SAAEvoDataset.Clasification)
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 40
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
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

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox10.Text.Contains(".") Then
                    If Me.TextBox10.Text.Split(".")(1).Length < 2 Then
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

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox11.Text.Contains(".") Then
                    If Me.TextBox11.Text.Split(".")(1).Length < 2 Then
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

    Private Sub TextBox5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox5.MouseDoubleClick

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox5.Text.Contains(".") Then
                    If Me.TextBox5.Text.Split(".")(1).Length < 2 Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cust As New SAAEvoDatasetTableAdapters.CustomerTableAdapter
        Dim dt As DataTable
        Dim email, sms As Boolean
        Dim openingbal, creditlimit As Decimal
        If TextBox9.Text = "" Then
            MessageBox.Show("Customer Number is required")
            TextBox9.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("Customer Name is required")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("Classification is required")
            ComboBox2.Focus()
            Exit Sub
        End If
        If TextBox4.Text = "" Then
            MessageBox.Show("Phone no. Name is required")
            TextBox4.Focus()
            Exit Sub
        End If
        dt = cust.GetDataDistinctNumAndName(TextBox9.Text, TextBox1.Text)
        If Not dt.Rows.Count = 0 Then
            MessageBox.Show("Either the customername or number exists in the database")
            TextBox1.Clear()
            TextBox9.Clear()
            TextBox9.Focus()
            Exit Sub
        End If
        If TextBox10.Text = "" Then
            openingbal = 0
        Else
            openingbal = Convert.ToDecimal(TextBox10.Text)
        End If
        If TextBox11.Text = "" Then
            creditlimit = 0
        Else
            creditlimit = Convert.ToDecimal(TextBox11.Text)
        End If
        If CheckBox1.Checked = True Then
            sms = True
        Else
            sms = False
        End If
        If CheckBox2.Checked = True Then
            email = True
        Else
            email = False
        End If
        cust.InsertQuery(TextBox9.Text, TextBox1.Text, TextBox2.Text, TextBox6.Text, TextBox8.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, ComboBox1.Text, ComboBox3.Text, openingbal, creditlimit, email, sms, True, ComboBox2.Text)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cust As New SAAEvoDatasetTableAdapters.CustomerTableAdapter
        Dim dt As DataTable
        Dim email, sms As Boolean
        Dim openingbal, creditlimit As Decimal
        If TextBox9.Text = "" Then
            MessageBox.Show("Customer Number is required")
            TextBox9.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("Customer Name is required")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MessageBox.Show("Classification is required")
            ComboBox2.Focus()
            Exit Sub
        End If
        If TextBox4.Text = "" Then
            MessageBox.Show("Phone no. Name is required")
            TextBox4.Focus()
            Exit Sub
        End If
        dt = cust.GetDataDistinctNumAndName(TextBox9.Text, TextBox1.Text)
        If Not dt.Rows.Count = 0 Then
            MessageBox.Show("Either the customername or number exists in the database")
            TextBox1.Clear()
            TextBox9.Clear()
            TextBox9.Focus()
            Exit Sub
        End If
        If TextBox10.Text = "" Then
            openingbal = 0
        Else
            openingbal = Convert.ToDecimal(TextBox10.Text)
        End If
        If TextBox11.Text = "" Then
            creditlimit = 0
        Else
            creditlimit = Convert.ToDecimal(TextBox11.Text)
        End If
        If CheckBox1.Checked = True Then
            sms = True
        Else
            sms = False
        End If
        If CheckBox2.Checked = True Then
            email = True
        Else
            email = False
        End If
        cust.InsertQuery(TextBox9.Text, TextBox1.Text, TextBox2.Text, TextBox6.Text, TextBox8.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, ComboBox1.Text, ComboBox3.Text, openingbal, creditlimit, email, sms, True, ComboBox2.Text)
        TextBox9.Clear()
        TextBox1.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox7.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox9.Focus()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class