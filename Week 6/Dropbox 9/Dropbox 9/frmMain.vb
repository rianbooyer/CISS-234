'Rian Booyer
'ciss 234 ade
'Random Number File Generator
'Create an application that generates a series of 100 random numbers in the range of
'1 through 1,000. Save the series of numbers in a file.'random number file generator

'Imports
Imports System
Imports System.IO

Public Class frmMain
    Private myFile As String = "myFile.txt" 'global variable for default storage file
    Private randNumArray(99) As Integer 'to hold random numbers declared globaly because it needs to be accessible to all functions

    'btnExit_Click - exits application with me.close()
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'btnGenerate_Click - creates a new random number generator named rand then clears the list view box just in case
    'it has values in it (so you can generate multiple times). Uses loop to fill the array with random numbers and also
    'assignes them to the listView box to view before the write button is clicked
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim rand As New Random
        'clear listbox contents
        lstViewMain.Clear()

        'generate numbers and add to listbox
        For count = 0 To randNumArray.Length - 1
            randNumArray(count) = rand.Next(1000) + 1 'assigns random numbers to randNumArray(count) from 1 to 1000
            lstViewMain.Items.Add(randNumArray(count).ToString, count) 'populates lstViewmain with the numbers for display
        Next
    End Sub


    'btnWrite_Click - creates a streamWriter and writes contents of the rndNumArray to a file either specified by user or 
    'the file specified in txtFileName.text. try also catches common exceptions related to the file operations
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Try
            Dim myWriter As StreamWriter 'create streamWriter


            If txtFileName.Text.Length > 0 Then
                myFile = txtFileName.Text.ToString
            End If
            myWriter = File.CreateText(myFile)

            For count = 0 To randNumArray.Length - 1
                myWriter.WriteLine(randNumArray(count))
            Next
            myWriter.Close()
        Catch dirNotFound As System.IO.DirectoryNotFoundException
            MessageBox.Show("Directory Not Found.", "Error: ")
        Catch fileNotFound As System.IO.FileNotFoundException
            MessageBox.Show("File Not Found", "Error:")
        Catch pathTooLong As System.IO.PathTooLongException
            MessageBox.Show("Path is longer than system supports. Please specify new path", "Error:")
        Catch ioEx As System.IO.IOException
            MessageBox.Show("IO Exception Occured, Please try to open file again. If error continues file may be corrupt, damaged, or just not readable", "Error")
        Catch security As System.Security.SecurityException
            MessageBox.Show("File Cannot Be Accessed: You may have insufficient security privileges to access the file or folder.", "Error:")
        Catch ex As Exception
            MessageBox.Show("A general error has occured. Please contact technical support.", "Error:")
        End Try

    End Sub
End Class
