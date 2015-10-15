﻿Imports System.Windows.Forms

Public Class ClassesDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ClassesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClassesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpaceshipDataSet)

    End Sub

    Private Sub ClassesDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpaceshipDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.SpaceshipDataSet.Classes)

        'TODO: This line of code loads data into the 'SpaceshipDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.SpaceshipDataSet.Classes)

    End Sub

    Private Sub ClassesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ClassesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClassesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpaceshipDataSet)

    End Sub
End Class
