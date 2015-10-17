Public Class MainForm
    Private Sub msbShips_Click(sender As Object, e As EventArgs) Handles msbShips.Click
        Dim sf As New ShipDialog

        sf.ShowDialog()
    End Sub

    Private Sub msbClass_Click(sender As Object, e As EventArgs) Handles msbClass.Click
        Dim cd As New ClassesDialog

        cd.ShowDialog()
    End Sub

    Private Sub msbImages_Click(sender As Object, e As EventArgs) Handles msbImages.Click
        Dim sid As New ShipImageDialog

        sid.ShowDialog()
    End Sub

    Private Sub msbShows_Click(sender As Object, e As EventArgs) Handles msbShows.Click
        Dim sd As New ShowsDialog

        sd.ShowDialog()
    End Sub

    Private Sub ByShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByShowToolStripMenuItem.Click
        Dim ps As New PrintShowForm
        ps.MdiParent = Me

        ps.Show()
    End Sub

    Private Sub ByClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByClassToolStripMenuItem.Click
        Dim pc As New PrintClassForm
        pc.MdiParent = Me

        pc.Show()
    End Sub

    Private Sub IndividuallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividuallyToolStripMenuItem.Click
        Dim pi As New PrintShipForm
        pi.MdiParent = Me

        pi.Show()
    End Sub
End Class