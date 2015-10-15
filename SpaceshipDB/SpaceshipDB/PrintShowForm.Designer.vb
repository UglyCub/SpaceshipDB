<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintShowForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintShowForm))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tscbShows = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ShipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintShowDataSet = New SpaceshipDB.PrintShowDataSet()
        Me.ShipsTableAdapter = New SpaceshipDB.PrintShowDataSetTableAdapters.ShipsTableAdapter()
        Me.ShowsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShowsTableAdapter = New SpaceshipDB.PrintShowDataSetTableAdapters.ShowsTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintShowDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PrintShow"
        ReportDataSource1.Value = Me.ShipsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SpaceshipDB.PrintShowReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(521, 386)
        Me.ReportViewer1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscbShows, Me.tsbRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(521, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 411)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(521, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tscbShows
        '
        Me.tscbShows.Name = "tscbShows"
        Me.tscbShows.Size = New System.Drawing.Size(121, 25)
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
        'ShipsBindingSource
        '
        Me.ShipsBindingSource.DataMember = "Ships"
        Me.ShipsBindingSource.DataSource = Me.PrintShowDataSet
        '
        'PrintShowDataSet
        '
        Me.PrintShowDataSet.DataSetName = "PrintShowDataSet"
        Me.PrintShowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShipsTableAdapter
        '
        Me.ShipsTableAdapter.ClearBeforeFill = True
        '
        'ShowsBindingSource
        '
        Me.ShowsBindingSource.DataMember = "Shows"
        Me.ShowsBindingSource.DataSource = Me.PrintShowDataSet
        '
        'ShowsTableAdapter
        '
        Me.ShowsTableAdapter.ClearBeforeFill = True
        '
        'PrintShowForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 433)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "PrintShowForm"
        Me.Text = "PrintShowForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintShowDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tscbShows As ToolStripComboBox
    Friend WithEvents tsbRefresh As ToolStripButton
    Friend WithEvents ShipsBindingSource As BindingSource
    Friend WithEvents PrintShowDataSet As PrintShowDataSet
    Friend WithEvents ShipsTableAdapter As PrintShowDataSetTableAdapters.ShipsTableAdapter
    Friend WithEvents ShowsBindingSource As BindingSource
    Friend WithEvents ShowsTableAdapter As PrintShowDataSetTableAdapters.ShowsTableAdapter
End Class
