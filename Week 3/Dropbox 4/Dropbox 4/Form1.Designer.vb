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
        Me.lblEnterDecimal = New System.Windows.Forms.Label()
        Me.lblRomanNumeral = New System.Windows.Forms.Label()
        Me.txtDecimalInput = New System.Windows.Forms.TextBox()
        Me.txtRomanNumeral = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterDecimal
        '
        Me.lblEnterDecimal.Location = New System.Drawing.Point(36, 28)
        Me.lblEnterDecimal.Name = "lblEnterDecimal"
        Me.lblEnterDecimal.Size = New System.Drawing.Size(124, 28)
        Me.lblEnterDecimal.TabIndex = 0
        Me.lblEnterDecimal.Text = "Enter a decimal Integer in the range 1 - 10:"
        Me.lblEnterDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRomanNumeral
        '
        Me.lblRomanNumeral.Location = New System.Drawing.Point(39, 61)
        Me.lblRomanNumeral.Name = "lblRomanNumeral"
        Me.lblRomanNumeral.Size = New System.Drawing.Size(121, 31)
        Me.lblRomanNumeral.TabIndex = 1
        Me.lblRomanNumeral.Text = "Equivalent Roman Numeral:"
        Me.lblRomanNumeral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDecimalInput
        '
        Me.txtDecimalInput.Location = New System.Drawing.Point(166, 33)
        Me.txtDecimalInput.Name = "txtDecimalInput"
        Me.txtDecimalInput.Size = New System.Drawing.Size(100, 20)
        Me.txtDecimalInput.TabIndex = 0
        '
        'txtRomanNumeral
        '
        Me.txtRomanNumeral.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtRomanNumeral.Location = New System.Drawing.Point(166, 67)
        Me.txtRomanNumeral.Name = "txtRomanNumeral"
        Me.txtRomanNumeral.ReadOnly = True
        Me.txtRomanNumeral.Size = New System.Drawing.Size(100, 20)
        Me.txtRomanNumeral.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(75, 128)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 185)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtRomanNumeral)
        Me.Controls.Add(Me.txtDecimalInput)
        Me.Controls.Add(Me.lblRomanNumeral)
        Me.Controls.Add(Me.lblEnterDecimal)
        Me.MinimumSize = New System.Drawing.Size(330, 0)
        Me.Name = "frmMain"
        Me.Text = "Roman Numeral Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterDecimal As System.Windows.Forms.Label
    Friend WithEvents lblRomanNumeral As System.Windows.Forms.Label
    Friend WithEvents txtDecimalInput As System.Windows.Forms.TextBox
    Friend WithEvents txtRomanNumeral As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
