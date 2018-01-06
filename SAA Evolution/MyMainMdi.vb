Imports System.Windows.Forms

Public Class MyMainMdi
    Public Property role As String
    Public Property user As String
    Public Property passwd As String
    Public Property dlocation As String
    Public Property dstore As String



    Private Sub MainMdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkfunction As New SAAEvoDatasetTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Top = 2
        Me.Left = 2
        ' MessageBox.Show("hello " + userdatails.usernamess)
        Me.ToolStripStatusLabel1.Text = user
        Me.ToolStripStatusLabel2.Text = role
        'If role = "Administrator" Then
        ''AdministatorToolStrip.Enabled = True
        'RibbonTab7.Visible = True
        'End If
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "Administrator")
        If dtcheckfunction.Rows.Count = 0 Then
            RibbonTab7.Visible = False
        Else
           RibbonTab7.Visible = True
        End If
        If dlocation = "UNIVERSAL" And dstore = "UNIVERSAL" Then
            ' RibbonTab1.Visible = False
            RibbonTab2.Visible = False
            RibbonTab3.Visible = False
            RibbonTab5.Visible = False
            RibbonTab6.Visible = False
            ' RibbonTab8.Visible = False
            RibbonTab4.Visible = False
            RibbonButton54.Visible = False
            RibbonButton58.Visible = False

            RibbonButton19.Visible = False
            RibbonButton1.Visible = False
            RibbonButton2.Visible = False
            RibbonButton3.Visible = False
            RibbonButton11.Visible = False
            RibbonButton14.Visible = False
            RibbonButton36.Visible = False
            RibbonButton29.Visible = False

        End If
        Me.ToolStripStatusLabel1.Text = user
        Me.ToolStripStatusLabel2.Text = dlocation
        Me.ToolStripStatusLabel3.Text = dstore

    End Sub

    Private Sub RibbonButton8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RibbonButton21_Click(sender As Object, e As EventArgs) Handles RibbonButton21.Click
        Dim newCustomer As New NewCustomer
        newCustomer.MdiParent = Me
        newCustomer.Show()
    End Sub

    Private Sub RibbonButton22_Click(sender As Object, e As EventArgs) Handles RibbonButton22.Click
        Dim newVendor As New NewVendor
        newVendor.user = user
        newVendor.dlocation = dlocation
        newVendor.dstore = dstore
        newVendor.MdiParent = Me
        newVendor.Show()
    End Sub

    Private Sub RibbonButton16_Click(sender As Object, e As EventArgs) Handles RibbonButton16.Click
        Dim newBank As New NewBank

        newBank.Show()

    End Sub

    Private Sub RibbonButton31_Click(sender As Object, e As EventArgs) Handles RibbonButton31.Click
        Dim newItem As New Items
        newItem.MdiParent = Me
        newItem.Show()
    End Sub

    Private Sub RibbonButton7_Click(sender As Object, e As EventArgs) Handles RibbonButton7.Click
        Dim po As New NewPurchaseOrder
        Dim checkfunction As New SAAEvoDatasetTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "Purchase Order")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function, please see the administrator")
            Exit Sub
        Else
            po.user = user
            po.dlocation = dlocation
            po.dstore = dstore
            po.MdiParent = Me
            po.Show()
        End If
    End Sub

    Private Sub RibbonButton4_Click(sender As Object, e As EventArgs) Handles RibbonButton4.Click
        Dim salesorder As New NewSalesOrder
        Dim checkfunction As New SAAEvoDatasetTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "Sales Order")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function, please see the administrator")
            Exit Sub
        Else
            salesorder.user = user
            salesorder.dlocation = dlocation
            salesorder.dstore = dstore
            salesorder.MdiParent = Me
            salesorder.Show()
        End If
    End Sub

    Private Sub RibbonButton25_Click(sender As Object, e As EventArgs) Handles RibbonButton25.Click
        Dim coa As New ViewChartOf_Acct
        coa.MdiParent = Me
        coa.Show()
    End Sub

    Private Sub RibbonButton29_Click(sender As Object, e As EventArgs)
        Dim newcatgory As New Category

        newcatgory.Show()
    End Sub

    Private Sub RibbonButton24_Click(sender As Object, e As EventArgs) Handles RibbonButton24.Click
        Dim coa As New chartOfAccounts
        coa.MdiParent = Me
        coa.Show()
    End Sub

    Private Sub RibbonButton10_Click(sender As Object, e As EventArgs) Handles RibbonButton10.Click
        Dim purchaseInvoice As New PurchaseInvoice
        Dim checkfunction As New SAAEvoDatasetTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "Purchase Invoice")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function, please see the administrator")
            Exit Sub
        Else
            purchaseInvoice.user = user
            purchaseInvoice.dlocation = dlocation
            purchaseInvoice.dstore = dstore

            purchaseInvoice.MdiParent = Me
            purchaseInvoice.Show()
        End If
    End Sub

    Private Sub RibbonTab2_MouseEnter(sender As Object, e As MouseEventArgs) Handles RibbonTab2.MouseEnter

    End Sub

    Private Sub RibbonButton9_Click(sender As Object, e As EventArgs) Handles RibbonButton9.Click

    End Sub

    Private Sub RibbonButton11_Click(sender As Object, e As EventArgs) Handles RibbonButton11.Click

    End Sub

    Private Sub RibbonButton26_Click(sender As Object, e As EventArgs) Handles RibbonButton26.Click
        Dim custlist As New CustomerList()
        custlist.MdiParent = Me
        custlist.Show()
    End Sub

    Private Sub RibbonButton27_Click(sender As Object, e As EventArgs) Handles RibbonButton27.Click
        Dim vendorlist As New VendorList
        vendorlist.MdiParent = Me
        vendorlist.Show()
    End Sub

    Private Sub RibbonButton30_Click(sender As Object, e As EventArgs)
        Dim categorylist As New CategoryList
        categorylist.Show()
    End Sub

    Private Sub RibbonButton32_Click(sender As Object, e As EventArgs) Handles RibbonButton32.Click
        Dim itemlist As New ItemList
        itemlist.MdiParent = Me
        itemlist.Show()
    End Sub

    Private Sub RibbonButton37_Click(sender As Object, e As EventArgs) Handles RibbonButton37.Click
        Dim newbrand As New NewBrand
        newbrand.MdiParent = Me
        newbrand.Show()

    End Sub

    Private Sub RibbonButton38_Click(sender As Object, e As EventArgs) Handles RibbonButton38.Click
        Dim brandlist As New brandList
        brandlist.MdiParent = Me
        brandlist.Show()
    End Sub

   

    Private Sub RibbonButton43_Click(sender As Object, e As EventArgs) Handles RibbonButton43.Click
        Dim store As New Store
        store.MdiParent = Me
        store.Show()
    End Sub

    Private Sub RibbonButton30_Click_1(sender As Object, e As EventArgs) Handles RibbonButton30.Click
        Dim salesrep As New SalesRep
        salesrep.dlocation = dlocation
        salesrep.dstore = dstore
        salesrep.MdiParent = Me
        salesrep.Show()
    End Sub

    Private Sub RibbonButton41_Click(sender As Object, e As EventArgs) Handles RibbonButton41.Click
        Dim location As New NewLocation
        location.MdiParent = Me
        location.Show()
    End Sub

  

   

    Private Sub RibbonButton49_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

   

    Private Sub RibbonButton52_Click(sender As Object, e As EventArgs) Handles RibbonButton52.Click
        If dlocation = "UNIVERSAL" And dstore = "UNIVERSAL" Then
            Dim newFirstUser As New NewFirstUser
            newFirstUser.MdiParent = Me
            newFirstUser.Show()
            Exit Sub
        End If
        Dim newUser As New NewUser
        newUser.dstore = dstore
        newUser.dlocation = dlocation
        newUser.MdiParent = Me
        newUser.Show()
    End Sub

    Private Sub RibbonButton58_Click(sender As Object, e As EventArgs) Handles RibbonButton58.Click

        Dim mngusers As New ManageUsers
        mngusers.dlocation = dlocation
        mngusers.dstore = dstore
        mngusers.MdiParent = Me
        mngusers.Show()
    End Sub

    Private Sub RibbonButton56_Click(sender As Object, e As EventArgs) Handles RibbonButton56.Click
        Dim chanepwd As New CahngePassword
        chanepwd.MdiParent = Me
        chanepwd.user = user
        chanepwd.Show()
    End Sub

    Private Sub RibbonButton42_Click(sender As Object, e As EventArgs) Handles RibbonButton42.Click
        Dim locList As New Locationlist
        locList.MdiParent = Me
        locList.Show()
    End Sub

    Private Sub RibbonButton44_Click(sender As Object, e As EventArgs) Handles RibbonButton44.Click
        Dim storelist As New storeList
        storelist.MdiParent = Me
        storelist.Show()
    End Sub

    Private Sub RibbonButton45_Click(sender As Object, e As EventArgs) Handles RibbonButton45.Click
        Dim salerepList As New SalesRepList
        salerepList.dlocation = dlocation
        salerepList.dstore = dstore
        SalesRepList.MdiParent = Me
        salerepList.Show()
    End Sub

    Private Sub RibbonButton5_Click(sender As Object, e As EventArgs) Handles RibbonButton5.Click
        Dim salesinv As New SalesInvoice
        Dim checkfunction As New SAAEvoDatasetTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "Sales Invoice")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function, please see the administrator")
            Exit Sub
        Else
            salesinv.user = user
            salesinv.dlocation = dlocation
            salesinv.dstore = dstore
            salesinv.MdiParent = Me
            salesinv.Show()
        End If
    End Sub

    Private Sub RibbonButton12_Click(sender As Object, e As EventArgs) Handles RibbonButton12.Click
        Dim stktrans As New StockTransfersMain
        Dim checkfunction As New SAAEvoDatasetTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "Stock Transfers")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function, please see the administrator")
            Exit Sub
        Else
            stktrans.user = user
            stktrans.dlocation = dlocation
            stktrans.dstore = dstore
            stktrans.MdiParent = Me
            stktrans.Show()
        End If
    End Sub

    Private Sub RibbonButton8_Click_1(sender As Object, e As EventArgs) Handles RibbonButton8.Click
        Dim stkBal As New StockBalances
        stkBal.MdiParent = Me
        stkBal.Show()
    End Sub

    Private Sub RibbonButton55_Click(sender As Object, e As EventArgs) Handles RibbonButton55.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub RibbonButton46_Click(sender As Object, e As EventArgs) Handles RibbonButton46.Click
        Dim atrail As New AuditTrailSalesorder
        atrail.MdiParent = Me
        atrail.Show()
    End Sub

    Private Sub RibbonButton47_Click(sender As Object, e As EventArgs) Handles RibbonButton47.Click
        Dim trail As New AuditTrailSalesDelivery
        trail.MdiParent = Me
        trail.Show()
    End Sub

    Private Sub Ribbon1_Click(sender As Object, e As EventArgs) Handles Ribbon1.Click

    End Sub

    Private Sub RibbonButton48_Click(sender As Object, e As EventArgs) Handles RibbonButton48.Click
        Dim customerClass As New CustomerClassification
        customerClass.MdiParent = Me
        customerClass.Show()
    End Sub

    Private Sub RibbonButton49_Click_1(sender As Object, e As EventArgs) Handles RibbonButton49.Click
        Dim custlist As New classificationList
        custlist.MdiParent = Me
        custlist.Show()
    End Sub

    Private Sub MyMainMdi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As Integer = MessageBox.Show("Do you want to quit SAA Evolution", "Want to quit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub RibbonButton6_Click(sender As Object, e As EventArgs) Handles RibbonButton6.Click
        Dim reciept As New SalesReciept
        Dim checkfunction As New SAAEvoDatasetTableAdapters.UserFunctionsTableAdapter
        Dim dtcheckfunction As DataTable
        dtcheckfunction = checkfunction.GetDataByCheckFunction(user, "Sales Reciept")
        If dtcheckfunction.Rows.Count = 0 Then
            MessageBox.Show("You are not assigned this function, please see the administrator")
            Exit Sub
        Else

            reciept.user = user
            reciept.dstore = dstore
            reciept.dlocation = dlocation
            reciept.MdiParent = Me
            reciept.Show()
        End If
    End Sub

    Private Sub RibbonButton51_Click(sender As Object, e As EventArgs) Handles RibbonButton51.Click
        Dim InvBySalesOrder As New InvoicesByOrders
        InvBySalesOrder.MdiParent = Me
        InvBySalesOrder.Show()
    End Sub

    Private Sub RibbonButton57_Click(sender As Object, e As EventArgs) Handles RibbonButton57.Click
        Dim salesInvoicebyNumber As New rptSalesInvoiceByNumber
        salesInvoicebyNumber.MdiParent = Me
        salesInvoicebyNumber.Show()
    End Sub

    Private Sub RibbonButton60_Click(sender As Object, e As EventArgs) Handles RibbonButton60.Click
        Dim invoicesbyCustomerOrder As New rptsalesInvoicesByCustomerOrder
        invoicesbyCustomerOrder.MdiParent = Me
        invoicesbyCustomerOrder.Show()
    End Sub

    Private Sub RibbonButton59_Click(sender As Object, e As EventArgs) Handles RibbonButton59.Click
        Dim invoicesbyOrderNuber As New rptInvoicesBySalesOrder
        invoicesbyOrderNuber.MdiParent = Me
        invoicesbyOrderNuber.Show()
    End Sub

    Private Sub RibbonButton50_Click(sender As Object, e As EventArgs) Handles RibbonButton50.Click
        Dim allSalesInvoices As New rptAllSalesInvoices
        allSalesInvoices.MdiParent = Me
        allSalesInvoices.Show()
    End Sub

    Private Sub RibbonButton62_Click(sender As Object, e As EventArgs) Handles RibbonButton62.Click
        Dim allpurchaseInvoices As New rptAllPurchaseInvoice
        allpurchaseInvoices.MdiParent = Me
        allpurchaseInvoices.Show()
    End Sub

    Private Sub RibbonButton63_Click(sender As Object, e As EventArgs) Handles RibbonButton63.Click
        Dim rptpurchaseInvoicesByOrder As New rptInvoicesByPurchaseOrder
        rptpurchaseInvoicesByOrder.MdiParent = Me
        rptpurchaseInvoicesByOrder.Show()
    End Sub
End Class
