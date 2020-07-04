<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewEmployee))
        Me.grpEmpData = New System.Windows.Forms.GroupBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnSaveNewRecord = New System.Windows.Forms.Button()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblEmployeeNumber = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.grpEmpData.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEmpData
        '
        Me.grpEmpData.Controls.Add(Me.btnHelp)
        Me.grpEmpData.Controls.Add(Me.btnSaveNewRecord)
        Me.grpEmpData.Controls.Add(Me.cboDepartment)
        Me.grpEmpData.Controls.Add(Me.txtEmailAddress)
        Me.grpEmpData.Controls.Add(Me.txtExtension)
        Me.grpEmpData.Controls.Add(Me.txtTelephone)
        Me.grpEmpData.Controls.Add(Me.txtEmployeeNumber)
        Me.grpEmpData.Controls.Add(Me.txtLastName)
        Me.grpEmpData.Controls.Add(Me.txtMiddleName)
        Me.grpEmpData.Controls.Add(Me.btnExit)
        Me.grpEmpData.Controls.Add(Me.btnClear)
        Me.grpEmpData.Controls.Add(Me.lblEmailAddress)
        Me.grpEmpData.Controls.Add(Me.lblExtension)
        Me.grpEmpData.Controls.Add(Me.lblTelephone)
        Me.grpEmpData.Controls.Add(Me.lblDepartment)
        Me.grpEmpData.Controls.Add(Me.lblEmployeeNumber)
        Me.grpEmpData.Controls.Add(Me.lblLastName)
        Me.grpEmpData.Controls.Add(Me.lblMiddleName)
        Me.grpEmpData.Controls.Add(Me.txtFirstName)
        Me.grpEmpData.Controls.Add(Me.lblFirstName)
        Me.grpEmpData.Location = New System.Drawing.Point(3, 12)
        Me.grpEmpData.Name = "grpEmpData"
        Me.grpEmpData.Size = New System.Drawing.Size(333, 304)
        Me.grpEmpData.TabIndex = 1
        Me.grpEmpData.TabStop = False
        Me.grpEmpData.Text = "New Employee Data"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(198, 267)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(55, 23)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.Text = "H&elp"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnSaveNewRecord
        '
        Me.btnSaveNewRecord.Location = New System.Drawing.Point(6, 267)
        Me.btnSaveNewRecord.Name = "btnSaveNewRecord"
        Me.btnSaveNewRecord.Size = New System.Drawing.Size(105, 23)
        Me.btnSaveNewRecord.TabIndex = 8
        Me.btnSaveNewRecord.Text = "Save Record"
        Me.btnSaveNewRecord.UseVisualStyleBackColor = True
        '
        'cboDepartment
        '
        Me.cboDepartment.AutoCompleteCustomSource.AddRange(New String() {"Accounting", "Administration", "Marketing", "MIS", "Sales"})
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"Accounting", "Administration", "Marketing", "MIS", "Sales"})
        Me.cboDepartment.Location = New System.Drawing.Point(126, 147)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(181, 21)
        Me.cboDepartment.TabIndex = 4
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(126, 226)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(181, 20)
        Me.txtEmailAddress.TabIndex = 7
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(126, 200)
        Me.txtExtension.MaxLength = 3
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(100, 20)
        Me.txtExtension.TabIndex = 6
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(126, 174)
        Me.txtTelephone.MaxLength = 10
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(181, 20)
        Me.txtTelephone.TabIndex = 5
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(126, 121)
        Me.txtEmployeeNumber.MaxLength = 5
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(181, 20)
        Me.txtEmployeeNumber.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(126, 95)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(181, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(126, 68)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(181, 20)
        Me.txtMiddleName.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(259, 267)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(117, 267)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(44, 229)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(76, 13)
        Me.lblEmailAddress.TabIndex = 8
        Me.lblEmailAddress.Text = "Email Address:"
        '
        'lblExtension
        '
        Me.lblExtension.AutoSize = True
        Me.lblExtension.Location = New System.Drawing.Point(64, 203)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(56, 13)
        Me.lblExtension.TabIndex = 7
        Me.lblExtension.Text = "Extension:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(59, 177)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 6
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(55, 150)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(65, 13)
        Me.lblDepartment.TabIndex = 5
        Me.lblDepartment.Text = "Department:"
        '
        'lblEmployeeNumber
        '
        Me.lblEmployeeNumber.AutoSize = True
        Me.lblEmployeeNumber.Location = New System.Drawing.Point(24, 124)
        Me.lblEmployeeNumber.Name = "lblEmployeeNumber"
        Me.lblEmployeeNumber.Size = New System.Drawing.Size(96, 13)
        Me.lblEmployeeNumber.TabIndex = 4
        Me.lblEmployeeNumber.Text = "Employee Number:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(59, 98)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name:"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(48, 71)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(72, 13)
        Me.lblMiddleName.TabIndex = 2
        Me.lblMiddleName.Text = "Middle Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(126, 42)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(181, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(60, 45)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'frmNewEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 323)
        Me.Controls.Add(Me.grpEmpData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewEmployee"
        Me.Text = "New Employee"
        Me.grpEmpData.ResumeLayout(False)
        Me.grpEmpData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpEmpData As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveNewRecord As System.Windows.Forms.Button
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtExtension As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblExtension As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeNumber As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
