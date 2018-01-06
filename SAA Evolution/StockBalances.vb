Imports System.Data.SqlClient
Imports System.Configuration
Public Class StockBalances

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StockBalances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Top = 40
        Dim connectionstring As String
        connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings(1).ToString
        Using cn As New SqlConnection(connectionstring)

            Dim cmd As SqlCommand = New SqlCommand("truncate table ItemBalances", cn)
            cn.Open()
            cmd.ExecuteNonQuery()

        End Using
        Dim SourceAnddestination As String
        Dim item As String
        'Dim locations As String
        Dim totalrecieved As Decimal?
        Dim totalissued As Decimal?
        Dim bal As Decimal?
        'Dim transDate As Date
        Dim location As New SAAEvoDatasetTableAdapters.LocationTableAdapter
        Dim store As New SAAEvoDatasetTableAdapters.StoreTableAdapter
        Dim salesrep As New SAAEvoDatasetTableAdapters.SalesRepStoreTableAdapter
        Dim itemsBySourceAndDestination As New SAAEvoDatasetTableAdapters.ItemTransTableAdapter
        Dim distinctitems As New SAAEvoDatasetTableAdapters.DistinctItemTransTableAdapter
        Dim insertItemBalance As New SAAEvoDatasetTableAdapters.ItemBalancesTableAdapter
        Dim dtlocation As DataTable
        Dim dtstore As DataTable
        Dim dtsalesrep As DataTable
        Dim dtItemsBySourceAndDestination As DataTable
        Dim dtTotalIssued As DataTable
        Dim dtTotalRecieved As DataTable
        Dim dtRecieves As DataTable
        Dim dtIssues As DataTable
        dtlocation = location.GetData()
        For Each rowlocation As DataRow In dtlocation.Rows
            SourceAnddestination = rowlocation.Item(1).ToString
            'dtItemsBySourceAndDestination = itemsBySourceAndDestination.GetDataBy1SourceAndDestination(SourceAnddestination, SourceAnddestination)
            dtItemsBySourceAndDestination = distinctitems.GetData(SourceAnddestination, SourceAnddestination)
            ' MessageBox.Show(SourceAnddestination)
            For Each rowitem As DataRow In dtItemsBySourceAndDestination.Rows
                item = rowitem.Item(0).ToString
                dtIssues = itemsBySourceAndDestination.GetDataBycheckIssuesExists(item, SourceAnddestination)
                If dtIssues.Rows.Count = 0 Then
                    totalissued = 0
                Else
                    totalissued = itemsBySourceAndDestination.sumisssued(item, SourceAnddestination)
                End If
                dtRecieves = itemsBySourceAndDestination.GetDataBycheckRecievesExists(item, SourceAnddestination)
                If dtRecieves.Rows.Count = 0 Then
                    totalrecieved = 0
                Else
                    totalrecieved = itemsBySourceAndDestination.sumrecieved(item, SourceAnddestination)
                End If
                bal = totalrecieved - totalissued
                'MessageBox.Show("Item balance is " + item + " " + bal.ToString)
                insertItemBalance.InsertQuery(Date.Today, item, 0, totalissued, totalrecieved, "", 0, SourceAnddestination, "", bal)
            Next rowitem
        Next rowlocation
        dtstore = store.GetData()
        For Each rowStore As DataRow In dtstore.Rows
            SourceAnddestination = rowStore.Item(1).ToString
            dtItemsBySourceAndDestination = distinctitems.GetData(SourceAnddestination, SourceAnddestination)
            ' MessageBox.Show(SourceAnddestination)
            For Each rowitem As DataRow In dtItemsBySourceAndDestination.Rows
                item = rowitem.Item(0).ToString
                dtIssues = itemsBySourceAndDestination.GetDataBycheckIssuesExists(item, SourceAnddestination)
                If dtIssues.Rows.Count = 0 Then
                    totalissued = 0
                Else
                    totalissued = itemsBySourceAndDestination.sumisssued(item, SourceAnddestination)
                End If
                dtRecieves = itemsBySourceAndDestination.GetDataBycheckRecievesExists(item, SourceAnddestination)
                If dtRecieves.Rows.Count = 0 Then
                    totalrecieved = 0
                Else
                    totalrecieved = itemsBySourceAndDestination.sumrecieved(item, SourceAnddestination)
                End If
                bal = totalrecieved - totalissued
                'MessageBox.Show("Item balance is " + item + " " + bal.ToString)
                insertItemBalance.InsertQuery(Date.Today, item, 0, totalissued, totalrecieved, "", 0, SourceAnddestination, "", bal)
            Next rowitem
        Next rowStore
        ' MessageBox.Show("iuhfifhuierhi")
        'dtstore = store.GetData()
        dtsalesrep = salesrep.GetDataByActiveReps
        For Each rowSalesRep As DataRow In dtsalesrep.Rows
            SourceAnddestination = rowSalesRep.Item(1).ToString
            dtItemsBySourceAndDestination = distinctitems.GetData(SourceAnddestination, SourceAnddestination)
            '  MessageBox.Show(SourceAnddestination)
            For Each rowitem As DataRow In dtItemsBySourceAndDestination.Rows
                item = rowitem.Item(0).ToString
                dtIssues = itemsBySourceAndDestination.GetDataBycheckIssuesExists(item, SourceAnddestination)
                If dtIssues.Rows.Count = 0 Then
                    totalissued = 0
                Else
                    totalissued = itemsBySourceAndDestination.sumisssued(item, SourceAnddestination)
                End If
                dtRecieves = itemsBySourceAndDestination.GetDataBycheckRecievesExists(item, SourceAnddestination)
                If dtRecieves.Rows.Count = 0 Then
                    totalrecieved = 0
                Else
                    totalrecieved = itemsBySourceAndDestination.sumrecieved(item, SourceAnddestination)
                End If
                bal = totalrecieved - totalissued
                'MessageBox.Show("Item balance is " + item + " " + bal.ToString)
                insertItemBalance.InsertQuery(Date.Today, item, 0, totalissued, totalrecieved, "", 0, SourceAnddestination, "", bal)
            Next rowitem
        Next rowSalesRep

        Me.ItemBalancesTableAdapter.Fill(Me.SAAEvoDataset.ItemBalances)
        Me.ReportViewer1.RefreshReport()
    End Sub

   

   
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class