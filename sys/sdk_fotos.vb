Imports System.Data.SqlClient
Imports System.IO

Module sdk_fotos

    Public Sub save_foto(ByVal foto As Image, ByVal id As String)
        'cadena de conexion
        Dim conectar As New SqlConnection(My.Settings.cs.ToString)
        conectar.Open()
        Dim ms As New MemoryStream
        foto.Save(ms, foto.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer

        'realizamos la operacion SQL 
        Dim modificar As New SqlClient.SqlCommand()
        modificar.CommandType = System.Data.CommandType.Text
        modificar.CommandText = "Update medicos set foto=@imagen WHERE id_medico = '[ID]'"
        modificar.CommandText = modificar.CommandText.Replace("[ID]", id)
        modificar.Parameters.Add(New SqlParameter("@Imagen", SqlDbType.Image)).Value = arrImage

        'reliazamos la conexion
        modificar.Connection = conectar
        Try
            If ((modificar.ExecuteNonQuery <> 0)) Then
            End If
            '  Operaciones.CargarInformacion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Function Extraer_Foto(ByVal id As String) As Byte()
        Dim Cnx As New SqlClient.SqlConnection(My.Settings.cs)
        Try
            Dim SqlSelect As String = "Select foto From medicos Where id_medico = '[ID]' "
            SqlSelect = SqlSelect.Replace("[ID]", id)
            Dim Command As New SqlCommand(SqlSelect, Cnx)
            Cnx.Open()
            Dim MyPhoto() As Byte = CType(Command.ExecuteScalar(), Byte())
            Cnx.Close()
            Return MyPhoto
        Catch ex As Exception
            ' MsgBox(ex.Message)

        End Try

    End Function

End Module
