Partial Class Base_DatosfinalDataSet
    Partial Public Class CLIENTESDataTable
        Private Sub CLIENTESDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IdClienteColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

