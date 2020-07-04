<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUranus
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
        Me.rtfUranusInfo = New System.Windows.Forms.RichTextBox()
        Me.picUranusImage = New System.Windows.Forms.PictureBox()
        CType(Me.picUranusImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfUranusInfo
        '
        Me.rtfUranusInfo.AcceptsTab = True
        Me.rtfUranusInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfUranusInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfUranusInfo.Location = New System.Drawing.Point(28, 323)
        Me.rtfUranusInfo.Name = "rtfUranusInfo"
        Me.rtfUranusInfo.Size = New System.Drawing.Size(351, 71)
        Me.rtfUranusInfo.TabIndex = 0
        Me.rtfUranusInfo.Text = "Uranus" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Type " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "  Jovian" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Average distance from the sun 19.18 AU" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Mass " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "  8.69 " & _
    "x 1025 kg" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Temperature above cloud tops  -220°C"
        '
        'picUranusImage
        '
        Me.picUranusImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picUranusImage.Image = Global.Dropbox_7.My.Resources.Resources.imgUranus
        Me.picUranusImage.Location = New System.Drawing.Point(0, 0)
        Me.picUranusImage.Name = "picUranusImage"
        Me.picUranusImage.Size = New System.Drawing.Size(391, 314)
        Me.picUranusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUranusImage.TabIndex = 1
        Me.picUranusImage.TabStop = False
        '
        'frmUranus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 395)
        Me.Controls.Add(Me.rtfUranusInfo)
        Me.Controls.Add(Me.picUranusImage)
        Me.Name = "frmUranus"
        Me.Text = "Planet Uranus"
        CType(Me.picUranusImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfUranusInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents picUranusImage As System.Windows.Forms.PictureBox
End Class
