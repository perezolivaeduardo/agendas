Partial Class db_baseDataSet
    Partial Class EsquemaDataTable

        Private Sub EsquemaDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_medicoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class

Namespace db_baseDataSetTableAdapters
    
    Partial Public Class citasTableAdapter
    End Class
End Namespace
