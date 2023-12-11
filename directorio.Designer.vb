<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class directorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(directorio))
        Me.Db_baseDataSet = New Agendas.db_baseDataSet()
        Me.Tbl_directorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_directorioTableAdapter = New Agendas.db_baseDataSetTableAdapters.tbl_directorioTableAdapter()
        Me.TableAdapterManager = New Agendas.db_baseDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_directorioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_directorioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_directorioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_directorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_directorioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_directorioBindingNavigator.SuspendLayout()
        CType(Me.Tbl_directorioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_baseDataSet
        '
        Me.Db_baseDataSet.DataSetName = "db_baseDataSet"
        Me.Db_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_directorioBindingSource
        '
        Me.Tbl_directorioBindingSource.DataMember = "tbl_directorio"
        Me.Tbl_directorioBindingSource.DataSource = Me.Db_baseDataSet
        '
        'Tbl_directorioTableAdapter
        '
        Me.Tbl_directorioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bitacoraTableAdapter = Nothing
        Me.TableAdapterManager.citasTableAdapter = Nothing
        Me.TableAdapterManager.EsquemaTableAdapter = Nothing
        Me.TableAdapterManager.lista_esperaTableAdapter = Nothing
        Me.TableAdapterManager.medicosTableAdapter = Nothing
        Me.TableAdapterManager.notasTableAdapter = Nothing
        Me.TableAdapterManager.sql_citasTableAdapter = Nothing
        Me.TableAdapterManager.tbl_directorioTableAdapter = Me.Tbl_directorioTableAdapter
        Me.TableAdapterManager.tbl_usuariosTableAdapter = Nothing
        Me.TableAdapterManager.to_doTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Agendas.db_baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_directorioBindingNavigator
        '
        Me.Tbl_directorioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_directorioBindingNavigator.BindingSource = Me.Tbl_directorioBindingSource
        Me.Tbl_directorioBindingNavigator.CountItem = Nothing
        Me.Tbl_directorioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_directorioBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.Tbl_directorioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_directorioBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.Tbl_directorioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_directorioBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_directorioBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_directorioBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_directorioBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_directorioBindingNavigator.Name = "Tbl_directorioBindingNavigator"
        Me.Tbl_directorioBindingNavigator.PositionItem = Nothing
        Me.Tbl_directorioBindingNavigator.Size = New System.Drawing.Size(800, 39)
        Me.Tbl_directorioBindingNavigator.TabIndex = 0
        Me.Tbl_directorioBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Tbl_directorioBindingNavigatorSaveItem
        '
        Me.Tbl_directorioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_directorioBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_directorioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_directorioBindingNavigatorSaveItem.Name = "Tbl_directorioBindingNavigatorSaveItem"
        Me.Tbl_directorioBindingNavigatorSaveItem.Size = New System.Drawing.Size(36, 36)
        Me.Tbl_directorioBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Agendas.My.Resources.Resources.Log_Off
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Tbl_directorioDataGridView
        '
        Me.Tbl_directorioDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbl_directorioDataGridView.AutoGenerateColumns = False
        Me.Tbl_directorioDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Tbl_directorioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_directorioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Tbl_directorioDataGridView.DataSource = Me.Tbl_directorioBindingSource
        Me.Tbl_directorioDataGridView.Location = New System.Drawing.Point(12, 67)
        Me.Tbl_directorioDataGridView.Name = "Tbl_directorioDataGridView"
        Me.Tbl_directorioDataGridView.Size = New System.Drawing.Size(788, 351)
        Me.Tbl_directorioDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "celular"
        Me.DataGridViewTextBoxColumn2.HeaderText = "celular"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Paterno"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Paterno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Materno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Materno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "paciente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "paciente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'directorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tbl_directorioDataGridView)
        Me.Controls.Add(Me.Tbl_directorioBindingNavigator)
        Me.Name = "directorio"
        Me.Text = "directorio"
        CType(Me.Db_baseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_directorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_directorioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_directorioBindingNavigator.ResumeLayout(False)
        Me.Tbl_directorioBindingNavigator.PerformLayout()
        CType(Me.Tbl_directorioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_baseDataSet As db_baseDataSet
    Friend WithEvents Tbl_directorioBindingSource As BindingSource
    Friend WithEvents Tbl_directorioTableAdapter As db_baseDataSetTableAdapters.tbl_directorioTableAdapter
    Friend WithEvents TableAdapterManager As db_baseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_directorioBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Tbl_directorioBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_directorioDataGridView As DataGridView
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
