<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimir
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.sql_citasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_baseDataSet = New Agendas.db_baseDataSet()
        Me.lista_esperaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sql_citasTableAdapter = New Agendas.db_baseDataSetTableAdapters.sql_citasTableAdapter()
        Me.lista_esperaTableAdapter = New Agendas.db_baseDataSetTableAdapters.lista_esperaTableAdapter()
        CType(Me.sql_citasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_baseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lista_esperaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sql_citasBindingSource
        '
        Me.sql_citasBindingSource.DataMember = "sql_citas"
        Me.sql_citasBindingSource.DataSource = Me.db_baseDataSet
        '
        'db_baseDataSet
        '
        Me.db_baseDataSet.DataSetName = "db_baseDataSet"
        Me.db_baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lista_esperaBindingSource
        '
        Me.lista_esperaBindingSource.DataMember = "lista_espera"
        Me.lista_esperaBindingSource.DataSource = Me.db_baseDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.sql_citasBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.lista_esperaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Agendas.Agenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(549, 409)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'sql_citasTableAdapter
        '
        Me.sql_citasTableAdapter.ClearBeforeFill = True
        '
        'lista_esperaTableAdapter
        '
        Me.lista_esperaTableAdapter.ClearBeforeFill = True
        '
        'imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 409)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "imprimir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sql_citasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_baseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lista_esperaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_citasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_baseDataSet As Agendas.db_baseDataSet
    Friend WithEvents lista_esperaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sql_citasTableAdapter As Agendas.db_baseDataSetTableAdapters.sql_citasTableAdapter
    Friend WithEvents lista_esperaTableAdapter As Agendas.db_baseDataSetTableAdapters.lista_esperaTableAdapter
End Class
