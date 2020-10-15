Public Class pruebas

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        Dim tbl As New DataTable
        tbl = leer_db("select * from sql_pacientes")
        Dim max As Integer = tbl.Rows.Count - 1
        Dim cmd As String
        cmd = "select * from citas where fecha <= '" + del.Value.ToShortDateString + "'  and id_medico=" + txtmedico.Text
        MsgBox(cmd)
        'cmd = "select * from citas where  convert(varchar(10),cast(fecha as date),103) < #" + del.Value.ToString + "# and id_medico =" + txtmedico.Text
        Dim tbcitas As New DataTable
        tbcitas = leer_tabla(cmd)
        MsgBox(tbcitas.Rows.Count)
        Dim Random As New Random()
        Dim contador As Integer
        For j As Integer = 0 To tbcitas.Rows.Count - 1
            Dim id As Integer, fe As Date
            id = tbcitas.Rows(j).Item(0)
            fe = tbcitas.Rows(j).Item(1)
            contador = Random.Next(1, max)
            Dim nombre As String = tbl.Rows(contador).Item(1)
            adap.actualiza_cita(nombre, "111", "222", "mundode@hotmail.com", "Automatico", 0, True, 1, id, fe)
          
        Next

    End Sub

   

    Private Sub NotasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles NotasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NotasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)

    End Sub

    Private Sub pruebas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.notas' Puede moverla o quitarla según sea necesario.
        Me.NotasTableAdapter.Fill(Me.Db_baseDataSet.notas)

    End Sub
End Class