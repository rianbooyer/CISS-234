<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuStripMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.frmFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlanetsMercury = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EarthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JupiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UranusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeptuneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuStripMain
        '
        Me.mnuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlanetsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuStripMain.Name = "mnuStripMain"
        Me.mnuStripMain.Size = New System.Drawing.Size(466, 24)
        Me.mnuStripMain.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.frmFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'frmFileExit
        '
        Me.frmFileExit.Name = "frmFileExit"
        Me.frmFileExit.Size = New System.Drawing.Size(152, 22)
        Me.frmFileExit.Text = "E&xit"
        '
        'PlanetsToolStripMenuItem
        '
        Me.PlanetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlanetsMercury, Me.VenusToolStripMenuItem, Me.EarthToolStripMenuItem, Me.MarsToolStripMenuItem, Me.JupiterToolStripMenuItem, Me.SaturnToolStripMenuItem, Me.UranusToolStripMenuItem, Me.NeptuneToolStripMenuItem, Me.PlutoToolStripMenuItem})
        Me.PlanetsToolStripMenuItem.Name = "PlanetsToolStripMenuItem"
        Me.PlanetsToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.PlanetsToolStripMenuItem.Text = "&Planets"
        '
        'mnuPlanetsMercury
        '
        Me.mnuPlanetsMercury.Name = "mnuPlanetsMercury"
        Me.mnuPlanetsMercury.Size = New System.Drawing.Size(152, 22)
        Me.mnuPlanetsMercury.Text = "M&ercury"
        '
        'VenusToolStripMenuItem
        '
        Me.VenusToolStripMenuItem.Name = "VenusToolStripMenuItem"
        Me.VenusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VenusToolStripMenuItem.Text = "&Venus"
        '
        'EarthToolStripMenuItem
        '
        Me.EarthToolStripMenuItem.Name = "EarthToolStripMenuItem"
        Me.EarthToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EarthToolStripMenuItem.Text = "E&arth"
        '
        'MarsToolStripMenuItem
        '
        Me.MarsToolStripMenuItem.Name = "MarsToolStripMenuItem"
        Me.MarsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MarsToolStripMenuItem.Text = "Ma&rs"
        '
        'JupiterToolStripMenuItem
        '
        Me.JupiterToolStripMenuItem.Name = "JupiterToolStripMenuItem"
        Me.JupiterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JupiterToolStripMenuItem.Text = "Jup&iter"
        '
        'SaturnToolStripMenuItem
        '
        Me.SaturnToolStripMenuItem.Name = "SaturnToolStripMenuItem"
        Me.SaturnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaturnToolStripMenuItem.Text = "Sa&turn"
        '
        'UranusToolStripMenuItem
        '
        Me.UranusToolStripMenuItem.Name = "UranusToolStripMenuItem"
        Me.UranusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UranusToolStripMenuItem.Text = "&Uranus"
        '
        'NeptuneToolStripMenuItem
        '
        Me.NeptuneToolStripMenuItem.Name = "NeptuneToolStripMenuItem"
        Me.NeptuneToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NeptuneToolStripMenuItem.Text = "Neptu&ne"
        '
        'PlutoToolStripMenuItem
        '
        Me.PlutoToolStripMenuItem.Name = "PlutoToolStripMenuItem"
        Me.PlutoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PlutoToolStripMenuItem.Text = "P&luto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Dropbox_7.My.Resources.Resources.imgPlanets
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(466, 400)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 424)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mnuStripMain)
        Me.MainMenuStrip = Me.mnuStripMain
        Me.Name = "frmMain"
        Me.Text = "Astronomy Helper"
        Me.mnuStripMain.ResumeLayout(False)
        Me.mnuStripMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlanetsMercury As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VenusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EarthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JupiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UranusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeptuneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
