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
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.grpBoxMain = New System.Windows.Forms.GroupBox()
        Me.btnMainClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtNum4 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum0 = New System.Windows.Forms.TextBox()
        Me.chkCheat = New System.Windows.Forms.CheckBox()
        Me.grpBoxMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(39, 184)
        Me.lblTemp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(126, 13)
        Me.lblTemp.TabIndex = 0
        Me.lblTemp.Text = "Numbers will appear here"
        Me.lblTemp.Visible = False
        '
        'grpBoxMain
        '
        Me.grpBoxMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpBoxMain.Controls.Add(Me.btnMainClear)
        Me.grpBoxMain.Controls.Add(Me.btnExit)
        Me.grpBoxMain.Controls.Add(Me.btnCheck)
        Me.grpBoxMain.Controls.Add(Me.txtNum4)
        Me.grpBoxMain.Controls.Add(Me.txtNum3)
        Me.grpBoxMain.Controls.Add(Me.txtNum2)
        Me.grpBoxMain.Controls.Add(Me.txtNum1)
        Me.grpBoxMain.Controls.Add(Me.txtNum0)
        Me.grpBoxMain.Location = New System.Drawing.Point(7, 10)
        Me.grpBoxMain.Margin = New System.Windows.Forms.Padding(2)
        Me.grpBoxMain.MinimumSize = New System.Drawing.Size(236, 124)
        Me.grpBoxMain.Name = "grpBoxMain"
        Me.grpBoxMain.Padding = New System.Windows.Forms.Padding(2)
        Me.grpBoxMain.Size = New System.Drawing.Size(236, 124)
        Me.grpBoxMain.TabIndex = 8
        Me.grpBoxMain.TabStop = False
        Me.grpBoxMain.Text = "Enter Your Numbers"
        '
        'btnMainClear
        '
        Me.btnMainClear.Location = New System.Drawing.Point(75, 85)
        Me.btnMainClear.Name = "btnMainClear"
        Me.btnMainClear.Size = New System.Drawing.Size(55, 19)
        Me.btnMainClear.TabIndex = 15
        Me.btnMainClear.Text = "Clear"
        Me.btnMainClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(135, 85)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 19)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(16, 85)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(56, 19)
        Me.btnCheck.TabIndex = 13
        Me.btnCheck.Text = "C&heck"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtNum4
        '
        Me.txtNum4.Location = New System.Drawing.Point(136, 41)
        Me.txtNum4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum4.MaxLength = 1
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(17, 20)
        Me.txtNum4.TabIndex = 12
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(116, 41)
        Me.txtNum3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum3.MaxLength = 1
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(17, 20)
        Me.txtNum3.TabIndex = 11
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(95, 41)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum2.MaxLength = 1
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(17, 20)
        Me.txtNum2.TabIndex = 10
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(75, 41)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum1.MaxLength = 1
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(17, 20)
        Me.txtNum1.TabIndex = 9
        '
        'txtNum0
        '
        Me.txtNum0.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum0.Location = New System.Drawing.Point(55, 41)
        Me.txtNum0.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum0.MaxLength = 1
        Me.txtNum0.Name = "txtNum0"
        Me.txtNum0.Size = New System.Drawing.Size(17, 20)
        Me.txtNum0.TabIndex = 8
        '
        'chkCheat
        '
        Me.chkCheat.AutoSize = True
        Me.chkCheat.Location = New System.Drawing.Point(32, 149)
        Me.chkCheat.Name = "chkCheat"
        Me.chkCheat.Size = New System.Drawing.Size(88, 17)
        Me.chkCheat.TabIndex = 9
        Me.chkCheat.Text = "Let's Cheat :)"
        Me.chkCheat.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(250, 212)
        Me.Controls.Add(Me.chkCheat)
        Me.Controls.Add(Me.grpBoxMain)
        Me.Controls.Add(Me.lblTemp)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(266, 251)
        Me.Name = "frmMain"
        Me.Text = "Lottery Application"
        Me.grpBoxMain.ResumeLayout(False)
        Me.grpBoxMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents grpBoxMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtNum4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum0 As System.Windows.Forms.TextBox
    Friend WithEvents btnMainClear As System.Windows.Forms.Button
    Friend WithEvents chkCheat As System.Windows.Forms.CheckBox

End Class
