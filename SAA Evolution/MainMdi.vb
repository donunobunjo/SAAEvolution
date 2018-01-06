Imports System.Windows.Forms

Public Class Main
    Public Property role As String
    Public Property user As String
    Public Property passwd As String
    Private Sub VendorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorsToolStripMenuItem.Click

    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Top = 2
        Me.Left = 2
        If role = "Administrator" Then
            AdministatorToolStrip.Enabled = True
        End If
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        Dim newcustomer As New NewCustomer
        newcustomer.MdiParent = Me
        newcustomer.Show()
    End Sub

    Private Sub CustomersListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersListToolStripMenuItem.Click
        Dim customerlist As New CustomerList
        customerlist.MdiParent = Me
        customerlist.Show()
    End Sub

    Private Sub NewVendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewVendorToolStripMenuItem.Click
        Dim newvendor As New NewVendor
        newvendor.MdiParent = Me
        newvendor.Show()
    End Sub

    Private Sub VendorsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorsListToolStripMenuItem.Click
        Dim vendorlist As New VendorList
        vendorlist.MdiParent = Me
        vendorlist.Show()
    End Sub

    Private Sub NewItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewItemsToolStripMenuItem.Click
        Dim newitem As New Items
        newitem.MdiParent = Me
        newitem.Show()
    End Sub

    Private Sub ItemsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsListToolStripMenuItem.Click
        Dim itemlist As New ItemList
        itemlist.MdiParent = Me
        itemlist.Show()
    End Sub

    Private Sub NewBrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBrandToolStripMenuItem.Click
        Dim newbrand As New NewBrand
        newbrand.MdiParent = Me
        newbrand.Show()
    End Sub

    Private Sub BrandListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrandListToolStripMenuItem.Click
        Dim brandlist As New brandList
        brandlist.MdiParent = Me
        brandlist.Show()
    End Sub

    Private Sub NewLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewLocationToolStripMenuItem.Click
        Dim loc As New NewLocation
        NewLocation.MdiParent = Me
        loc.Show()
    End Sub

    Private Sub LocationListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationListToolStripMenuItem.Click
        Dim locList As New Locationlist
        locList.MdiParent = Me
        locList.Show()
    End Sub

    Private Sub NewStoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStoreToolStripMenuItem.Click
        Dim store As New Store
        store.MdiParent = Me
        store.Show()
    End Sub

    Private Sub StoreListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoreListToolStripMenuItem.Click
        Dim storelist As New storeList
        storelist.MdiParent = Me
        storelist.Show()
    End Sub

    Private Sub NewSalesRepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSalesRepToolStripMenuItem.Click
        Dim salesrep As New SalesRep
        salesrep.MdiParent = Me
        salesrep.Show()
    End Sub

    Private Sub SalesRepListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesRepListToolStripMenuItem.Click
        Dim salerepList As New SalesRepList
        SalesRepList.MdiParent = Me
        salerepList.Show()
    End Sub

    Private Sub SalesOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesOrdersToolStripMenuItem.Click
        Dim salesorder As New NewSalesOrder
        salesorder.user = user
        salesorder.MdiParent = Me
        ' salesorder.user = user
        salesorder.Show()
    End Sub

    Private Sub SalesInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesInvoiceToolStripMenuItem.Click
        Dim salesinv As New SalesInvoice
        salesinv.user = user
        salesinv.MdiParent = Me
        salesinv.Show()
    End Sub

    Private Sub StockMovementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockMovementsToolStripMenuItem.Click
        Dim stktrans As New StockTransfers
        stktrans.user = user
        stktrans.MdiParent = Me
        stktrans.Show()
    End Sub





    Private Sub AdministratorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '       If Not role = "Administrator" Then

        '       MessageBox.Show("You don't have the previeledge to run this module,consult the administrator")
        '      End If
        '     Exit Sub
    End Sub

    Private Sub ManagerUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagerUsersToolStrip.Click

    End Sub

    Private Sub NewUsersTool_Click(sender As Object, e As EventArgs) Handles NewUsersTool.Click
        Dim user As New NewUser
        user.MdiParent = Me
        user.Show()
    End Sub

    Private Sub ActivateDeactivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateDeactivateToolStripMenuItem.Click
        Dim mnguser As New ManageUsers
        mnguser.MdiParent = Me
        mnguser.Show()
    End Sub

    Private Sub StockBalancesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockBalancesToolStripMenuItem.Click
        Dim stkBal As New StockBalances
        stkBal.MdiParent = Me
        stkBal.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim changepwd As New CahngePassword
        ' changepwd.oldpasswd = passwd
        'changepwd.username = user
        changepwd.MdiParent = Me
        changepwd.Show()
    End Sub

    Private Sub AuditTrailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditTrailToolStripMenuItem.Click
        '    Dim audittrail As New AuditTrailByDatee
        '   audittrail.MdiParent = Me
        '  audittrail.Show()
    End Sub

    Private Sub SalesOrdersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalesOrdersToolStripMenuItem1.Click
        Dim atrail As New AuditTrailSalesorder
        atrail.MdiParent = Me
        atrail.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim salesReciept As New SalesReciept
        salesReciept.user = user
        salesReciept.MdiParent = Me
        salesReciept.Show()
    End Sub

    Private Sub SalesDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesDeliveryToolStripMenuItem.Click
        Dim trail As New AuditTrailSalesDelivery
        trail.MdiParent = Me
        trail.Show()
    End Sub
End Class
