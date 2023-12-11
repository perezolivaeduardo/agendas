Public Class Configurar_Agenda
    Private Sub MedicosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MedicosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EsquemaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)

    End Sub


    Public Sub Cargar(ByRef id_medico As Integer)
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.Esquema' Puede moverla o quitarla según sea necesario.
        Me.EsquemaTableAdapter.FillByID(Me.Db_baseDataSet.Esquema, id_medico)
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.medicos' Puede moverla o quitarla según sea necesario.
        Me.MedicosTableAdapter.FillByid(Me.Db_baseDataSet.medicos, id_medico)
    End Sub

    Public Sub Actualizar_agenda(ByVal ID_medico As Integer)
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        Dim ffi, ff, fecha, fecha_cita As DateTime
        ffi = Now.Date
        ff = Now.Date.AddDays(365)
        fecha = ffi

        Dim ndias As Integer = DateDiff(DateInterval.Day, ffi, ff)
        avance.Maximum = ndias + 2
        avance.Value = 1

        Dim Esquema As DataTable = leer_tabla("select * from esquema where id_medico =" + ID_medico.ToString)
        While fecha <= ff
            Dim dia As Integer = fecha.DayOfWeek, horacita As TimeSpan
            If dia = 0 Then dia = 6
            For j As Integer = 0 To Esquema.Rows.Count - 1
                If Esquema.Rows(j).Item(dia + 1) = True Then
                    horacita = Esquema.Rows(j).Item(1)
                    fecha_cita = fecha.ToShortDateString + " " + horacita.Duration.ToString
                    Try
                        adap.Insert(id_medico, fecha_cita, "", "", "", "", "", 0, False, 0)
                    Catch ex As Exception

                    End Try
                End If
            Next j
            fecha = fecha.AddDays(1)
            avance.Value += 1
        End While

    End Sub
End Class