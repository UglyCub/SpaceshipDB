<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShipDialog
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
        Dim ShipIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim ClassIDLabel As System.Windows.Forms.Label
        Dim ShowIDLabel As System.Windows.Forms.Label
        Dim ImageIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShipDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SpaceshipDataSet = New SpaceshipDB.SpaceshipDataSet()
        Me.ShipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipsTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShipsTableAdapter()
        Me.TableAdapterManager = New SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager()
        Me.ClassesTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ClassesTableAdapter()
        Me.ShipImagesTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShipImagesTableAdapter()
        Me.ShowsTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ShowsTableAdapter()
        Me.ShipsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ShipsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ShipIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ClassIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShowIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ShowsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ShipImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ShipIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        ClassIDLabel = New System.Windows.Forms.Label()
        ShowIDLabel = New System.Windows.Forms.Label()
        ImageIDLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShipsBindingNavigator.SuspendLayout()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShipIDLabel
        '
        ShipIDLabel.AutoSize = True
        ShipIDLabel.Location = New System.Drawing.Point(103, 73)
        ShipIDLabel.Name = "ShipIDLabel"
        ShipIDLabel.Size = New System.Drawing.Size(45, 13)
        ShipIDLabel.TabIndex = 2
        ShipIDLabel.Text = "Ship ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(103, 99)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(103, 125)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'ClassIDLabel
        '
        ClassIDLabel.AutoSize = True
        ClassIDLabel.Location = New System.Drawing.Point(103, 151)
        ClassIDLabel.Name = "ClassIDLabel"
        ClassIDLabel.Size = New System.Drawing.Size(49, 13)
        ClassIDLabel.TabIndex = 8
        ClassIDLabel.Text = "Class ID:"
        '
        'ShowIDLabel
        '
        ShowIDLabel.AutoSize = True
        ShowIDLabel.Location = New System.Drawing.Point(103, 178)
        ShowIDLabel.Name = "ShowIDLabel"
        ShowIDLabel.Size = New System.Drawing.Size(51, 13)
        ShowIDLabel.TabIndex = 10
        ShowIDLabel.Text = "Show ID:"
        '
        'ImageIDLabel
        '
        ImageIDLabel.AutoSize = True
        ImageIDLabel.Location = New System.Drawing.Point(103, 205)
        ImageIDLabel.Name = "ImageIDLabel"
        ImageIDLabel.Size = New System.Drawing.Size(53, 13)
        ImageIDLabel.TabIndex = 12
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(210, 301)
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
        'SpaceshipDataSet
        '
        Me.SpaceshipDataSet.DataSetName = "SpaceshipDataSet"
        Me.SpaceshipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShipsBindingSource
        '
        Me.ShipsBindingSource.DataMember = "Ships"
        Me.ShipsBindingSource.DataSource = Me.SpaceshipDataSet
        '
        'ShipsTableAdapter
        '
        Me.ShipsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassesTableAdapter = Me.ClassesTableAdapter
        Me.TableAdapterManager.ShipImagesTableAdapter = Me.ShipImagesTableAdapter
        Me.TableAdapterManager.ShipsTableAdapter = Me.ShipsTableAdapter
        Me.TableAdapterManager.ShowsTableAdapter = Me.ShowsTableAdapter
        Me.TableAdapterManager.UpdateOrder = SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'ShipImagesTableAdapter
        '
        Me.ShipImagesTableAdapter.ClearBeforeFill = True
        '
        'ShowsTableAdapter
        '
        Me.ShowsTableAdapter.ClearBeforeFill = True
        '
        'ShipsBindingNavigator
        '
        Me.ShipsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ShipsBindingNavigator.BindingSource = Me.ShipsBindingSource
        Me.ShipsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ShipsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ShipsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ShipsBindingNavigatorSaveItem})
        Me.ShipsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ShipsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ShipsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ShipsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ShipsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ShipsBindingNavigator.Name = "ShipsBindingNavigator"
        Me.ShipsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ShipsBindingNavigator.Size = New System.Drawing.Size(368, 25)
        Me.ShipsBindingNavigator.TabIndex = 1
        Me.ShipsBindingNavigator.Text = "BindingNavigator1"
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
        'ShipsBindingNavigatorSaveItem
        '
        Me.ShipsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShipsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ShipsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ShipsBindingNavigatorSaveItem.Name = "ShipsBindingNavigatorSaveItem"
        Me.ShipsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ShipsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ShipIDTextBox
        '
        Me.ShipIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipsBindingSource, "ShipID", True))
        Me.ShipIDTextBox.Location = New System.Drawing.Point(172, 70)
        Me.ShipIDTextBox.Name = "ShipIDTextBox"
        Me.ShipIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ShipIDTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(172, 96)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(172, 122)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'ClassIDComboBox
        '
        Me.ClassIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipsBindingSource, "ClassID", True))
        Me.ClassIDComboBox.DataSource = Me.ClassesBindingSource
        Me.ClassIDComboBox.DisplayMember = "Name"
        Me.ClassIDComboBox.FormattingEnabled = True
        Me.ClassIDComboBox.Location = New System.Drawing.Point(172, 148)
        Me.ClassIDComboBox.Name = "ClassIDComboBox"
        Me.ClassIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClassIDComboBox.TabIndex = 9
        Me.ClassIDComboBox.ValueMember = "ClassID"
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.SpaceshipDataSet
        '
        'ShowIDComboBox
        '
        Me.ShowIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipsBindingSource, "ShowID", True))
        Me.ShowIDComboBox.DataSource = Me.ShowsBindingSource
        Me.ShowIDComboBox.DisplayMember = "Name"
        Me.ShowIDComboBox.FormattingEnabled = True
        Me.ShowIDComboBox.Location = New System.Drawing.Point(172, 175)
        Me.ShowIDComboBox.Name = "ShowIDComboBox"
        Me.ShowIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ShowIDComboBox.TabIndex = 11
        Me.ShowIDComboBox.ValueMember = "ShowID"
        '
        'ShowsBindingSource
        '
        Me.ShowsBindingSource.DataMember = "Shows"
        Me.ShowsBindingSource.DataSource = Me.SpaceshipDataSet
        '
        'ImageIDComboBox
        '
        Me.ImageIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipsBindingSource, "ImageID", True))
        Me.ImageIDComboBox.DataSource = Me.ShipImagesBindingSource
        Me.ImageIDComboBox.DisplayMember = "ImageID"
        Me.ImageIDComboBox.FormattingEnabled = True
        Me.ImageIDComboBox.Location = New System.Drawing.Point(172, 202)
        Me.ImageIDComboBox.Name = "ImageIDComboBox"
        Me.ImageIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ImageIDComboBox.TabIndex = 13
        Me.ImageIDComboBox.ValueMember = "ImageID"
        '
        'ShipImagesBindingSource
        '
        Me.ShipImagesBindingSource.DataMember = "ShipImages"
        Me.ShipImagesBindingSource.DataSource = Me.SpaceshipDataSet
        '
        'ShipDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(368, 342)
        Me.Controls.Add(ShipIDLabel)
        Me.Controls.Add(Me.ShipIDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(ClassIDLabel)
        Me.Controls.Add(Me.ClassIDComboBox)
        Me.Controls.Add(ShowIDLabel)
        Me.Controls.Add(Me.ShowIDComboBox)
        Me.Controls.Add(ImageIDLabel)
        Me.Controls.Add(Me.ImageIDComboBox)
        Me.Controls.Add(Me.ShipsBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShipDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ShipDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShipsBindingNavigator.ResumeLayout(False)
        Me.ShipsBindingNavigator.PerformLayout()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents SpaceshipDataSet As SpaceshipDataSet
    Friend WithEvents ShipsBindingSource As BindingSource
    Friend WithEvents ShipsTableAdapter As SpaceshipDataSetTableAdapters.ShipsTableAdapter
    Friend WithEvents TableAdapterManager As SpaceshipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ShipsBindingNavigator As BindingNavigator
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
    Friend WithEvents ShipsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClassesTableAdapter As SpaceshipDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents ShipIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents ClassIDComboBox As ComboBox
    Friend WithEvents ShowIDComboBox As ComboBox
    Friend WithEvents ImageIDComboBox As ComboBox
    Friend WithEvents ClassesBindingSource As BindingSource
    Friend WithEvents ShowsTableAdapter As SpaceshipDataSetTableAdapters.ShowsTableAdapter
    Friend WithEvents ShowsBindingSource As BindingSource
    Friend WithEvents ShipImagesTableAdapter As SpaceshipDataSetTableAdapters.ShipImagesTableAdapter
    Friend WithEvents ShipImagesBindingSource As BindingSource
End Class
