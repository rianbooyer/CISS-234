Public Class frmMain
    'Rian Booyer
    'CISS 234 ADE
    'Week 4 Assignment 1
    '
    'Retail Price Calculator
    'Write an application that accepts from the user the wholesale cost of an item and its
    'markup percentage. (For example, if an item’s wholesale cost is $5 and its retail
    'price is $10, then the markup is 100%.)
    'The program should contain a function named CalculateRetail that receives the
    'wholesale cost and markup percentage as arguments, and returns the retail price of
    'the item. The application’s form should look something like the one shown in
    'Figure 6-22.

    '    When the user clicks the Get Retail button, the program should do the following:
    '• Verify that the values entered by the user for the wholesale cost and the markup
    'percent are numeric and not negative
    '• Call the CalculateRetail function
    '• Display the retail cost as returned from the function

    'CalculateRetail - assigned function - takes two values and calculates the final price and returns it to calling sub
    'returns the cost by dividing the markup Percentage (mPerc) by 100 to convert to decimal then adding 1 for proper calculations
    ' for example mperc = 50 becomes .50 becomes 1.5 then multiplied by the wholesale Cost (wCost) wcost = 100 so it returns $150 as a
    'double
    Private Function CalculateRetail(ByVal wCost As Double, ByVal mPerc As Double) As Double
        
        Return (wCost * (1 + (mPerc / 100))) ' multiplies cost times 1 plus mperc/100

    End Function

    'testPositive - returns true if value is positive or prints message about entering a positive number and returns false
    Private Function TestPositive(ByVal testVal As Double) As Boolean
        If testVal > 0 Then
            Return True
        Else
            MessageBox.Show("You must enter a positive number.", "There was an error: ")
            Return False

        End If
    End Function
    'btnGetRetail_Click - has test variable to check inputs for the wholesale price and the markup to make sure they can
    'be parsed to a double. once the test is complete it sets the text of txtRetailPrice.txt as the value returned from
    'CalculateRetail function.
    Private Sub btnGetRetail_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click
        Dim testVariable As Double
        If Double.TryParse(txtWholesalePrice.Text, testVariable) Then
            If TestPositive(testVariable) Then
                If Double.TryParse(txtMarkup.Text, testVariable) Then
                    If TestPositive(testVariable) Then
                        txtRetailPrice.Text = CalculateRetail(CDbl(txtWholesalePrice.Text), CDbl(txtMarkup.Text)).ToString("C")
                    End If ' testpositive for markup
                Else
                    MessageBox.Show("Markup percentage must be a number. For example 55 percent is input as 55 not .55 or 55%", "There was an error:")
                End If ' end tryparse txtMarkup
            End If ' testpositive for wholsale price
        Else
            MessageBox.Show("Wholesale price must be a number only without special characters", "There was an error:")
        End If ' end tryparse wholesale
        txtWholesalePrice.Focus() 'return focus to txtWholesalePrice.text


    End Sub
    'btnExit_Click - exits application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    
End Class
