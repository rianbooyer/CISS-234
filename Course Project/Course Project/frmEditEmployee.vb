Imports System
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports Course_Project.EmployeeData
Imports Course_Project.Accessors

Public Class frmEditEmployee
    Dim access As New Accessors
    Dim employeeIndex As Integer

    'New - initializes component (i guess that was required) and sets the employee index to the index passed to form
    Public Sub New(ByVal eIndex As Integer)
        InitializeComponent()

        employeeIndex = eIndex
    End Sub

    'btnUpdate_Click - stores the changed information back into the collection then writes the information to file
    'repopulates the main form then exits the form
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim s As employeeData = CType(employees(employeeIndex), employeeData)
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

                access.writeFile(DataFile)
                frmMain.populateListView()
                Me.Close()
            End If 'end tryparse
        End If 'validate


    End Sub

    'frmEditEmployee_Load - loads the information from the integer passed to the form as the key (all employee id's are the same as the keys)
    'then populates the data fields. Employee Number is not editable because we need to preserve the key
    Private Sub frmEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim empInd As Integer = SearchCollectionByEmployeeNumber(employeeIndex)
        employeeIndex = empInd
        If employeeIndex >= 1 Then
            Dim cboIndex As Integer
            Dim s As employeeData = CType(employees(empInd), employeeData)
            txtFirstName.Text = s.firstName
            txtMiddleName.Text = s.middleName
            txtLastName.Text = s.lastName
            txtEmployeeNumber.Text = s.employeeNumber.ToString()
            cboIndex = cboDepartment.FindString(s.employeeDepartment)
            cboDepartment.SelectedIndex = cboIndex
            txtTelephone.Text = s.employeeTelephone
            txtExtension.Text = s.employeeExtension
            txtEmailAddress.Text = s.employeeEmailAddress
        ElseIf employeeIndex = 0 Then
            MessageBox.Show("Employee Not Found.", "Error: Invalid Employee")
            Me.Close()
        End If
    End Sub

    'btnRemove_Click - delete's employee from collection, pops up a message to declare a success, 
    'refreshes the listview on the main form and exits the application
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If employees.Contains(txtEmployeeNumber.Text) Then
            employees.Remove(txtEmployeeNumber.Text)
        End If
        access.writeFile(DataFile)
        MessageBox.Show("Employee Removed Sucessfully", "Message: ")
        frmMain.populateListView()
        Me.Close()
    End Sub

    'btnExit_Click - closes form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    'ValidateInput - validates all data on the form and puts up errors if it doesn't exist or if it is the wrong format
    Private Function ValidateInput() As Boolean
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
            isOk = True
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