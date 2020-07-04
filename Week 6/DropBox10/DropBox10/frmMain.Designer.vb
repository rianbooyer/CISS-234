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
        Me.lstBoxMotorInfo = New System.Windows.Forms.ListBox()
        Me.cmsMotorOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.csmAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMotorOptions.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBoxMotorInfo
        '
        Me.lstBoxMotorInfo.FormattingEnabled = True
        Me.lstBoxMotorInfo.ItemHeight = 16
        Me.lstBoxMotorInfo.Location = New System.Drawing.Point(12, 46)
        Me.lstBoxMotorInfo.Name = "lstBoxMotorInfo"
        Me.lstBoxMotorInfo.Size = New System.Drawing.Size(444, 132)
        Me.lstBoxMotorInfo.TabIndex = 0
        '
        'cmsMotorOptions
        '
        Me.cmsMotorOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.csmAdd})
        Me.cmsMotorOptions.Name = "ContextMenuStrip1"
        Me.cmsMotorOptions.Size = New System.Drawing.Size(107, 28)
        '
        'csmAdd
        '
        Me.csmAdd.Name = "csmAdd"
        Me.csmAdd.Size = New System.Drawing.Size(106, 24)
        Me.csmAdd.Text = "Add"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(154, 201)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(235, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(468, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileAdd, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileAdd
        '
        Me.mnuFileAdd.Name = "mnuFileAdd"
        Me.mnuFileAdd.Size = New System.Drawing.Size(106, 24)
        Me.mnuFileAdd.Text = "&Add"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(106, 24)
        Me.mnuFileExit.Text = "E&xit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 244)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lstBoxMotorInfo)
        Me.Name = "frmMain"
        Me.Text = "Motor Class"
        Me.cmsMotorOptions.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBoxMotorInfo As System.Windows.Forms.ListBox
    Friend WithEvents cmsMotorOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents csmAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem

End Class
