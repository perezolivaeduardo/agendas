Public Class crear_agendas

    Private Sub EsquemaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
     

    End Sub

    Private Sub crear_agendas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.medicos' Puede moverla o quitarla según sea necesario.
        Me.MedicosTableAdapter.Fill(Me.Db_baseDataSet.medicos)
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.Esquema' Puede moverla o quitarla según sea necesario.
        Me.EsquemaTableAdapter.Fill(Me.Db_baseDataSet.Esquema)
        For j = 0 To 4
            listday.SetItemChecked(j, True)
        Next j


    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Dim id As Integer = NombreComboBox.SelectedValue
        Dim cmd As String
        cmd = "select * from citas where id_medico = [ID]"
        cmd = cmd.Replace("[ID]", id.ToString)
        Dim tbl As DataTable = leer_tabla(cmd)
        If tbl.Rows.Count > 0 Then
            MsgBox("Ya existe la agenda para este doctor, si quiere hacer un cambio seleccione la opcion de Modificar Agenda")
        End If
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.Esquema' Puede moverla o quitarla según sea necesario.
        Me.EsquemaTableAdapter.FillByID(Me.Db_baseDataSet.Esquema, id)


    End Sub

    Private Sub btn_crear_Click(sender As System.Object, e As System.EventArgs) Handles btn_crear.Click
        Dim id_medico As Integer = NombreComboBox.SelectedValue
        Dim hora, horafinal As DateTime
        Dim dias(7) As Boolean 'habilita los dias que se van a usar
        For j As Integer = 0 To listday.CheckedIndices.Count - 1
            dias(listday.CheckedIndices.Item(j).ToString + 1) = True
        Next

        hora = hini.Value : horafinal = hfin.Value
        While hora <= horafinal
            Try
                EsquemaTableAdapter.Insert(id_medico, hora.TimeOfDay, dias(1), dias(2), dias(3), dias(4), dias(5), dias(6), dias(7))

            Catch ex As Exception

            End Try

            hora = hora.AddMinutes(intervalo.Value)
        End While
        Me.EsquemaTableAdapter.FillByID(Me.Db_baseDataSet.Esquema, id_medico)
    End Sub

    Private Sub btn_reset_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset.Click
        ' BORRA EL ESQUEMA DE LAS CITAS
        '==============================================
        Dim id_medico As Integer = NombreComboBox.SelectedValue
        commando("delete from esquema where id_medico =" + id_medico.ToString)
        Me.EsquemaTableAdapter.Fill(Me.Db_baseDataSet.Esquema)

        ' BORRA EL ESQUEMA DE LAS CITAS
        '==============================================
        Dim sql = "SELECT        id_medico, CONVERT(varchar(10), fecha, 108) AS hora  FROM dbo.citas " _
        & " WHERE        (fecha >= CONVERT(DATETIME, '2017-12-01 00:00:00', 102) AND fecha <= CONVERT(DATETIME, '2017-12-31 00:00:00', 102)) " _
        & " GROUP BY id_medico, CONVERT(varchar(10), fecha, 108) HAVING        (id_medico = @Param1)"
        sql = sql.Replace("@Param1", id_medico.ToString)

        Dim tbl As New DataTable
        tbl = leer_tabla(sql)
        For j = 0 To tbl.Rows.Count - 1
            Dim t As DateTime
            t = tbl.Rows(j).Item(1)
            EsquemaTableAdapter.Insert(id_medico, t.TimeOfDay, 0, 0, 0, 0, 0, 0, 0)
        Next j


        sql = "SELECT id_medico, CONVERT(varchar(10), fecha, 108) AS hora, { fn DAYOFWEEK(fecha) } AS dia  FROM dbo.citas " _
        & " WHERE   (fecha >= CONVERT(DATETIME, '2017-12-01 00:00:00', 102) AND fecha <= CONVERT(DATETIME, '2017-12-31 00:00:00', 102)) " _
        & "GROUP BY id_medico, CONVERT(varchar(10), fecha, 108), { fn DAYOFWEEK(fecha) } HAVING (id_medico = @Param1)"
        sql = sql.Replace("@Param1", id_medico.ToString)
        tbl = leer_tabla(sql)
        For j = 0 To tbl.Rows.Count - 1
            sql = "UPDATE   Esquema SET [dia] = -1  WHERE  (id_medico = @id) AND (hora = '@hora')"
            sql = sql.Replace("@id", id_medico.ToString)
            sql = sql.Replace("@hora", tbl.Rows(j).Item(1))
            Dim dia As String = ""
            If tbl.Rows(j).Item(2) = 1 Then dia = "Lun"
            If tbl.Rows(j).Item(2) = 2 Then dia = "Mar"
            If tbl.Rows(j).Item(2) = 3 Then dia = "Mie"
            If tbl.Rows(j).Item(2) = 4 Then dia = "Jue"
            If tbl.Rows(j).Item(2) = 5 Then dia = "Vie"
            If tbl.Rows(j).Item(2) = 6 Then dia = "Sab"
            If tbl.Rows(j).Item(2) = 7 Then dia = "Dom"
            sql = sql.Replace("[dia]", dia)
            commando(sql)

        Next

    End Sub

    

    Private Sub btn_genera_Click(sender As System.Object, e As System.EventArgs) Handles btn_genera.Click
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        Dim ffi, ff, fecha, fecha_cita As DateTime
        ffi = fechainicial.Value.ToShortDateString
        ff = fechafinal.Value.ToShortDateString
        fecha = ffi

        Dim ndias As Integer = DateDiff(DateInterval.Day, ffi, ff)
        avance.Maximum = ndias + 2
        avance.Value = 1
        Dim id_medico As Integer = NombreComboBox.SelectedValue
        Dim Esquema As DataTable = leer_tabla("select * from esquema where id_medico =" + id_medico.ToString)
        While fecha <= ff
            Dim dia As Integer = fecha.DayOfWeek, horacita As TimeSpan
            If dia = 0 Then dia = 7

            For j As Integer = 0 To Esquema.Rows.Count - 1
                If Esquema.Rows(j).Item(dia + 1) = True Then
                    horacita = Esquema.Rows(j).Item(1)
                    fecha_cita = fecha.ToShortDateString + " " + horacita.Duration.ToString
                    Try
                        adap.Insert(id_medico, fecha_cita, "", "", "", "", "", 0, False, 0)
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try
                End If
            Next j
            fecha = fecha.AddDays(1)
            avance.Value += 1
        End While

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.EsquemaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Dim id_medico As Integer = NombreComboBox.SelectedValue
        Dim cmd As String = "select min(fecha), max(fecha) from citas where id_medico =" + id_medico.ToString
        Dim tbl As DataTable
        tbl = leer_tabla(cmd)
        Try
            cdel.Text = Format(tbl.Rows(0).Item(0), "dd/mm/yyyy")
            cal.Text = Format(tbl.Rows(0).Item(1), "dd/mm/yyyy")

        Catch ex As Exception

        End Try
        SplitContainer2.Panel1Collapsed = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        SplitContainer2.Panel1Collapsed = Not SplitContainer2.Panel1Collapsed

    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Dim id_medico As Integer = NombreComboBox.SelectedValue
        Dim ix As MsgBoxResult
        ix = MsgBox("Esto eliminara TODAS las citas de esta agenda, seguro que quiere continuar", MsgBoxStyle.YesNo, "ELIMINAR AGENDA")
        If ix <> MsgBoxResult.Yes Then Exit Sub
        Dim i As String = InputBox("Teclee la clave de eliminacion", "Contraseña ", "")
        If i = "esperanza" Then
            commando("delete from citas where id_medico =" + id_medico.ToString)
            MsgBox("Eliminado")
        End If
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click
        MsgBox(fechainicial.Value.DayOfWeek)
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        Dim msg As String
        msg = "Dia  1=Dom, 2=lun, 3=mar, 4=mie, 5=Jue, 6=Vie, 7=sabado"
        Dim dia As Integer = InputBox(msg, "Eliminar un dia de la semana", "7")
        If dia > 7 Then Exit Sub
        If dia <> 7 Then
            Dim ix As MsgBoxResult = MsgBox("Seguro que quiere eliminar este dia", MsgBoxStyle.YesNo, "")
            If ix = MsgBoxResult.No Then Exit Sub
        End If
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.eliminar_por_dia(dia, NombreComboBox.SelectedValue)
        MsgBox("Eliminado")
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        Dim id As String
        id = NombreComboBox.SelectedValue
        My.Forms.eliminar_diayhora.Show()
        My.Forms.eliminar_diayhora.id_medico.Text = id

    End Sub

    Private Sub SplitContainer3_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel1.Paint

    End Sub

    Private Sub EsquemaDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles EsquemaDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class