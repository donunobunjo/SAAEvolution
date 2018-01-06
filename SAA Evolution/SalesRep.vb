Public Class SalesRep
    Public Property dlocation As String
    Public Property dstore As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As New SAAEvoDatasetTableAdapters.SalesRepStoreTableAdapter
        Dim dt As New DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("Sales Rep name is required")
            TextBox1.Focus()
            Exit Sub
        End If
       
        dt = insert.GetDataBy1(TextBox1.Text)
        If dt.Rows.Count = 0 Then
            insert.InsertQuery(TextBox1.Text, dlocation, dstore, DateTimePicker1.Value, True)

        Else
            MessageBox.Show("This Sales Rep exists in the database")
            TextBox1.Focus()
            Exit Sub
        End If
        TextBox1.Clear()
       
        DateTimePicker1.Value = Date.Today
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim insert As New SAAEvoDatasetTableAdapters.SalesRepStoreTableAdapter
        Dim dt As New DataTable
        If TextBox1.Text = "" Then
            MessageBox.Show("Sales Rep name is required")
            TextBox1.Focus()
            Exit Sub
        End If
       
        dt = insert.GetDataBy1(TextBox1.Text)
        If dt.Rows.Count = 0 Then
            insert.InsertQuery(TextBox1.Text, dlocation, dstore, DateTimePicker1.Value, True)

        Else
            MessageBox.Show("This Sales Rep exists in the database")
            TextBox1.Focus()
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub SalesRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Store' table. You can move, or remove it, as needed.
        ' Me.StoreTableAdapter.Fill(Me.SAAEvoDataset.Store)
        'TODO: This line of code loads data into the 'SAAEvoDataset.Location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter.Fill(Me.SAAEvoDataset.Location)
        'Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 1
       
    End Sub

   
End Class