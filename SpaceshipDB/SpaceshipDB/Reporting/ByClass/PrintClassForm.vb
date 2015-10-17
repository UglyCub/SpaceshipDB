Public Class PrintClassForm
    'Public Shared pcfInstance As PrintClassForm = Nothing

    'Public ReadOnly Property GetInstance As PrintClassForm
    '    Get
    '        If pcfInstance Is Nothing Then
    '            pcfInstance = New PrintClassForm
    '        End If
    '        Return pcfInstance
    '    End Get
    'End Property

    Private Sub PrintClassForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'pcfInstance = Nothing
    End Sub

    Private Sub PrintClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrintClassDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.PrintClassDataSet.Classes)
        With tscbClass.ComboBox
            .DataSource = Me.ClassesBindingSource
            .DisplayMember = "ClassName"
            .ValueMember = "ClassID"
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With

    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Me.ShipsTableAdapter.FillByClassID(Me.PrintClassDataSet.Ships, Me.tscbClass.ComboBox.SelectedValue)
        Me.ShipsBindingSource.DataSource = Me.PrintClassDataSet.Ships
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class