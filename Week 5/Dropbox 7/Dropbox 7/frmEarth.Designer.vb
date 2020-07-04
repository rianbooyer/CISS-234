<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEarth
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
        Me.rtfEarthInfo = New System.Windows.Forms.RichTextBox()
        Me.picEarthImage = New System.Windows.Forms.PictureBox()
        CType(Me.picEarthImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfEarthInfo
        '
        Me.rtfEarthInfo.AcceptsTab = True
        Me.rtfEarthInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfEarthInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfEarthInfo.Location = New System.Drawing.Point(28, 323)
        Me.rtfEarthInfo.Name = "rtfEarthInfo"
        Me.rtfEarthInfo.Size = New System.Drawing.Size(351, 71)
        Me.rtfEarthInfo.TabIndex = 0
        Me.rtfEarthInfo.Text = "Earth" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Type " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Terrestrial" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Average distance from the sun " & Global.Microsoft.VisualBasic.ChrW(9) & "1 AU" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Mass " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "5.967 " & _
    "_ 1024 kg" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Surface temperature " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "-50°C to 50°C"
        '
        'picEarthImage
        '
        Me.picEarthImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picEarthImage.Image = Global.Dropbox_7.My.Resources.Resources.imgEarth
        Me.picEarthImage.Location = New System.Drawing.Point(0, 0)
        Me.picEarthImage.Name = "picEarthImage"
        Me.picEarthImage.Size = New System.Drawing.Size(391, 314)
        Me.picEarthImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEarthImage.TabIndex = 1
        Me.picEarthImage.TabStop = False
        '
        'frmEarth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 395)
        Me.Controls.Add(Me.rtfEarthInfo)
        Me.Controls.Add(Me.picEarthImage)
        Me.Name = "frmEarth"
        Me.Text = "Planet Earth"
        CType(Me.picEarthImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfEarthInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents picEarthImage As System.Windows.Forms.PictureBox
End Class
