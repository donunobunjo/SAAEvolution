Public Class AuditTrailSalesorder

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            ComboBox1.Enabled = False
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            ComboBox1.Enabled = True
        Else
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub AuditTrailSalesorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SAAEvoDataset.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.FillByActiveUsers(Me.SAAEvoDataset.Users)
        'TODO: This line of code loads data into the 'SAAEvoDataset.SalesOrderDetail' table. You can move, or remove it, as needed.
        Me.SalesOrderDetailTableAdapter.Fill(Me.SAAEvoDataset.SalesOrderDetail)
        ComboBox1.SelectedIndex = -1
        Me.CenterToScreen()
        Me.Top = 5
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.SalesOrderDetailTableAdapter.FillByAuditUser(Me.SAAEvoDataset.SalesOrderDetail, ComboBox1.Text)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Me.SalesOrderDetailTableAdapter.FillByAudittrailDate(Me.SAAEvoDataset.SalesOrderDetail, DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub
End Class