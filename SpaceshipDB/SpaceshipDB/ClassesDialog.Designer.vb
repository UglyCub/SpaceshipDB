<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClassesDialog
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
        Dim ClassIDLabel As System.Windows.Forms.Label
        Dim ClassNameLabel As System.Windows.Forms.Label
        Dim ClassDescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassesDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SpaceshipDataSet = New SpaceshipDB.SpaceshipDataSet()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassesTableAdapter = New SpaceshipDB.SpaceshipDataSetTableAdapters.ClassesTableAdapter()
        Me.TableAdapterManager = New SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager()
        Me.ClassesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClassesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClassIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClassNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClassDescriptionTextBox = New System.Windows.Forms.TextBox()
        ClassIDLabel = New System.Windows.Forms.Label()
        ClassNameLabel = New System.Windows.Forms.Label()
        ClassDescriptionLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClassesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClassIDLabel
        '
        ClassIDLabel.AutoSize = True
        ClassIDLabel.Location = New System.Drawing.Point(30, 57)
        ClassIDLabel.Name = "ClassIDLabel"
        ClassIDLabel.Size = New System.Drawing.Size(35, 13)
        ClassIDLabel.TabIndex = 2
        ClassIDLabel.Text = "Class:"
        '
        'ClassNameLabel
        '
        ClassNameLabel.AutoSize = True
        ClassNameLabel.Location = New System.Drawing.Point(30, 83)
        ClassNameLabel.Name = "ClassNameLabel"
        ClassNameLabel.Size = New System.Drawing.Size(66, 13)
        ClassNameLabel.TabIndex = 4
        ClassNameLabel.Text = "Class Name:"
        '
        'ClassDescriptionLabel
        '
        ClassDescriptionLabel.AutoSize = True
        ClassDescriptionLabel.Location = New System.Drawing.Point(30, 109)
        ClassDescriptionLabel.Name = "ClassDescriptionLabel"
        ClassDescriptionLabel.Size = New System.Drawing.Size(91, 13)
        ClassDescriptionLabel.TabIndex = 6
        ClassDescriptionLabel.Text = "Class Description:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(134, 234)
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
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.SpaceshipDataSet
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassesTableAdapter = Me.ClassesTableAdapter
        Me.TableAdapterManager.ShipImagesTableAdapter = Nothing
        Me.TableAdapterManager.ShipsTableAdapter = Nothing
        Me.TableAdapterManager.ShowsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SpaceshipDB.SpaceshipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClassesBindingNavigator
        '
        Me.ClassesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClassesBindingNavigator.BindingSource = Me.ClassesBindingSource
        Me.ClassesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClassesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClassesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClassesBindingNavigatorSaveItem})
        Me.ClassesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClassesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClassesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClassesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClassesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClassesBindingNavigator.Name = "ClassesBindingNavigator"
        Me.ClassesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClassesBindingNavigator.Size = New System.Drawing.Size(292, 25)
        Me.ClassesBindingNavigator.TabIndex = 1
        Me.ClassesBindingNavigator.Text = "BindingNavigator1"
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
        'ClassesBindingNavigatorSaveItem
        '
        Me.ClassesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClassesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClassesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClassesBindingNavigatorSaveItem.Name = "ClassesBindingNavigatorSaveItem"
        Me.ClassesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClassesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClassIDTextBox
        '
        Me.ClassIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "ClassID", True))
        Me.ClassIDTextBox.Location = New System.Drawing.Point(127, 54)
        Me.ClassIDTextBox.Name = "ClassIDTextBox"
        Me.ClassIDTextBox.ReadOnly = True
        Me.ClassIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassIDTextBox.TabIndex = 3
        '
        'ClassNameTextBox
        '
        Me.ClassNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "ClassName", True))
        Me.ClassNameTextBox.Location = New System.Drawing.Point(127, 80)
        Me.ClassNameTextBox.Name = "ClassNameTextBox"
        Me.ClassNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassNameTextBox.TabIndex = 5
        '
        'ClassDescriptionTextBox
        '
        Me.ClassDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassesBindingSource, "ClassDescription", True))
        Me.ClassDescriptionTextBox.Location = New System.Drawing.Point(33, 125)
        Me.ClassDescriptionTextBox.Multiline = True
        Me.ClassDescriptionTextBox.Name = "ClassDescriptionTextBox"
        Me.ClassDescriptionTextBox.Size = New System.Drawing.Size(194, 92)
        Me.ClassDescriptionTextBox.TabIndex = 7
        '
        'ClassesDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(292, 275)
        Me.Controls.Add(ClassIDLabel)
        Me.Controls.Add(Me.ClassIDTextBox)
        Me.Controls.Add(ClassNameLabel)
        Me.Controls.Add(Me.ClassNameTextBox)
        Me.Controls.Add(ClassDescriptionLabel)
        Me.Controls.Add(Me.ClassDescriptionTextBox)
        Me.Controls.Add(Me.ClassesBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClassesDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ClassesDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SpaceshipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClassesBindingNavigator.ResumeLayout(False)
        Me.ClassesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents SpaceshipDataSet As SpaceshipDataSet
    Friend WithEvents ClassesBindingSource As BindingSource
    Friend WithEvents ClassesTableAdapter As SpaceshipDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents TableAdapterManager As SpaceshipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClassesBindingNavigator As BindingNavigator
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
    Friend WithEvents ClassesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClassIDTextBox As TextBox
    Friend WithEvents ClassNameTextBox As TextBox
    Friend WithEvents ClassDescriptionTextBox As TextBox
End Class
