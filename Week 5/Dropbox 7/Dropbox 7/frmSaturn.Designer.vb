<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaturn
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
        Me.rtfSaturnInfo = New System.Windows.Forms.RichTextBox()
        Me.picSaturnImage = New System.Windows.Forms.PictureBox()
        CType(Me.picSaturnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfSaturnInfo
        '
        Me.rtfSaturnInfo.AcceptsTab = True
        Me.rtfSaturnInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfSaturnInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfSaturnInfo.Location = New System.Drawing.Point(28, 323)
        Me.rtfSaturnInfo.Name = "rtfSaturnInfo"
        Me.rtfSaturnInfo.Size = New System.Drawing.Size(351, 71)
        Me.rtfSaturnInfo.TabIndex = 0
        Me.rtfSaturnInfo.Text = "Saturn" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Type " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "  Jovian" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Average distance from the sun  9.5388 AU" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Mass " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "  5.6" & _
    "9 x 1026 kg" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Temperature at cloud tops " & Global.Microsoft.VisualBasic.ChrW(9) & "  -180°C"
        '
        'picSaturnImage
        '
        Me.picSaturnImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picSaturnImage.Image = Global.Dropbox_7.My.Resources.Resources.imgSaturn
        Me.picSaturnImage.Location = New System.Drawing.Point(0, 0)
        Me.picSaturnImage.Name = "picSaturnImage"
        Me.picSaturnImage.Size = New System.Drawing.Size(391, 314)
        Me.picSaturnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSaturnImage.TabIndex = 1
        Me.picSaturnImage.TabStop = False
        '
        'frmSaturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 395)
        Me.Controls.Add(Me.rtfSaturnInfo)
        Me.Controls.Add(Me.picSaturnImage)
        Me.Name = "frmSaturn"
        Me.Text = "Planet Saturn"
        CType(Me.picSaturnImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfSaturnInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents picSaturnImage As System.Windows.Forms.PictureBox
End Class
