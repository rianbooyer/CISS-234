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
        Me.lstViewMain = New System.Windows.Forms.ListView()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblExplanation = New System.Windows.Forms.Label()
        Me.lblFileBox = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstViewMain
        '
        Me.lstViewMain.Location = New System.Drawing.Point(26, 91)
        Me.lstViewMain.Name = "lstViewMain"
        Me.lstViewMain.Size = New System.Drawing.Size(515, 327)
        Me.lstViewMain.TabIndex = 0
        Me.lstViewMain.UseCompatibleStateImageBehavior = False
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(92, 424)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(156, 40)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "&Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(254, 424)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(84, 40)
        Me.btnWrite.TabIndex = 2
        Me.btnWrite.Text = "&Write File"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(344, 424)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblExplanation
        '
        Me.lblExplanation.AutoSize = True
        Me.lblExplanation.Location = New System.Drawing.Point(11, 490)
        Me.lblExplanation.Name = "lblExplanation"
        Me.lblExplanation.Size = New System.Drawing.Size(544, 34)
        Me.lblExplanation.TabIndex = 4
        Me.lblExplanation.Text = "This program will generate 100 random numbers when you click 'Generate Numbers'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Click Write File to write the numbers to the file you specify or default file " & _
    "myFile.txt"
        '
        'lblFileBox
        '
        Me.lblFileBox.AutoSize = True
        Me.lblFileBox.Location = New System.Drawing.Point(36, 25)
        Me.lblFileBox.Name = "lblFileBox"
        Me.lblFileBox.Size = New System.Drawing.Size(75, 17)
        Me.lblFileBox.TabIndex = 5
        Me.lblFileBox.Text = "File Name:"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(118, 25)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(337, 22)
        Me.txtFileName.TabIndex = 6
        Me.txtFileName.Text = "myFile.txt"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 598)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblFileBox)
        Me.Controls.Add(Me.lblExplanation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lstViewMain)
        Me.Name = "frmMain"
        Me.Text = "Random Number Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstViewMain As System.Windows.Forms.ListView
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblExplanation As System.Windows.Forms.Label
    Friend WithEvents lblFileBox As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox

End Class
