Public Class Pendientes_pro_cancelar
    Dim micitas As v_citas
    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()

    End Sub

    Private Sub Pendientes_pro_cancelar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String
        sql = "SELECT CONVERT(varchar(10), CAST(citas.fecha AS date), 103) AS fecha, CONVERT(varchar(10), CAST(citas.fecha AS time), 108) AS hora, citas.nombre as Nombre, citas.telefono as Telefono, " _
       & "  medicos.Nombre AS Medico, medicos.id_medico as id, citas.id_usuario as usuario FROM citas INNER JOIN medicos ON citas.id_medico = medicos.id_medico " _
       & "WHERE  citas.status = 10 "
        dgv.DataSource = leer_tabla(sql)
        If dgv.Rows.Count = 0 Then
            MsgBox("No hay citas pendientes de manejar")
            Me.Close()
            Exit Sub
        End If
        SplitContainer2.Panel1Collapsed = False
        SplitContainer2.Panel2Collapsed = True
        btn_lista.Visible = False
        btn_can.Visible = True

    End Sub

    Private Sub dgv_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
       

    End Sub

   
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles btn_can.Click
        cancela()
    End Sub

    Private Sub btn_lista_Click(sender As System.Object, e As System.EventArgs) Handles btn_lista.Click
        SplitContainer2.Panel1Collapsed = False
        SplitContainer2.Panel2Collapsed = True
        btn_lista.Visible = False
        btn_can.Visible = True

    End Sub

   
    
    Private Sub cancela()
        Try
            With dgv.CurrentRow
                micitas.fecha = .Cells("fecha").Value
                micitas.hora = .Cells("hora").Value
                micitas.id_medico = .Cells("id").Value
                micitas.nombre = .Cells("Nombre").Value
                micitas.tel = .Cells("Telefono").Value
                micitas.user = .Cells("usuario").Value
            End With
            'boton _cancelar
            SplitContainer2.Panel1Collapsed = True
            SplitContainer2.Panel2Collapsed = False
            btn_lista.Visible = True
            btn_can.Visible = False
            tfecha.Text = micitas.fecha
            thora.Text = micitas.hora
            tnombre.Text = micitas.nombre
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        cancela()
    End Sub

    Private Sub btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancelar.Click
        Dim ix As MsgBoxResult
        ix = MsgBox(user_nick + ", Seguro quieres cancelar esta cita", MsgBoxStyle.YesNo, "Cancelar Cita Bloqueda")
        If ix = MsgBoxResult.Yes Then
            ' Try
            Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
            adap.actualiza_cita("", "", "", "", "", user_id, True, 9, micitas.id_medico, micitas.fecha.ToShortDateString + " " + micitas.hora)
            adap.Dispose()

            ' Catch ex As Exception
            'MsgBox("No se cancelo la cita")
            'Exit Sub
            ' End Try

            Try
                actualiza_bitacora(user_id, "Cancela Bloqueada", micitas.id_medico, micitas.fecha.ToShortDateString + " " + micitas.hora, micitas.nombre, micitas.tel, tmemo.Text)
            Catch ex As Exception
                MsgBox("No se actualizo bitacora")
            End Try
            SplitContainer2.Panel1Collapsed = False
            SplitContainer2.Panel2Collapsed = True
            btn_lista.Visible = False
            btn_can.Visible = True
            Dim sql As String
            sql = "SELECT CONVERT(varchar(10), CAST(citas.fecha AS date), 103) AS fecha, CONVERT(varchar(10), CAST(citas.fecha AS time), 108) AS hora, citas.nombre as Nombre, citas.telefono as Telefono, " _
           & "  medicos.Nombre AS Medico, medicos.id_medico as id, citas.id_usuario as usuario FROM citas INNER JOIN medicos ON citas.id_medico = medicos.id_medico " _
           & "WHERE  citas.status = 10 "
            dgv.DataSource = leer_tabla(sql)
            If dgv.Rows.Count = 0 Then
                MsgBox("No hay citas pendientes de manejar")
                Me.Close()
            End If
        End If
    End Sub
End Class