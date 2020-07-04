'Rian Booyer
'Ciss 234 ADE

'Lottery Application
'Create an application that simulates a lottery. The application should have an array
'of five integers and should generate a random number in the range 0 through 9 for
'each element in the array. The array is permitted to contain duplicate values. The
'user should then enter five digits, which the application will compare to the numbers
'in the array. A form should be displayed showing how many of the digits
'matched. If all of the digits match, display a form proclaiming the user as a grand
'prize winner.
Public Class frmMain
    Dim intArraySize As Integer = 4
    Dim lotteryArray(intArraySize) As Integer ' for random numbers generated on load
    Dim userArray(intArraySize) As Integer 'to hold users numbers


    'frmMain_Load - main load of form runs Set_Reset_All function to set initial random numbers in lottery array
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Set_Reset_All()

    End Sub

    'btnCheck_Click - runs the Check_numbers function on each user txt number box if it's ok it assignes
    'it to the user array at specified location. Once done it runs the Compare_Numbers sub to finalize the check
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'would like to loop this instead

        userArray(0) = Check_Numbers(txtNum0.Text, 1)
        userArray(1) = Check_Numbers(txtNum1.Text, 2)
        userArray(2) = Check_Numbers(txtNum2.Text, 3)
        userArray(3) = Check_Numbers(txtNum3.Text, 4)
        userArray(4) = Check_Numbers(txtNum4.Text, 5)
        Compare_Numbers()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Check_Numbers - verifies that the test string can be parsed as an integer. if not it throws an error also checks
    'for alpha and numbers under 0 an over 9
    Private Function Check_Numbers(ByVal testString As String, ByVal boxNum As Integer) As Integer
        Dim testInt As New Integer

        If Integer.TryParse(testString, testInt) Then
            If testInt >= 0 And testInt <= 9 Then
                Return testInt
            Else
                MessageBox.Show("You must enter a number from 0 to 9 in box " & boxNum, "Error:")
            End If ' 0 to 9 if statement

        Else
            MessageBox.Show("You must enter a number from 0 to 9 in box " & boxNum, "Error:")
        End If 'tryparse if statement

        Return testInt
    End Function

    'Compare_Numbers - compares the numbers in the user array to the random numbers generated at load time
    'in the lotteryarray. 
    Private Sub Compare_Numbers()
        Dim intTotalMatches As Integer = 0 ' total matches accumulator
        Dim matchesArray() As Integer = {0, 0, 0, 0, 0} 'creates an array to hold which number positions match and populates it with 0's

        'steps through the arrays and checks for a match if a match is found then the total matches accumulator
        'is incremented and a 1 is stored in the matches array if not a 0 is stored in matches array at same position
        'to show a match

        For intCounter = 0 To userArray.Length - 1
            If userArray(intCounter) = lotteryArray(intCounter) Then
                matchesArray(intCounter) = 1
                intTotalMatches += 1
            Else
                matchesArray(intCounter) = 0
            End If
        Next

        ' if matches are 1 or greater it displays the results form and changes colors of textbox's to green
        'if there is a match otherwise it stays red for no match
        If intTotalMatches >= 1 And intTotalMatches < 5 Then

            'set user number text box display
            Dim frmResults As New frmResults
            frmResults.txtUserNum0.Text = txtNum0.Text
            frmResults.txtUserNum1.Text = txtNum1.Text
            frmResults.txtUserNum2.Text = txtNum2.Text
            frmResults.txtUserNum3.Text = txtNum3.Text
            frmResults.txtUserNum4.Text = txtNum4.Text

            'set lotery number box's display
            frmResults.txtLotNum0.Text = lotteryArray(0).ToString
            frmResults.txtLotNum1.Text = lotteryArray(1).ToString
            frmResults.txtLotNum2.Text = lotteryArray(2).ToString
            frmResults.txtLotNum3.Text = lotteryArray(3).ToString
            frmResults.txtLotNum4.Text = lotteryArray(4).ToString

            'set colors of box's if they match to green
            If matchesArray(0) = 1 Then
                frmResults.txtLotNum0.BackColor = Color.LightGreen
                frmResults.txtUserNum0.BackColor = Color.LightGreen
            End If
            If matchesArray(1) = 1 Then
                frmResults.txtLotNum1.BackColor = Color.LightGreen
                frmResults.txtUserNum1.BackColor = Color.LightGreen
            End If
            If matchesArray(2) = 1 Then
                frmResults.txtLotNum2.BackColor = Color.LightGreen
                frmResults.txtUserNum2.BackColor = Color.LightGreen
            End If
            If matchesArray(3) = 1 Then
                frmResults.txtLotNum3.BackColor = Color.LightGreen
                frmResults.txtUserNum3.BackColor = Color.LightGreen
            End If
            If matchesArray(4) = 1 Then
                frmResults.txtLotNum4.BackColor = Color.LightGreen
                frmResults.txtUserNum4.BackColor = Color.LightGreen
            End If
            frmResults.ShowDialog()

        ElseIf intTotalMatches = 5 Then 'if matches is over 5 then call the grand prize winner form
            Dim frmWinner As New frmWinner
            frmWinner.ShowDialog()
        ElseIf intTotalMatches = 0 Then
            MessageBox.Show("No Numbers Matched Try Again!", "No Numbers Matched:") 'shown if no numbers matched

        End If 'show winner end

    End Sub

   
    'btnMainClear_Click - runs Set_Reset_all when clear is clicked.
    Private Sub btnMainClear_Click(sender As Object, e As EventArgs) Handles btnMainClear.Click
        
        Set_Reset_All()
    End Sub
    'Set_Reset_All - clears text box's of any numbers entered and (re)populates lottery array with new random numbers
    Private Sub Set_Reset_All()
        txtNum0.Clear()
        txtNum1.Clear()
        txtNum2.Clear()
        txtNum3.Clear()
        txtNum4.Clear()
        txtNum0.Focus()
        Dim rand As New Random
        For intCount = 0 To lotteryArray.Length - 1
            lotteryArray(intCount) = rand.Next(10)
        Next

        'for testing purposes
        lblTemp.Text = "Cheater: " & lotteryArray(0).ToString() & lotteryArray(1).ToString() & lotteryArray(2).ToString() & lotteryArray(3).ToString() & lotteryArray(4).ToString()

    End Sub

    'chkCheat_CheckedChanged - shows the numbers in the array you cheater
    Private Sub chkCheat_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheat.CheckedChanged
        If chkCheat.Checked = True Then
            lblTemp.Visible = True
        ElseIf chkCheat.Checked = False Then
            lblTemp.Visible = False
        End If
    End Sub
End Class
