﻿Imports System.Windows.Forms

Public Class ShipDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShipDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShipsTableAdapter.Fill(Me.SpaceshipDataSet.Ships)
        'TODO: This line of code loads data into the 'SpaceshipDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.SpaceshipDataSet.Classes)
        'TODO: This line of code loads data into the 'SpaceshipDataSet.Shows' table. You can move, or remove it, as needed.
        Me.ShowsTableAdapter.Fill(Me.SpaceshipDataSet.Shows)
        'TODO: This line of code loads data into the 'SpaceshipDataSet.ShipImages' table. You can move, or remove it, as needed.
        Me.ShipImagesTableAdapter.Fill(Me.SpaceshipDataSet.ShipImages)

    End Sub

    Private Sub ShipsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ShipsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ShipsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpaceshipDataSet)

    End Sub
End Class
