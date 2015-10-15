<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintClassForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintClassForm))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tscbClass = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PrintClassDataSet = New SpaceshipDB.PrintClassDataSet()
        Me.ShipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipsTableAdapter = New SpaceshipDB.PrintClassDataSetTableAdapters.ShipsTableAdapter()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassesTableAdapter = New SpaceshipDB.PrintClassDataSetTableAdapters.ClassesTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PrintClassDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscbClass, Me.tsbRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(703, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tscbClass
        '
        Me.tscbClass.Name = "tscbClass"
        Me.tscbClass.Size = New System.Drawing.Size(121, 25)
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRefresh.Image = CType(resources.GetObject("tsbRefresh.Image"), System.Drawing.Image)
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(50, 22)
        Me.tsbRefresh.Text = "Refresh"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PrintClass"
        ReportDataSource1.Value = Me.ShipsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SpaceshipDB.PrintClassReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(703, 491)
        Me.ReportViewer1.TabIndex = 1
        '
        'PrintClassDataSet
        '
        Me.PrintClassDataSet.DataSetName = "PrintClassDataSet"
        Me.PrintClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShipsBindingSource
        '
        Me.ShipsBindingSource.DataMember = "Ships"
        Me.ShipsBindingSource.DataSource = Me.PrintClassDataSet
        '
        'ShipsTableAdapter
        '
        Me.ShipsTableAdapter.ClearBeforeFill = True
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.PrintClassDataSet
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'PrintClassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 516)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PrintClassForm"
        Me.Text = "PrintClassForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PrintClassDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tscbClass As ToolStripComboBox
    Friend WithEvents tsbRefresh As ToolStripButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ShipsBindingSource As BindingSource
    Friend WithEvents PrintClassDataSet As PrintClassDataSet
    Friend WithEvents ShipsTableAdapter As PrintClassDataSetTableAdapters.ShipsTableAdapter
    Friend WithEvents ClassesBindingSource As BindingSource
    Friend WithEvents ClassesTableAdapter As PrintClassDataSetTableAdapters.ClassesTableAdapter
End Class
