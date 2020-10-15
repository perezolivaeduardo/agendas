Public Class crear_editar_nota
    Public id As Integer
    Public fecha As Date
    Public nuevo As Boolean

    
    Private Sub crear_editar_nota_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim nuevo As Boolean
        nuevo = valida_nota(id, fecha)
        If nuevo = False Then
            btn_ok.Text = "Actualizar"
            Dim adap As New db_baseDataSetTableAdapters.notasTableAdapter
            txtnota.Text = adap.get_nota(id, fecha).Rows(0).Item("nota")
        Else
            txtnota.Text = ""
            btn_ok.Text = "Crear"
        End If


    End Sub

    Private Sub btn_ok_Click(sender As System.Object, e As System.EventArgs) Handles btn_ok.Click
        Dim adap As New db_baseDataSetTableAdapters.notasTableAdapter
        nuevo = valida_nota(id, fecha)
        If nuevo = True Then
            adap.Insert(id, fecha, txtnota.Text)
        Else
            adap.Actualizar_nota(txtnota.Text, id, fecha)
        End If
        adap.Dispose()
        Close()
    End Sub
End Class