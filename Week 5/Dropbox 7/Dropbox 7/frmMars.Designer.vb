<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMars
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
        Me.rtfMarsInfo = New System.Windows.Forms.RichTextBox()
        Me.picMarsImage = New System.Windows.Forms.PictureBox()
        CType(Me.picMarsImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfMarsInfo
        '
        Me.rtfMarsInfo.AcceptsTab = True
        Me.rtfMarsInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfMarsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfMarsInfo.Location = New System.Drawing.Point(28, 323)
        Me.rtfMarsInfo.Name = "rtfMarsInfo"
        Me.rtfMarsInfo.Size = New System.Drawing.Size(351, 71)
        Me.rtfMarsInfo.TabIndex = 0
        Me.rtfMarsInfo.Text = "Mars" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Type " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & " Terrestrial" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Average distance from the sun 1.5237 AU" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Mass " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & " 0.6" & _
    "424 x 1024 kg" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Surface temperature " & Global.Microsoft.VisualBasic.ChrW(9) & "-140°C to 20°C"
        '
        'picMarsImage
        '
        Me.picMarsImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picMarsImage.Image = Global.Dropbox_7.My.Resources.Resources.imgMars
        Me.picMarsImage.Location = New System.Drawing.Point(0, 0)
        Me.picMarsImage.Name = "picMarsImage"
        Me.picMarsImage.Size = New System.Drawing.Size(391, 314)
        Me.picMarsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMarsImage.TabIndex = 1
        Me.picMarsImage.TabStop = False
        '
        'frmMars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 395)
        Me.Controls.Add(Me.rtfMarsInfo)
        Me.Controls.Add(Me.picMarsImage)
        Me.Name = "frmMars"
        Me.Text = "Planet Mars"
        CType(Me.picMarsImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfMarsInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents picMarsImage As System.Windows.Forms.PictureBox
End Class
