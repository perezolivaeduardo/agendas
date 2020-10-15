Public Class localizar
    Dim sql As String
    Private Sub btn_salir_Click(sender As System.Object, e As System.EventArgs) Handles btn_salir.Click
        kfecha.Text = ""
        kid.Text = ""
        Me.Close()
    End Sub
    Private Sub localizar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        sql = "SELECT CONVERT(varchar(10), CAST(citas.fecha AS date), 103) AS fecha, CONVERT(varchar(10), CAST(citas.fecha AS time), 108) AS hora, citas.nombre, citas.telefono, " _
        & "  medicos.Nombre AS Medico, medicos.id_medico as id FROM citas INNER JOIN medicos ON citas.id_medico = medicos.id_medico " _
        & "WHERE citas.fecha >= '@fecha' AND (citas.status = 1) "
    End Sub
    Private Sub btn_go_Click(sender As System.Object, e As System.EventArgs) Handles btn_go.Click
        localiza()
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            localiza()
        End If
    End Sub
    Private Sub localiza()
        Dim cmd As String
        cmd = sql.Replace("@fecha", Date.Today.ToShortDateString)
        cmd += " and citas.nombre like '%" + TextBox1.Text + "%'"
        dgv.DataSource = leer_tabla(cmd)
        dgv.Columns("id").Visible = False
        dgv.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub dgv_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        kfecha.Text = dgv.CurrentRow.Cells("fecha").Value
        kid.Text = dgv.CurrentRow.Cells("id").Value
        Me.Close()
    End Sub
End Class