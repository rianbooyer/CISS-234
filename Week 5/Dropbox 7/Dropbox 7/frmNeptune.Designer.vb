<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNeptune
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
        Me.rtfNeptuneInfo = New System.Windows.Forms.RichTextBox()
        Me.picNeptuneImage = New System.Windows.Forms.PictureBox()
        CType(Me.picNeptuneImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtfNeptuneInfo
        '
        Me.rtfNeptuneInfo.AcceptsTab = True
        Me.rtfNeptuneInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtfNeptuneInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfNeptuneInfo.Location = New System.Drawing.Point(28, 323)
        Me.rtfNeptuneInfo.Name = "rtfNeptuneInfo"
        Me.rtfNeptuneInfo.Size = New System.Drawing.Size(351, 71)
        Me.rtfNeptuneInfo.TabIndex = 0
        Me.rtfNeptuneInfo.Text = "Neptune" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Type " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Jovian" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Average distance from the sun 30.0611 AU" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Mass " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "1.03 x" & _
    " 1026 kg" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Temperature at cloud tops " & Global.Microsoft.VisualBasic.ChrW(9) & "-216°C"
        '
        'picNeptuneImage
        '
        Me.picNeptuneImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picNeptuneImage.Image = Global.Dropbox_7.My.Resources.Resources.imgNeptune
        Me.picNeptuneImage.Location = New System.Drawing.Point(0, 0)
        Me.picNeptuneImage.Name = "picNeptuneImage"
        Me.picNeptuneImage.Size = New System.Drawing.Size(391, 314)
        Me.picNeptuneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNeptuneImage.TabIndex = 1
        Me.picNeptuneImage.TabStop = False
        '
        'frmNeptune
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 395)
        Me.Controls.Add(Me.rtfNeptuneInfo)
        Me.Controls.Add(Me.picNeptuneImage)
        Me.Name = "frmNeptune"
        Me.Text = "Planet Neptune"
        CType(Me.picNeptuneImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfNeptuneInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents picNeptuneImage As System.Windows.Forms.PictureBox
End Class
