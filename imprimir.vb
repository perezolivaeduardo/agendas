Public Class imprimir

    Public Sub imprimir(ByVal id As Integer, ByVal fecha As Date, ByVal medico As String)
        'TODO: esta línea de código carga datos en la tabla 'db_baseDataSet.sql_citas' Puede moverla o quitarla según sea necesario.
        Me.sql_citasTableAdapter.Fill(Me.db_baseDataSet.sql_citas, fecha.ToString("dd/MM/yyyy"), id)
        'TODO: esta línea de código carga datos en la tabla 'db_baseDataSet.lista_espera' Puede moverla o quitarla según sea necesario.
        Me.lista_esperaTableAdapter.FillByid_fecha(Me.db_baseDataSet.lista_espera, id, fecha)

        Dim rp(0 To 2) As Microsoft.Reporting.WinForms.ReportParameter
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("medico", medico, False)
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", fecha, False)
        rp(2) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", user_nick, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub imprimir_mañana(ByVal id As Integer, ByVal fecha As Date, ByVal medico As String)
        'TODO: esta línea de código carga datos en la tabla 'db_baseDataSet.sql_citas' Puede moverla o quitarla según sea necesario.
        Me.sql_citasTableAdapter.FillBymañana(Me.db_baseDataSet.sql_citas, fecha.ToString("dd/MM/yyyy"), id)
        'TODO: esta línea de código carga datos en la tabla 'db_baseDataSet.lista_espera' Puede moverla o quitarla según sea necesario.
        Me.lista_esperaTableAdapter.FillByturno(Me.db_baseDataSet.lista_espera, id, fecha, "M")

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("medico", medico, False)
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", fecha, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub imprimir_tarde(ByVal id As Integer, ByVal fecha As Date, ByVal medico As String)
        'TODO: esta línea de código carga datos en la tabla 'db_baseDataSet.sql_citas' Puede moverla o quitarla según sea necesario.
        Me.sql_citasTableAdapter.FillBytarde(Me.db_baseDataSet.sql_citas, fecha, id)
        'TODO: esta línea de código carga datos en la tabla 'db_baseDataSet.lista_espera' Puede moverla o quitarla según sea necesario.
        Me.lista_esperaTableAdapter.FillByturno(Me.db_baseDataSet.lista_espera, id, fecha.ToString("dd/MM/yyyy"), "T")

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("medico", medico, False)
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", fecha, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class