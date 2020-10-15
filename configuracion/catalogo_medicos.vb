Public Class catalogo_medicos

    Private Sub MedicosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub catalogo_medicos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.medicos' Puede moverla o quitarla según sea necesario.
        Me.MedicosTableAdapter.Fill(Me.Db_baseDataSet.medicos)

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.MedicosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_baseDataSet)
        Me.Close()
    End Sub

    Private Sub btn_color_Click(sender As System.Object, e As System.EventArgs) Handles btn_color.Click
        ColorDialog1.ShowDialog()
        ColorTextBox.Text = ColorDialog1.Color.ToArgb

    End Sub

    Private Sub ColorTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ColorTextBox.TextChanged
        Try
            ColorTextBox.BackColor = Color.FromArgb(ColorTextBox.Text)
        Catch ex As Exception

        End Try

    End Sub
End Class