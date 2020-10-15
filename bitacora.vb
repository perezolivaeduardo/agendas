Public Class bitacora

    Private Sub bitacora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.tbl_usuarios' Puede moverla o quitarla según sea necesario.
        Me.Tbl_usuariosTableAdapter.Fill(Me.Db_baseDataSet.tbl_usuarios)
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.sql_bitacora' Puede moverla o quitarla según sea necesario.
        Me.Sql_bitacoraTableAdapter.Fill(Me.Db_baseDataSet.sql_bitacora)

    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Dim id As String = NombreComboBox.SelectedValue
        Sql_bitacoraBindingSource.Filter = "nik = '" + id + "'"
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Sql_bitacoraBindingSource.Filter = "cita_nombre like '%" + TextBox1.Text + "%'"
        Catch ex As Exception
            Sql_bitacoraBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Try
            Sql_bitacoraBindingSource.Filter = "tipo like '%" + TextBox2.Text + "%'"
        Catch ex As Exception
            Sql_bitacoraBindingSource.Filter = ""
        End Try
    End Sub
End Class