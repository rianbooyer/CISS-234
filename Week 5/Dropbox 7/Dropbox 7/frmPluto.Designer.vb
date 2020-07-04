<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPluto
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
        Me.rtfPlutoInfo = New System.Windows.Forms.RichTextBox()
        Me.picPlutoImage = New System.Windows.Forms.PictureBox()
        CType(Me.picPlutoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfPlutoInfo
        '
        Me.rtfPlutoInfo.AcceptsTab = True
        Me.rtfPlutoInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfPlutoInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfPlutoInfo.Location = New System.Drawing.Point(28, 323)
        Me.rtfPlutoInfo.Name = "rtfPlutoInfo"
        Me.rtfPlutoInfo.Size = New System.Drawing.Size(351, 71)
        Me.rtfPlutoInfo.TabIndex = 0
        Me.rtfPlutoInfo.Text = "Pluto" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Type" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & " Low density" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Average distance from the sun 39.44 AU" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Mass " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & " 1.2 " & _
    "x 1022 kg" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Surface temperature " & Global.Microsoft.VisualBasic.ChrW(9) & " -230°C"
        '
        'picPlutoImage
        '
        Me.picPlutoImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picPlutoImage.Image = Global.Dropbox_7.My.Resources.Resources.imgPluto
        Me.picPlutoImage.Location = New System.Drawing.Point(0, 0)
        Me.picPlutoImage.Name = "picPlutoImage"
        Me.picPlutoImage.Size = New System.Drawing.Size(391, 314)
        Me.picPlutoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlutoImage.TabIndex = 1
        Me.picPlutoImage.TabStop = False
        '
        'frmPluto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 395)
        Me.Controls.Add(Me.rtfPlutoInfo)
        Me.Controls.Add(Me.picPlutoImage)
        Me.Name = "frmPluto"
        Me.Text = "Planet Pluto"
        CType(Me.picPlutoImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfPlutoInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents picPlutoImage As System.Windows.Forms.PictureBox
End Class
