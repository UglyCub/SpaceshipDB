<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowsDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ShowIDLabel As System.Windows.Forms.Label
        Dim ShowNameLabel As System.Windows.Forms.Label
        Dim ShowDescriptionLabel As System.Windows.Forms.Label
        Dim ShowImageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowsDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.bAddImage = New System.Windows.Forms.Button()
        Me.bRemoveImage = New System.Windows.Forms.Button()
        Me.SpaceshipDataSet = New SpaceshipDB.SpaceshipDataSet()
        Me.ShowsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShowsTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShowsTableAdapter()
        Me.TableAdapterManager = New SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager()
        Me.ShowsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ShowIDTextBox = New System.Windows.Forms.TextBox()
        Me.ShowNameTextBox = New System.Windows.Forms.TextBox()
        Me.ShowDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ShowImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ShipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipsTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShipsTableAdapter()
        ShowIDLabel = New System.Windows.Forms.Label()
        ShowNameLabel = New System.Windows.Forms.Label()
        ShowDescriptionLabel = New System.Windows.Forms.Label()
        ShowImageLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShowsBindingNavigator.SuspendLayout()
        CType(Me.ShowImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowIDLabel
        '
        ShowIDLabel.AutoSize = True
        ShowIDLabel.Location = New System.Drawing.Point(23, 49)
        ShowIDLabel.Name = "ShowIDLabel"
        ShowIDLabel.Size = New System.Drawing.Size(37, 13)
        ShowIDLabel.TabIndex = 12
        ShowIDLabel.Text = "Show:"
        '
        'ShowNameLabel
        '
        ShowNameLabel.AutoSize = True
        ShowNameLabel.Location = New System.Drawing.Point(23, 77)
        ShowNameLabel.Name = "ShowNameLabel"
        ShowNameLabel.Size = New System.Drawing.Size(68, 13)
        ShowNameLabel.TabIndex = 14
        ShowNameLabel.Text = "Show Name:"
        '
        'ShowDescriptionLabel
        '
        ShowDescriptionLabel.AutoSize = True
        ShowDescriptionLabel.Location = New System.Drawing.Point(262, 109)
        ShowDescriptionLabel.Name = "ShowDescriptionLabel"
        ShowDescriptionLabel.Size = New System.Drawing.Size(93, 13)
        ShowDescriptionLabel.TabIndex = 16
        ShowDescriptionLabel.Text = "Show Description:"
        '
        'ShowImageLabel
        '
        ShowImageLabel.AutoSize = True
        ShowImageLabel.Location = New System.Drawing.Point(23, 109)
        ShowImageLabel.Name = "ShowImageLabel"
        ShowImageLabel.Size = New System.Drawing.Size(69, 13)
        ShowImageLabel.TabIndex = 18
        ShowImageLabel.Text = "Show Image:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(347, 258)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'bAddImage
        '
        Me.bAddImage.Location = New System.Drawing.Point(26, 254)
        Me.bAddImage.Name = "bAddImage"
        Me.bAddImage.Size = New System.Drawing.Size(75, 23)
        Me.bAddImage.TabIndex = 10
        Me.bAddImage.Text = "Add Image"
        Me.bAddImage.UseVisualStyleBackColor = True
        '
        'bRemoveImage
        '
        Me.bRemoveImage.Location = New System.Drawing.Point(148, 254)
        Me.bRemoveImage.Name = "bRemoveImage"
        Me.bRemoveImage.Size = New System.Drawing.Size(91, 23)
        Me.bRemoveImage.TabIndex = 11
        Me.bRemoveImage.Text = "Remove Image"
        Me.bRemoveImage.UseVisualStyleBackColor = True
        '
        'SpaceshipDataSet
        '
        Me.SpaceshipDataSet.DataSetName = "SpaceshipDataSet"
        Me.SpaceshipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShowsBindingSource
        '
        Me.ShowsBindingSource.DataMember = "Shows"
        Me.ShowsBindingSource.DataSource = Me.SpaceshipDataSet
        '
        'ShowsTableAdapter
        '
        Me.ShowsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassesTableAdapter = Nothing
        Me.TableAdapterManager.ShipImagesTableAdapter = Nothing
        Me.TableAdapterManager.ShipsTableAdapter = Nothing
        Me.TableAdapterManager.ShowsTableAdapter = Me.ShowsTableAdapter
        Me.TableAdapterManager.UpdateOrder = SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ShowsBindingNavigator
        '
        Me.ShowsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ShowsBindingNavigator.BindingSource = Me.ShowsBindingSource
        Me.ShowsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ShowsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ShowsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ShowsBindingNavigatorSaveItem})
        Me.ShowsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ShowsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ShowsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ShowsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ShowsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ShowsBindingNavigator.Name = "ShowsBindingNavigator"
        Me.ShowsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ShowsBindingNavigator.Size = New System.Drawing.Size(505, 25)
        Me.ShowsBindingNavigator.TabIndex = 12
        Me.ShowsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ShowsBindingNavigatorSaveItem
        '
        Me.ShowsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ShowsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ShowsBindingNavigatorSaveItem.Name = "ShowsBindingNavigatorSaveItem"
        Me.ShowsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ShowsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ShowIDTextBox
        '
        Me.ShowIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShowsBindingSource, "ShowID", True))
        Me.ShowIDTextBox.Location = New System.Drawing.Point(122, 46)
        Me.ShowIDTextBox.Name = "ShowIDTextBox"
        Me.ShowIDTextBox.ReadOnly = True
        Me.ShowIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShowIDTextBox.TabIndex = 13
        '
        'ShowNameTextBox
        '
        Me.ShowNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShowsBindingSource, "ShowName", True))
        Me.ShowNameTextBox.Location = New System.Drawing.Point(122, 74)
        Me.ShowNameTextBox.Name = "ShowNameTextBox"
        Me.ShowNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShowNameTextBox.TabIndex = 15
        '
        'ShowDescriptionTextBox
        '
        Me.ShowDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShowsBindingSource, "ShowDescription", True))
        Me.ShowDescriptionTextBox.Location = New System.Drawing.Point(265, 125)
        Me.ShowDescriptionTextBox.Multiline = True
        Me.ShowDescriptionTextBox.Name = "ShowDescriptionTextBox"
        Me.ShowDescriptionTextBox.Size = New System.Drawing.Size(220, 109)
        Me.ShowDescriptionTextBox.TabIndex = 17
        '
        'ShowImagePictureBox
        '
        Me.ShowImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ShowsBindingSource, "ShowImage", True))
        Me.ShowImagePictureBox.Location = New System.Drawing.Point(26, 125)
        Me.ShowImagePictureBox.Name = "ShowImagePictureBox"
        Me.ShowImagePictureBox.Size = New System.Drawing.Size(213, 109)
        Me.ShowImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ShowImagePictureBox.TabIndex = 19
        Me.ShowImagePictureBox.TabStop = False
        '
        'ShipsBindingSource
        '
        Me.ShipsBindingSource.DataMember = "FK__Ships__ShowID__5BE2A6F2"
        Me.ShipsBindingSource.DataSource = Me.ShowsBindingSource
        '
        'ShipsTableAdapter
        '
        Me.ShipsTableAdapter.ClearBeforeFill = True
        '
        'ShowsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(505, 299)
        Me.Controls.Add(ShowIDLabel)
        Me.Controls.Add(Me.ShowIDTextBox)
        Me.Controls.Add(ShowNameLabel)
        Me.Controls.Add(Me.ShowNameTextBox)
        Me.Controls.Add(ShowDescriptionLabel)
        Me.Controls.Add(Me.ShowDescriptionTextBox)
        Me.Controls.Add(ShowImageLabel)
        Me.Controls.Add(Me.ShowImagePictureBox)
        Me.Controls.Add(Me.ShowsBindingNavigator)
        Me.Controls.Add(Me.bRemoveImage)
        Me.Controls.Add(Me.bAddImage)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShowsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ShowsDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShowsBindingNavigator.ResumeLayout(False)
        Me.ShowsBindingNavigator.PerformLayout()
        CType(Me.ShowImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents bAddImage As Button
    Friend WithEvents bRemoveImage As Button
    Friend WithEvents SpaceshipDataSet As SpaceshipDataSet
    Friend WithEvents ShowsBindingSource As BindingSource
    Friend WithEvents ShowsTableAdapter As SpaceshipDataSetTableAdapters.ShowsTableAdapter
    Friend WithEvents TableAdapterManager As SpaceshipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ShowsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ShowsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ShowIDTextBox As TextBox
    Friend WithEvents ShowNameTextBox As TextBox
    Friend WithEvents ShowDescriptionTextBox As TextBox
    Friend WithEvents ShowImagePictureBox As PictureBox
    Friend WithEvents ShipsBindingSource As BindingSource
    Friend WithEvents ShipsTableAdapter As SpaceshipDataSetTableAdapters.ShipsTableAdapter
End Class
