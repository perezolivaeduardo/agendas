Imports System.Windows.Forms

Public Class Selecciona_persona

    Public paterno As String
    Public materno As String
    Public nombre As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        nombre = dgv.CurrentRow.Cells("nombre").Value
        paterno = dgv.CurrentRow.Cells("paterno").Value
        materno = dgv.CurrentRow.Cells("materno").Value
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Selecciona_persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Cargar(tbl As DataTable)
        dgv.DataSource = tbl
        For j = 0 To 4
            dgv.Columns(j).Visible = False
        Next
        dgv.Rows(0).Selected = True

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        nombre = dgv.CurrentRow.Cells("nombre").Value
        paterno = dgv.CurrentRow.Cells("paterno").Value
        materno = dgv.CurrentRow.Cells("materno").Value

    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        nombre = dgv.CurrentRow.Cells("nombre").Value
        paterno = dgv.CurrentRow.Cells("paterno").Value
        materno = dgv.CurrentRow.Cells("materno").Value
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
