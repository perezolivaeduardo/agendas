Public Class login
    Public login As Boolean = False
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim adap As New db_baseDataSetTableAdapters.tbl_usuariosTableAdapter
        Dim tbl As New DataTable
        tbl = adap.GetDataBylogin(usuario.Text, pw.Text)
        If tbl.Rows.Count = 0 Then
            MsgBox("Verifique la informacion")
            usuario.Text = ""
            pw.Text = ""
            usuario.Select()
        Else
            user_id = tbl.Rows(0).Item(0)
            user_nombre = tbl.Rows(0).Item(1)
            user_nick = tbl.Rows(0).Item("nik")
            user_nivel = tbl.Rows(0).Item("nivel")
            login = True
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If My.Computer.Name = "SISTEMAS" Then
            usuario.Text = "EDU"
            pw.Text = "99"
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Computer.Name = "SISTEMAS" Then
            usuario.Text = "EDU"
            pw.Text = "99"
        End If
    End Sub
End Class