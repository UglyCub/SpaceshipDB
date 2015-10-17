Imports Microsoft.Reporting.WinForms
Public Class PrintShipForm
    'Public Shared psfInstance As PrintShipForm = Nothing

    'Public Shared ReadOnly Property GetInstance As PrintShipForm
    '    Get
    '        If psfInstance Is Nothing Then
    '            psfInstance = New PrintShipForm
    '        End If
    '        Return psfInstance
    '    End Get
    'End Property

    Private Sub PrintShipForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'psfInstance = Nothing
    End Sub

    Private Sub PrintShipForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler ReportViewer1.LocalReport.SubreportProcessing, AddressOf SubreportHandler
        Me.ShipsTableAdapter.Fill(Me.PrintShipDataSet.Ships)
        Me.ClassesTableAdapter.Fill(Me.PrintShipDataSet.Classes)
        Me.ShowsTableAdapter.Fill(Me.PrintShipDataSet.Shows)
        Me.ShipImagesTableAdapter.Fill(Me.PrintShipDataSet.ShipImages)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SubreportHandler(sender As Object, e As SubreportProcessingEventArgs)

        e.DataSources.Add(New ReportDataSource("PrintShipClass", ClassesBindingSource))
        e.DataSources.Add(New ReportDataSource("PrintShipShow", ShowsBindingSource))
        e.DataSources.Add(New ReportDataSource("PrintShipImage", ShipImagesBindingSource))
    End Sub
End Class