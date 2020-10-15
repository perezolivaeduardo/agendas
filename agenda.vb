Public Class frm_agenda
    Dim bscitas As New BindingSource
    Dim dscitas As New DataSet("cita")
    Dim tablecitas As DataTable = dscitas.Tables.Add("citas")
    Dim id_medico As Integer
    Dim clip_cita As v_citas
    Dim nueva_Cita As v_citas
    Dim flag As Boolean = False
    Dim fecha_seleccionada As Date
    Private Sub agenda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.dias_festivos' Puede moverla o quitarla según sea necesario.
        Me.Dias_festivosTableAdapter.Fill(Me.Db_baseDataSet.dias_festivos)
        dgv.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("fecha").Visible = False
        dgv.Columns("status").Visible = False
        dgv.Columns("hora").DefaultCellStyle.Format = "HH:MM"
        dgv.Columns("hora").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("telefono").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("celular").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("email").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("email").Visible = False
        lbl_user.Text = user_nombre


    End Sub

    Public Sub cargar(ByVal id_doctor As Integer, ByVal fecha As Date)
        id_medico = id_doctor
        'carga tabla
        Dim cmd As String = "select convert(varchar(10),cast(fecha as date),103) as fecha,convert(varchar(10),cast(fecha as time),108) as hora,citas.nombre as nombre ,telefono,celular,email,comentarios,status,tbl_usuarios.Nombre as Usuario  from citas INNER JOIN tbl_usuarios ON citas.id_usuario = tbl_usuarios.id_usuario  where id_medico = " + id_doctor.ToString + " Order by convert(varchar(10),cast(fecha as time),108) ASC"
        tablecitas = leer_tabla(cmd)
        dgv.DataSource = tablecitas
        bscitas.DataSource = tablecitas
        'formatear tabla
        dgv.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("fecha").Visible = False
        dgv.Columns("hora").DefaultCellStyle.Format = "HH:mm tt"
        Me.MedicosTableAdapter.FillByid(Me.Db_baseDataSet.medicos, id_doctor)
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(Me.MedicosTableAdapter.GetDataByid(id_doctor).Rows(0).Item("color"))
        If flag = False Then
            SplitContainer7.Panel1Collapsed = False
            SplitContainer7.Panel2Collapsed = True
        End If

        cargar_lista_espera()

        'filtar el dia
        calendario.SetDate(fecha)
        bscitas.Filter = "fecha = '" & CDate(fecha).ToShortDateString & "'"
        Label2.Text = Format(calendario.SelectionStart.Date, "dddd dd MMMM yyyy")
        ' carga lista de espera del dia
        cargar_lista_espera()
        cargar_opciones()
        pendietes_de_cancelar()

        'determina cita mas proxima y la pone en ToolTip
        Dim adap As New db_baseDataSetTableAdapters.citas_disponiblesTableAdapter
        Dim mfecha As DateTime = adap.primer_cita_del_medico(Date.Today.ToShortDateString, id_medico)
        ToolStripButton2.ToolTipText = "Cita mas proxima el : " + mfecha.ToShortDateString
        colorea()


    End Sub ' carga inicial de las citas del doctor

    Private Sub cargar_opciones()
        dgvalternas.DataSource = citas_Disponibles_x_dia(calendario.SelectionRange.Start.ToShortDateString, id_medico)
        dgvalternas.Columns(0).Visible = False
        dgvalternas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvalternas.Columns(1).HeaderText = "Médico"
        dgvalternas.Columns(2).HeaderText = "Disp."
    End Sub ' carga citas disponibles de otros medicos en la misma fecha

    Private Sub recarga_citas()
        Dim cmd As String = "select convert(varchar(10),cast(fecha as date),103) as fecha,convert(varchar(10),cast(fecha as time),108) as hora,citas.nombre as nombre ,telefono,celular,email,comentarios,status,tbl_usuarios.Nombre as Usuario  from citas INNER JOIN tbl_usuarios ON citas.id_usuario = tbl_usuarios.id_usuario  where id_medico = " + id_medico.ToString + " Order by convert(varchar(10),cast(fecha as time),108) ASC"
        tablecitas = leer_tabla(cmd)
        bscitas.DataSource = tablecitas
        dgv.DataSource = tablecitas
        pendietes_de_cancelar()
        colorea()
    End Sub

    Private Sub calendario_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles calendario.DateChanged
        fecha_seleccionada = CDate(calendario.SelectionRange.Start.Date)
        bscitas.Filter = "fecha = '" & CDate(fecha_seleccionada) & "'"
        Label2.Text = Format(fecha_seleccionada, "dddd dd MMMM yyyy")
        SplitContainer6.Panel1Collapsed = True

        cargar_opciones()
        cargar_lista_espera()
        filtrar_notas(fecha_seleccionada)
        colorea()

        If fecha_seleccionada < Date.Today Then
            ContextMenuStrip1.Enabled = False
        Else
            ContextMenuStrip1.Enabled = True
        End If
        DiasfestivosBindingSource.Filter = "fecha = '" + fecha_seleccionada.ToShortDateString + "'"
        If fecha_seleccionada.Date = Now.Date Then
            Lista_esperaDataGridView.BackgroundColor = Color.GreenYellow
        Else
            Lista_esperaDataGridView.BackgroundColor = Color.Yellow
        End If
    End Sub

    Private Sub filtrar_notas(ByVal fecha As Date)
        NotasBindingSource.Filter = ""
        Me.NotasTableAdapter.FillByid(Me.Db_baseDataSet.notas, id_medico)
        NotasBindingSource.Filter = "fecha = '" + fecha.ToShortDateString + "'"
    End Sub
    Private Sub cargar_notas()
        Me.NotasTableAdapter.FillByid(Me.Db_baseDataSet.notas, id_medico)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        'calendario.SetDate(Today.Date)
        Dim adap As New db_baseDataSetTableAdapters.citas_disponiblesTableAdapter
        Dim fecha As DateTime = adap.primer_cita_del_medico(Date.Today.ToShortDateString, id_medico)
        calendario.SetDate(fecha)
        adap.Dispose()
    End Sub ' selecciona el dia actual en el calendario

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles btn_salie.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btn_confirmar.Click
        ' Dim fecha As Date = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
        Dim fecha As DateTime = txttime.Value
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.actualiza_cita(txtnombre.Text, txttelefono.Text, txtcelular.Text, txtmail.Text, txtcomentarios.Text, user_id, True, 1, id_medico, fecha)
        adap.Dispose()
        recarga_citas()
        img_proxima.Visible = False
        SplitContainer6.Panel1Collapsed = True
    End Sub 'confirma una cita (nueva)

    Private Sub _btn_salir_Click(sender As System.Object, e As System.EventArgs) Handles _btn_salir.Click
        Me.Close()
    End Sub

    Private Sub cancelar()
        If dgv.CurrentRow.Cells("status").Value = 0 Then MsgBox(user_nick + ", No hay cita que cancelar") : Exit Sub
        If dgv.CurrentRow.Cells("status").Value = 9 Then MsgBox(user_nick + ", esta hora esta bloqueada") : Exit Sub
        Dim ix As MsgBoxResult, micita As v_citas

        'lee la informacion de la tabla
        micita.fecha = CDate(dgv.CurrentRow.Cells("fecha").Value.ToString)
        micita.hora = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
        micita.nombre = dgv.CurrentRow.Cells("nombre").Value.ToString
        micita.tel = dgv.CurrentRow.Cells("telefono").Value.ToString
        ix = MsgBox(user_nick + ",segura que quieres cancelar esta cita", MsgBoxStyle.YesNo, "Cancelar Cita")
        If ix = MsgBoxResult.No Then Exit Sub
        Dim fecha As Date = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.actualiza_cita("", "", "", "", "", user_id, True, 0, id_medico, fecha)
        adap.Dispose()
        Try
            actualiza_bitacora(user_id, "Cancelar", id_medico, micita.fecha.ToShortDateString + " " + micita.hora.ToShortTimeString, micita.nombre, micita.tel, "")
        Catch ex As Exception
            MsgBox("No se actualizo bitacora")
        End Try
        recarga_citas()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Me.grupo_proxima.Visible = False
    End Sub

    Private Sub CitaEnUnMesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CitaEnUnMesToolStripMenuItem.Click
        'lee la informacion de la tabla
        el_nombre.Text = dgv.CurrentRow.Cells("nombre").Value.ToString
        el_telefono.Text = dgv.CurrentRow.Cells("telefono").Value.ToString
        el_celular.Text = dgv.CurrentRow.Cells("celular").Value.ToString
        img_proxima.Visible = True
        Dim fecha As Date
        fecha = CDate(dgv.CurrentRow.Cells("fecha").Value.ToString).AddMonths(1)
        calendario.SetDate(fecha)
        If citas_disponibles(fecha) = 0 Then
            Dim mensaje As String
            mensaje = user_nick + ", No hay citas disponibles para el " + Format(fecha, "dddd dd MMMM") + Chr(10) _
                + "Opciones  : " + Chr(10) + Chr(10) _
                + "Imediata anterior : " + formatea_fecha(cita_anterior(fecha)) + Chr(10) _
                + "Siguiente fecha disponible: " + formatea_fecha(cita_siguiente(fecha))
            MsgBox(mensaje, MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub img_proxima_Click(sender As System.Object, e As System.EventArgs) Handles img_proxima.Click
        If txtnombre.TextLength > 0 Then
            MsgBox(user_nick + ", debes seleccionar una fecha y hora dispoible para poder pegar los datos de la cita")
            Exit Sub
        End If
        txtnombre.Text = el_nombre.Text
        txttelefono.Text = el_telefono.Text
        txtcelular.Text = el_celular.Text
    End Sub

    Private Function citas_disponibles(ByVal fecha As Date) As Integer
        'carga tabla
        Dim cmd As String = "select id_medicos as disponibles from citas where convert(varchar(10),cast(fecha as date),103)= #[fecha]# and status=0 and id_medico = " + id_medico.ToString
        cmd = cmd.Replace("[fecha]", fecha.ToShortDateString)
        Dim tbl As DataTable = leer_tabla(cmd)
        citas_disponibles = tbl.Rows.Count
    End Function

    Private Function cita_anterior(ByVal fecha As Date) As String
        'carga tabla
        Dim cmd As String = "SELECT TOP (1) fecha FROM citas WHERE  id_medico = [id] AND fecha < '[fecha]' ORDER BY fecha DESC"
        cmd = cmd.Replace("[fecha]", fecha.ToShortDateString)
        cmd = cmd.Replace("[id]", id_medico.ToString)
        Dim tbl As DataTable = leer_tabla(cmd)
        If tbl.Rows.Count > 0 Then
            cita_anterior = tbl.Rows(0).Item(0).ToString
        Else
            cita_anterior = "No Existe"
        End If

    End Function

    Private Function cita_siguiente(ByVal fecha As Date) As String
        Dim cmd As String = "SELECT TOP (1) fecha FROM citas WHERE  id_medico = [id] AND fecha > '[fecha]' ORDER BY fecha ASC"
        cmd = cmd.Replace("[fecha]", fecha.ToShortDateString)
        cmd = cmd.Replace("[id]", id_medico.ToString)
        Dim tbl As DataTable = leer_tabla(cmd)
        If tbl.Rows.Count > 0 Then
            cita_siguiente = tbl.Rows(0).Item(0).ToString
        Else
            cita_siguiente = "No Existe"
        End If
    End Function

    Private Sub CancelarCitaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarCitaToolStripMenuItem.Click
        cancelar()
    End Sub

    Private Sub dgv_DoubleClick(sender As System.Object, e As System.EventArgs) Handles dgv.DoubleClick
        '' selecciona una fecha y hora para hacer una cita 
        If dgv.CurrentRow.Cells("status").Value <> 0 Then MsgBox(user_nick + ", este horario no esta disponible") : Exit Sub
        If flag = True Then
            nueva_Cita.fecha = CDate(dgv.CurrentRow.Cells("fecha").Value.ToString)
            nueva_Cita.hora = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
            nfecha.Text = Format(nueva_Cita.fecha, "dddd dd MMMM")
            nhora.Value = nueva_Cita.hora
            cambiar_fecha_de_cita()
            Exit Sub
        End If
        'lee la informacion de la tabla
        txtfecha.Text = Format(CDate(dgv.CurrentRow.Cells("fecha").Value.ToString), "dddd dd MMMM")
        txttime.Value = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
        txtnombre.Text = dgv.CurrentRow.Cells("nombre").Value.ToString
        txttelefono.Text = dgv.CurrentRow.Cells("telefono").Value.ToString
        txtcelular.Text = dgv.CurrentRow.Cells("celular").Value.ToString
        txtmail.Text = dgv.CurrentRow.Cells("email").Value.ToString
        txtcomentarios.Text = dgv.CurrentRow.Cells("comentarios").Value.ToString
        SplitContainer6.Panel1Collapsed = False
        txtnombre.Focus()
    End Sub  '' selecciona una fecha y hora para hacer una cita 

    Private Sub dgv_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        SplitContainer6.Panel1Collapsed = True
    End Sub

    Private Sub calendario_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles calendario.MouseMove
        If SplitContainer6.Panel1Collapsed = False Then
            Dim ix As MsgBoxResult
            ix = MsgBox("Quiere cambiar de fecha", MsgBoxStyle.YesNo, "")
            If ix = MsgBoxResult.No Then Exit Sub
            SplitContainer6.Panel1Collapsed = True
        End If
    End Sub

    Private Sub cargar_lista_espera()
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.lista_espera' Puede moverla o quitarla según sea necesario.
        Dim FECHA = calendario.SelectionRange.Start.ToShortDateString
        Me.Lista_esperaTableAdapter.FillByid_fecha(Me.Db_baseDataSet.lista_espera, id_medico, FECHA)
        If Lista_esperaDataGridView.Rows.Count = 0 Then
            boton_cancelar.Enabled = False
        Else
            boton_cancelar.Enabled = True
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Lista_esperaDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista_esperaDataGridView.CellEndEdit
        Me.Validate()
        Me.Lista_esperaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)
    End Sub

    Private Sub boton_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles boton_cancelar.Click

        Dim ix As MsgBoxResult
        ix = MsgBox("Seguro que quiere quitar de la lista", MsgBoxStyle.YesNo, "BORRAR")
        If ix = MsgBoxResult.No Then Exit Sub
        'borrar alguien de la lista
        Try
            Me.Lista_esperaBindingSource.RemoveCurrent()
            Me.Validate()
            Me.Lista_esperaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub EditarCitaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditarCitaToolStripMenuItem.Click
        If dgv.CurrentRow.Cells("status").Value = 0 Then MsgBox(user_nick + ", No hay nada que Editar") : Exit Sub
        If dgv.CurrentRow.Cells("status").Value = 9 Then MsgBox(user_nick + ", esta hora esta bloqueada") : Exit Sub
        'lee la informacion de la tabla
        txtfecha.Text = Format(CDate(dgv.CurrentRow.Cells("fecha").Value.ToString), "dddd dd MMMM")
        txttime.Value = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
        txtnombre.Text = dgv.CurrentRow.Cells("nombre").Value.ToString
        txttelefono.Text = dgv.CurrentRow.Cells("telefono").Value.ToString
        txtcelular.Text = dgv.CurrentRow.Cells("celular").Value.ToString
        txtmail.Text = dgv.CurrentRow.Cells("email").Value.ToString
        txtcomentarios.Text = dgv.CurrentRow.Cells("comentarios").Value.ToString
        SplitContainer6.Panel1Collapsed = False
    End Sub

    Private Sub CambiarDeDiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambiarDeDiaToolStripMenuItem.Click
        '' CAMBIAR DE DIA
        If dgv.CurrentRow.Cells("status").Value = 0 Then MsgBox(user_nick + ", No hay nada que cambiar") : Exit Sub
        If dgv.CurrentRow.Cells("status").Value = 9 Then MsgBox(user_nick + ", esta hora esta bloqueada") : Exit Sub
        'lee la informacion de la tabla
        clip_cita.fecha = CDate(dgv.CurrentRow.Cells("fecha").Value.ToString)
        clip_cita.hora = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
        clip_cita.nombre = dgv.CurrentRow.Cells("nombre").Value.ToString
        clip_cita.tel = dgv.CurrentRow.Cells("telefono").Value.ToString
        clip_cita.cel = dgv.CurrentRow.Cells("celular").Value.ToString
        clip_cita.email = dgv.CurrentRow.Cells("email").Value.ToString
        clip_cita.status = dgv.CurrentRow.Cells("status").Value.ToString
        clip_cita.comentarios = dgv.CurrentRow.Cells("comentarios").Value.ToString
        clip_cita.id_medico = id_medico
        SplitContainer7.Panel1Collapsed = True
        SplitContainer7.Panel2Collapsed = False
        flag = True
        ContextMenuStrip1.Enabled = False
        cnombre.Text = clip_cita.nombre
        ctelefono.Text = clip_cita.tel
        cfecha.Text = Format(clip_cita.fecha, "dddd dd MMMM")
        chora.Value = clip_cita.hora
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'cancelar cambio de cita
        flag = False
        ContextMenuStrip1.Enabled = True
        SplitContainer7.Panel1Collapsed = False
        SplitContainer7.Panel2Collapsed = True
    End Sub 'cancelar cambio de cita

   

    Private Sub cambiar_fecha_de_cita()
        'aplica cambio de cita
        'confirmar cambio de fecha para una cita
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        nueva_Cita.comentarios = "Cita original el " + formatea_fecha(clip_cita.fecha) + " al las " + clip_cita.hora.ToShortTimeString
        If clip_cita.id_medico <> id_medico Then nueva_Cita.comentarios += " del Dr." + NombreLabel1.Text
        'Borra cita anterior
        Dim fecha As Date = clip_cita.hora
        Dim status As Integer
        If clip_cita.status = 1 Then status = 0 Else If clip_cita.status = 10 Then status = 9
        adap.actualiza_cita("", "", "", "", "", user_id, True, status, clip_cita.id_medico, fecha)
        'Guarda la nueva cita
        adap.actualiza_cita(clip_cita.nombre, clip_cita.tel, clip_cita.cel, clip_cita.email, nueva_Cita.comentarios, user_id, True, 1, id_medico, nueva_Cita.hora)
        adap.Dispose()
        'actualiza Bitacora
        Dim comentario As String = "Se cambio para el " + nueva_Cita.hora.ToString
        If clip_cita.id_medico <> id_medico Then comentario += " a la Agenda del Dr." + NombreLabel1.Text
        Try
            actualiza_bitacora(user_id, "Movio una cita", clip_cita.id_medico, clip_cita.hora.ToString, clip_cita.nombre, clip_cita.tel, comentario)
        Catch ex As Exception
            MsgBox("No se actualizo bitacora")
        End Try
        recarga_citas()
        flag = False
        ContextMenuStrip1.Enabled = True
        SplitContainer7.Panel1Collapsed = False
        SplitContainer7.Panel2Collapsed = True
    End Sub

    Private Sub btn_localizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_localizar.Click
        My.Forms.localizar.ShowDialog()
        If My.Forms.localizar.kfecha.TextLength > 0 Then
            Dim fecha As Date, id As Integer
            fecha = My.Forms.localizar.kfecha.Text
            id = My.Forms.localizar.kid.Text
            cargar(id, fecha)
        End If
    End Sub

    Private Sub bloquear(ByVal fecha As Date)
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.bloquear_un_dia(user_id, id_medico, fecha)
        adap.Dispose()
        recarga_citas()
        pendietes_de_cancelar()
        Try
            actualiza_bitacora(user_id, "Se Bloqueo", id_medico, fecha, "", "", "")
        Catch ex As Exception
            MsgBox("No se actualizo bitacora")
        End Try
    End Sub

    Private Sub desbloquear(ByVal fecha As Date)
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.desbloquea_un_dia(user_id, id_medico, fecha)
        adap.Dispose()
        recarga_citas()
        pendietes_de_cancelar()
        colorea()
        Try
            actualiza_bitacora(user_id, "Desbloqueo", id_medico, fecha, "", "", "")
        Catch ex As Exception
            MsgBox("No se actualizo bitacora")
        End Try
    End Sub

    Private Sub btn_bloquear_Click(sender As System.Object, e As System.EventArgs) Handles btn_bloquear.Click
        Dim cmd As String, fecha As Date = CDate(calendario.SelectionRange.Start.Date)
        cmd = "select * from citas where status=1 and solofecha = '" + CDate(calendario.SelectionRange.Start.Date).ToShortDateString + "' and id_medico =" + id_medico.ToString
        Dim nc As Integer = leer_tabla(cmd).Rows.Count
        Dim ix As MsgBoxResult
        If nc > 0 Then
            ix = MsgBox(user_nick + ", Existen " + nc.ToString + " cita(s), Quieres bloquear el dia?", MsgBoxStyle.YesNo, "Bloquear el " + formatea_fecha(fecha))
        Else
            ix = MsgBox(user_nick + ", Quieres bloquear el dia?", MsgBoxStyle.YesNo, "Bloquear el " + formatea_fecha(fecha))
        End If
        If ix = MsgBoxResult.No Then Exit Sub
        bloquear(CDate(calendario.SelectionRange.Start.Date))
        colorea()

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        dgv.Columns("status").Visible = Not dgv.Columns("status").Visible
    End Sub

    Private Sub pendietes_de_cancelar()
        Dim cmd As String, cp As Integer
        cmd = "select * from citas where status=10"
        cp = leer_tabla(cmd).Rows.Count
        If cp > 0 Then
            Linkcitasxcancelar.Text = cp.ToString + " Citas por cancelar."
            Linkcitasxcancelar.Visible = True
        Else
            Linkcitasxcancelar.Visible = False

        End If

    End Sub

    Private Sub Linkcitasxcancelar_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Linkcitasxcancelar.LinkClicked
        My.Forms.Pendientes_pro_cancelar.ShowDialog()
        pendietes_de_cancelar()
        recarga_citas()
    End Sub

    Private Sub dgvalternas_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvalternas.CellDoubleClick
        Dim id As Integer = dgvalternas.CurrentRow.Cells("id").Value
        cargar(id, calendario.SelectionRange.Start.ToShortDateString)
    End Sub

    Private Sub colorea()
        btn_bloquear.Visible = True : Btn_desbloqueo.Visible = False
        For j As Integer = 0 To dgv.Rows.Count - 1
            Dim estatus As Integer = dgv.Rows(j).Cells("status").Value
            If estatus > 8 Then
                dgv.Rows(j).Cells("hora").Style.ForeColor = Color.Red
                btn_bloquear.Visible = False : Btn_desbloqueo.Visible = True
            Else
                dgv.Rows(j).Cells("hora").Style.ForeColor = Color.Black

            End If

        Next

    End Sub

    Private Sub Btn_desbloqueo_Click(sender As System.Object, e As System.EventArgs) Handles Btn_desbloqueo.Click
        Dim fecha As Date = CDate(calendario.SelectionRange.Start.Date)
        Dim ix As MsgBoxResult
        ix = MsgBox(user_nick + ", Quieres habilitar el dia?", MsgBoxStyle.YesNo, "Habilitar el " + formatea_fecha(fecha))
        desbloquear(fecha)
        recarga_citas()
    End Sub

    Private Sub btn_horario_Click(sender As System.Object, e As System.EventArgs) Handles btn_horario.Click
        My.Forms.horario.ShowDialog()
        If My.Forms.horario.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim fecha As DateTime = calendario.SelectionRange.Start.ToShortDateString
            fecha += " " + My.Forms.horario.DateTimePicker1.Value.ToShortTimeString
            Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
            adap.Insert(id_medico, fecha, "", "", "", "", "", user_id, False, 0)
            adap.Dispose()
            recarga_citas()
            'lee la informacion de la tabla
            txtfecha.Text = Format(fecha, "dddd dd MMMM")
            txttime.Value = fecha
            txtnombre.Text = ""
            txttelefono.Text = ""
            txtcelular.Text = ""
            txtmail.Text = ""
            txtcomentarios.Text = "Horario especial"
            SplitContainer6.Panel1Collapsed = False
            txtnombre.Focus()

        End If
    End Sub

   
    Private Sub btn_BloquearHorario_Click(sender As System.Object, e As System.EventArgs) Handles btn_BloquearHorario.Click
        'Bloquear un solo horario
        If dgv.CurrentRow.Cells("status").Value <> 0 Then MsgBox(user_nick + ", solo puede bloquear horarios disponibles") : Exit Sub
        Dim ix As MsgBoxResult, micita As v_citas
        micita.fecha = CDate(dgv.CurrentRow.Cells("fecha").Value.ToString)
        micita.hora = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString

        ix = MsgBox(user_nick + ",segura que quieres bloquear este Horario", MsgBoxStyle.YesNo, "Bloquear horario")
        Dim fecha As Date = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.actualiza_cita("", "", "", "", "", user_id, True, 9, id_medico, fecha)
        adap.Dispose()
        Try
            actualiza_bitacora(user_id, "bloquear horario", id_medico, micita.fecha.ToShortDateString + " " + micita.hora.ToShortTimeString, "-", "-", "-")
        Catch ex As Exception
            MsgBox("No se actualizo bitacora" + ex.Message)
        End Try
        recarga_citas()
    End Sub  'Bloquear un solo horario


    Private Sub btn_crear_nota_Click(sender As System.Object, e As System.EventArgs) Handles btn_crear_nota.Click
        My.Forms.crear_editar_nota.id = id_medico
        My.Forms.crear_editar_nota.fecha = fecha_seleccionada
        My.Forms.crear_editar_nota.ShowDialog()
        cargar_notas()
    End Sub

   
    
    Private Sub txtnombre_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtnombre.KeyDown, txttelefono.KeyDown, txtmail.KeyDown, txtcomentarios.KeyDown, txtcelular.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btn_completa_Click(sender As System.Object, e As System.EventArgs) Handles btn_completa.Click
        My.Forms.imprimir.imprimir(id_medico, calendario.SelectionRange.Start.ToShortDateString, NombreLabel1.Text)
        My.Forms.imprimir.Show()
    End Sub

    Private Sub btn_mañana_Click(sender As System.Object, e As System.EventArgs) Handles btn_mañana.Click
        My.Forms.imprimir.imprimir_mañana(id_medico, calendario.SelectionRange.Start.ToShortDateString, NombreLabel1.Text)
        My.Forms.imprimir.Show()
    End Sub

    Private Sub btn_tarde_Click(sender As System.Object, e As System.EventArgs) Handles btn_tarde.Click
        My.Forms.imprimir.imprimir_tarde(id_medico, calendario.SelectionRange.Start.ToShortDateString, NombreLabel1.Text)
        My.Forms.imprimir.Show()
    End Sub

    Private Sub agregar_manana()
        'agregar eventuales
        Dim linea As Integer
        Dim nombre As String
        Dim FECHA = calendario.SelectionRange.Start.ToShortDateString
        Dim adap As New db_baseDataSetTableAdapters.lista_esperaTableAdapter
        nombre = InputBox(user_nick + ", Teclea el nombre de la paciente", "Lista de espera", "")
        If nombre.Length < 1 Then Exit Sub
        linea = adap.siguiente(id_medico, FECHA)
        adap.Insert(id_medico, FECHA, linea, UCase(nombre), "", user_nick, "M")
        cargar_lista_espera()
    End Sub
    Private Sub agregar_tarde()
        'agregar eventuales
        Dim linea As Integer, nombre As String
        Dim FECHA = calendario.SelectionRange.Start.ToShortDateString
        Dim adap As New db_baseDataSetTableAdapters.lista_esperaTableAdapter
        nombre = InputBox(user_nick + ", Teclea el nombre de la paciente", "Lista de espera", "")
        If nombre.Length < 1 Then Exit Sub
        linea = adap.siguiente(id_medico, FECHA)
        adap.Insert(id_medico, FECHA, linea, UCase(nombre), "", user_nick, "T")
        cargar_lista_espera()
    End Sub

    Private Sub boton_tarde_Click(sender As System.Object, e As System.EventArgs) Handles boton_tarde.Click
        agregar_tarde()
    End Sub

    Private Sub btn_manana_Click(sender As System.Object, e As System.EventArgs) Handles btn_manana.Click
        agregar_manana()

    End Sub

    Private Sub DesbloquearHorarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DesbloquearHorarioToolStripMenuItem.Click
        'Bloquear un solo horario
        If dgv.CurrentRow.Cells("status").Value <> 9 Then MsgBox(user_nick + ", solo puede desbloquear horarios bloqueados!!") : Exit Sub
        Dim ix As MsgBoxResult, micita As v_citas
        micita.fecha = CDate(dgv.CurrentRow.Cells("fecha").Value.ToString)
        micita.hora = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString

        ix = MsgBox(user_nick + ",segura que quieres Desbloquea el horario", MsgBoxStyle.YesNo, "Desbloquear horario")
        Dim fecha As Date = dgv.CurrentRow.Cells(0).Value.ToString + " " + dgv.CurrentRow.Cells(1).Value.ToString
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.actualiza_cita("", "", "", "", "", user_id, True, 0, id_medico, fecha)
        adap.Dispose()
        Try
            actualiza_bitacora(user_id, "Desbloquear horario", id_medico, micita.fecha.ToShortDateString + " " + micita.hora.ToShortTimeString, "-", "-", "-")
        Catch ex As Exception
            MsgBox("No se actualizo bitacora")
        End Try
        recarga_citas()
    End Sub

    
    
End Class