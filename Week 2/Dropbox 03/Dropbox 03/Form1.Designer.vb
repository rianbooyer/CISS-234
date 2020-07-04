<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.txtMPG = New System.Windows.Forms.TextBox()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.btnCalculateMPG = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.staCalculations = New System.Windows.Forms.StatusStrip()
        Me.lblErrors = New System.Windows.Forms.ToolStripStatusLabel()
        Me.staCalculations.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(115, 50)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 20)
        Me.txtGallons.TabIndex = 0
        '
        'lblGallons
        '
        Me.lblGallons.Location = New System.Drawing.Point(12, 46)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(97, 31)
        Me.lblGallons.TabIndex = 1
        Me.lblGallons.Text = "Gallons of gas the car can hold:"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(115, 86)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 1
        '
        'lblMiles
        '
        Me.lblMiles.Location = New System.Drawing.Point(12, 77)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(100, 41)
        Me.lblMiles.TabIndex = 3
        Me.lblMiles.Text = "Number of miles it can be driven on a full tank:"
        '
        'txtMPG
        '
        Me.txtMPG.Location = New System.Drawing.Point(115, 126)
        Me.txtMPG.Name = "txtMPG"
        Me.txtMPG.ReadOnly = True
        Me.txtMPG.Size = New System.Drawing.Size(100, 20)
        Me.txtMPG.TabIndex = 2
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Location = New System.Drawing.Point(12, 129)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(83, 13)
        Me.lblMPG.TabIndex = 5
        Me.lblMPG.Text = "Miles per gallon:"
        '
        'btnCalculateMPG
        '
        Me.btnCalculateMPG.AutoSize = True
        Me.btnCalculateMPG.Location = New System.Drawing.Point(21, 181)
        Me.btnCalculateMPG.Name = "btnCalculateMPG"
        Me.btnCalculateMPG.Size = New System.Drawing.Size(88, 23)
        Me.btnCalculateMPG.TabIndex = 3
        Me.btnCalculateMPG.Text = "&Calculate MPG"
        Me.btnCalculateMPG.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(190, 182)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(109, 181)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Cle&ar"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'staCalculations
        '
        Me.staCalculations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblErrors})
        Me.staCalculations.Location = New System.Drawing.Point(0, 239)
        Me.staCalculations.Name = "staCalculations"
        Me.staCalculations.Size = New System.Drawing.Size(284, 22)
        Me.staCalculations.TabIndex = 10
        '
        'lblErrors
        '
        Me.lblErrors.Name = "lblErrors"
        Me.lblErrors.Size = New System.Drawing.Size(120, 17)
        Me.lblErrors.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.staCalculations)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculateMPG)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.txtMPG)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.txtGallons)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon Calculator"
        Me.staCalculations.ResumeLayout(False)
        Me.staCalculations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblMiles As System.Windows.Forms.Label
    Friend WithEvents txtMPG As System.Windows.Forms.TextBox
    Friend WithEvents lblMPG As System.Windows.Forms.Label
    Friend WithEvents btnCalculateMPG As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents staCalculations As System.Windows.Forms.StatusStrip
    Friend WithEvents lblErrors As System.Windows.Forms.ToolStripStatusLabel

End Class
