Partial Class SAAEvoDataset
    Partial Public Class SalesOrderSummaryDataTable
        Private Sub SalesOrderSummaryDataTable_SalesOrderSummaryRowChanging(sender As Object, e As SalesOrderSummaryRowChangeEvent) Handles Me.SalesOrderSummaryRowChanging

        End Sub

        Private Sub SalesOrderSummaryDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CommentColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace SAAEvoDatasetTableAdapters

    Partial Public Class NumberChecksTableAdapter
    End Class
End Namespace
