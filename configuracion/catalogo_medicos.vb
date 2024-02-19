Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Drawing
Imports Image = System.Net.Mime.MediaTypeNames.Image

Public Class catalogo_medicos



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

    Private Sub btn_foto_Click(sender As Object, e As EventArgs) Handles btn_foto.Click
        Dim fileFoto As New OpenFileDialog
        fileFoto.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes GIF|*.gif|Imagenes BMP|*.bmp"
        fileFoto.ShowDialog()

        If fileFoto.FileName <> "" Then
            ' Cargar la imagen en el PictureBox
            Dim imagen As Bitmap = New Bitmap(fileFoto.FileName)
            ImgFoto.Image = imagen
            ' Ajustar el tamaño del PictureBox si es necesario
            ' ImgFoto.Size = New Size(imagen.Width, imagen.Height)
        End If

        ' Luego puedes guardar la imagen en tu base de datos con save_foto
        save_foto(ImgFoto.Image, Id_medicoTextBox.Text)


    End Sub

    Private Sub Foto()
        ' Actualizar Foto
        ImgFoto.Image = Nothing

        Try
            Dim id As String
            id = Id_medicoTextBox.Text
            Dim ms As New MemoryStream(Extraer_Foto(id))
            ' Asigna la imagen al control PictureBox
            Dim imagen As New Bitmap(ms)
            ImgFoto.Image = imagen
        Catch ex As Exception
            ' Maneja cualquier excepción que pueda ocurrir durante la carga de la imagen
            MessageBox.Show("Error al cargar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub MedicosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MedicosDataGridView.CellClick
        Foto()
    End Sub
End Class