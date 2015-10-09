<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShipImageForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShipImageForm))
        Dim ImageLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim ShipIDLabel As System.Windows.Forms.Label
        Me.SpaceshipDataSet = New SpaceshipDB.SpaceshipDataSet()
        Me.ShipImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipImagesTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShipImagesTableAdapter()
        Me.TableAdapterManager = New SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager()
        Me.ShipImagesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ShipImagesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ShipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipsTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShipsTableAdapter()
        Me.ShipIDComboBox = New System.Windows.Forms.ComboBox()
        ImageLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        ShipIDLabel = New System.Windows.Forms.Label()
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipImagesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShipImagesBindingNavigator.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ShipImagesBindingNavigator.Size = New System.Drawing.Size(456, 25)
        Me.ShipImagesBindingNavigator.TabIndex = 0
        Me.ShipImagesBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ShipImagesBindingNavigatorSaveItem
        '
        Me.ShipImagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShipImagesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ShipImagesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ShipImagesBindingNavigatorSaveItem.Name = "ShipImagesBindingNavigatorSaveItem"
        Me.ShipImagesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ShipImagesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.Location = New System.Drawing.Point(25, 53)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(39, 13)
        ImageLabel.TabIndex = 1
        ImageLabel.Text = "Image:"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ShipImagesBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(28, 72)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(186, 222)
        Me.ImagePictureBox.TabIndex = 2
        Me.ImagePictureBox.TabStop = False
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(230, 56)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 3
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipImagesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(233, 72)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(186, 118)
        Me.DescriptionTextBox.TabIndex = 4
        '
        'ShipsBindingSource
        '
        Me.ShipsBindingSource.DataMember = "ShipImages_Ships"
        Me.ShipsBindingSource.DataSource = Me.ShipImagesBindingSource
        '
        'ShipsTableAdapter
        '
        Me.ShipsTableAdapter.ClearBeforeFill = True
        '
        'ShipIDLabel
        '
        ShipIDLabel.AutoSize = True
        ShipIDLabel.Location = New System.Drawing.Point(25, 326)
        ShipIDLabel.Name = "ShipIDLabel"
        ShipIDLabel.Size = New System.Drawing.Size(45, 13)
        ShipIDLabel.TabIndex = 5
        ShipIDLabel.Text = "Ship ID:"
        '
        'ShipIDComboBox
        '
        Me.ShipIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipsBindingSource, "ShipID", True))
        Me.ShipIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ShipsBindingSource, "ShipID", True))
        Me.ShipIDComboBox.DataSource = Me.ShipsBindingSource
        Me.ShipIDComboBox.DisplayMember = "Name"
        Me.ShipIDComboBox.FormattingEnabled = True
        Me.ShipIDComboBox.Location = New System.Drawing.Point(76, 323)
        Me.ShipIDComboBox.Name = "ShipIDComboBox"
        Me.ShipIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ShipIDComboBox.TabIndex = 6
        Me.ShipIDComboBox.ValueMember = "ShipID"
        '
        'ShipImageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 469)
        Me.Controls.Add(ShipIDLabel)
        Me.Controls.Add(Me.ShipIDComboBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.ShipImagesBindingNavigator)
        Me.Name = "ShipImageForm"
        Me.Text = "ShipImageForm"
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipImagesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShipImagesBindingNavigator.ResumeLayout(False)
        Me.ShipImagesBindingNavigator.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents ShipsTableAdapter As SpaceshipDataSetTableAdapters.ShipsTableAdapter
    Friend WithEvents ShipsBindingSource As BindingSource
    Friend WithEvents ShipIDComboBox As ComboBox
End Class
