Imports System.Text.RegularExpressions
Module sdk
    Public fileini As String
    Public user_id As Integer
    Public user_nombre As String
    Public user_nick As String
    Public user_nivel As Integer


    Structure cmd_result
        Dim ok As Boolean
        Dim msg As String
    End Structure

    Structure Persona
        Dim celular As String
        Dim paterno As String
        Dim materno As String
        Dim nombre As String
        Dim existe As Boolean
    End Structure

    Structure v_citas
        Dim fecha As Date
        Dim hora As DateTime
        Dim id_medico As Integer
        Dim nombre As String
        Dim tel As String
        Dim cel As String
        Dim email As String
        Dim comentarios As String
        Dim user As Integer
        Dim status As Integer
    End Structure

    Public Sub inicializa()
        fileini = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\agendas.ini"
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists(fileini)
        Dim file As New OpenFileDialog
        If fileExists = False Then
            My.Forms.dbconfig.ShowDialog()
            fileExists = My.Computer.FileSystem.FileExists(fileini)
            If fileExists = False Then
                MsgBox("No se genero el archivo de Inicio")
                End
            End If

        End If

    End Sub

    Function leer_tabla(ByVal cmd As String) As DataTable
        Dim da As New SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim cs As String = My.Settings.cs
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(da)
        Try
            da.Fill(tbl)
        Catch ex As Exception

        End Try
        leer_tabla = tbl
        tbl.Dispose()
        da.Dispose()
    End Function

    Function leer_db(ByVal cmd As String) As DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Dim tbl As New DataTable
        ' Dim cs As String = My.Settings.dbclinica
        ' da = New Data.OleDb.OleDbDataAdapter(cmd, cs)
        da.Fill(tbl)
        leer_db = tbl
    End Function

    Function commando(ByVal cmd As String) As cmd_result
        Try
            Using conection As New SqlClient.SqlConnection(My.Settings.cs)
                conection.Open()
                Dim AdaptadorDeDatos As New Data.SqlClient.SqlDataAdapter
                Dim cs As String = My.Settings.cs.ToString
                Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.UpdateCommand = Command
                AdaptadorDeDatos.UpdateCommand.ExecuteNonQuery()
                commando.msg = "Ok"
                commando.ok = True
                conection.Close()
            End Using
        Catch ex As Exception
            commando.ok = False
            commando.msg = ex.Message
            MsgBox(ex.Message)
        End Try

    End Function

    Function formatea_fecha(ByVal fecha As Date) As String
        Try
            formatea_fecha = Format(fecha, "dddd dd MMMM")
        Catch ex As Exception
            formatea_fecha = ""
        End Try

    End Function

    Function citas_Disponibles_x_dia(ByVal fecha As Date, ByVal id_medico As Integer) As DataTable
        Dim cmd As String
        cmd = "SELECT citas.id_medico AS ID, medicos.Nombre as Medico, COUNT(citas.nombre) AS Disp FROM citas INNER JOIN medicos ON citas.id_medico = medicos.id_medico " _
        & "GROUP BY citas.id_medico, citas.solofecha, medicos.Nombre HAVING citas.solofecha = '[fecha]' and citas.id_medico <>" + id_medico.ToString
        cmd = cmd.Replace("[fecha]", fecha.ToShortDateString)
        ' Dim adap As New db_baseDataSetTableAdapters.citasTableAdapter
        'citas_Disponibles_x_dia = adap.GetDisponibles(fecha)
        citas_Disponibles_x_dia = leer_tabla(cmd)
    End Function

    Function actualiza_bitacora(ByVal id_user As Integer, ByVal tipo As String, ByVal id_medico As Integer, ByVal cita_fecha As DateTime, ByVal nombre As String, ByVal tel As String, ByVal comentarios As String) As Boolean
        'Try
        Dim adap As New db_baseDataSetTableAdapters.bitacoraTableAdapter
        adap.Insert(Date.Today.ToShortDateString + " " + Date.Today.ToShortTimeString, id_user, tipo, id_medico, cita_fecha, nombre, tel, comentarios)
        adap.Dispose()
        actualiza_bitacora = True

        '  Catch ex As Exception
        'actualiza_bitacora = False
        '  End Try

    End Function

    Function valida_nota(ByVal id As Integer, ByVal fecha As Date) As Boolean
        Dim adap As New db_baseDataSetTableAdapters.notasTableAdapter
        Try
            Dim nota As String = adap.get_nota(id, fecha).Rows(0).Item(0)
            valida_nota = False
        Catch ex As Exception
            valida_nota = True
        End Try
    End Function

    Function EsNumeroCelularValido(phoneNumber As String) As Boolean
        ' Define una expresión regular para verificar el formato del número de teléfono.
        Dim pattern As String = "^\d{3}\d{3}\d{4}$"

        ' Usa la clase Regex para hacer coincidir la cadena con la expresión regular.
        Dim regex As New Regex(pattern)

        ' Realiza la coincidencia y verifica si es válida.
        Dim isMatch As Boolean = regex.IsMatch(phoneNumber)

        Return isMatch
    End Function

    Public Function ValidaPersona(celular) As Persona
        Dim Kpersona As Persona
        Dim sql As String = "Select * from tbl_directorio where celular ='" + celular + "'"
        Dim tbl As DataTable
        tbl = leer_tabla(sql)
        If tbl.Rows.Count = 0 Then
            Kpersona.existe = False
        Else
            If tbl.Rows.Count = 1 Then
                With Kpersona
                    .celular = celular
                    .paterno = tbl.Rows(0).Item("Paterno")
                    .materno = tbl.Rows(0).Item("Materno")
                    .nombre = tbl.Rows(0).Item("Nombre")
                    .existe = True
                End With
            Else
                Dim frm As New Selecciona_persona
                frm.Cargar(tbl)
                frm.ShowDialog()
                If frm.DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Kpersona.celular = celular
                    Kpersona.paterno = frm.paterno
                    Kpersona.materno = frm.materno
                    Kpersona.nombre = frm.nombre
                    Kpersona.existe = True
                Else
                    Kpersona.existe = False
                End If
            End If

        End If
        Return Kpersona
    End Function

    Public Function FnAgregar_persona(celular As String, paterno As String, materno As String, nombre As String) As Boolean
        Try
            Dim adap As New db_baseDataSetTableAdapters.tbl_directorioTableAdapter
            adap.Insert(celular, paterno, materno, nombre)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function

    Public Function FN_NombreMedico(id) As String
        Dim sql As String
        sql = "SELECT CONCAT(CASE WHEN trato = 'Dr.' THEN 'el' WHEN trato = 'Dra.' THEN 'la' ELSE '' END,' ',trato,' ', nombre   ) AS nombre_completo FROM medicos where id_medico=" + id.ToString
        Dim Doctor As String = leer_tabla(sql).Rows(0).Item(0)
        Return Doctor
    End Function

End Module
