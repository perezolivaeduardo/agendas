Public Class test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SMS(Mensaje.Text, celular.Text)
    End Sub

    Private Sub Confirmar_cita_Click(sender As Object, e As EventArgs) Handles Confirmar_cita.Click
        WhatsApp_Confirmar_Cita(celular.Text, fecha.Text, hora.Text, doctor.Text)
    End Sub
End Class