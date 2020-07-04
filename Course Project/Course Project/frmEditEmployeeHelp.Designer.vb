<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditEmployeeHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditEmployeeHelp))
        Me.rtbEditEmployeeHelp = New System.Windows.Forms.RichTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbEditEmployeeHelp
        '
        Me.rtbEditEmployeeHelp.Location = New System.Drawing.Point(13, 13)
        Me.rtbEditEmployeeHelp.Name = "rtbEditEmployeeHelp"
        Me.rtbEditEmployeeHelp.Size = New System.Drawing.Size(514, 104)
        Me.rtbEditEmployeeHelp.TabIndex = 0
        Me.rtbEditEmployeeHelp.Text = resources.GetString("rtbEditEmployeeHelp.Text")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(452, 123)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmEditEmployeeHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 155)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rtbEditEmployeeHelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditEmployeeHelp"
        Me.Text = "frmEditEmployeeHelp"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbEditEmployeeHelp As System.Windows.Forms.RichTextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
