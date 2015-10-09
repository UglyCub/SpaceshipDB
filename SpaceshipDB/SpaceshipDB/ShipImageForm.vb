Public Class ShipImageForm
    Private Sub ShipImagesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ShipImagesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ShipImagesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpaceshipDataSet)

    End Sub

    Private Sub ShipImageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaceshipDataSet.Ships' table. You can move, or remove it, as needed.
        Me.ShipsTableAdapter.Fill(Me.SpaceshipDataSet.Ships)
        'TODO: This line of code loads data into the 'SpaceshipDataSet.ShipImages' table. You can move, or remove it, as needed.
        Me.ShipImagesTableAdapter.Fill(Me.SpaceshipDataSet.ShipImages)

    End Sub
End Class