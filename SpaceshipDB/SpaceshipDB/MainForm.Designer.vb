<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.msbShips = New System.Windows.Forms.ToolStripButton()
        Me.msbClass = New System.Windows.Forms.ToolStripButton()
        Me.msbImages = New System.Windows.Forms.ToolStripButton()
        Me.msbShows = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msbShips, Me.msbClass, Me.msbImages, Me.msbShows})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(616, 26)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'msbShips
        '
        Me.msbShips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.msbShips.Image = CType(resources.GetObject("msbShips.Image"), System.Drawing.Image)
        Me.msbShips.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.msbShips.Name = "msbShips"
        Me.msbShips.Size = New System.Drawing.Size(39, 19)
        Me.msbShips.Text = "Ships"
        '
        'msbClass
        '
        Me.msbClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.msbClass.Image = CType(resources.GetObject("msbClass.Image"), System.Drawing.Image)
        Me.msbClass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.msbClass.Name = "msbClass"
        Me.msbClass.Size = New System.Drawing.Size(75, 19)
        Me.msbClass.Text = "Ship Classes"
        '
        'msbImages
        '
        Me.msbImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.msbImages.Image = CType(resources.GetObject("msbImages.Image"), System.Drawing.Image)
        Me.msbImages.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.msbImages.Name = "msbImages"
        Me.msbImages.Size = New System.Drawing.Size(75, 19)
        Me.msbImages.Text = "Ship Images"
        '
        'msbShows
        '
        Me.msbShows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.msbShows.Image = CType(resources.GetObject("msbShows.Image"), System.Drawing.Image)
        Me.msbShows.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.msbShows.Name = "msbShows"
        Me.msbShows.Size = New System.Drawing.Size(45, 19)
        Me.msbShows.Text = "Shows"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 520)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents msbShips As ToolStripButton
    Friend WithEvents msbClass As ToolStripButton
    Friend WithEvents msbImages As ToolStripButton
    Friend WithEvents msbShows As ToolStripButton
End Class
