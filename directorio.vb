Public Class directorio
    Private Sub Tbl_directorioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_directorioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_directorioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)

    End Sub

    Private Sub directorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.tbl_directorio' Puede moverla o quitarla según sea necesario.
        Me.Tbl_directorioTableAdapter.Fill(Me.Db_baseDataSet.tbl_directorio)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class