Imports System
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports Course_Project.EmployeeData
Imports Course_Project.Accessors

Public Class frmNewEmployee
    Dim access As New Accessors

    'btnSaveNewRecord_Click - takes the information and saves it to the collection and stores it into the data file.
    'performes tryparse validation on the employee id
    Private Sub btnSaveNewRecord_Click(sender As Object, e As EventArgs) Handles btnSaveNewRecord.Click
        Dim s As New employeeData '= CType(employees.Item(1), employeeData)
        Dim testInt As New Integer
        Dim selectedItem As Object
        selectedItem = cboDepartment.SelectedItem
        If ValidateInput() = True Then


            If Integer.TryParse(txtEmployeeNumber.Text, testInt) Then

                Dim filename As String = DataFile
                Dim count As Integer = employees.Count
                s.firstName = txtFirstName.Text
                s.middleName = txtMiddleName.Text
                s.lastName = txtLastName.Text
                s.employeeNumber = testInt
                s.employeeDepartment = selectedItem.ToString()
                s.employeeTelephone = txtTelephone.Text
                s.employeeExtension = txtExtension.Text
                s.employeeEmailAddress = txtEmailAddress.Text

                employees.Add(s, CStr(s.employeeNumber))
                MessageBox.Show(employees.Count.ToString)

                access.writeFile(DataFile)
                MessageBox.Show("Employee Added Successfully", "Message: ")
                Me.Close()
            End If 'end tryparse

        End If 'end validate
       
        FormClear() 'clears form so another employee may be entered

        frmMain.populateListView() 'repopulates the listview on the main form
    End Sub

    'btnClear_Click - calls formClear to clear the form's contents
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        FormClear()

    End Sub

    'btnHelp_Click - declares a new help form and then opens it.
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim frmNewEmployeeHelp As New frmNewEmployeeHelp
        frmNewEmployeeHelp.ShowDialog()

    End Sub

    'btnExit_Click - exits form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'FormClear - clears all data from the form's text boxes and sets the combo box to -1 so it has nothing selected
    Private Sub FormClear()
        txtEmailAddress.Clear()
        txtEmployeeNumber.Clear()
        txtExtension.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtTelephone.Clear()
        cboDepartment.SelectedIndex = -1
    End Sub

    'ValidateInput - validates all input from the form so there are no errors and all variables
    'are the correct type. Also makes sure that data is actually input into the forms text box's
    Public Function ValidateInput() As Boolean
        Dim isOk = False
        Dim testInt As Integer
        If txtFirstName.Text <> "" Then
            isOk = True
        Else
            MessageBox.Show("You must input a First Name.", "Error: No First Name")
            Return False
        End If

        If txtMiddleName.Text <> "" Then
            isOk = True
        Else

            MessageBox.Show("You must input a Middle Name.", "Error: No Middle Name")
            Return False
        End If

        If txtLastName.Text <> "" Then
            isOk = True
        Else

            MessageBox.Show("You must input a Last Name.", "Error: No Last Name")
            Return False
        End If

        If Integer.TryParse(txtEmployeeNumber.Text, testInt) Then
            If access.SearchCollectionByNumber(testInt) = False Then
                isOk = True
            ElseIf access.SearchCollectionByNumber(testInt) = True Then

                MessageBox.Show("Employee Number " & testInt.ToString & " is already in use please select a number above " & employees.Count.ToString, "Error: Employee Number already in use")
                Return False
            End If
        Else
            MessageBox.Show("Employee number must be a set of 0-9 integers. Example: 1234 or 1.", "Error: Invalid Employee Number")
            Return False
        End If

        'detect department
        If cboDepartment.SelectedIndex <> -1 Then
            isOk = True
        Else
            MessageBox.Show("You must select a Department.", "Error: Department not selected")
            Return False
        End If
        If txtTelephone.Text <> "" Then
            isOk = True
        Else
            MessageBox.Show("You must input a telephone Number.", "Error: No Telephone Number")
            Return False
        End If
        If txtExtension.Text <> "" Then
            isOk = True
        Else
            MessageBox.Show("You must input an Extension.", "Error: No Extension")
            Return False
        End If

        If txtEmailAddress.Text <> "" Then
            isOk = True
        Else
            MessageBox.Show("You must input an Email Address.", "Error: No Email Address")
            Return False
        End If
        Return isOk
    End Function

End Class