<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.grpSearchBy = New System.Windows.Forms.GroupBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.txtEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.rdbOther = New System.Windows.Forms.RadioButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rdbEmployeeNumber = New System.Windows.Forms.RadioButton()
        Me.lvwEmployeeDisplay = New System.Windows.Forms.ListView()
        Me.lstvEmployeeNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvMiddleName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvTelephone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpSearchBy.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSearchBy
        '
        Me.grpSearchBy.Controls.Add(Me.btnHelp)
        Me.grpSearchBy.Controls.Add(Me.txtEmployeeNumber)
        Me.grpSearchBy.Controls.Add(Me.btnExit)
        Me.grpSearchBy.Controls.Add(Me.txtOther)
        Me.grpSearchBy.Controls.Add(Me.btnClear)
        Me.grpSearchBy.Controls.Add(Me.rdbOther)
        Me.grpSearchBy.Controls.Add(Me.btnSearch)
        Me.grpSearchBy.Controls.Add(Me.rdbEmployeeNumber)
        Me.grpSearchBy.Location = New System.Drawing.Point(12, 12)
        Me.grpSearchBy.Name = "grpSearchBy"
        Me.grpSearchBy.Size = New System.Drawing.Size(803, 112)
        Me.grpSearchBy.TabIndex = 1
        Me.grpSearchBy.TabStop = False
        Me.grpSearchBy.Text = "Search By"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(393, 83)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.Text = "H&elp"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(165, 31)
        Me.txtEmployeeNumber.MaxLength = 5
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(177, 20)
        Me.txtEmployeeNumber.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(474, 83)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtOther
        '
        Me.txtOther.Enabled = False
        Me.txtOther.Location = New System.Drawing.Point(541, 32)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(177, 20)
        Me.txtOther.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(311, 83)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'rdbOther
        '
        Me.rdbOther.AutoSize = True
        Me.rdbOther.Location = New System.Drawing.Point(424, 32)
        Me.rdbOther.Name = "rdbOther"
        Me.rdbOther.Size = New System.Drawing.Size(89, 17)
        Me.rdbOther.TabIndex = 1
        Me.rdbOther.Text = "Other Criteria:"
        Me.rdbOther.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(230, 83)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rdbEmployeeNumber
        '
        Me.rdbEmployeeNumber.AutoSize = True
        Me.rdbEmployeeNumber.Checked = True
        Me.rdbEmployeeNumber.Location = New System.Drawing.Point(48, 32)
        Me.rdbEmployeeNumber.Name = "rdbEmployeeNumber"
        Me.rdbEmployeeNumber.Size = New System.Drawing.Size(114, 17)
        Me.rdbEmployeeNumber.TabIndex = 0
        Me.rdbEmployeeNumber.TabStop = True
        Me.rdbEmployeeNumber.Text = "Employee Number:"
        Me.rdbEmployeeNumber.UseVisualStyleBackColor = True
        '
        'lvwEmployeeDisplay
        '
        Me.lvwEmployeeDisplay.AllowColumnReorder = True
        Me.lvwEmployeeDisplay.CheckBoxes = True
        Me.lvwEmployeeDisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstvEmployeeNumber, Me.lstvFirstName, Me.lstvMiddleName, Me.lstvLastName, Me.lstvDepartment, Me.lstvTelephone, Me.lstvExtension, Me.lstvEmail})
        Me.lvwEmployeeDisplay.FullRowSelect = True
        Me.lvwEmployeeDisplay.GridLines = True
        Me.lvwEmployeeDisplay.Location = New System.Drawing.Point(3, 130)
        Me.lvwEmployeeDisplay.MultiSelect = False
        Me.lvwEmployeeDisplay.Name = "lvwEmployeeDisplay"
        Me.lvwEmployeeDisplay.Size = New System.Drawing.Size(812, 171)
        Me.lvwEmployeeDisplay.TabIndex = 5
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
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 311)
        Me.Controls.Add(Me.lvwEmployeeDisplay)
        Me.Controls.Add(Me.grpSearchBy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.Text = "Employee Search"
        Me.grpSearchBy.ResumeLayout(False)
        Me.grpSearchBy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSearchBy As System.Windows.Forms.GroupBox
    Friend WithEvents rdbOther As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEmployeeNumber As System.Windows.Forms.RadioButton
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtEmployeeNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents lvwEmployeeDisplay As System.Windows.Forms.ListView
    Friend WithEvents lstvEmployeeNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvFirstName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvMiddleName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvLastName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvDepartment As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvTelephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvExtension As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
