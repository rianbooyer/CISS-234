Imports System
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

'references
'https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-comma-delimited-text-files
'https://social.msdn.microsoft.com/Forums/vstudio/en-US/75a2f148-fc0d-416e-b474-76ab8d5ff729/vbnet-printing-with-both-texts-and-images?forum=vbgeneral\

'Accessors class is for functions to open, close files and populate and search the collection basically it "accesses" the collection and files
Public Class Accessors
    Public Shared DataFile As String ' to store the path and filename of the file you wish to open and save


    'OpenFile - Recieves a String and an openFileDialog by value and calls the open file dialog for you to open the file and then 
    'assign the file name to a string and returns the string for a StringReader useage
    Public Function OpenFile(ByVal inpFile As String, ByVal ofdOne As OpenFileDialog
                              ) As String
        Try
            With ofdOne
                '.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                '.Title = "Open File"
                '.RestoreDirectory = True
                '.InitialDirectory = "%USERPROFILE%\Documents\"

                If ofdOne.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    inpFile = ofdOne.FileName()
                End If
            End With
        Catch dirNotFound As System.IO.DirectoryNotFoundException
            MessageBox.Show("Directory Not Found.", "Error: ")
        Catch fileNotFound As System.IO.FileNotFoundException
            MessageBox.Show("File Not Found", "Error:")
        Catch pathTooLong As System.IO.PathTooLongException
            MessageBox.Show("", "Error:")
        Catch ioEx As System.IO.IOException
            MessageBox.Show("IO Exception Occured, Please try to open file again. If error continues file may be corrupt, damaged, or just not readable", "Error")
        Catch security As System.Security.SecurityException
            MessageBox.Show("File Cannot Be Accessed: You may have insufficient security privileges to access the file or folder.", "Error:")
        Catch ex As Exception
            MessageBox.Show("A general error has occured. Please contact technical support.", "Error:")
        End Try

        Return inpFile
    End Function

    'SaveFileAs - receives a file string and a save file dialog to save a file. If file is saved it returns true if not it returns false
    Public Function SaveFileAs(ByVal svFile As String, ByVal sfdOne As SaveFileDialog) As String


        Try
            With sfdOne
                '.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                '.Title = "Open File"
                '.RestoreDirectory = True
                '.InitialDirectory = "%USERPROFILE%\Documents\"

                If sfdOne.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    svFile = sfdOne.FileName()
                End If
            End With
        Catch dirNotFound As System.IO.DirectoryNotFoundException
            MessageBox.Show("Directory Not Found.", "Error: ")
        Catch fileNotFound As System.IO.FileNotFoundException
            MessageBox.Show("File Not Found", "Error:")
        Catch pathTooLong As System.IO.PathTooLongException
            MessageBox.Show("", "Error:")
        Catch ioEx As System.IO.IOException
            MessageBox.Show("IO Exception Occured, Please try to open file again. If error continues file may be corrupt, damaged, or just not readable", "Error")
        Catch security As System.Security.SecurityException
            MessageBox.Show("File Cannot Be Accessed: You may have insufficient security privileges to access the file or folder.", "Error:")
        Catch ex As Exception
            MessageBox.Show("A general error has occured. Please contact technical support.", "Error:")
        End Try
        Return svFile
    End Function

    'sub writeFile - stores all information inside of the collection to file specified by saveFile as a csv file
    Public Sub writeFile(ByVal saveFile As String)
        Dim myStream As StreamWriter = File.CreateText(saveFile)
        Dim s As EmployeeData '= CType(employees.Item(1), employeeData)
        s = CType(employees.Item(1), EmployeeData)

        For Each s In employees
            myStream.Write(s.firstName & ",")
            myStream.Write(s.middleName & ",")
            myStream.Write(s.lastName & ",")
            myStream.Write(s.employeeNumber & ",")
            myStream.Write(s.employeeDepartment & ",")
            myStream.Write(s.employeeTelephone & ",")
            myStream.Write(s.employeeExtension & ",")
            myStream.WriteLine(s.employeeEmailAddress)

        Next
        myStream.Close()

    End Sub
    'printing with pictures


    'sub populateCollection - reads lines from the DataFile and parses the comma delimiters and assigns the values to the employeeData class
    'then stores each instance of that class into the employee's collection
    Public Sub populateCollection()
        Dim myPosition As Integer = 1
        Dim currentRow() As String
        Dim currentField As String
        Dim count As Integer = 0
        Dim myEmployees As New EmployeeData

        'clear existing collection for if you wish to open a different file
        For count1 = 1 To employees.Count
            employees.Remove(CStr(count1))

        Next

        Try 'not necesarily needed

            Dim readArray(10) As String 'read array to store data from file dilimeters

            Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(DataFile)
                Do Until myReader.EndOfData = True
                    myReader.TextFieldType = FileIO.FieldType.Delimited     'sets textfield type to delimited
                    myReader.SetDelimiters(",")                             'sets delimiter


                    count = 0               'must reset count each iteration

                    'reads in currentRow and starts parsing fields into the array
                    currentRow = myReader.ReadFields()
                    For Each currentField In currentRow
                        readArray(count) = currentField
                        count += 1
                    Next

                    'start assignment of array files to myEmployees object after reset of myEmployees
                    myEmployees = New EmployeeData 'must be reset after each iteration
                    myEmployees.firstName = readArray(0)
                    myEmployees.middleName = readArray(1)
                    myEmployees.lastName = readArray(2)
                    myEmployees.employeeNumber = CInt(readArray(3)) 'must cast the string to an int
                    myEmployees.employeeDepartment = readArray(4)
                    myEmployees.employeeTelephone = readArray(5)
                    myEmployees.employeeExtension = readArray(6)
                    myEmployees.employeeEmailAddress = readArray(7)

                    'add myEmployees information to employee's collection
                    employees.Add(myEmployees, readArray(3).ToString)

                Loop
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error:")
        End Try

    End Sub

    'SearchCollectionByNumber - receives an integer to search for and compares it to every employeeData in the collection. 
    'if it is found it returns a true if not a false
    Public Function SearchCollectionByNumber(ByVal eNumb As Integer) As Boolean
        Dim isFound As Boolean = False
        Dim s As EmployeeData = CType(employees.Item(1), EmployeeData)

        For Each s In employees
            If s.employeeNumber = eNumb Then
                Return True
            Else
                isFound = False
            End If
        Next

        Return isFound
    End Function

    'SearchCollectionByEmployeeNumber - this is simmilar to the SearchCollectionByNumber but instead of returning a boolean
    'it returns the location of the employee number to the calling sub
    Public Shared Function SearchCollectionByEmployeeNumber(ByRef eNumb As Integer) As Integer
        Dim isFound As Boolean = False
        Dim s As EmployeeData = CType(employees.Item(1), EmployeeData)
        Dim count As Integer = 1
        Dim noEmployee As Integer = 0
        For Each s In employees
            If s.employeeNumber = eNumb Then
                Return count
            Else

            End If
            count += 1
        Next

        Return noEmployee 'if not found returns 0
    End Function

    'clearCollection - clears the collection passed to it
    Public Sub clearCollection(ByRef e As Collection)
        For count1 = 1 To e.Count Step 1
            e.Remove(e.Count)

        Next
    End Sub



End Class





