Public Class main

    
    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()

        Dim f As Integer = FreeFile()
        Try
            FileOpen(f, fileini, OpenMode.Input, OpenAccess.Read)
            My.Settings.cadena = LineInput(f)
            FileClose(f)
        Catch ex As Exception
            MsgBox(ex.Message)
            FileClose(f)
        End Try

        My.Forms.login.ShowDialog()
        If My.Forms.login.login = False Then End
        
        If user_nivel.ToString < 1 Then ToolStrip1.Visible = False
        Me.Top = 1 : Me.Left = 0
        Me.Height = 750
        carga_lista()
        Me.Text = "Agendas Electronicas V.3.0"
    End Sub

    Private Sub DatosGeneralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosGeneralesToolStripMenuItem.Click
        My.Forms.cfg_generales.ShowDialog()
    End Sub

    Private Sub MEDICOSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MEDICOSToolStripMenuItem.Click
        My.Forms.catalogo_medicos.Show()
    End Sub

    Private Sub CrearAgendasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrearAgendasToolStripMenuItem.Click
        My.Forms.crear_agendas.Show()
    End Sub

   
    Private Sub dgvm_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvm.CellClick
        Dim id As Integer, fecha As Date
        id = dgvm.CurrentRow.Cells(0).Value
        fecha = dgvm.CurrentRow.Cells(2).Value
        frm_agenda.cargar(id, fecha)
        frm_agenda.ShowDialog()
        carga_lista()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        My.Forms.usuarios.Show()
    End Sub

    Private Sub PruebasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PruebasToolStripMenuItem.Click
        My.Forms.pruebas.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        carga_lista()
    End Sub
    Private Sub carga_lista()
        'TODO: esta línea de código carga datos en la tabla 'Db_baseDataSet.citas_disponibles' Puede moverla o quitarla según sea necesario.
        Me.Citas_disponiblesTableAdapter.Fill_primer_cita(Me.Db_baseDataSet.citas_disponibles, Now.ToString)
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        My.Forms.localizar.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub BTN_BITACORA_Click(sender As System.Object, e As System.EventArgs) Handles BTN_BITACORA.Click
        My.Forms.bitacora.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked_1(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
