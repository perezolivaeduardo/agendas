Public Class usuarios

    Private Sub Tbl_usuariosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Tbl_usuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_usuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)

    End Sub

    Private Sub usuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.tbl_usuarios' Puede moverla o quitarla según sea necesario.
        Me.Tbl_usuariosTableAdapter.Fill(Me.Db_baseDataSet.tbl_usuarios)

    End Sub
End Class