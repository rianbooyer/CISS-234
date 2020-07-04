<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJupiter
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
        Me.rtfJupiterInfo = New System.Windows.Forms.RichTextBox()
        Me.picJupiterImage = New System.Windows.Forms.PictureBox()
        CType(Me.picJupiterImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfJupiterInfo
        '
        Me.rtfJupiterInfo.AcceptsTab = True
        Me.rtfJupiterInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfJupiterInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfJupiterInfo.Location = New System.Drawing.Point(28, 323)
        Me.rtfJupiterInfo.Name = "rtfJupiterInfo"
        Me.rtfJupiterInfo.Size = New System.Drawing.Size(351, 71)
        Me.rtfJupiterInfo.TabIndex = 0
        Me.rtfJupiterInfo.Text = "Jupiter" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Type " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Jovian" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Average distance from the sun 5.2028 AU" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Mass " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "1.899 x" & _
    " 1027 kg" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Temperature at cloud tops " & Global.Microsoft.VisualBasic.ChrW(9) & "-110°C"
        '
        'picJupiterImage
        '
        Me.picJupiterImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picJupiterImage.Image = Global.Dropbox_7.My.Resources.Resources.imgJupiter
        Me.picJupiterImage.Location = New System.Drawing.Point(0, 0)
        Me.picJupiterImage.Name = "picJupiterImage"
        Me.picJupiterImage.Size = New System.Drawing.Size(391, 314)
        Me.picJupiterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picJupiterImage.TabIndex = 1
        Me.picJupiterImage.TabStop = False
        '
        'frmJupiter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 395)
        Me.Controls.Add(Me.rtfJupiterInfo)
        Me.Controls.Add(Me.picJupiterImage)
        Me.Name = "frmJupiter"
        Me.Text = "Planet Jupiter"
        CType(Me.picJupiterImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfJupiterInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents picJupiterImage As System.Windows.Forms.PictureBox
End Class
