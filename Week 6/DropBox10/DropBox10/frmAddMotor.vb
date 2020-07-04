
Public Class frmAddMotor

    Private arrayPosition As Integer ' declares arrayPosition to be used as a reference to the element of the array to store data

    'frmAddMotor_Load - sets array position to frmMain.position 
    Private Sub frmAddMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrayPosition = frmMain.position
        txtMotorID.FindForm()
    End Sub

    'btnSave_Click - saves all data entered into form to the array at position referenced by arrayposition
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim RPMTestVar As Double    'testvar for double.tryparse RPMS
            Dim voltageTestVar As Double 'testvar for double.tryparse Voltage
            Dim motorIDTestVar As Integer
            Dim stat(3) As Char 'for conversion of statusString to char array for motor object variable
            Dim statusString As String = cmbStatus.SelectedItem.ToString 'declares statusString as the comboBox selection text 

            'boolean values used to verify status of voltage, rpm, and motorID value's later
            Dim VoltageOk As Boolean = False
            Dim RPMOk As Boolean = False
            Dim motorIDOK As Boolean = False

            stat = statusString.ToCharArray ' converts status string to char array for storage into motor object array

            'starts the verification process
            'tryparse for the MOTORID

            If Integer.TryParse(txtMotorID.Text, motorIDTestVar) Then 'checks to make sure motorID is integer
                If txtMotorID.TextLength = 5 Then 'checks to see if motor id is 5 digits if it is sets MOTORIDOK to true
                    motorIDOK = True
                ElseIf txtMotorID.TextLength < 5 Then ' if less than 5 digits sets motorIDOK to false and displays error
                    motorIDOK = False
                    MessageBox.Show("Motor ID must be 5 digits long", "Error: Motor ID")

                End If
            End If

            'tryparse for the RPM values
            If Double.TryParse(txtRPM.Text, RPMTestVar) Then

                If RPMTestVar >= 10 And RPMTestVar <= 10000 Then 'checks to see if RPM is within range if within rpmok to tru if outside rpmok to false and message displayed
                    RPMOk = True
                Else
                    RPMOk = False
                    MessageBox.Show("The RPM value is out of range. Correct range is between 10 and 10000", "Error: RPM out of range")
                End If

            Else 'if tryparse fails message displayed
                MessageBox.Show("Please enter a DECIMAL number for RPM value", "Error: Not Invalid Data")
                RPMOk = False
            End If

            'tryparse for VOLTAGE value 
            If Double.TryParse(txtVoltage.Text, voltageTestVar) Then

                If voltageTestVar >= 1 And voltageTestVar <= 500 Then 'checks range 
                    VoltageOk = True
                Else
                    MessageBox.Show("The voltage value is out of range. Please enter a value from 1 to 500", "Error: Voltage out of range.")
                    VoltageOk = False
                End If ' voltage range check

            Else ' if tryparse fails set voltage ok to false and display message
                VoltageOk = False
                MessageBox.Show("Please enter a DECIMAL number for VOLTAGE value.", "Error: Invlid Data")
            End If 'end tryparse voltage

            'checks to see if rpmok and voltageok is true if they are it continues if not it doesn't proceded so values can be changed
            If RPMOk = True And VoltageOk = True Then
                If motorIDOK = True Then ' if the motorID is integer AND is 5 digits continue


                    'set data values
                    frmMain.myMotor(arrayPosition).MotorId = txtMotorID.Text.ToString
                    frmMain.myMotor(arrayPosition).Description = txtDescription.Text.ToString
                    frmMain.myMotor(arrayPosition).RPM = RPMTestVar
                    frmMain.myMotor(arrayPosition).voltage = voltageTestVar
                    frmMain.myMotor(arrayPosition).status = stat

                    'calls frmMain.refreshlistbox to refresh the array displayed in the listbox
                    frmMain.RefreshListBox()
                    'closes form
                    Me.Close()
                End If ' motorIDOK = true

            End If 'rpm ok and voltage ok = true

        Catch ex As NullReferenceException
            MessageBox.Show("You have not entered enough information to save. All fields are required", "Error:")
        End Try


    End Sub

    'btnClear_Click - clears data input into form
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDescription.Clear()
        txtMotorID.Clear()
        txtRPM.Clear()
        txtVoltage.Clear()
        cmbStatus.SelectedIndex = -1
    End Sub

    'btnExit_Click - closes form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class