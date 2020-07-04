'Rian Booyer
'Ciss 234 ADE
'Motor Class
'Create an application that tracks electric motors in a manufacturing plant. The application
'should have a Motor class with the following properties:
'• MotorId: Five-digit string, such as "02340"
'• Description: String
'• RPM: Double, values in the range 10 to 10000
'• Voltage: Double, values in the range 1 to 500
'• Status: String, three characters
'The Status values are:
'• ON: Motor is online and running.
'• OFF: Motor is online but not running.
'• MNT: Motor is undergoing maintenance and cleaning.
'• NA: Motor is not available.
'The application should be able to store at least 10 Motor class objects in an array.
'Create an input form in the application that allows users to input new motor
'records to be added to the array. Create another form that displays all the motors in
'the array in a list box.
Imports DropBox10.Motor
Public Class frmMain
    Public myMotor(50) As Motor 'declares a global array of 50 motor objects (from motor class)
    Public position As Integer  'global public position integer so i can access it from the add form to assign new data to the correct position in the array


    'frmMain_Load - initializes the motor array as new motor objects in for loop. Assignes sample values into the 0 position of the array.
    '
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim charString As String = "On" 'creates a string and populates with on to be converted to a string array when assigned to the array position

        ' initializes the motor array as new motor objects
        For count = 0 To myMotor.Length - 1
            myMotor(count) = New Motor
            myMotor(count).Description = "" 'sets the description to empty for a search for empty later
        Next

        'sample data
        myMotor(0).MotorId = "12345"
        myMotor(0).Description = "Hemi V8"
        myMotor(0).RPM = 7000
        myMotor(0).voltage = 12.45
        myMotor(0).status = charString.ToCharArray

        'puts sample data into the listbox
        lstBoxMotorInfo.Items.Add(myMotor(0).MotorId & " | " & myMotor(0).Description & " | " & myMotor(0).RPM.ToString & "  | " & myMotor(0).RPM.ToString & " | " & myMotor(0).voltage.ToString & " | " & myMotor(0).status)

    End Sub

    'lstBoxMotorInfo_MouseDown - allows the use of the context menu in the listbox for an add function
    Private Sub lstBoxMotorInfo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstBoxMotorInfo.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cmsMotorOptions.Show(MousePosition)
        End If
    End Sub

    'csmAdd_Click - content menu click - calls the add_item sub
    Private Sub csmAdd_Click(sender As Object, e As EventArgs) Handles csmAdd.Click
        Add_Item()
    End Sub

    'btnAdd_Click - calls the add_item function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Item()
    End Sub

    'mnuFileAdd_Click - calls add_item
    Private Sub mnuFileAdd_Click(sender As Object, e As EventArgs) Handles mnuFileAdd.Click
        Add_Item()
    End Sub

    'mnuFileExit_Click - closes form
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    'btnExit_Click - closes form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    'add_item - declares the frmAddMotor that steps through and looks for an empty description then assignes that position to the global
    'variable of me.position for use in the frmAddMotor form so that it adds to the correct array element. then sets the count to the last position so 
    'the loop stops. calls frmaddmotor to add motors.
    Private Sub Add_Item()
        'MessageBox.Show("This option is not implemented yet", "Error:")
        Dim frmAddMotor As New frmAddMotor

        For count = 0 To myMotor.Length - 1
            If myMotor(count).Description = "" Then
                Me.position = count
                frmAddMotor.Show()
                count = myMotor.Length - 1
            End If
        Next
        'frmAddMotor.Show()
    End Sub

    'RefreshListBox - called by the frmAddMotor function currently - clears the listbox contents then steps through the array and adds items untill it 
    'reaches a blank description and then stops.
    Public Sub RefreshListBox()
        lstBoxMotorInfo.Items.Clear()
        For count = 0 To myMotor.Length - 1
            If myMotor(count).Description.ToString <> "" Then
                lstBoxMotorInfo.Items.Add(myMotor(count).MotorId & " | " & myMotor(count).Description & " | " & myMotor(count).RPM.ToString & "  | " & myMotor(count).RPM.ToString & " | " & myMotor(count).voltage.ToString & " | " & myMotor(count).status)
            End If
        Next
    End Sub
End Class
