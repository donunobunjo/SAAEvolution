Public Class NewVendor
    Public Property user As String
    Public Property dlocation As String
    Public Property dstore As String

    Private Sub NewVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 40

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vendor As New SAAEvoDatasetTableAdapters.VendorTableAdapter
        Dim dt As DataTable
        Dim email, sms As Boolean
        Dim openingbal, creditlimit As Decimal
        If TextBox9.Text = "" Then
            MessageBox.Show("Vendor Number is required")
            TextBox9.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("Vendor Name is required")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            MessageBox.Show("Phone no.  is required")
            TextBox4.Focus()
            Exit Sub
        End If
        dt = vendor.GetDataDistinctNumAndName(TextBox9.Text, TextBox1.Text)
        If Not dt.Rows.Count = 0 Then
            MessageBox.Show("Either the Vendorname or number exists in the database")
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
        '  cust.InsertQuery(TextBox9.Text, TextBox1.Text, TextBox2.Text, TextBox6.Text, TextBox8.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, ComboBox1.Text, ComboBox3.Text, openingbal, creditlimit, email, sms, True, ComboBox2.Text)
        vendor.InsertQuery(TextBox9.Text, TextBox1.Text, TextBox2.Text, TextBox6.Text, TextBox8.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, ComboBox1.Text, ComboBox3.Text, openingbal, creditlimit, email, sms, True, "Normal")
        TextBox9.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox7.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        ComboBox1.SelectedIndex = -1
        TextBox9.Focus()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vendor As New SAAEvoDatasetTableAdapters.VendorTableAdapter
        Dim dt As DataTable
        Dim email, sms As Boolean
        Dim openingbal, creditlimit As Decimal
        If TextBox9.Text = "" Then
            MessageBox.Show("Vendor Number is required")
            TextBox9.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("Vendor Name is required")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            MessageBox.Show("Phone no.  is required")
            TextBox4.Focus()
            Exit Sub
        End If
        dt = vendor.GetDataDistinctNumAndName(TextBox9.Text, TextBox1.Text)
        If Not dt.Rows.Count = 0 Then
            MessageBox.Show("Either the Vendorname or number exists in the database")
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
        '  cust.InsertQuery(TextBox9.Text, TextBox1.Text, TextBox2.Text, TextBox6.Text, TextBox8.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, ComboBox1.Text, ComboBox3.Text, openingbal, creditlimit, email, sms, True, ComboBox2.Text)
        vendor.InsertQuery(TextBox9.Text, TextBox1.Text, TextBox2.Text, TextBox6.Text, TextBox8.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, ComboBox1.Text, ComboBox3.Text, openingbal, creditlimit, email, sms, True, "Normal")
        Me.Close()
    End Sub
End Class