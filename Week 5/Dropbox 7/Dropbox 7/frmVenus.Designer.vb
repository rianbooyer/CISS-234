<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenus
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
        Me.rtfVenusInfo = New System.Windows.Forms.RichTextBox()
        Me.picVenusImage = New System.Windows.Forms.PictureBox()
        CType(Me.picVenusImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfVenusInfo
        '
        Me.rtfVenusInfo.AcceptsTab = True
        Me.rtfVenusInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfVenusInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfVenusInfo.Location = New System.Drawing.Point(28, 323)
        Me.rtfVenusInfo.Name = "rtfVenusInfo"
        Me.rtfVenusInfo.Size = New System.Drawing.Size(351, 71)
        Me.rtfVenusInfo.TabIndex = 0
        Me.rtfVenusInfo.Text = "Venus" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Type " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Terrestrial" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Average distance from the sun 0.7233 AU" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Mass" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "4.87 " & _
    "x 1024 kg" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Surface temperature" & Global.Microsoft.VisualBasic.ChrW(9) & "472°C"
        '
        'picVenusImage
        '
        Me.picVenusImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picVenusImage.Image = Global.Dropbox_7.My.Resources.Resources.imgVenus
        Me.picVenusImage.Location = New System.Drawing.Point(0, 0)
        Me.picVenusImage.Name = "picVenusImage"
        Me.picVenusImage.Size = New System.Drawing.Size(391, 314)
        Me.picVenusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVenusImage.TabIndex = 1
        Me.picVenusImage.TabStop = False
        '
        'frmVenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 395)
        Me.Controls.Add(Me.rtfVenusInfo)
        Me.Controls.Add(Me.picVenusImage)
        Me.Name = "frmVenus"
        Me.Text = "Planet Venus"
        CType(Me.picVenusImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfVenusInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents picVenusImage As System.Windows.Forms.PictureBox
End Class
