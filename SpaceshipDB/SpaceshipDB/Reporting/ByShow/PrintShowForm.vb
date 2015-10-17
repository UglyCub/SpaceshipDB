Public Class PrintShowForm
    'Public Shared pshowInstance As PrintShowForm = Nothing

    'Public Shared ReadOnly Property GetInstance As PrintShowForm
    '    Get
    '        If pshowInstance Is Nothing Then
    '            pshowInstance = New PrintShowForm
    '        End If
    '        Return pshowInstance
    '    End Get
    'End Property

    Private Sub PrintShowForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'pshowInstance = Nothing
    End Sub

    Private Sub PrintShowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrintShowDataSet.Shows' table. You can move, or remove it, as needed.
        Me.ShowsTableAdapter.Fill(Me.PrintShowDataSet.Shows)
        'TODO: This line of code loads data into the 'PrintShowDataSet.Shows' table. You can move, or remove it, as needed.
        Me.ShowsTableAdapter.Fill(Me.PrintShowDataSet.Shows)

        With tscbShows.ComboBox
            .DataSource = Me.ShowsBindingSource
            .DisplayMember = "ShowName"
            .ValueMember = "ShowID"
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click

        Me.ShipsTableAdapter.FillByShowID(Me.PrintShowDataSet.Ships, tscbShows.ComboBox.SelectedValue)
        Me.ShipsBindingSource.DataSource = Me.PrintShowDataSet.Ships
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class