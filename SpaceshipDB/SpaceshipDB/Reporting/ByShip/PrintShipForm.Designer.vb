<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintShipForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ShipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintShipDataSet = New SpaceshipDB.PrintShipDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ShipsTableAdapter = New SpaceshipDB.PrintShipDataSetTableAdapters.ShipsTableAdapter()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassesTableAdapter = New SpaceshipDB.PrintShipDataSetTableAdapters.ClassesTableAdapter()
        Me.ShowsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShowsTableAdapter = New SpaceshipDB.PrintShipDataSetTableAdapters.ShowsTableAdapter()
        Me.ShipImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipImagesTableAdapter = New SpaceshipDB.PrintShipDataSetTableAdapters.ShipImagesTableAdapter()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintShipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShipsBindingSource
        '
        Me.ShipsBindingSource.DataMember = "Ships"
        Me.ShipsBindingSource.DataSource = Me.PrintShipDataSet
        '
        'PrintShipDataSet
        '
        Me.PrintShipDataSet.DataSetName = "PrintShipDataSet"
        Me.PrintShipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PrintShip"
        ReportDataSource1.Value = Me.ShipsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SpaceshipDB.PrintShipReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(769, 563)
        Me.ReportViewer1.TabIndex = 0
        '
        'ShipsTableAdapter
        '
        Me.ShipsTableAdapter.ClearBeforeFill = True
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.PrintShipDataSet
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'ShowsBindingSource
        '
        Me.ShowsBindingSource.DataMember = "Shows"
        Me.ShowsBindingSource.DataSource = Me.PrintShipDataSet
        '
        'ShowsTableAdapter
        '
        Me.ShowsTableAdapter.ClearBeforeFill = True
        '
        'ShipImagesBindingSource
        '
        Me.ShipImagesBindingSource.DataMember = "ShipImages"
        Me.ShipImagesBindingSource.DataSource = Me.PrintShipDataSet
        '
        'ShipImagesTableAdapter
        '
        Me.ShipImagesTableAdapter.ClearBeforeFill = True
        '
        'PrintShipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 563)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "PrintShipForm"
        Me.Text = "PrintShipForm"
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintShipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrintShipDataSet As PrintShipDataSet
    Friend WithEvents ShipsBindingSource As BindingSource
    Friend WithEvents ShipsTableAdapter As PrintShipDataSetTableAdapters.ShipsTableAdapter
    Friend WithEvents ClassesBindingSource As BindingSource
    Friend WithEvents ClassesTableAdapter As PrintShipDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents ShowsBindingSource As BindingSource
    Friend WithEvents ShowsTableAdapter As PrintShipDataSetTableAdapters.ShowsTableAdapter
    Friend WithEvents ShipImagesBindingSource As BindingSource
    Friend WithEvents ShipImagesTableAdapter As PrintShipDataSetTableAdapters.ShipImagesTableAdapter
End Class
