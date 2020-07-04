Public Class frmInput

    'btnInputCancel_Click - closes this form and returns to primary form
    Private Sub btnInputCancel_Click(sender As Object, e As EventArgs) Handles btnInputCancel.Click
        Me.Close()

    End Sub

    'lblInputOK_Click - sets three variables to be used in the calculations and display. Calculates the total based on deincrementing count
    'until it reaches 0. TempNum is added to the count so 5 is added to 0 then 5 is added to 4 and so on. The result is called in a messagebox
    Private Sub lblInputOK_Click(sender As Object, e As EventArgs) Handles lblInputOK.Click
        Dim intNumber As Integer ' for tryparse testing also replaced cint(txtNumberInput.txt) in arithmatic problem

        If Integer.TryParse(txtNumberInput.Text, intNumber) Then ' tests to verify an integer value


            Try
                Dim TempNum As Integer = 0
                Dim count As Integer = intNumber 'count variable i used count in for loops in c++
                Dim myNum As Integer = intNumber 'sets myNum to the value of intNumber from tryparse
                Do Until count = 0 'start loop for the result calculation
                    TempNum += count
                    count -= 1 ' decrement count
                Loop
                Me.Close() 'closes this form once ok is clicked
                MessageBox.Show("The sum of the numbers 1 through " & myNum & " is " & TempNum, "Sum of Numbers") 'call messagebox to display result
            Catch ex As Exception
                MessageBox.Show("ERROR: Please enter positive INTEGERS only123") 'catches all exceptions
            End Try

        Else
            MessageBox.Show("ERROR: Please enter positive INTEGERS only") 'Error that tryparse displays if it can't parse to an integer
        End If

    End Sub

    'frmInput_Load - sets the focus to the txtNumberInput box 
    Private Sub frmInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumberInput.Focus()
    End Sub
End Class