Public Class Form1

    'global variables declared outside sub functions since we haven't approached passing variables around functions

    ' the three variables are doubles because you never know how exact the ammount a gas tank will hold. I have never
    'seen a tank rated at an exact integer nor the miles you can drive at an exact integer either.
    Private GallonsGas As Double
    Private MilesDriven As Double
    Private MilesPerGallon As Double

    'btnExit_Click - closes program using me.close()
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    'btnCalculateMPG_Click - uses error try/catch. While trying it gets the value of txtGalons.text and txtMiles.text
    'and converts them to doubles if an exception is thrown an error is displayed in status bar label (please note that
    'i could not find a specific naming convention for the status bar label since the status bar name starts with sta and
    'a label starts with lbl would like to know if this is correct.
    ' if no exception is thrown the program calculates the miles per gallon and displays it in txtMPG.text and converts
    ' it to a string with the fixed point with 2 decimal places ("f2")
    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Try
            GallonsGas = CDbl(txtGallons.Text)
            MilesDriven = CDbl(txtMiles.Text)
            MilesPerGallon = MilesDriven / GallonsGas
            txtMPG.Text = MilesPerGallon.ToString("f2")
            txtGallons.Focus()
        Catch ex As InvalidCastException
            lblErrors.Text = "Error: Enter Numerical Values Only"

        Catch ex As DivideByZeroException
            lblErrors.Text = "Error: Numbers must be greater than 0"
        End Try



    End Sub

    'btnClear_Click - clears the text of the three text box's and the status label displayed at the bottom
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Clear()
        txtMiles.Clear()
        txtMPG.Clear()
        lblErrors.Text = ""
        txtGallons.Focus()
    End Sub
End Class
