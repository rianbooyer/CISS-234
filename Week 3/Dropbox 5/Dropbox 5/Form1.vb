Public Class Form1
    'Rian Booyer
    'Ciss 234 ade
    '
    'Sum of Numbers
    'Create an application that displays a form similar to the one shown in Figure 5-44.
    'When the Enter Numbers button is clicked, the application should display the input
    'box shown in Figure 5-45.
    'The input box asks the user to enter a positive integer value. Notice that the default
    'input value is 10. When the OK button is clicked, the application should display a
    'message box with the sum of all the integers from 1 through the value entered by the
    'user, as shown in Figure 5-46.

    '    If the user enters a negative value, the application should display an error message.
    'Use the following test data to determine if the application is calculating properly:
    'Value Sum
    '5 15
    '10 55
    '20 210
    '100 5050

    'btnEnterNumbers_click - opens the input form frmInput
    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        frmInput.Show()

    End Sub

    'btnExit_Click - closes application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
