Public Class NewVendorModal
    Dim VendorNumberCheck As New SAAEvoDatasetTableAdapters.VendorNumberCheckTableAdapter
    Dim mydt As DataTable
    Dim highestVendorNumber As Int32?
    Dim oldVendorNumber As Int32?
    Dim NewVendorNumber As String
    Dim vendorNumber, fullname, company, website, address, email, mobile, fax, street, state, acct As String
    Dim openingbal, creditlimit As Decimal?
    Dim smspreference, emailpreference, inactive As Boolean
    Private Sub NewVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.MdiParent = Main
        'Me.ParentForm = NewVendor

        Me.CenterToScreen()
        Me.Top = 100
        mydt = VendorNumberCheck.GetData()
        oldVendorNumber = Convert.ToInt32(mydt.Rows(0).Item(0))
        highestVendorNumber = oldVendorNumber + 1
        NewVendorNumber = Convert.ToString(highestVendorNumber)
        NewVendorNumber = "VN" + NewVendorNumber
        TextBox9.Text = NewVendorNumber
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '  Dim insertvendor = New SAAEvoDatasetTableAdapters.VendorTableAdapter
        vendorNumber = TextBox9.Text
        fullname = TextBox1.Text
        company = TextBox2.Text
        website = TextBox6.Text
        address = TextBox8.Text
        email = TextBox3.Text
        mobile = TextBox4.Text
        fax = TextBox5.Text
        street = TextBox7.Text
        state = ComboBox1.Text
        acct = ComboBox3.Text
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
        If CheckBox1.Checked Then
            smspreference = True
        Else
            smspreference = False
        End If
        If CheckBox2.Checked Then
            emailpreference = True
        Else
            emailpreference = False
        End If
        If CheckBox3.Checked Then
            inactive = True
        Else
            inactive = False
        End If
        '  insertvendor.InsertQuery(vendorNumber, fullname, company, website, address, email, mobile, fax, street, state, acct, openingbal, creditlimit, emailpreference, smspreference, inactive)

        VendorNumberCheck.UpdateQuery(highestVendorNumber, oldVendorNumber)
        Me.Close()
    End Sub
End Class