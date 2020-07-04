Public Class frmMain
    ' Rian Booyer
    'CISS 234 ADE
    ' Week 3 Chapter 4 Programming Assignment 1
    '    Roman Numeral Converter
    'Create an application that allows the user to enter an integer between 1 and 10 into
    'a text box on a form similar to the one shown in Figure 4-34. Use a Select Case
    'statement to identify which Roman numeral is the correct translation of the integer.
    'Display the Roman numeral in a Label control. If the user enters an invalid value,
    'display an appropriate error message and do not attempt the conversion. Include an
    'Exit button that closes the window.

    '    The following table lists the Roman numerals for the numbers 1 through 10.
    'Number Roman Numeral
    '1 I
    '2 II
    '3 III
    '4 IV
    '5 V
    '6 VI
    '7 VII
    '8 VIII
    '9 IX
    '10 X
    'Input validation: Do not accept a number less than 1 or greater than 10. If the user
    'enters a number outside this range, display an error message.




    'brnConvert_Click - default button when enter is pressed - tries to convert the number entered in txtDecimalInput as an integer. If a double, decimal, text is
    ' is entered it throws a message. If it can be converted it continues with the cases of 1 - 10. If a number is outside the case numbers an error message 
    'is displayed. Luckily this makes it so extra code for input validation for the range is not needed.

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim intNumber As Integer    'declare an integer to use with tryparse
        If Integer.TryParse(txtDecimalInput.Text, intNumber) Then ' tries to parse the input as an integer if it can convert to integer it continues
            Select Case CInt(txtDecimalInput.Text)
                Case 1
                    txtRomanNumeral.Text = "I"
                Case 2
                    txtRomanNumeral.Text = "II"
                Case 3
                    txtRomanNumeral.Text = "III"
                Case 4
                    txtRomanNumeral.Text = "IV"
                Case 5
                    txtRomanNumeral.Text = "V"
                Case 6
                    txtRomanNumeral.Text = "VI"
                Case 7
                    txtRomanNumeral.Text = "VII"
                Case 8
                    txtRomanNumeral.Text = "VIII"
                Case 9
                    txtRomanNumeral.Text = "IX"
                Case 10
                    txtRomanNumeral.Text = "X"
                Case Else
                    MessageBox.Show("ERROR: Please enter an INTEGER from 1 to 10")      'case else if something other than the cases is entered displays enter
                    txtRomanNumeral.Clear()
                    txtDecimalInput.Clear()
            End Select
        Else
            MessageBox.Show("ERROR: Please enter an INTEGER from 1 to 10") ' if tryparse cannot be converted to an integer displays error
            txtRomanNumeral.Clear()
            txtDecimalInput.Clear()
        End If
       


    End Sub
    'btnExit_Click - exits application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
