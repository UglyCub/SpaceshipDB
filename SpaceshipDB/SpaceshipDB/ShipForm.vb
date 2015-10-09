Public Class ShipForm
    Private Sub ShipsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ShipsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ShipsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpaceshipDataSet)

    End Sub

    Private Sub ShipForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaceshipDataSet.ShipImages' table. You can move, or remove it, as needed.
        Me.ShipImagesTableAdapter.Fill(Me.SpaceshipDataSet.ShipImages)
        Me.ClassesTableAdapter.Fill(Me.SpaceshipDataSet.Classes)
        Me.ShowsTableAdapter.Fill(Me.SpaceshipDataSet.Shows)
        Me.ShipsTableAdapter.Fill(Me.SpaceshipDataSet.Ships)

    End Sub
End Class