Imports System.IO
Imports System.Net
Imports System.Text

Module Sdk_msg
    '' Ubiaion de la API


    Public Function SMS(Mensaje, Celular) As Boolean
        If Celular = "0000000000" Then Return False
        Dim parametros As String = My.Settings.ApiServer + "msg/sms.php?celular={{celular}}&mensaje={{mensaje}}"

        parametros = parametros.Replace("{{mensaje}}", Mensaje)
        parametros = parametros.Replace("{{celular}}", Celular)


        Dim coki As New System.Net.CookieContainer

        Dim Resp = ApiMsg(parametros, coki)

        MsgBox(Resp)
    End Function

    Public Function WhatsApp_Confirmar_Cita(Celular As String, fecha As DateTime, hora As String, medico As String) As Boolean
        If Celular = "0000000000" Then Return False 
        Dim hr As DateTime
        Dim fe As String = Format(fecha, "dddd d 'de' MMMM")

        hr = hora

        Dim Template As String = "Le informamos que su cita con {{1}} quedó confirmada para el día {{2}} a las {{3}}
Dudas o aclaraciones marcar al 9999286231 ó 9999239899 y con gusto te atenderemos."
        Template = Template.Replace("{{1}}", medico)
        Template = Template.Replace("{{2}}", fe)
        Template = Template.Replace("{{3}}", hr.ToShortTimeString)

        Dim parametros As String = My.Settings.ApiServer + "msg/whatsapp.php?celular={{celular}}&mensaje={{mensaje}}"

        parametros = parametros.Replace("{{celular}}", Celular)
        parametros = parametros.Replace("{{mensaje}}", Template)


        Dim coki As New System.Net.CookieContainer

        Dim Resp = ApiMsg(parametros, coki)

        If Resp.Contains("Error") Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function WhatsApp_Cancelar_Cita(Celular, fecha, hora, medico) As Boolean
        If Celular = "0000000000" Then Return False
        'TODO: poner nuevo teplete y agregar lo de doctor.

        Dim Template As String = "Le informamos que su cita con {{1}} para el día {{2}} a las {{3}} quedo cancelada.
Dudas o aclaraciones marcar al 9999286231 o 9999239899 y con gusto te atenderemos."


        Template = Template.Replace("{{1}}", medico)
        Template = Template.Replace("{{2}}", fecha)
        Template = Template.Replace("{{3}}", hora)

        Dim parametros As String = My.Settings.ApiServer + "msg/whatsapp.php?celular={{celular}}&mensaje={{mensaje}}"

        parametros = parametros.Replace("{{celular}}", Celular)
        parametros = parametros.Replace("{{mensaje}}", Template)


        Dim coki As New System.Net.CookieContainer

        Dim Resp = ApiMsg(parametros, coki)

        If Resp.Contains("Error") Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function WhatsApp_Mensaje(celular, mensaje) As Boolean
        If celular = "0000000000" Then Return False
        Dim Template As String = mensaje

        Dim parametros As String = My.Settings.ApiServer + "msg/whatsapp.php?celular={{celular}}&mensaje={{mensaje}}"

        parametros = parametros.Replace("{{celular}}", celular)
        parametros = parametros.Replace("{{mensaje}}", Template)


        Dim coki As New System.Net.CookieContainer

        Dim Resp = ApiMsg(parametros, coki)

        If Resp.Contains("Error") Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function ApiMsg(ByVal cURL As String, ByRef cookies As System.Net.CookieContainer) As String
        Dim urlAddress As String = cURL
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse
        request = CType(WebRequest.Create(cURL), HttpWebRequest)
        request.Method = "GET"
        request.AllowAutoRedirect = False
        request.CookieContainer = cookies

        Try
            response = CType(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                Dim reader As New StreamReader(response.GetResponseStream())
                Dim result As String = reader.ReadToEnd()
                reader.Close()
                Return result
            Else
                ' Aquí puedes manejar otros códigos de estado si es necesario
                Return String.Empty
            End If
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir durante la solicitud
            MsgBox(ex.Message)
            Return String.Empty
        End Try
    End Function


    Public Function MI_IP() As String
        Try
            Return New System.Net.WebClient().DownloadString("http://programacionintegral.com/ip.php")
        Catch ex As Exception
            Return "????"
        End Try

    End Function


End Module
