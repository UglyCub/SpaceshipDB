<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShipImageDialog
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
        Dim ShipImageLabel As System.Windows.Forms.Label
        Dim ImageDescriptionLabel As System.Windows.Forms.Label
        Dim ImageIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShipImageDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.bRemoveImage = New System.Windows.Forms.Button()
        Me.bAddImage = New System.Windows.Forms.Button()
        Me.SpaceshipDataSet = New SpaceshipDB.SpaceshipDataSet()
        Me.ShipImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipImagesTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShipImagesTableAdapter()
        Me.TableAdapterManager = New SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager()
        Me.ShipsTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShipsTableAdapter()
        Me.ShipImagesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ShipImagesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ShipImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ImageDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ShipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageIDComboBox = New System.Windows.Forms.ComboBox()
        ShipImageLabel = New System.Windows.Forms.Label()
        ImageDescriptionLabel = New System.Windows.Forms.Label()
        ImageIDLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipImagesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShipImagesBindingNavigator.SuspendLayout()
        CType(Me.ShipImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShipImageLabel
        '
        ShipImageLabel.AutoSize = True
        ShipImageLabel.Location = New System.Drawing.Point(36, 92)
        ShipImageLabel.Name = "ShipImageLabel"
        ShipImageLabel.Size = New System.Drawing.Size(63, 13)
        ShipImageLabel.TabIndex = 16
        ShipImageLabel.Text = "Ship Image:"
        '
        'ImageDescriptionLabel
        '
        ImageDescriptionLabel.AutoSize = True
        ImageDescriptionLabel.Location = New System.Drawing.Point(283, 92)
        ImageDescriptionLabel.Name = "ImageDescriptionLabel"
        ImageDescriptionLabel.Size = New System.Drawing.Size(95, 13)
        ImageDescriptionLabel.TabIndex = 18
        ImageDescriptionLabel.Text = "Image Description:"
        '
        'ImageIDLabel
        '
        ImageIDLabel.AutoSize = True
        ImageIDLabel.Location = New System.Drawing.Point(36, 64)
        ImageIDLabel.Name = "ImageIDLabel"
        ImageIDLabel.Size = New System.Drawing.Size(53, 13)
        ImageIDLabel.TabIndex = 20
        ImageIDLabel.Text = "Image ID:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(404, 288)
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
        'bRemoveImage
        '
        Me.bRemoveImage.Location = New System.Drawing.Point(177, 272)
        Me.bRemoveImage.Name = "bRemoveImage"
        Me.bRemoveImage.Size = New System.Drawing.Size(91, 23)
        Me.bRemoveImage.TabIndex = 13
        Me.bRemoveImage.Text = "Remove Image"
        Me.bRemoveImage.UseVisualStyleBackColor = True
        '
        'bAddImage
        '
        Me.bAddImage.Location = New System.Drawing.Point(39, 272)
        Me.bAddImage.Name = "bAddImage"
        Me.bAddImage.Size = New System.Drawing.Size(75, 23)
        Me.bAddImage.TabIndex = 12
        Me.bAddImage.Text = "Add Image"
        Me.bAddImage.UseVisualStyleBackColor = True
        '
        'SpaceshipDataSet
        '
        Me.SpaceshipDataSet.DataSetName = "SpaceshipDataSet"
        Me.SpaceshipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShipImagesBindingSource
        '
        Me.ShipImagesBindingSource.DataMember = "ShipImages"
        Me.ShipImagesBindingSource.DataSource = Me.SpaceshipDataSet
        '
        'ShipImagesTableAdapter
        '
        Me.ShipImagesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassesTableAdapter = Nothing
        Me.TableAdapterManager.ShipImagesTableAdapter = Me.ShipImagesTableAdapter
        Me.TableAdapterManager.ShipsTableAdapter = Me.ShipsTableAdapter
        Me.TableAdapterManager.ShowsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ShipsTableAdapter
        '
        Me.ShipsTableAdapter.ClearBeforeFill = True
        '
        'ShipImagesBindingNavigator
        '
        Me.ShipImagesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ShipImagesBindingNavigator.BindingSource = Me.ShipImagesBindingSource
        Me.ShipImagesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ShipImagesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ShipImagesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ShipImagesBindingNavigatorSaveItem})
        Me.ShipImagesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ShipImagesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ShipImagesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ShipImagesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ShipImagesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ShipImagesBindingNavigator.Name = "ShipImagesBindingNavigator"
        Me.ShipImagesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ShipImagesBindingNavigator.Size = New System.Drawing.Size(562, 25)
        Me.ShipImagesBindingNavigator.TabIndex = 14
        Me.ShipImagesBindingNavigator.Text = "BindingNavigator1"
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
        'ShipImagesBindingNavigatorSaveItem
        '
        Me.ShipImagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShipImagesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ShipImagesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ShipImagesBindingNavigatorSaveItem.Name = "ShipImagesBindingNavigatorSaveItem"
        Me.ShipImagesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ShipImagesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ShipImagePictureBox
        '
        Me.ShipImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ShipImagesBindingSource, "ShipImage", True))
        Me.ShipImagePictureBox.Location = New System.Drawing.Point(39, 108)
        Me.ShipImagePictureBox.Name = "ShipImagePictureBox"
        Me.ShipImagePictureBox.Size = New System.Drawing.Size(229, 146)
        Me.ShipImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ShipImagePictureBox.TabIndex = 17
        Me.ShipImagePictureBox.TabStop = False
        '
        'ImageDescriptionTextBox
        '
        Me.ImageDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipImagesBindingSource, "ImageDescription", True))
        Me.ImageDescriptionTextBox.Location = New System.Drawing.Point(286, 108)
        Me.ImageDescriptionTextBox.Multiline = True
        Me.ImageDescriptionTextBox.Name = "ImageDescriptionTextBox"
        Me.ImageDescriptionTextBox.Size = New System.Drawing.Size(243, 146)
        Me.ImageDescriptionTextBox.TabIndex = 19
        '
        'ShipsBindingSource
        '
        Me.ShipsBindingSource.DataMember = "FK__Ships__ImageID__6FE99F9F"
        Me.ShipsBindingSource.DataSource = Me.ShipImagesBindingSource
        '
        'ImageIDComboBox
        '
        Me.ImageIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipImagesBindingSource, "ImageID", True))
        Me.ImageIDComboBox.DataSource = Me.ShipImagesBindingSource
        Me.ImageIDComboBox.DisplayMember = "ImageID"
        Me.ImageIDComboBox.FormattingEnabled = True
        Me.ImageIDComboBox.Location = New System.Drawing.Point(137, 61)
        Me.ImageIDComboBox.Name = "ImageIDComboBox"
        Me.ImageIDComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ImageIDComboBox.TabIndex = 21
        Me.ImageIDComboBox.ValueMember = "ImageID"
        '
        'ShipImageDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(562, 329)
        Me.Controls.Add(ImageIDLabel)
        Me.Controls.Add(Me.ImageIDComboBox)
        Me.Controls.Add(ShipImageLabel)
        Me.Controls.Add(Me.ShipImagePictureBox)
        Me.Controls.Add(ImageDescriptionLabel)
        Me.Controls.Add(Me.ImageDescriptionTextBox)
        Me.Controls.Add(Me.ShipImagesBindingNavigator)
        Me.Controls.Add(Me.bRemoveImage)
        Me.Controls.Add(Me.bAddImage)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShipImageDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ShipImageDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipImagesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShipImagesBindingNavigator.ResumeLayout(False)
        Me.ShipImagesBindingNavigator.PerformLayout()
        CType(Me.ShipImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents bRemoveImage As Button
    Friend WithEvents bAddImage As Button
    Friend WithEvents SpaceshipDataSet As SpaceshipDataSet
    Friend WithEvents ShipImagesBindingSource As BindingSource
    Friend WithEvents ShipImagesTableAdapter As SpaceshipDataSetTableAdapters.ShipImagesTableAdapter
    Friend WithEvents TableAdapterManager As SpaceshipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ShipImagesBindingNavigator As BindingNavigator
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
    Friend WithEvents ShipImagesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ShipsTableAdapter As SpaceshipDataSetTableAdapters.ShipsTableAdapter
    Friend WithEvents ShipImagePictureBox As PictureBox
    Friend WithEvents ImageDescriptionTextBox As TextBox
    Friend WithEvents ShipsBindingSource As BindingSource
    Friend WithEvents ImageIDComboBox As ComboBox
End Class
