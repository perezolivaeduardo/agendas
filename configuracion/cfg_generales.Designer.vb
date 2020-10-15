<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cfg_generales
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim MunicipioLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim RfcLabel As System.Windows.Forms.Label
        Dim ArchivodelogoLabel As System.Windows.Forms.Label
        Dim ComercialLabel As System.Windows.Forms.Label
        Me.Tbl_generalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_generalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_baseDataSet = New Agendas.db_baseDataSet()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.MunicipioTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CpTextBox = New System.Windows.Forms.TextBox()
        Me.RfcTextBox = New System.Windows.Forms.TextBox()
        Me.ArchivodelogoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Tbl_generalesTableAdapter = New Agendas.db_baseDataSetTableAdapters.tbl_generalesTableAdapter()
        Me.TableAdapterManager = New Agendas.db_baseDataSetTableAdapters.TableAdapterManager()
        Me.ComercialTextBox = New System.Windows.Forms.TextBox()
        Me.linkfileini = New System.Windows.Forms.LinkLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        MunicipioLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        RfcLabel = New System.Windows.Forms.Label()
        ArchivodelogoLabel = New System.Windows.Forms.Label()
        ComercialLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_generalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_generalesBindingNavigator.SuspendLayout()
        CType(Me.Tbl_generalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(130, 155)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(25, 20)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(21, 107)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(69, 20)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(11, 137)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(79, 20)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "Dirección:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColoniaLabel.Location = New System.Drawing.Point(24, 200)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(66, 20)
        ColoniaLabel.TabIndex = 7
        ColoniaLabel.Text = "Colonia:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadLabel.Location = New System.Drawing.Point(27, 230)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(63, 20)
        CiudadLabel.TabIndex = 9
        CiudadLabel.Text = "Ciudad:"
        '
        'MunicipioLabel
        '
        MunicipioLabel.AutoSize = True
        MunicipioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MunicipioLabel.Location = New System.Drawing.Point(11, 259)
        MunicipioLabel.Name = "MunicipioLabel"
        MunicipioLabel.Size = New System.Drawing.Size(79, 20)
        MunicipioLabel.TabIndex = 11
        MunicipioLabel.Text = "Municipio:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(26, 288)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(64, 20)
        EstadoLabel.TabIndex = 13
        EstadoLabel.Text = "Estado:"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpLabel.Location = New System.Drawing.Point(48, 317)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(42, 20)
        CpLabel.TabIndex = 15
        CpLabel.Text = "C.P.:"
        '
        'RfcLabel
        '
        RfcLabel.AutoSize = True
        RfcLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RfcLabel.Location = New System.Drawing.Point(32, 346)
        RfcLabel.Name = "RfcLabel"
        RfcLabel.Size = New System.Drawing.Size(58, 20)
        RfcLabel.TabIndex = 17
        RfcLabel.Text = "R.F.C.:"
        '
        'ArchivodelogoLabel
        '
        ArchivodelogoLabel.AutoSize = True
        ArchivodelogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArchivodelogoLabel.Location = New System.Drawing.Point(39, 392)
        ArchivodelogoLabel.Name = "ArchivodelogoLabel"
        ArchivodelogoLabel.Size = New System.Drawing.Size(49, 20)
        ArchivodelogoLabel.TabIndex = 19
        ArchivodelogoLabel.Text = "Logo:"
        '
        'ComercialLabel
        '
        ComercialLabel.AutoSize = True
        ComercialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComercialLabel.Location = New System.Drawing.Point(10, 77)
        ComercialLabel.Name = "ComercialLabel"
        ComercialLabel.Size = New System.Drawing.Size(83, 20)
        ComercialLabel.TabIndex = 23
        ComercialLabel.Text = "Comercial:"
        '
        'Tbl_generalesBindingNavigator
        '
        Me.Tbl_generalesBindingNavigator.AddNewItem = Nothing
        Me.Tbl_generalesBindingNavigator.BindingSource = Me.Tbl_generalesBindingSource
        Me.Tbl_generalesBindingNavigator.CountItem = Nothing
        Me.Tbl_generalesBindingNavigator.DeleteItem = Nothing
        Me.Tbl_generalesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Tbl_generalesBindingNavigator.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.Tbl_generalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.Tbl_generalesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_generalesBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_generalesBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_generalesBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_generalesBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_generalesBindingNavigator.Name = "Tbl_generalesBindingNavigator"
        Me.Tbl_generalesBindingNavigator.PositionItem = Nothing
        Me.Tbl_generalesBindingNavigator.Size = New System.Drawing.Size(503, 71)
        Me.Tbl_generalesBindingNavigator.TabIndex = 0
        Me.Tbl_generalesBindingNavigator.Text = "BindingNavigator1"
        '
        'Tbl_generalesBindingSource
        '
        Me.Tbl_generalesBindingSource.DataMember = "tbl_generales"
        Me.Tbl_generalesBindingSource.DataSource = Me.Db_baseDataSet
        '
        'Db_baseDataSet
        '
        Me.Db_baseDataSet.DataSetName = "db_baseDataSet"
        Me.Db_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Agendas.My.Resources.Resources.Log_Off
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(163, 155)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(33, 26)
        Me.IdTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(96, 107)
        Me.NombreTextBox.MaxLength = 50
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(361, 26)
        Me.NombreTextBox.TabIndex = 4
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(96, 137)
        Me.DireccionTextBox.MaxLength = 150
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(361, 60)
        Me.DireccionTextBox.TabIndex = 6
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "colonia", True))
        Me.ColoniaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(96, 200)
        Me.ColoniaTextBox.MaxLength = 50
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(361, 26)
        Me.ColoniaTextBox.TabIndex = 8
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "ciudad", True))
        Me.CiudadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadTextBox.Location = New System.Drawing.Point(96, 230)
        Me.CiudadTextBox.MaxLength = 50
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(185, 26)
        Me.CiudadTextBox.TabIndex = 10
        '
        'MunicipioTextBox
        '
        Me.MunicipioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "municipio", True))
        Me.MunicipioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MunicipioTextBox.Location = New System.Drawing.Point(96, 259)
        Me.MunicipioTextBox.MaxLength = 40
        Me.MunicipioTextBox.Name = "MunicipioTextBox"
        Me.MunicipioTextBox.Size = New System.Drawing.Size(185, 26)
        Me.MunicipioTextBox.TabIndex = 12
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.Location = New System.Drawing.Point(96, 288)
        Me.EstadoTextBox.MaxLength = 40
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(185, 26)
        Me.EstadoTextBox.TabIndex = 14
        '
        'CpTextBox
        '
        Me.CpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "cp", True))
        Me.CpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpTextBox.Location = New System.Drawing.Point(96, 317)
        Me.CpTextBox.Name = "CpTextBox"
        Me.CpTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CpTextBox.TabIndex = 16
        '
        'RfcTextBox
        '
        Me.RfcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "rfc", True))
        Me.RfcTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RfcTextBox.Location = New System.Drawing.Point(96, 346)
        Me.RfcTextBox.MaxLength = 15
        Me.RfcTextBox.Name = "RfcTextBox"
        Me.RfcTextBox.Size = New System.Drawing.Size(185, 26)
        Me.RfcTextBox.TabIndex = 18
        '
        'ArchivodelogoTextBox
        '
        Me.ArchivodelogoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "archivodelogo", True))
        Me.ArchivodelogoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivodelogoTextBox.Location = New System.Drawing.Point(96, 389)
        Me.ArchivodelogoTextBox.Name = "ArchivodelogoTextBox"
        Me.ArchivodelogoTextBox.Size = New System.Drawing.Size(331, 26)
        Me.ArchivodelogoTextBox.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.Filter = "JPG |*.jpg|PNG|*.png"
        Me.OpenFileDialog.Title = "Archivo de logotipo"
        '
        'logo
        '
        Me.logo.Location = New System.Drawing.Point(287, 235)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(188, 137)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 22
        Me.logo.TabStop = False
        '
        'Tbl_generalesTableAdapter
        '
        Me.Tbl_generalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.citasTableAdapter = Nothing
        Me.TableAdapterManager.EsquemaTableAdapter = Nothing
        Me.TableAdapterManager.lista_esperaTableAdapter = Nothing
        Me.TableAdapterManager.medicosTableAdapter = Nothing
        Me.TableAdapterManager.sql_citasTableAdapter = Nothing
        Me.TableAdapterManager.tbl_generalesTableAdapter = Me.Tbl_generalesTableAdapter
        Me.TableAdapterManager.tbl_usuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agendas.db_baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComercialTextBox
        '
        Me.ComercialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_generalesBindingSource, "comercial", True))
        Me.ComercialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComercialTextBox.Location = New System.Drawing.Point(96, 74)
        Me.ComercialTextBox.MaxLength = 50
        Me.ComercialTextBox.Name = "ComercialTextBox"
        Me.ComercialTextBox.Size = New System.Drawing.Size(361, 26)
        Me.ComercialTextBox.TabIndex = 24
        '
        'linkfileini
        '
        Me.linkfileini.AutoSize = True
        Me.linkfileini.Location = New System.Drawing.Point(52, 428)
        Me.linkfileini.Name = "linkfileini"
        Me.linkfileini.Size = New System.Drawing.Size(59, 13)
        Me.linkfileini.TabIndex = 25
        Me.linkfileini.TabStop = True
        Me.linkfileini.Text = "LinkLabel1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Agendas.My.Resources.Resources.Search_Engine
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'cfg_generales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 451)
        Me.Controls.Add(Me.linkfileini)
        Me.Controls.Add(ComercialLabel)
        Me.Controls.Add(Me.ComercialTextBox)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ArchivodelogoLabel)
        Me.Controls.Add(Me.ArchivodelogoTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(ColoniaLabel)
        Me.Controls.Add(Me.ColoniaTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(MunicipioLabel)
        Me.Controls.Add(Me.MunicipioTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(CpLabel)
        Me.Controls.Add(Me.CpTextBox)
        Me.Controls.Add(RfcLabel)
        Me.Controls.Add(Me.RfcTextBox)
        Me.Controls.Add(Me.Tbl_generalesBindingNavigator)
        Me.Name = "cfg_generales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos generales del Sistema"
        CType(Me.Tbl_generalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_generalesBindingNavigator.ResumeLayout(False)
        Me.Tbl_generalesBindingNavigator.PerformLayout()
        CType(Me.Tbl_generalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_baseDataSet As Agendas.db_baseDataSet
    Friend WithEvents Tbl_generalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_generalesTableAdapter As Agendas.db_baseDataSetTableAdapters.tbl_generalesTableAdapter
    Friend WithEvents TableAdapterManager As Agendas.db_baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_generalesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColoniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MunicipioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RfcTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArchivodelogoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents ComercialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents linkfileini As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
