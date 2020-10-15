<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminar_diayhora
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lbldia = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minuto = New System.Windows.Forms.NumericUpDown()
        Me.hora = New System.Windows.Forms.NumericUpDown()
        Me.dia = New System.Windows.Forms.NumericUpDown()
        Me.id_medico = New System.Windows.Forms.TextBox()
        Me.CitasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_baseDataSet = New Agendas.db_baseDataSet()
        Me.CitasTableAdapter = New Agendas.db_baseDataSetTableAdapters.citasTableAdapter()
        Me.TableAdapterManager = New Agendas.db_baseDataSetTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.minuto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.minuto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.hora)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.id_medico)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.CitasDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(929, 217)
        Me.SplitContainer1.SplitterDistance = 40
        Me.SplitContainer1.TabIndex = 0
        '
        'lbldia
        '
        Me.lbldia.AutoSize = True
        Me.lbldia.Location = New System.Drawing.Point(270, 15)
        Me.lbldia.Name = "lbldia"
        Me.lbldia.Size = New System.Drawing.Size(39, 13)
        Me.lbldia.TabIndex = 10
        Me.lbldia.Text = "Label5"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(640, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(559, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "ver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Minuto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hora:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dia de la semana"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id Medico"
        '
        'minuto
        '
        Me.minuto.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.minuto.Location = New System.Drawing.Point(503, 12)
        Me.minuto.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minuto.Name = "minuto"
        Me.minuto.Size = New System.Drawing.Size(50, 20)
        Me.minuto.TabIndex = 3
        '
        'hora
        '
        Me.hora.Location = New System.Drawing.Point(399, 13)
        Me.hora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.hora.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(50, 20)
        Me.hora.TabIndex = 2
        Me.hora.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dia
        '
        Me.dia.Location = New System.Drawing.Point(214, 12)
        Me.dia.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.dia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.dia.Name = "dia"
        Me.dia.Size = New System.Drawing.Size(50, 20)
        Me.dia.TabIndex = 1
        Me.dia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'id_medico
        '
        Me.id_medico.Location = New System.Drawing.Point(63, 12)
        Me.id_medico.Name = "id_medico"
        Me.id_medico.Size = New System.Drawing.Size(50, 20)
        Me.id_medico.TabIndex = 0
        '
        'CitasDataGridView
        '
        Me.CitasDataGridView.AutoGenerateColumns = False
        Me.CitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.CitasDataGridView.DataSource = Me.CitasBindingSource
        Me.CitasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CitasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CitasDataGridView.Name = "CitasDataGridView"
        Me.CitasDataGridView.Size = New System.Drawing.Size(929, 173)
        Me.CitasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_medico"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_medico"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "celular"
        Me.DataGridViewTextBoxColumn5.HeaderText = "celular"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "comentarios"
        Me.DataGridViewTextBoxColumn7.HeaderText = "comentarios"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_usuario"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "normal"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "normal"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "status"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "solofecha"
        Me.DataGridViewTextBoxColumn10.HeaderText = "solofecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "citas"
        Me.CitasBindingSource.DataSource = Me.Db_baseDataSet
        '
        'Db_baseDataSet
        '
        Me.Db_baseDataSet.DataSetName = "db_baseDataSet"
        Me.Db_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bitacoraTableAdapter = Nothing
        Me.TableAdapterManager.citasTableAdapter = Me.CitasTableAdapter
        Me.TableAdapterManager.dias_festivosTableAdapter = Nothing
        Me.TableAdapterManager.EsquemaTableAdapter = Nothing
        Me.TableAdapterManager.lista_esperaTableAdapter = Nothing
        Me.TableAdapterManager.medicosTableAdapter = Nothing
        Me.TableAdapterManager.notasTableAdapter = Nothing
        Me.TableAdapterManager.sql_citasTableAdapter = Nothing
        Me.TableAdapterManager.tbl_generalesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_usuariosTableAdapter = Nothing
        Me.TableAdapterManager.to_doTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agendas.db_baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(721, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Eliminar la hora de todos los dias"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'eliminar_diayhora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 217)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "eliminar_diayhora"
        Me.Text = "eliminar_diayhora"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.minuto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents minuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents dia As System.Windows.Forms.NumericUpDown
    Friend WithEvents id_medico As System.Windows.Forms.TextBox
    Friend WithEvents Db_baseDataSet As Agendas.db_baseDataSet
    Friend WithEvents CitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CitasTableAdapter As Agendas.db_baseDataSetTableAdapters.citasTableAdapter
    Friend WithEvents TableAdapterManager As Agendas.db_baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CitasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbldia As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
