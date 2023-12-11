<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agenda
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_agenda))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CitaEnUnMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDeDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_BloquearHorario = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesbloquearHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_baseDataSet = New Agendas.db_baseDataSet()
        Me.calendario = New System.Windows.Forms.MonthCalendar()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvalternas = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btn_salie = New System.Windows.Forms.ToolStripButton()
        Me.btn_localizar = New System.Windows.Forms.ToolStripButton()
        Me.btn_bloquear = New System.Windows.Forms.ToolStripButton()
        Me.Btn_desbloqueo = New System.Windows.Forms.ToolStripButton()
        Me.btn_horario = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblinfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.infoIco = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblinfopro = New System.Windows.Forms.ToolStripStatusLabel()
        Me._btn_salir = New System.Windows.Forms.Button()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lista_esperaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lista_esperaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nhora = New System.Windows.Forms.DateTimePicker()
        Me.nfecha = New System.Windows.Forms.TextBox()
        Me.chora = New System.Windows.Forms.DateTimePicker()
        Me.cfecha = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ctelefono = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cnombre = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.grupo_proxima = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.el_celular = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.el_telefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.el_nombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.menu_agregar = New System.Windows.Forms.ToolStripSplitButton()
        Me.btn_manana = New System.Windows.Forms.ToolStripMenuItem()
        Me.boton_tarde = New System.Windows.Forms.ToolStripMenuItem()
        Me.boton_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.boton_imprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.btn_mañana = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_tarde = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_completa = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_user = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.btn_nowhats = New System.Windows.Forms.Button()
        Me.btn_addPersona = New System.Windows.Forms.Button()
        Me.img_valido = New System.Windows.Forms.PictureBox()
        Me.img_nuevo = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.materno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.paterno = New System.Windows.Forms.TextBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.img_proxima = New System.Windows.Forms.PictureBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcomentarios = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.lblfestivos = New System.Windows.Forms.Label()
        Me.btn_crear_nota = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgvnota = New System.Windows.Forms.DataGridView()
        Me.NotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Linkcitasxcancelar = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MedicosTableAdapter = New Agendas.db_baseDataSetTableAdapters.medicosTableAdapter()
        Me.Lista_esperaTableAdapter = New Agendas.db_baseDataSetTableAdapters.lista_esperaTableAdapter()
        Me.NotasTableAdapter = New Agendas.db_baseDataSetTableAdapters.notasTableAdapter()
        Me.TableAdapterManager = New Agendas.db_baseDataSetTableAdapters.TableAdapterManager()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvalternas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_esperaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_esperaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_proxima.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.img_valido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_proxima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvnota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundColor", Me.MedicosBindingSource, "color", True))
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(581, 380)
        Me.dgv.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CitaEnUnMesToolStripMenuItem, Me.CambiarDeDiaToolStripMenuItem, Me.EditarCitaToolStripMenuItem, Me.ToolStripSeparator1, Me.CancelarCitaToolStripMenuItem, Me.btn_BloquearHorario, Me.DesbloquearHorarioToolStripMenuItem, Me.ToolStripSeparator2, Me.EliminarHorarioToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(233, 282)
        '
        'CitaEnUnMesToolStripMenuItem
        '
        Me.CitaEnUnMesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CitaEnUnMesToolStripMenuItem.Image = Global.Agendas.My.Resources.Resources.calendario
        Me.CitaEnUnMesToolStripMenuItem.Name = "CitaEnUnMesToolStripMenuItem"
        Me.CitaEnUnMesToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.CitaEnUnMesToolStripMenuItem.Text = "Cita en un Mes"
        '
        'CambiarDeDiaToolStripMenuItem
        '
        Me.CambiarDeDiaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CambiarDeDiaToolStripMenuItem.Image = Global.Agendas.My.Resources.Resources.Windows_Calendar
        Me.CambiarDeDiaToolStripMenuItem.Name = "CambiarDeDiaToolStripMenuItem"
        Me.CambiarDeDiaToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.CambiarDeDiaToolStripMenuItem.Text = "Cambiar de Dia"
        '
        'EditarCitaToolStripMenuItem
        '
        Me.EditarCitaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EditarCitaToolStripMenuItem.Image = Global.Agendas.My.Resources.Resources.lista
        Me.EditarCitaToolStripMenuItem.Name = "EditarCitaToolStripMenuItem"
        Me.EditarCitaToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.EditarCitaToolStripMenuItem.Text = "Editar Cita"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(229, 6)
        '
        'CancelarCitaToolStripMenuItem
        '
        Me.CancelarCitaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.CancelarCitaToolStripMenuItem.Image = Global.Agendas.My.Resources.Resources.Error_2
        Me.CancelarCitaToolStripMenuItem.Name = "CancelarCitaToolStripMenuItem"
        Me.CancelarCitaToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.CancelarCitaToolStripMenuItem.Text = "Cancelar Cita"
        '
        'btn_BloquearHorario
        '
        Me.btn_BloquearHorario.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_BloquearHorario.Image = Global.Agendas.My.Resources.Resources.Firewall
        Me.btn_BloquearHorario.Name = "btn_BloquearHorario"
        Me.btn_BloquearHorario.Size = New System.Drawing.Size(232, 38)
        Me.btn_BloquearHorario.Text = "Bloquear Horario"
        Me.btn_BloquearHorario.ToolTipText = "Bloquear este horario"
        '
        'DesbloquearHorarioToolStripMenuItem
        '
        Me.DesbloquearHorarioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.DesbloquearHorarioToolStripMenuItem.Image = Global.Agendas.My.Resources.Resources.Decrypted
        Me.DesbloquearHorarioToolStripMenuItem.Name = "DesbloquearHorarioToolStripMenuItem"
        Me.DesbloquearHorarioToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.DesbloquearHorarioToolStripMenuItem.Text = "Desbloquear Horario"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(229, 6)
        '
        'EliminarHorarioToolStripMenuItem
        '
        Me.EliminarHorarioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EliminarHorarioToolStripMenuItem.Name = "EliminarHorarioToolStripMenuItem"
        Me.EliminarHorarioToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.EliminarHorarioToolStripMenuItem.Text = "Eliminar Horario"
        '
        'MedicosBindingSource
        '
        Me.MedicosBindingSource.DataMember = "medicos"
        Me.MedicosBindingSource.DataSource = Me.Db_baseDataSet
        '
        'Db_baseDataSet
        '
        Me.Db_baseDataSet.DataSetName = "db_baseDataSet"
        Me.Db_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'calendario
        '
        Me.calendario.BackColor = System.Drawing.Color.Aqua
        Me.calendario.CalendarDimensions = New System.Drawing.Size(1, 3)
        Me.calendario.Dock = System.Windows.Forms.DockStyle.Top
        Me.calendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendario.Location = New System.Drawing.Point(0, 0)
        Me.calendario.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.calendario.MaxSelectionCount = 1
        Me.calendario.Name = "calendario"
        Me.calendario.TabIndex = 3
        Me.calendario.TrailingForeColor = System.Drawing.Color.Tomato
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvalternas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.calendario)
        Me.SplitContainer1.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.MedicosBindingSource, "color", True))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1179, 830)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 434)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 25)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Citas Disponibles"
        '
        'dgvalternas
        '
        Me.dgvalternas.AllowUserToAddRows = False
        Me.dgvalternas.AllowUserToDeleteRows = False
        Me.dgvalternas.AllowUserToResizeColumns = False
        Me.dgvalternas.AllowUserToResizeRows = False
        Me.dgvalternas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvalternas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvalternas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvalternas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvalternas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvalternas.Location = New System.Drawing.Point(3, 467)
        Me.dgvalternas.Name = "dgvalternas"
        Me.dgvalternas.ReadOnly = True
        Me.dgvalternas.RowHeadersVisible = False
        Me.dgvalternas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvalternas.Size = New System.Drawing.Size(218, 321)
        Me.dgvalternas.TabIndex = 6
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.btn_salie, Me.btn_localizar, Me.btn_bloquear, Me.Btn_desbloqueo, Me.btn_horario})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 791)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(254, 39)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Cita Imediata"
        '
        'btn_salie
        '
        Me.btn_salie.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_salie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salie.Image = CType(resources.GetObject("btn_salie.Image"), System.Drawing.Image)
        Me.btn_salie.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salie.Name = "btn_salie"
        Me.btn_salie.Size = New System.Drawing.Size(36, 36)
        Me.btn_salie.Text = "ToolStripButton3"
        '
        'btn_localizar
        '
        Me.btn_localizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_localizar.Image = Global.Agendas.My.Resources.Resources.Vista_Search
        Me.btn_localizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_localizar.Name = "btn_localizar"
        Me.btn_localizar.Size = New System.Drawing.Size(36, 36)
        Me.btn_localizar.Text = "Localizar una cita"
        '
        'btn_bloquear
        '
        Me.btn_bloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_bloquear.Image = Global.Agendas.My.Resources.Resources.Encrypted
        Me.btn_bloquear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_bloquear.Name = "btn_bloquear"
        Me.btn_bloquear.Size = New System.Drawing.Size(36, 36)
        Me.btn_bloquear.Text = "Bloquear un dia"
        Me.btn_bloquear.Visible = False
        '
        'Btn_desbloqueo
        '
        Me.Btn_desbloqueo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_desbloqueo.Image = Global.Agendas.My.Resources.Resources.Decrypted
        Me.Btn_desbloqueo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_desbloqueo.Name = "Btn_desbloqueo"
        Me.Btn_desbloqueo.Size = New System.Drawing.Size(36, 36)
        Me.Btn_desbloqueo.Text = "Desbloquear una fecha"
        Me.Btn_desbloqueo.Visible = False
        '
        'btn_horario
        '
        Me.btn_horario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_horario.Image = Global.Agendas.My.Resources.Resources.calendario
        Me.btn_horario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_horario.Name = "btn_horario"
        Me.btn_horario.Size = New System.Drawing.Size(36, 36)
        Me.btn_horario.Text = "Crear un horario "
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.PictureBox2)
        Me.SplitContainer2.Panel2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.MedicosBindingSource, "color", True))
        Me.SplitContainer2.Size = New System.Drawing.Size(920, 830)
        Me.SplitContainer2.SplitterDistance = 581
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.NombreLabel1)
        Me.SplitContainer3.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.MedicosBindingSource, "color", True))
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(581, 830)
        Me.SplitContainer3.SplitterDistance = 85
        Me.SplitContainer3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(581, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Nombre", True))
        Me.NombreLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.NombreLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLabel1.Location = New System.Drawing.Point(0, 0)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(581, 40)
        Me.NombreLabel1.TabIndex = 1
        Me.NombreLabel1.Text = "Label1"
        Me.NombreLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.dgv)
        Me.SplitContainer4.Panel1.Controls.Add(Me._btn_salir)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer4.Size = New System.Drawing.Size(581, 741)
        Me.SplitContainer4.SplitterDistance = 400
        Me.SplitContainer4.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblinfo, Me.infoIco, Me.lblinfopro})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 378)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(581, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblinfo
        '
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(0, 17)
        '
        'infoIco
        '
        Me.infoIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.infoIco.Image = Global.Agendas.My.Resources.Resources.whatsapp
        Me.infoIco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.infoIco.Name = "infoIco"
        Me.infoIco.Size = New System.Drawing.Size(32, 32)
        Me.infoIco.Text = "ToolStripDropDownButton1"
        Me.infoIco.Visible = False
        '
        'lblinfopro
        '
        Me.lblinfopro.Name = "lblinfopro"
        Me.lblinfopro.Size = New System.Drawing.Size(0, 17)
        '
        '_btn_salir
        '
        Me._btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btn_salir.Location = New System.Drawing.Point(57, 251)
        Me._btn_salir.Name = "_btn_salir"
        Me._btn_salir.Size = New System.Drawing.Size(75, 23)
        Me._btn_salir.TabIndex = 3
        Me._btn_salir.Text = "Button4"
        Me._btn_salir.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.AutoScroll = True
        Me.SplitContainer5.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer5.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer5.Panel1.Controls.Add(Me.SplitContainer7)
        Me.SplitContainer5.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Me.MedicosBindingSource, "color", True))
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer5.Size = New System.Drawing.Size(581, 337)
        Me.SplitContainer5.SplitterDistance = 299
        Me.SplitContainer5.TabIndex = 0
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer7.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer7.Panel1.Controls.Add(Me.Lista_esperaDataGridView)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainer7.Panel2.Controls.Add(Me.nhora)
        Me.SplitContainer7.Panel2.Controls.Add(Me.nfecha)
        Me.SplitContainer7.Panel2.Controls.Add(Me.chora)
        Me.SplitContainer7.Panel2.Controls.Add(Me.cfecha)
        Me.SplitContainer7.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer7.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer7.Panel2.Controls.Add(Me.ctelefono)
        Me.SplitContainer7.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer7.Panel2.Controls.Add(Me.cnombre)
        Me.SplitContainer7.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer7.Panel2.Controls.Add(Me.grupo_proxima)
        Me.SplitContainer7.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer7.Panel2.Controls.Add(Me.PictureBox3)
        Me.SplitContainer7.Panel2Collapsed = True
        Me.SplitContainer7.Size = New System.Drawing.Size(581, 299)
        Me.SplitContainer7.SplitterDistance = 371
        Me.SplitContainer7.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EVENTUALES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(535, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Lista_esperaDataGridView
        '
        Me.Lista_esperaDataGridView.AllowUserToAddRows = False
        Me.Lista_esperaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lista_esperaDataGridView.AutoGenerateColumns = False
        Me.Lista_esperaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista_esperaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.turno, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.id_usuario, Me.DataGridViewTextBoxColumn5})
        Me.Lista_esperaDataGridView.DataSource = Me.Lista_esperaBindingSource
        Me.Lista_esperaDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.Lista_esperaDataGridView.Name = "Lista_esperaDataGridView"
        Me.Lista_esperaDataGridView.RowHeadersVisible = False
        Me.Lista_esperaDataGridView.Size = New System.Drawing.Size(581, 271)
        Me.Lista_esperaDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_medico"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_medico"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'turno
        '
        Me.turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.turno.DataPropertyName = "turno"
        Me.turno.HeaderText = "turno"
        Me.turno.Name = "turno"
        Me.turno.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "numero"
        Me.DataGridViewTextBoxColumn3.HeaderText = "numero"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'id_usuario
        '
        Me.id_usuario.DataPropertyName = "id_usuario"
        Me.id_usuario.HeaderText = "Usuario"
        Me.id_usuario.Name = "id_usuario"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tel"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tel"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'Lista_esperaBindingSource
        '
        Me.Lista_esperaBindingSource.DataMember = "lista_espera"
        Me.Lista_esperaBindingSource.DataSource = Me.Db_baseDataSet
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(2, 167)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 17)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Nueva Fecha"
        Me.Label16.Visible = False
        '
        'nhora
        '
        Me.nhora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nhora.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nhora.CustomFormat = "hh:mm tt"
        Me.nhora.Enabled = False
        Me.nhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nhora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.nhora.Location = New System.Drawing.Point(-14, 160)
        Me.nhora.Name = "nhora"
        Me.nhora.Size = New System.Drawing.Size(126, 24)
        Me.nhora.TabIndex = 19
        Me.nhora.Visible = False
        '
        'nfecha
        '
        Me.nfecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nfecha.Enabled = False
        Me.nfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nfecha.Location = New System.Drawing.Point(100, 160)
        Me.nfecha.Name = "nfecha"
        Me.nfecha.ReadOnly = True
        Me.nfecha.Size = New System.Drawing.Size(0, 24)
        Me.nfecha.TabIndex = 18
        Me.nfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nfecha.Visible = False
        '
        'chora
        '
        Me.chora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chora.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chora.CustomFormat = "hh:mm tt"
        Me.chora.Enabled = False
        Me.chora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.chora.Location = New System.Drawing.Point(-3, 74)
        Me.chora.Name = "chora"
        Me.chora.Size = New System.Drawing.Size(126, 24)
        Me.chora.TabIndex = 16
        '
        'cfecha
        '
        Me.cfecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cfecha.Enabled = False
        Me.cfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cfecha.Location = New System.Drawing.Point(100, 74)
        Me.cfecha.Name = "cfecha"
        Me.cfecha.ReadOnly = True
        Me.cfecha.Size = New System.Drawing.Size(0, 24)
        Me.cfecha.TabIndex = 15
        Me.cfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 129)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Telefono :"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(78, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 39)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Seleccione una nueva fecha para la cita. y haga 2 clic en la fecha y hora corresp" &
    "ondiente"
        '
        'ctelefono
        '
        Me.ctelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctelefono.Location = New System.Drawing.Point(100, 129)
        Me.ctelefono.Name = "ctelefono"
        Me.ctelefono.ReadOnly = True
        Me.ctelefono.Size = New System.Drawing.Size(102, 23)
        Me.ctelefono.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 17)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Nombre :"
        '
        'cnombre
        '
        Me.cnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnombre.Location = New System.Drawing.Point(100, 102)
        Me.cnombre.Name = "cnombre"
        Me.cnombre.ReadOnly = True
        Me.cnombre.Size = New System.Drawing.Size(21, 23)
        Me.cnombre.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(31, 201)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.Button4, "Al cancelar no se hace ningun cambio en la cita original.")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'grupo_proxima
        '
        Me.grupo_proxima.Controls.Add(Me.Button3)
        Me.grupo_proxima.Controls.Add(Me.el_celular)
        Me.grupo_proxima.Controls.Add(Me.Label10)
        Me.grupo_proxima.Controls.Add(Me.el_telefono)
        Me.grupo_proxima.Controls.Add(Me.Label8)
        Me.grupo_proxima.Controls.Add(Me.el_nombre)
        Me.grupo_proxima.Location = New System.Drawing.Point(78, 8)
        Me.grupo_proxima.Name = "grupo_proxima"
        Me.grupo_proxima.Size = New System.Drawing.Size(20, 19)
        Me.grupo_proxima.TabIndex = 6
        Me.grupo_proxima.TabStop = False
        Me.grupo_proxima.Text = "datos de nueva cita"
        Me.grupo_proxima.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(424, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 24)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'el_celular
        '
        Me.el_celular.Location = New System.Drawing.Point(75, 74)
        Me.el_celular.Name = "el_celular"
        Me.el_celular.Size = New System.Drawing.Size(147, 21)
        Me.el_celular.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Celular :"
        '
        'el_telefono
        '
        Me.el_telefono.Location = New System.Drawing.Point(75, 47)
        Me.el_telefono.Name = "el_telefono"
        Me.el_telefono.Size = New System.Drawing.Size(147, 21)
        Me.el_telefono.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Telefono:"
        '
        'el_nombre
        '
        Me.el_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.el_nombre.Location = New System.Drawing.Point(10, 19)
        Me.el_nombre.Name = "el_nombre"
        Me.el_nombre.Size = New System.Drawing.Size(8, 21)
        Me.el_nombre.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-59, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 22)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "CAMBIO DE FECHA"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 67)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_agregar, Me.boton_cancelar, Me.boton_imprimir, Me.lbl_user, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(581, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'menu_agregar
        '
        Me.menu_agregar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_manana, Me.boton_tarde})
        Me.menu_agregar.Image = Global.Agendas.My.Resources.Resources.lista
        Me.menu_agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menu_agregar.Name = "menu_agregar"
        Me.menu_agregar.Size = New System.Drawing.Size(97, 36)
        Me.menu_agregar.Text = "Agregar"
        '
        'btn_manana
        '
        Me.btn_manana.Name = "btn_manana"
        Me.btn_manana.Size = New System.Drawing.Size(172, 22)
        Me.btn_manana.Text = "Lista de la mañana"
        '
        'boton_tarde
        '
        Me.boton_tarde.Name = "boton_tarde"
        Me.boton_tarde.Size = New System.Drawing.Size(172, 22)
        Me.boton_tarde.Text = "Lista de la tarde"
        '
        'boton_cancelar
        '
        Me.boton_cancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.boton_cancelar.Image = CType(resources.GetObject("boton_cancelar.Image"), System.Drawing.Image)
        Me.boton_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_cancelar.Name = "boton_cancelar"
        Me.boton_cancelar.Size = New System.Drawing.Size(128, 36)
        Me.boton_cancelar.Text = "Quitar de la lista"
        Me.boton_cancelar.ToolTipText = "Quitar de la lista"
        '
        'boton_imprimir
        '
        Me.boton_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boton_imprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_mañana, Me.btn_tarde, Me.btn_completa})
        Me.boton_imprimir.Image = Global.Agendas.My.Resources.Resources.Printer
        Me.boton_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boton_imprimir.Name = "boton_imprimir"
        Me.boton_imprimir.Size = New System.Drawing.Size(69, 36)
        Me.boton_imprimir.Text = "Imprimir"
        '
        'btn_mañana
        '
        Me.btn_mañana.Name = "btn_mañana"
        Me.btn_mañana.Size = New System.Drawing.Size(132, 22)
        Me.btn_mañana.Text = "Mañana"
        '
        'btn_tarde
        '
        Me.btn_tarde.Name = "btn_tarde"
        Me.btn_tarde.Size = New System.Drawing.Size(132, 22)
        Me.btn_tarde.Text = "Tarede"
        '
        'btn_completa
        '
        Me.btn_completa.Name = "btn_completa"
        Me.btn_completa.Size = New System.Drawing.Size(132, 22)
        Me.btn_completa.Text = "Todo el Dia"
        '
        'lbl_user
        '
        Me.lbl_user.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(17, 36)
        Me.lbl_user.Text = "--"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 164)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.btn_nowhats)
        Me.SplitContainer6.Panel1.Controls.Add(Me.btn_addPersona)
        Me.SplitContainer6.Panel1.Controls.Add(Me.img_valido)
        Me.SplitContainer6.Panel1.Controls.Add(Me.img_nuevo)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer6.Panel1.Controls.Add(Me.nombre)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer6.Panel1.Controls.Add(Me.materno)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer6.Panel1.Controls.Add(Me.paterno)
        Me.SplitContainer6.Panel1.Controls.Add(Me.logo)
        Me.SplitContainer6.Panel1.Controls.Add(Me.img_proxima)
        Me.SplitContainer6.Panel1.Controls.Add(Me.btn_confirmar)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txttime)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtcomentarios)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtmail)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtcelular)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txttelefono)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtnombre)
        Me.SplitContainer6.Panel1.Controls.Add(Me.txtfecha)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.lblfestivos)
        Me.SplitContainer6.Panel2.Controls.Add(Me.btn_crear_nota)
        Me.SplitContainer6.Panel2.Controls.Add(Me.Label17)
        Me.SplitContainer6.Panel2.Controls.Add(Me.dgvnota)
        Me.SplitContainer6.Panel2.Controls.Add(Me.Linkcitasxcancelar)
        Me.SplitContainer6.Size = New System.Drawing.Size(334, 666)
        Me.SplitContainer6.SplitterDistance = 449
        Me.SplitContainer6.TabIndex = 5
        '
        'btn_nowhats
        '
        Me.btn_nowhats.BackgroundImage = Global.Agendas.My.Resources.Resources.nowhatsapp1
        Me.btn_nowhats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_nowhats.Location = New System.Drawing.Point(241, 110)
        Me.btn_nowhats.Name = "btn_nowhats"
        Me.btn_nowhats.Size = New System.Drawing.Size(29, 24)
        Me.btn_nowhats.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.btn_nowhats, "Agregar otra persona a este numero.")
        Me.btn_nowhats.UseVisualStyleBackColor = True
        '
        'btn_addPersona
        '
        Me.btn_addPersona.BackgroundImage = Global.Agendas.My.Resources.Resources.notification_add
        Me.btn_addPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addPersona.Location = New System.Drawing.Point(212, 110)
        Me.btn_addPersona.Name = "btn_addPersona"
        Me.btn_addPersona.Size = New System.Drawing.Size(23, 23)
        Me.btn_addPersona.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.btn_addPersona, "Agregar otra persona a este numero.")
        Me.btn_addPersona.UseVisualStyleBackColor = True
        '
        'img_valido
        '
        Me.img_valido.Image = Global.Agendas.My.Resources.Resources.notification_done
        Me.img_valido.Location = New System.Drawing.Point(185, 110)
        Me.img_valido.Name = "img_valido"
        Me.img_valido.Size = New System.Drawing.Size(21, 23)
        Me.img_valido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_valido.TabIndex = 27
        Me.img_valido.TabStop = False
        Me.ToolTip1.SetToolTip(Me.img_valido, "Numero nuevo, se agregara a la base de datos,")
        Me.img_valido.Visible = False
        '
        'img_nuevo
        '
        Me.img_nuevo.Image = Global.Agendas.My.Resources.Resources.notification_add
        Me.img_nuevo.Location = New System.Drawing.Point(185, 110)
        Me.img_nuevo.Name = "img_nuevo"
        Me.img_nuevo.Size = New System.Drawing.Size(21, 23)
        Me.img_nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_nuevo.TabIndex = 26
        Me.img_nuevo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.img_nuevo, "Numero nuevo, se agregara a la base de datos,")
        Me.img_nuevo.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 197)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 15)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Nombre :"
        '
        'nombre
        '
        Me.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nombre.Enabled = False
        Me.nombre.Location = New System.Drawing.Point(79, 194)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(194, 21)
        Me.nombre.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 170)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 15)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Materno :"
        '
        'materno
        '
        Me.materno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.materno.Enabled = False
        Me.materno.Location = New System.Drawing.Point(78, 167)
        Me.materno.MaxLength = 30
        Me.materno.Name = "materno"
        Me.materno.Size = New System.Drawing.Size(194, 21)
        Me.materno.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 142)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 15)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Paterno :"
        '
        'paterno
        '
        Me.paterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.paterno.Enabled = False
        Me.paterno.Location = New System.Drawing.Point(78, 139)
        Me.paterno.MaxLength = 30
        Me.paterno.Name = "paterno"
        Me.paterno.Size = New System.Drawing.Size(194, 21)
        Me.paterno.TabIndex = 5
        '
        'logo
        '
        Me.logo.Image = Global.Agendas.My.Resources.Resources.whatsapp
        Me.logo.Location = New System.Drawing.Point(17, 382)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(23, 25)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 19
        Me.logo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.logo, "Se mandara un mensaje de confirmacion.")
        Me.logo.Visible = False
        '
        'img_proxima
        '
        Me.img_proxima.Image = CType(resources.GetObject("img_proxima.Image"), System.Drawing.Image)
        Me.img_proxima.Location = New System.Drawing.Point(13, 63)
        Me.img_proxima.Name = "img_proxima"
        Me.img_proxima.Size = New System.Drawing.Size(46, 47)
        Me.img_proxima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_proxima.TabIndex = 18
        Me.img_proxima.TabStop = False
        Me.ToolTip1.SetToolTip(Me.img_proxima, "Seleccine la fecha para la nueva cita y haga clic en esta imagen.")
        Me.img_proxima.Visible = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(279, 353)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar.TabIndex = 11
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CITA"
        '
        'txttime
        '
        Me.txttime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.CustomFormat = "hh:mm tt"
        Me.txttime.Enabled = False
        Me.txttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttime.Location = New System.Drawing.Point(79, 63)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(136, 29)
        Me.txttime.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Comentarios"
        '
        'txtcomentarios
        '
        Me.txtcomentarios.Location = New System.Drawing.Point(15, 322)
        Me.txtcomentarios.Multiline = True
        Me.txtcomentarios.Name = "txtcomentarios"
        Me.txtcomentarios.Size = New System.Drawing.Size(258, 54)
        Me.txtcomentarios.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nombre :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "E.Mail :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Celular :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefono :"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(79, 274)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(194, 21)
        Me.txtmail.TabIndex = 9
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(79, 112)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(100, 21)
        Me.txtcelular.TabIndex = 4
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(80, 248)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(100, 21)
        Me.txttelefono.TabIndex = 8
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(80, 220)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(194, 21)
        Me.txtnombre.TabIndex = 2
        Me.txtnombre.TabStop = False
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(7, 32)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(274, 26)
        Me.txtfecha.TabIndex = 0
        Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblfestivos
        '
        Me.lblfestivos.Location = New System.Drawing.Point(182, 10)
        Me.lblfestivos.Name = "lblfestivos"
        Me.lblfestivos.Size = New System.Drawing.Size(100, 23)
        Me.lblfestivos.TabIndex = 0
        '
        'btn_crear_nota
        '
        Me.btn_crear_nota.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_crear_nota.Location = New System.Drawing.Point(8, 184)
        Me.btn_crear_nota.Name = "btn_crear_nota"
        Me.btn_crear_nota.Size = New System.Drawing.Size(314, 25)
        Me.btn_crear_nota.TabIndex = 4
        Me.btn_crear_nota.Text = "Ediatr"
        Me.btn_crear_nota.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 18)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Comentarios del dia."
        '
        'dgvnota
        '
        Me.dgvnota.AllowUserToAddRows = False
        Me.dgvnota.AllowUserToDeleteRows = False
        Me.dgvnota.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvnota.AutoGenerateColumns = False
        Me.dgvnota.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvnota.BackgroundColor = System.Drawing.Color.White
        Me.dgvnota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnota.ColumnHeadersVisible = False
        Me.dgvnota.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NotaDataGridViewTextBoxColumn})
        Me.dgvnota.DataSource = Me.NotasBindingSource
        Me.dgvnota.Location = New System.Drawing.Point(8, 60)
        Me.dgvnota.Name = "dgvnota"
        Me.dgvnota.ReadOnly = True
        Me.dgvnota.RowHeadersVisible = False
        Me.dgvnota.Size = New System.Drawing.Size(314, 119)
        Me.dgvnota.TabIndex = 1
        '
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "nota"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NotaDataGridViewTextBoxColumn.HeaderText = ""
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        Me.NotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotasBindingSource
        '
        Me.NotasBindingSource.DataMember = "notas"
        Me.NotasBindingSource.DataSource = Me.Db_baseDataSet
        '
        'Linkcitasxcancelar
        '
        Me.Linkcitasxcancelar.AutoSize = True
        Me.Linkcitasxcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linkcitasxcancelar.LinkColor = System.Drawing.Color.Red
        Me.Linkcitasxcancelar.Location = New System.Drawing.Point(13, 9)
        Me.Linkcitasxcancelar.Name = "Linkcitasxcancelar"
        Me.Linkcitasxcancelar.Size = New System.Drawing.Size(160, 24)
        Me.Linkcitasxcancelar.TabIndex = 0
        Me.Linkcitasxcancelar.TabStop = True
        Me.Linkcitasxcancelar.Text = "Citas por cancelar"
        Me.Linkcitasxcancelar.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(334, 164)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipTitle = "Datos de la cita"
        '
        'MedicosTableAdapter
        '
        Me.MedicosTableAdapter.ClearBeforeFill = True
        '
        'Lista_esperaTableAdapter
        '
        Me.Lista_esperaTableAdapter.ClearBeforeFill = True
        '
        'NotasTableAdapter
        '
        Me.NotasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bitacoraTableAdapter = Nothing
        Me.TableAdapterManager.citasTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EsquemaTableAdapter = Nothing
        Me.TableAdapterManager.lista_esperaTableAdapter = Nothing
        Me.TableAdapterManager.medicosTableAdapter = Nothing
        Me.TableAdapterManager.notasTableAdapter = Nothing
        Me.TableAdapterManager.sql_citasTableAdapter = Nothing
        Me.TableAdapterManager.tbl_directorioTableAdapter = Nothing
        Me.TableAdapterManager.tbl_usuariosTableAdapter = Nothing
        Me.TableAdapterManager.to_doTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agendas.db_baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'frm_agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me._btn_salir
        Me.ClientSize = New System.Drawing.Size(1179, 830)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_agenda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvalternas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.Panel2.PerformLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel1.PerformLayout()
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        Me.SplitContainer7.Panel2.PerformLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_esperaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_esperaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_proxima.ResumeLayout(False)
        Me.grupo_proxima.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel1.PerformLayout()
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.Panel2.PerformLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.img_valido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_proxima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvnota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Db_baseDataSet As Agendas.db_baseDataSet
    Friend WithEvents MedicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicosTableAdapter As Agendas.db_baseDataSetTableAdapters.medicosTableAdapter
    Friend WithEvents NombreLabel1 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As Agendas.db_baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_salie As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcomentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents txtcelular As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents txttime As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _btn_salir As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CitaEnUnMesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents img_proxima As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Lista_esperaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_esperaTableAdapter As Agendas.db_baseDataSetTableAdapters.lista_esperaTableAdapter
    Friend WithEvents Lista_esperaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents dgvalternas As System.Windows.Forms.DataGridView
    Friend WithEvents CambiarDeDiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grupo_proxima As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents el_celular As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents el_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents el_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents chora As System.Windows.Forms.DateTimePicker
    Friend WithEvents cfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ctelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents nhora As System.Windows.Forms.DateTimePicker
    Friend WithEvents nfecha As System.Windows.Forms.TextBox
    Friend WithEvents btn_localizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_bloquear As System.Windows.Forms.ToolStripButton
    Friend WithEvents Linkcitasxcancelar As System.Windows.Forms.LinkLabel
    Friend WithEvents Btn_desbloqueo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_horario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_BloquearHorario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dgvnota As System.Windows.Forms.DataGridView
    Friend WithEvents NotasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotasTableAdapter As Agendas.db_baseDataSetTableAdapters.notasTableAdapter
    Friend WithEvents btn_crear_nota As System.Windows.Forms.Button
    Friend WithEvents NotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblfestivos As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesbloquearHorarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents EliminarHorarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents logo As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents materno As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents paterno As TextBox
    Friend WithEvents img_nuevo As PictureBox
    Friend WithEvents img_valido As PictureBox
    Friend WithEvents btn_addPersona As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblinfo As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents menu_agregar As ToolStripSplitButton
    Friend WithEvents btn_manana As ToolStripMenuItem
    Friend WithEvents boton_tarde As ToolStripMenuItem
    Friend WithEvents boton_cancelar As ToolStripButton
    Friend WithEvents boton_imprimir As ToolStripSplitButton
    Friend WithEvents btn_mañana As ToolStripMenuItem
    Friend WithEvents btn_tarde As ToolStripMenuItem
    Friend WithEvents btn_completa As ToolStripMenuItem
    Friend WithEvents lbl_user As ToolStripLabel
    Friend WithEvents infoIco As ToolStripStatusLabel
    Friend WithEvents btn_nowhats As Button
    Friend WithEvents lblinfopro As ToolStripStatusLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
