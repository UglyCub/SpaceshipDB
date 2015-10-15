Public Class PrintClassForm
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
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class