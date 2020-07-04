<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInput
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
        Me.lblInputOK = New System.Windows.Forms.Button()
        Me.btnInputCancel = New System.Windows.Forms.Button()
        Me.txtNumberInput = New System.Windows.Forms.TextBox()
        Me.lblInputFormMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInputOK
        '
        Me.lblInputOK.Location = New System.Drawing.Point(293, 13)
        Me.lblInputOK.Name = "lblInputOK"
        Me.lblInputOK.Size = New System.Drawing.Size(75, 23)
        Me.lblInputOK.TabIndex = 1
        Me.lblInputOK.Text = "&OK"
        Me.lblInputOK.UseVisualStyleBackColor = True
        '
        'btnInputCancel
        '
        Me.btnInputCancel.Location = New System.Drawing.Point(293, 43)
        Me.btnInputCancel.Name = "btnInputCancel"
        Me.btnInputCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnInputCancel.TabIndex = 2
        Me.btnInputCancel.Text = "Cancel"
        Me.btnInputCancel.UseVisualStyleBackColor = True
        '
        'txtNumberInput
        '
        Me.txtNumberInput.Location = New System.Drawing.Point(13, 94)
        Me.txtNumberInput.Name = "txtNumberInput"
        Me.txtNumberInput.Size = New System.Drawing.Size(355, 20)
        Me.txtNumberInput.TabIndex = 0
        Me.txtNumberInput.Text = "10"
        '
        'lblInputFormMessage
        '
        Me.lblInputFormMessage.AutoSize = True
        Me.lblInputFormMessage.Location = New System.Drawing.Point(13, 13)
        Me.lblInputFormMessage.Name = "lblInputFormMessage"
        Me.lblInputFormMessage.Size = New System.Drawing.Size(147, 13)
        Me.lblInputFormMessage.TabIndex = 3
        Me.lblInputFormMessage.Text = "Enter a positive integer value."
        '
        'frmInput
        '
        Me.AcceptButton = Me.lblInputOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 126)
        Me.Controls.Add(Me.lblInputFormMessage)
        Me.Controls.Add(Me.txtNumberInput)
        Me.Controls.Add(Me.btnInputCancel)
        Me.Controls.Add(Me.lblInputOK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInput"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Input Needed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInputOK As System.Windows.Forms.Button
    Friend WithEvents btnInputCancel As System.Windows.Forms.Button
    Friend WithEvents txtNumberInput As System.Windows.Forms.TextBox
    Friend WithEvents lblInputFormMessage As System.Windows.Forms.Label
End Class
