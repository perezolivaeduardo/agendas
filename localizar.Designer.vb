<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class localizar
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_go = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.kfecha = New System.Windows.Forms.TextBox()
        Me.kid = New System.Windows.Forms.TextBox()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.kid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.kfecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_go)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Size = New System.Drawing.Size(539, 274)
        Me.SplitContainer1.SplitterDistance = 63
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.Agendas.My.Resources.Resources.Log_Off
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.Location = New System.Drawing.Point(493, 9)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(43, 41)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_go
        '
        Me.btn_go.BackgroundImage = Global.Agendas.My.Resources.Resources.Vista_Search
        Me.btn_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_go.Location = New System.Drawing.Point(452, 9)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(39, 41)
        Me.btn_go.TabIndex = 2
        Me.btn_go.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_go.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(91, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(355, 26)
        Me.TextBox1.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(539, 207)
        Me.dgv.TabIndex = 0
        '
        'kfecha
        '
        Me.kfecha.Location = New System.Drawing.Point(91, 38)
        Me.kfecha.Name = "kfecha"
        Me.kfecha.Size = New System.Drawing.Size(75, 20)
        Me.kfecha.TabIndex = 4
        '
        'kid
        '
        Me.kid.Location = New System.Drawing.Point(189, 38)
        Me.kid.Name = "kid"
        Me.kid.Size = New System.Drawing.Size(75, 20)
        Me.kid.TabIndex = 5
        '
        'localizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(539, 274)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "localizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "localizar una persona"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents kid As System.Windows.Forms.TextBox
    Friend WithEvents kfecha As System.Windows.Forms.TextBox
End Class
