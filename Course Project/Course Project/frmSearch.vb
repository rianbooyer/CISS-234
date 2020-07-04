Imports System
Imports System.IO
Imports System.Windows.Forms.PrintDialog
Imports Course_Project.Accessors
Imports Course_Project.EmployeeData
Imports System.Drawing.Printing

Public Class frmSearch
    Dim access As Accessors
    Dim locations(employees.Count) As Integer 'array to hold the locations of the employee search

    'frmSearch_Load - assigns the employee number search as default click
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdbEmployeeNumber.Checked = True

    End Sub

    'btnSearch_Click - searches through the collection by either the employee number or by string values in the txtOther field
    'if an employee isn't found it pops up a message. It validates that the employee number is an integer.
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim testInt As Integer
        Dim count As Integer = 0
        Dim empAccumulator As Integer = 0
        'clear the array and the listview
        Array.Clear(locations, 0, locations.Length) 'clears the locations array for new data
        lvwEmployeeDisplay.Items.Clear()    'clears the listview control for new data population

        'start searching
        If rdbEmployeeNumber.Checked = True Then
            If Integer.TryParse(txtEmployeeNumber.Text, testInt) Then
                SearchCollectionByEmployeeNumber(testInt) 'calls this sub to return the location of the employee number
                If testInt >= 1 Then    'if testint is found then it processes the information below
                    Dim s As EmployeeData = CType(employees(testInt), EmployeeData)

                    Dim item1 As New ListViewItem
                    item1 = lvwEmployeeDisplay.Items.Add(s.employeeNumber.ToString)
                    item1.SubItems.Add(s.firstName)
                    item1.SubItems.Add(s.middleName)
                    item1.SubItems.Add(s.lastName)
                    item1.SubItems.Add(s.employeeDepartment)
                    item1.SubItems.Add(s.employeeTelephone)
                    item1.SubItems.Add(s.employeeExtension)
                    item1.SubItems.Add(s.employeeEmailAddress)
                ElseIf testInt <= 0 Then
                    MessageBox.Show("Employee Not Found.", "Message:")  'if the employee number isn't found it pops up a message
                End If 'end testint >=1
            Else
                MessageBox.Show("You must input an employee number. If you wish to search by a string use other search option.", "Message:") 'if no employee number is input pops up a message
            End If ' end tryparse

            'start search using other 
        ElseIf rdbOther.Checked = True Then
            If txtOther.Text <> "" Then 'checks to see if txtOther has anything in it if it does it continues


                SearchCollectionByOther(txtOther.Text)  'calls search function that allows searching by string
                'find out if the locations array returned by searchcollectionbyother actually returned a value in the array
                For count = 0 To locations.Length - 1
                    empAccumulator = empAccumulator + locations(count)
                Next

                If empAccumulator >= 1 Then 'if there are values in the array start search
                    For count = 0 To locations.Length - 1

                        Dim eLoc As Integer = locations(count)
                        If eLoc >= 1 Then
                            Dim s As EmployeeData = CType(employees(eLoc), EmployeeData)

                            Dim item1 As New ListViewItem
                            item1 = lvwEmployeeDisplay.Items.Add(s.employeeNumber.ToString)
                            item1.SubItems.Add(s.firstName)
                            item1.SubItems.Add(s.middleName)
                            item1.SubItems.Add(s.lastName)
                            item1.SubItems.Add(s.employeeDepartment)
                            item1.SubItems.Add(s.employeeTelephone)
                            item1.SubItems.Add(s.employeeExtension)
                            item1.SubItems.Add(s.employeeEmailAddress)
                        End If
                    Next
                ElseIf empAccumulator = 0 Then 'if there are no values in the array pop up message
                    MessageBox.Show("No employee's found", "Message:")
                Else

                End If
            ElseIf txtOther.Text = "" Then 'if txtOther contains nothing pop up an error message
                MessageBox.Show("You must enter something in the textbox.", "Error: Empty Search String")
            End If
        End If
    End Sub

    'btnClear_Click - clears all fields and resets the form back to the beginning
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOther.Clear()
        txtEmployeeNumber.Clear()
        Array.Clear(locations, 0, locations.Length) 'clears the locations array for new data
        lvwEmployeeDisplay.Items.Clear()    'clears the listview control for new data population
        rdbEmployeeNumber.Checked = True
        rdbOther.Checked = False
        txtOther.Enabled = False
        txtEmployeeNumber.Enabled = True
        txtEmployeeNumber.Focus()

    End Sub

    'btnExit_Click - exits form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'btnHelp_Click - declares a new frmSearchHelp and then opens it.
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim frmSearchHelp As New frmSearchHelp
        frmSearchHelp.showdialog()
    End Sub

    'rdbOther_CheckedChage - enables the text field for the other search and disables the one for the employee number search
    Private Sub rdbOther_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOther.CheckedChanged
        txtOther.Enabled = True
        txtEmployeeNumber.Enabled = False
    End Sub

    'rdbEmployeeNumber_CheckedChange - disables the other search text box and enambles the employee number text box
    Private Sub rdbEmployeeNumber_CheckedChanged(sender As Object, e As EventArgs) Handles rdbEmployeeNumber.CheckedChanged
        txtOther.Enabled = False
        txtEmployeeNumber.Enabled = True
    End Sub


    'SearchCollectionByOther - searches for provided string through the variables that contain strings. If found
    'it sets the value of the key from the collection to the location in the array represented by locationCount
    'all strings are converted to uppercase so you can search without case problems so rian is the same as Rian
    'once complete returns the locations array declared at the top of the class
    Public Function SearchCollectionByOther(ByVal eString As String) As Integer()

        Dim locationCount As Integer = 0

        Dim s As EmployeeData = CType(employees(1), EmployeeData)
        For Each s In employees
            If s.firstName.ToUpper = eString.ToUpper Then
                locations(locationCount) = s.employeeNumber

            ElseIf s.lastName.ToUpper = eString.ToUpper Then
                locations(locationCount) = s.employeeNumber
                
            ElseIf s.middleName.ToUpper = eString.ToUpper Then
                locations(locationCount) = s.employeeNumber

            ElseIf s.lastName.ToUpper = eString.ToUpper Then
                locations(locationCount) = s.employeeNumber
                
            else If s.employeeTelephone = eString Then
            locations(locationCount) = s.employeeNumber
                
            ElseIf s.employeeExtension = eString Then
                locations(locationCount) = s.employeeNumber
                
            ElseIf s.employeeDepartment.ToUpper = eString.ToUpper Then
                locations(locationCount) = s.employeeNumber
                
            ElseIf s.employeeEmailAddress.ToUpper = eString.ToUpper Then
                locations(locationCount) = s.employeeNumber

            End If
            locationCount += 1 'increments locationCount
        Next

        Return locations 'returns locations array
    End Function


End Class