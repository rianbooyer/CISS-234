<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinner
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
        Me.btnWhooHoo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnWhooHoo
        '
        Me.btnWhooHoo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnWhooHoo.Location = New System.Drawing.Point(0, 210)
        Me.btnWhooHoo.Name = "btnWhooHoo"
        Me.btnWhooHoo.Size = New System.Drawing.Size(451, 23)
        Me.btnWhooHoo.TabIndex = 1
        Me.btnWhooHoo.Text = "WhooHoo!!!!"
        Me.btnWhooHoo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.Dropbox_8.My.Resources.Resources.imgGrandPrize
        Me.PictureBox1.Location = New System.Drawing.Point(72, 12)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(306, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmWinner
        '
        Me.AcceptButton = Me.btnWhooHoo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 233)
        Me.Controls.Add(Me.btnWhooHoo)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(340, 280)
        Me.Name = "frmWinner"
        Me.Text = "Congratulations!!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnWhooHoo As System.Windows.Forms.Button
End Class
