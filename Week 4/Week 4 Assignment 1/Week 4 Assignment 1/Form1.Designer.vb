<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnGetRetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWholesale = New System.Windows.Forms.Label()
        Me.lblMarkup = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtWholesalePrice = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGetRetail
        '
        Me.btnGetRetail.AutoSize = True
        Me.btnGetRetail.Location = New System.Drawing.Point(81, 128)
        Me.btnGetRetail.Name = "btnGetRetail"
        Me.btnGetRetail.Size = New System.Drawing.Size(85, 27)
        Me.btnGetRetail.TabIndex = 2
        Me.btnGetRetail.Text = "&Get Retail"
        Me.btnGetRetail.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(168, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 27)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWholesale
        '
        Me.lblWholesale.AutoSize = True
        Me.lblWholesale.Location = New System.Drawing.Point(20, 26)
        Me.lblWholesale.Name = "lblWholesale"
        Me.lblWholesale.Size = New System.Drawing.Size(155, 17)
        Me.lblWholesale.TabIndex = 2
        Me.lblWholesale.Text = "Wholesale Cost Of Item"
        '
        'lblMarkup
        '
        Me.lblMarkup.AutoSize = True
        Me.lblMarkup.Location = New System.Drawing.Point(104, 54)
        Me.lblMarkup.Name = "lblMarkup"
        Me.lblMarkup.Size = New System.Drawing.Size(71, 17)
        Me.lblMarkup.TabIndex = 3
        Me.lblMarkup.Text = "Markup %"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(95, 82)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(80, 17)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Retail Price"
        '
        'txtWholesalePrice
        '
        Me.txtWholesalePrice.Location = New System.Drawing.Point(181, 23)
        Me.txtWholesalePrice.Name = "txtWholesalePrice"
        Me.txtWholesalePrice.Size = New System.Drawing.Size(100, 22)
        Me.txtWholesalePrice.TabIndex = 0
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(181, 51)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(100, 22)
        Me.txtMarkup.TabIndex = 1
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(181, 79)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.ReadOnly = True
        Me.txtRetailPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtRetailPrice.TabIndex = 7
        Me.txtRetailPrice.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnGetRetail
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 209)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.txtWholesalePrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblMarkup)
        Me.Controls.Add(Me.lblWholesale)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetRetail)
        Me.MinimumSize = New System.Drawing.Size(400, 256)
        Me.Name = "frmMain"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetRetail As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblWholesale As System.Windows.Forms.Label
    Friend WithEvents lblMarkup As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtWholesalePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtMarkup As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox

End Class
