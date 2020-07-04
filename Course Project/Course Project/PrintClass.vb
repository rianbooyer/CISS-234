Imports System.Drawing.Printing
Imports Course_Project.Accessors

Public Class PrintClass
    Public employeeKey As Integer
    Private access As Accessors

    'printSingle - formats the page for a single record to print
    Public Sub printSingle(ByVal lvwTemp As ListView, ByVal e As PrintPageEventArgs)
        Dim chkCount As Integer
        Dim pc As New PrintClass
        Dim s As EmployeeData
        Dim empName As String
        Dim intVertPosition As Integer 'vertical position

        e.Graphics.DrawString("Employee Report", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 300, 20)
        e.Graphics.DrawString("Report Generated: " & Now.ToString(), New Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, 15, 58)
        intVertPosition = 100

        For Each item1 As ListViewItem In lvwTemp.Items
            If item1.Checked = True Then
                chkCount = SearchCollectionByEmployeeNumber(CInt(CStr(item1.Text)))
                s = CType(employees(chkCount), EmployeeData)
                empName = s.firstName & " " & s.middleName & " " & s.lastName
                e.Graphics.DrawString(String.Format("{0,22} {1,-20}", "Employee Number: ", s.employeeNumber.ToString), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, 114)
                e.Graphics.DrawString(String.Format("{0,22} {1,-20}", "Employee First Name: ", s.firstName.ToString), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, 128)
                e.Graphics.DrawString(String.Format("{0,22} {1,-20}", "Employee Middle Name: ", s.middleName.ToString), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, 142)
                e.Graphics.DrawString(String.Format("{0,22} {1,-20}", "Employee Last Name: ", s.lastName.ToString), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, 156)
                e.Graphics.DrawString(String.Format("{0,22} {1,-20}", "Employee Department: ", s.employeeDepartment.ToString), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, 170)
                e.Graphics.DrawString(String.Format("{0,22} {1,-20}", "Employee Telephone: ", s.employeeTelephone.ToString), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, 184)
                e.Graphics.DrawString(String.Format("{0,22} {1,-20}", "Employee Extension: ", s.employeeExtension.ToString), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, 198)
                e.Graphics.DrawString(String.Format("{0,22} {1,-20}", "Employee Email: ", s.employeeEmailAddress.ToString), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, 212)



            End If
        Next
    End Sub

    'PrintSelected - prints multiple selected records using the same format as the print all
    Public Sub PrintSelected(ByVal lvwTemp As ListView, ByVal e As PrintPageEventArgs)
        Dim chkCount As Integer
        Dim pc As New PrintClass
        Dim s As EmployeeData
        Dim empName As String
        Dim intVertPosition As Integer 'vertical position

        Dim strMultTemp As String = String.Format("{0,-7} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10} ", "Number:", "Name:", "Department:", "Telephone:", "Extension:", "Email Address:")

        e.Graphics.DrawString("Employee Report", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 300, 20)
        e.Graphics.DrawString("Report Generated: " & Now.ToString(), New Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, 15, 58)
        e.Graphics.DrawString(strMultTemp, New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 15, 86)

        intVertPosition = 100
        'For Each s In employees
        For Each item1 As ListViewItem In lvwTemp.Items
            If item1.Checked = True Then
                chkCount = SearchCollectionByEmployeeNumber(CInt(CStr(item1.Text)))
                s = CType(employees(chkCount), EmployeeData)
                empName = s.firstName & " " & s.middleName & " " & s.lastName
                e.Graphics.DrawString(String.Format("{0,-9} {1,-26} {2,-14} {3,-12} {4,-13} {5,-10} ", s.employeeNumber.ToString, empName, s.employeeDepartment, s.employeeTelephone, s.employeeExtension, s.employeeEmailAddress), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, intVertPosition)
                intVertPosition += 14
            End If
        Next
    End Sub

    'PrintAll - prints all records opened from file
    Public Sub PrintAll(ByVal lvwTemp As ListView, ByVal e As PrintPageEventArgs)

        Dim pc As New PrintClass
        Dim s As EmployeeData
        Dim empName As String
        Dim intVertPosition As Integer 'vertical position

        Dim strMultTemp As String = String.Format("{0,-7} {1,-20} {2,-10} {3,-10} {4,-10} {5,-10} ", "Number:", "Name:", "Department:", "Telephone:", "Extension:", "Email Address:")

        'report header
        e.Graphics.DrawString("Employee Report", New Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 300, 20)
        e.Graphics.DrawString("Report Generated: " & Now.ToString(), New Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, 15, 58)
        e.Graphics.DrawString(strMultTemp, New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 15, 86)

        intVertPosition = 100
        For Each s In employees
            empName = s.firstName & " " & s.middleName & " " & s.lastName

            e.Graphics.DrawString(String.Format("{0,-9} {1,-26} {2,-14} {3,-12} {4,-13} {5,-10} ", s.employeeNumber.ToString, empName, s.employeeDepartment, s.employeeTelephone, s.employeeExtension, s.employeeEmailAddress), New Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 15, intVertPosition)

            intVertPosition += 14
        Next

    End Sub
End Class
