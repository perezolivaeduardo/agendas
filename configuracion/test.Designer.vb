<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.celular = New System.Windows.Forms.TextBox()
        Me.Mensaje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.doctor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hora = New System.Windows.Forms.TextBox()
        Me.Confirmar_cita = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(65, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SMS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'celular
        '
        Me.celular.Location = New System.Drawing.Point(65, 108)
        Me.celular.Name = "celular"
        Me.celular.Size = New System.Drawing.Size(100, 20)
        Me.celular.TabIndex = 1
        Me.celular.Text = "9992771556"
        '
        'Mensaje
        '
        Me.Mensaje.Location = New System.Drawing.Point(198, 108)
        Me.Mensaje.Multiline = True
        Me.Mensaje.Name = "Mensaje"
        Me.Mensaje.Size = New System.Drawing.Size(484, 20)
        Me.Mensaje.TabIndex = 2
        Me.Mensaje.Text = "Prueba"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Celular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mensaje"
        '
        'doctor
        '
        Me.doctor.Location = New System.Drawing.Point(65, 156)
        Me.doctor.Name = "doctor"
        Me.doctor.Size = New System.Drawing.Size(162, 20)
        Me.doctor.TabIndex = 5
        Me.doctor.Text = "Onesiforo Canto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Doctor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(240, 156)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(162, 20)
        Me.fecha.TabIndex = 7
        Me.fecha.Text = "Lunes 30 de Octubre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(424, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Hora"
        '
        'hora
        '
        Me.hora.Location = New System.Drawing.Point(424, 156)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(162, 20)
        Me.hora.TabIndex = 9
        Me.hora.Text = "10:00 am"
        '
        'Confirmar_cita
        '
        Me.Confirmar_cita.Location = New System.Drawing.Point(592, 156)
        Me.Confirmar_cita.Name = "Confirmar_cita"
        Me.Confirmar_cita.Size = New System.Drawing.Size(90, 23)
        Me.Confirmar_cita.TabIndex = 11
        Me.Confirmar_cita.Text = "Confirmar Cita"
        Me.Confirmar_cita.UseVisualStyleBackColor = True
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Confirmar_cita)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.doctor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mensaje)
        Me.Controls.Add(Me.celular)
        Me.Controls.Add(Me.Button1)
        Me.Name = "test"
        Me.Text = "test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents celular As TextBox
    Friend WithEvents Mensaje As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents doctor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents hora As TextBox
    Friend WithEvents Confirmar_cita As Button
End Class
