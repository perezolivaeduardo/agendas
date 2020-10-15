Imports Microsoft.Win32

Public Class cfg_generales

    Private Sub cfg_generales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.tbl_generales' Puede moverla o quitarla según sea necesario.
        Me.Tbl_generalesTableAdapter.Fill(Me.Db_baseDataSet.tbl_generales)
        If Me.Db_baseDataSet.tbl_generales.Rows.Count = 0 Then
            Me.Tbl_generalesBindingSource.AddNew()
            Me.IdTextBox.Text = "1"
            Me.IdTextBox.ReadOnly = True
            Me.NombreTextBox.Focus()
        End If
        Me.linkfileini.Text = fileini
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.Tbl_generalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.OpenFileDialog.ShowDialog()
        Me.ArchivodelogoTextBox.Text = Me.OpenFileDialog.FileName
    End Sub

    Private Sub ArchivodelogoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivodelogoTextBox.TextChanged
        Try
            logo.Load(Me.ArchivodelogoTextBox.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub linkfileini_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkfileini.LinkClicked
        Process.Start(fileini)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        My.Forms.dbconfig.Show()
    End Sub
End Class