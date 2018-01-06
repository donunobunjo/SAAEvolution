Public Class deliverSalesOrdersBackUp
    Public Property user As String
    Public Property sonumber As String
    Public Property customer As String
    Public Property dlocation As String
    Public Property dstore As String





    Private Sub deliverSalesOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesOrderSummary' table. You can move, or remove it, as needed.
        ' Me.SalesOrderSummaryTableAdapter.Fill(Me.SAAEvoDataset.SalesOrderSummary)
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesOrderSummaryUpdate' table. You can move, or remove it, as needed.
        ' Me.SalesOrderSummaryUpdateTableAdapter.Fill(Me.SAAEvoDataset.SalesOrderSummaryUpdate)
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesRepStore' table. You can move, or remove it, as needed.
        Me.SalesRepStoreTableAdapter.FillByActiveReps(Me.SAAEvoDataset.SalesRepStore)
        'TODO: This line of code loads data into the 'SAAEvoDataset.Store' table. You can move, or remove it, as needed.
        Me.StoreTableAdapter.Fill(Me.SAAEvoDataset.Store)
        'TODO: This line of code loads data into the 'SAAEvoDataset.Location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter.Fill(Me.SAAEvoDataset.Location)
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesOrderDetail' table. You can move, or remove it, as needed.
        Me.SalesOrderDetailTableAdapter.FillBySalesOrder(Me.SAAEvoDataset.SalesOrderDetail, sonumber, customer)
        TextBox1.Text = customer
        TextBox2.Text = sonumber

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim updateSalesOrderStatus As SAAEvoDatasetTableAdapters.SalesOrderSummaryTableAdapter
        Dim cnt As Int32
        Dim cntchecked As Integer
        Dim source As String
        Dim item As String
        Dim deldate As Date
        Dim issue As Decimal
        Dim destination As String
        Dim bulkins As New SAAEvoDatasetTableAdapters.ItemTransTableAdapter

        '        cnt = DataGridView1.RowCount
        '       cntchecked = 0
        '      For j = 0 To (cnt - 1)
        'If DataGridView1.Item(5, j).Value = True Then
        '      cntchecked = cntchecked + 1
        '     If RadioButton1.Checked Then
        'source = ComboBox1.Text
        ''     '     End If
        '    If RadioButton2.Checked Then
        'source = ComboBox2.Text
        'End If
        'If RadioButton3.Checked Then
        '   source = ComboBox3.Text
        '  End If
        '    item = DataGridView1.Item(1, j).Value.ToString
        deldate = DateTimePicker1.Value
        '    issue = Convert.ToDecimal(DataGridView1.Item(2, j).Value)
        destination = customer
        bulkins.InsertQuery(item, deldate, 0, issue, 0, "", "", "", "", 0, source, destination, user)
        ' bulkins.InsertQuery(item,deldate
        '   End If
        '  Next
        If cntchecked < cnt Then

            Me.SalesOrderSummaryTableAdapter.UpdateQuery("PARTIAL", sonumber)
        End If
        If cntchecked = cnt Then
            ' updateSalesOrderStatus.UpdateQuery("FULFILLED", sonumber)
            Me.SalesOrderSummaryTableAdapter.UpdateQuery("FULFILLED", sonumber)
        End If
        Me.SalesOrderDetailTableAdapter.Update(Me.SAAEvoDataset.SalesOrderDetail)
        MessageBox.Show("Database Updated")
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class