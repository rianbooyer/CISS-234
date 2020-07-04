<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMotor
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
        Me.lblMotorId = New System.Windows.Forms.Label()
        Me.grpAddMotor = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtVoltage = New System.Windows.Forms.TextBox()
        Me.txtRPM = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtMotorID = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.lblRPM = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpAddMotor.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMotorId
        '
        Me.lblMotorId.AutoSize = True
        Me.lblMotorId.Location = New System.Drawing.Point(58, 34)
        Me.lblMotorId.Name = "lblMotorId"
        Me.lblMotorId.Size = New System.Drawing.Size(63, 17)
        Me.lblMotorId.TabIndex = 0
        Me.lblMotorId.Text = "Motor Id:"
        '
        'grpAddMotor
        '
        Me.grpAddMotor.Controls.Add(Me.cmbStatus)
        Me.grpAddMotor.Controls.Add(Me.txtVoltage)
        Me.grpAddMotor.Controls.Add(Me.txtRPM)
        Me.grpAddMotor.Controls.Add(Me.txtDescription)
        Me.grpAddMotor.Controls.Add(Me.txtMotorID)
        Me.grpAddMotor.Controls.Add(Me.lblStatus)
        Me.grpAddMotor.Controls.Add(Me.lblVoltage)
        Me.grpAddMotor.Controls.Add(Me.lblRPM)
        Me.grpAddMotor.Controls.Add(Me.lblDescription)
        Me.grpAddMotor.Controls.Add(Me.lblMotorId)
        Me.grpAddMotor.Location = New System.Drawing.Point(12, 12)
        Me.grpAddMotor.Name = "grpAddMotor"
        Me.grpAddMotor.Size = New System.Drawing.Size(309, 227)
        Me.grpAddMotor.TabIndex = 0
        Me.grpAddMotor.TabStop = False
        Me.grpAddMotor.Text = "Enter Motor Information"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteCustomSource.AddRange(New String() {"On"})
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"On", "Off", "Mnt", "NA "})
        Me.cmbStatus.Location = New System.Drawing.Point(127, 181)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(100, 24)
        Me.cmbStatus.TabIndex = 4
        '
        'txtVoltage
        '
        Me.txtVoltage.Location = New System.Drawing.Point(127, 151)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.Size = New System.Drawing.Size(100, 22)
        Me.txtVoltage.TabIndex = 3
        '
        'txtRPM
        '
        Me.txtRPM.Location = New System.Drawing.Point(127, 123)
        Me.txtRPM.Name = "txtRPM"
        Me.txtRPM.Size = New System.Drawing.Size(100, 22)
        Me.txtRPM.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(127, 60)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(176, 57)
        Me.txtDescription.TabIndex = 1
        '
        'txtMotorID
        '
        Me.txtMotorID.Location = New System.Drawing.Point(127, 31)
        Me.txtMotorID.MaxLength = 5
        Me.txtMotorID.Name = "txtMotorID"
        Me.txtMotorID.Size = New System.Drawing.Size(100, 22)
        Me.txtMotorID.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(69, 181)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(52, 17)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status:"
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Location = New System.Drawing.Point(61, 151)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(60, 17)
        Me.lblVoltage.TabIndex = 3
        Me.lblVoltage.Text = "Voltage:"
        '
        'lblRPM
        '
        Me.lblRPM.AutoSize = True
        Me.lblRPM.Location = New System.Drawing.Point(7, 126)
        Me.lblRPM.Name = "lblRPM"
        Me.lblRPM.Size = New System.Drawing.Size(114, 17)
        Me.lblRPM.TabIndex = 2
        Me.lblRPM.Text = "Maximum RPM's:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(38, 60)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 17)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Description:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(42, 264)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(124, 264)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(206, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAddMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 366)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpAddMotor)
        Me.Name = "frmAddMotor"
        Me.Text = "Add Motor"
        Me.grpAddMotor.ResumeLayout(False)
        Me.grpAddMotor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMotorId As System.Windows.Forms.Label
    Friend WithEvents grpAddMotor As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblRPM As System.Windows.Forms.Label
    Friend WithEvents lblVoltage As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtRPM As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtMotorID As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
