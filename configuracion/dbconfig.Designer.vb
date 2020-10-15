<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dbconfig
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Boton_open = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ldftxt = New System.Windows.Forms.TextBox
        Me.boton_subir = New System.Windows.Forms.Button
        Me.barra = New System.Windows.Forms.ProgressBar
        Me.cstxt = New System.Windows.Forms.TextBox
        Me.basetxt = New System.Windows.Forms.TextBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione la Base de Datos :"
        '
        'Boton_open
        '
        Me.Boton_open.Location = New System.Drawing.Point(419, 21)
        Me.Boton_open.Name = "Boton_open"
        Me.Boton_open.Size = New System.Drawing.Size(26, 20)
        Me.Boton_open.TabIndex = 3
        Me.Boton_open.Text = "..."
        Me.Boton_open.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Base de Datos |*.mdf"
        Me.OpenFileDialog1.ReadOnlyChecked = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(373, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(327, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Esc"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(4, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ldftxt
        '
        Me.ldftxt.Location = New System.Drawing.Point(89, 90)
        Me.ldftxt.Name = "ldftxt"
        Me.ldftxt.ReadOnly = True
        Me.ldftxt.Size = New System.Drawing.Size(210, 20)
        Me.ldftxt.TabIndex = 7
        '
        'boton_subir
        '
        Me.boton_subir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_subir.Location = New System.Drawing.Point(89, 47)
        Me.boton_subir.Name = "boton_subir"
        Me.boton_subir.Size = New System.Drawing.Size(91, 23)
        Me.boton_subir.TabIndex = 8
        Me.boton_subir.Text = "Bajar Base"
        Me.boton_subir.UseVisualStyleBackColor = True
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.Location = New System.Drawing.Point(0, 136)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(457, 26)
        Me.barra.TabIndex = 9
        '
        'cstxt
        '
        Me.cstxt.Location = New System.Drawing.Point(89, 76)
        Me.cstxt.Multiline = True
        Me.cstxt.Name = "cstxt"
        Me.cstxt.ReadOnly = True
        Me.cstxt.Size = New System.Drawing.Size(324, 54)
        Me.cstxt.TabIndex = 2
        '
        'basetxt
        '
        Me.basetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Agendas.My.MySettings.Default, "basededatos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.basetxt.Location = New System.Drawing.Point(4, 21)
        Me.basetxt.Name = "basetxt"
        Me.basetxt.ReadOnly = True
        Me.basetxt.Size = New System.Drawing.Size(409, 20)
        Me.basetxt.TabIndex = 0
        Me.basetxt.Text = Global.Agendas.My.MySettings.Default.cadena
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "rmdata.mdf"
        Me.SaveFileDialog1.Title = "Nombre de la base de datos"
        '
        'dbconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(457, 162)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.boton_subir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Boton_open)
        Me.Controls.Add(Me.cstxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.basetxt)
        Me.Controls.Add(Me.ldftxt)
        Me.Name = "dbconfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base de datos."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents basetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cstxt As System.Windows.Forms.TextBox
    Friend WithEvents Boton_open As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ldftxt As System.Windows.Forms.TextBox
    Friend WithEvents boton_subir As System.Windows.Forms.Button
    Friend WithEvents barra As System.Windows.Forms.ProgressBar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
