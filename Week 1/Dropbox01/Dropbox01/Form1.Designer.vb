<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnPressMe = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPressMe
        '
        Me.btnPressMe.Location = New System.Drawing.Point(99, 122)
        Me.btnPressMe.Name = "btnPressMe"
        Me.btnPressMe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPressMe.Size = New System.Drawing.Size(75, 23)
        Me.btnPressMe.TabIndex = 0
        Me.btnPressMe.Text = "Press Me"
        Me.btnPressMe.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(72, 85)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(134, 34)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "You just had to press the button...you just had to...."
        Me.lblMessage.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 284)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnPressMe)
        Me.Name = "Form1"
        Me.Text = "Dropbox01"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPressMe As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
