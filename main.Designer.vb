<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.DatosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEDICOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearAgendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BTN_BITACORA = New System.Windows.Forms.ToolStripButton()
        Me.dgvm = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisponibleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitasdisponiblesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_baseDataSet = New Agendas.db_baseDataSet()
        Me.Citas_disponiblesTableAdapter = New Agendas.db_baseDataSetTableAdapters.citas_disponiblesTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasdisponiblesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.BTN_BITACORA})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(607, 71)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosGeneralesToolStripMenuItem, Me.MEDICOSToolStripMenuItem, Me.CrearAgendasToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ToolStripSeparator1, Me.PruebasToolStripMenuItem})
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.Agendas.My.Resources.Resources.Search_Engine
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(80, 68)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'DatosGeneralesToolStripMenuItem
        '
        Me.DatosGeneralesToolStripMenuItem.Name = "DatosGeneralesToolStripMenuItem"
        Me.DatosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.DatosGeneralesToolStripMenuItem.Text = "Datos Generales"
        '
        'MEDICOSToolStripMenuItem
        '
        Me.MEDICOSToolStripMenuItem.Name = "MEDICOSToolStripMenuItem"
        Me.MEDICOSToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.MEDICOSToolStripMenuItem.Text = "MEDICOS"
        '
        'CrearAgendasToolStripMenuItem
        '
        Me.CrearAgendasToolStripMenuItem.Name = "CrearAgendasToolStripMenuItem"
        Me.CrearAgendasToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.CrearAgendasToolStripMenuItem.Text = "Crear Agendas"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'PruebasToolStripMenuItem
        '
        Me.PruebasToolStripMenuItem.Name = "PruebasToolStripMenuItem"
        Me.PruebasToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.PruebasToolStripMenuItem.Text = "Pruebas"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Agendas.My.Resources.Resources.Restart
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'BTN_BITACORA
        '
        Me.BTN_BITACORA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTN_BITACORA.Image = Global.Agendas.My.Resources.Resources.Index
        Me.BTN_BITACORA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_BITACORA.Name = "BTN_BITACORA"
        Me.BTN_BITACORA.Size = New System.Drawing.Size(68, 68)
        Me.BTN_BITACORA.Text = "ToolStripButton3"
        '
        'dgvm
        '
        Me.dgvm.AllowUserToAddRows = False
        Me.dgvm.AllowUserToDeleteRows = False
        Me.dgvm.AllowUserToResizeColumns = False
        Me.dgvm.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvm.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvm.AutoGenerateColumns = False
        Me.dgvm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvm.BackgroundColor = System.Drawing.Color.White
        Me.dgvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvm.ColumnHeadersVisible = False
        Me.dgvm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DisponibleDataGridViewTextBoxColumn})
        Me.dgvm.DataSource = Me.CitasdisponiblesBindingSource
        Me.dgvm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvm.Location = New System.Drawing.Point(0, 0)
        Me.dgvm.Name = "dgvm"
        Me.dgvm.ReadOnly = True
        Me.dgvm.RowHeadersVisible = False
        Me.dgvm.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvm.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.dgvm.Size = New System.Drawing.Size(607, 297)
        Me.dgvm.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 5
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 5
        '
        'DisponibleDataGridViewTextBoxColumn
        '
        Me.DisponibleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DisponibleDataGridViewTextBoxColumn.DataPropertyName = "Disponible"
        DataGridViewCellStyle2.Format = "dddd dd MMM HH:mm tt"
        Me.DisponibleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DisponibleDataGridViewTextBoxColumn.HeaderText = "Disponible"
        Me.DisponibleDataGridViewTextBoxColumn.Name = "DisponibleDataGridViewTextBoxColumn"
        Me.DisponibleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CitasdisponiblesBindingSource
        '
        Me.CitasdisponiblesBindingSource.DataMember = "citas_disponibles"
        Me.CitasdisponiblesBindingSource.DataSource = Me.Db_baseDataSet
        '
        'Db_baseDataSet
        '
        Me.Db_baseDataSet.DataSetName = "db_baseDataSet"
        Me.Db_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Citas_disponiblesTableAdapter
        '
        Me.Citas_disponiblesTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 71)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SplitContainer1.Panel2.CausesValidation = False
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(607, 403)
        Me.SplitContainer1.SplitterDistance = 502
        Me.SplitContainer1.TabIndex = 5
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Panel1.BackgroundImage = Global.Agendas.My.Resources.Resources.citas_medicas
        Me.SplitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvm)
        Me.SplitContainer2.Size = New System.Drawing.Size(607, 403)
        Me.SplitContainer2.SplitterDistance = 102
        Me.SplitContainer2.TabIndex = 4
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Agendas.My.Resources.Resources.Vista_Search
        Me.PictureBox4.Location = New System.Drawing.Point(285, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(52, 51)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Actualiza la informacion de ultimo minuto.")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Agendas.My.Resources.Resources.sync
        Me.PictureBox3.Location = New System.Drawing.Point(227, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Actualiza la informacion de ultimo minuto.")
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Agendas.My.Resources.Resources.Log_Off
        Me.PictureBox2.Location = New System.Drawing.Point(552, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Agendas.My.Resources.Resources.Download_5
        Me.PictureBox1.Location = New System.Drawing.Point(494, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label1.Location = New System.Drawing.Point(476, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGENDAS"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(607, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "main"
        Me.Text = "SISTEMA DE AGENDAS ELECTRONICAS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasdisponiblesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents DatosGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MEDICOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearAgendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvm As System.Windows.Forms.DataGridView
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Db_baseDataSet As Agendas.db_baseDataSet
    Friend WithEvents CitasdisponiblesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Citas_disponiblesTableAdapter As Agendas.db_baseDataSetTableAdapters.citas_disponiblesTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PruebasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_BITACORA As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisponibleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
