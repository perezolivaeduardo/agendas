Public Class eliminar_diayhora

    Private Sub eliminar_diayhora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.Db_baseDataSet.citas)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.FillBydiayhora(Me.Db_baseDataSet.citas, dia.Value, id_medico.Text, hora.Value, minuto.Value)
    End Sub

    Private Sub dia_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dia.ValueChanged
        Dim i As Integer = dia.Value
        If i = 1 Then lbldia.Text = "Lunes"
        If i = 2 Then lbldia.Text = "Martes"
        If i = 3 Then lbldia.Text = "Miercoles"
        If i = 4 Then lbldia.Text = "jueves"
        If i = 5 Then lbldia.Text = "Viernes"
        If i = 6 Then lbldia.Text = "Sabado"
        If i = 7 Then lbldia.Text = "Domingo"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.Eliminar_citas_diaYhora(dia.Value, id_medico.Text, hora.Value, minuto.Value)
        adap.Dispose()
        MsgBox("Borrado")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        adap.eliminar_una_hora_de_toda_la_agenda(id_medico.Text, hora.Value, minuto.Value)
        adap.Dispose()
        MsgBox("Borrado")
    End Sub

    Private Sub CitasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CitasDataGridView.CellContentClick
        Dim f As Date
        f = CitasDataGridView.CurrentRow.Cells("dgvfecha").Value
        Dim dia As Integer = f.DayOfWeek
        MsgBox(dia)
    End Sub
End Class