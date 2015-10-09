Imports System.Windows.Forms

Public Class ShipImageDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShipImagesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ShipImagesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpaceshipDataSet)

    End Sub

    Private Sub ShipImageDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaceshipDataSet.ShipImages' table. You can move, or remove it, as needed.
        Me.ShipImagesTableAdapter.Fill(Me.SpaceshipDataSet.ShipImages)
        'TODO: This line of code loads data into the 'SpaceshipDataSet.ShipImages' table. You can move, or remove it, as needed.
        Me.ShipImagesTableAdapter.Fill(Me.SpaceshipDataSet.ShipImages)

    End Sub
    Private Sub bAddImage_Click(sender As Object, e As EventArgs) Handles bAddImage.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "JPEG|*.jpg|PNG|*.png"

        If ofd.ShowDialog() = DialogResult.OK Then
            ImagePictureBox.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub bRemoveImage_Click(sender As Object, e As EventArgs) Handles bRemoveImage.Click
        ImagePictureBox.Image = Nothing
    End Sub

    Private Sub ShipImagesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ShipImagesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ShipImagesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpaceshipDataSet)

    End Sub
End Class
