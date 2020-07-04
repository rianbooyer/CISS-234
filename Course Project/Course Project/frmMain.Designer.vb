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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditNewEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSelectedRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSearchRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdMainFormOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdMainFormSave = New System.Windows.Forms.SaveFileDialog()
        Me.lvwEmployeeDisplay = New System.Windows.Forms.ListView()
        Me.lstvEmployeeNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvMiddleName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvTelephone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrntDlgMain = New System.Windows.Forms.PrintDialog()
        Me.prtPrvDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(806, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFilePrint, Me.mnuFilePrintPreview, Me.mnuFileSeparator1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileOpen.Text = "&Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Enabled = False
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Enabled = False
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSaveAs.Text = "S&ave As"
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Enabled = False
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Size = New System.Drawing.Size(152, 22)
        Me.mnuFilePrint.Text = "&Print"
        '
        'mnuFilePrintPreview
        '
        Me.mnuFilePrintPreview.Enabled = False
        Me.mnuFilePrintPreview.Name = "mnuFilePrintPreview"
        Me.mnuFilePrintPreview.Size = New System.Drawing.Size(152, 22)
        Me.mnuFilePrintPreview.Text = "Print Pr&eview"
        '
        'mnuFileSeparator1
        '
        Me.mnuFileSeparator1.Name = "mnuFileSeparator1"
        Me.mnuFileSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditNewEmployee, Me.mnuEditSelectedRecord, Me.mnuEditSearchRecords})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'mnuEditNewEmployee
        '
        Me.mnuEditNewEmployee.Enabled = False
        Me.mnuEditNewEmployee.Name = "mnuEditNewEmployee"
        Me.mnuEditNewEmployee.Size = New System.Drawing.Size(158, 22)
        Me.mnuEditNewEmployee.Text = "New Employee"
        '
        'mnuEditSelectedRecord
        '
        Me.mnuEditSelectedRecord.Enabled = False
        Me.mnuEditSelectedRecord.Name = "mnuEditSelectedRecord"
        Me.mnuEditSelectedRecord.Size = New System.Drawing.Size(158, 22)
        Me.mnuEditSelectedRecord.Text = "Selected Record"
        '
        'mnuEditSearchRecords
        '
        Me.mnuEditSearchRecords.Enabled = False
        Me.mnuEditSearchRecords.Name = "mnuEditSearchRecords"
        Me.mnuEditSearchRecords.Size = New System.Drawing.Size(158, 22)
        Me.mnuEditSearchRecords.Text = "Search Records"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpHelp, Me.mnuHelpAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mnuHelpHelp
        '
        Me.mnuHelpHelp.Name = "mnuHelpHelp"
        Me.mnuHelpHelp.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'ofdMainFormOpen
        '
        Me.ofdMainFormOpen.Filter = "Text Files (*.txt)|*.txt|AllFiles *.*|*.*"
        Me.ofdMainFormOpen.Title = "Open File"
        '
        'sfdMainFormSave
        '
        Me.sfdMainFormSave.Filter = "Text Files (*.txt)|*.txt|AllFiles *.*|*.*"
        Me.sfdMainFormSave.Title = "Save File "
        '
        'lvwEmployeeDisplay
        '
        Me.lvwEmployeeDisplay.AllowColumnReorder = True
        Me.lvwEmployeeDisplay.CheckBoxes = True
        Me.lvwEmployeeDisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstvEmployeeNumber, Me.lstvFirstName, Me.lstvMiddleName, Me.lstvLastName, Me.lstvDepartment, Me.lstvTelephone, Me.lstvExtension, Me.lstvEmail})
        Me.lvwEmployeeDisplay.Enabled = False
        Me.lvwEmployeeDisplay.GridLines = True
        Me.lvwEmployeeDisplay.Location = New System.Drawing.Point(0, 250)
        Me.lvwEmployeeDisplay.Name = "lvwEmployeeDisplay"
        Me.lvwEmployeeDisplay.Size = New System.Drawing.Size(806, 338)
        Me.lvwEmployeeDisplay.TabIndex = 1
        Me.lvwEmployeeDisplay.UseCompatibleStateImageBehavior = False
        Me.lvwEmployeeDisplay.View = System.Windows.Forms.View.Details
        '
        'lstvEmployeeNumber
        '
        Me.lstvEmployeeNumber.Text = "Employee Number"
        Me.lstvEmployeeNumber.Width = 120
        '
        'lstvFirstName
        '
        Me.lstvFirstName.Text = "First Name"
        Me.lstvFirstName.Width = 80
        '
        'lstvMiddleName
        '
        Me.lstvMiddleName.Text = "Middle Name"
        Me.lstvMiddleName.Width = 80
        '
        'lstvLastName
        '
        Me.lstvLastName.Text = "Last Name"
        Me.lstvLastName.Width = 80
        '
        'lstvDepartment
        '
        Me.lstvDepartment.Text = "Department"
        Me.lstvDepartment.Width = 80
        '
        'lstvTelephone
        '
        Me.lstvTelephone.Text = "Phone Number"
        Me.lstvTelephone.Width = 80
        '
        'lstvExtension
        '
        Me.lstvExtension.Text = "Extension"
        Me.lstvExtension.Width = 58
        '
        'lstvEmail
        '
        Me.lstvEmail.Text = "Email Address"
        Me.lstvEmail.Width = 230
        '
        'PrntDlgMain
        '
        Me.PrntDlgMain.AllowSelection = True
        Me.PrntDlgMain.AllowSomePages = True
        Me.PrntDlgMain.ShowHelp = True
        Me.PrntDlgMain.UseEXDialog = True
        '
        'prtPrvDialog
        '
        Me.prtPrvDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.prtPrvDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.prtPrvDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.prtPrvDialog.Enabled = True
        Me.prtPrvDialog.Icon = CType(resources.GetObject("prtPrvDialog.Icon"), System.Drawing.Icon)
        Me.prtPrvDialog.Name = "prtPrvDialog"
        Me.prtPrvDialog.UseAntiAlias = True
        Me.prtPrvDialog.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Course_Project.My.Resources.Resources.A1Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(319, 29)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(338, 72)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Human Resources System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Employee Directory"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 600)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lvwEmployeeDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "A-1 HS "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdMainFormOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdMainFormSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFilePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFilePrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvwEmployeeDisplay As System.Windows.Forms.ListView
    Friend WithEvents lstvEmployeeNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvFirstName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvMiddleName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvLastName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvTelephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvExtension As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvEmail As System.Windows.Forms.ColumnHeader

    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrntDlgMain As System.Windows.Forms.PrintDialog
    Friend WithEvents prtPrvDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditNewEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditSelectedRecord As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditSearchRecords As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents mnuHelpHelp As System.Windows.Forms.ToolStripMenuItem

End Class
