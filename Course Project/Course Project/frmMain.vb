Imports System
Imports System.IO
Imports System.Windows.Forms.PrintDialog
Imports Course_Project.Accessors
Imports Course_Project.EmployeeData
Imports Course_Project.PrintClass
Imports System.Drawing.Printing





Public Class frmMain
    Dim numPrint As New PrintClass
    Dim access As New Accessors 'declares new accessors as access 
    Dim myReader As StreamReader 'creates a streamreader


    'print declarations - these are used for the printing functions of the form
    Private WithEvents docToPrint As New Printing.PrintDocument
    Private WithEvents prntpvwDoc As New PrintDocument()

  
    'frmMain_Load - sets loadtime options
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    'mnuFileOpen_Click - opens an open file dialog which allows you to choose the csv file you wish to import
    'Then it calls the populateCollection from the accessors class to populate the collection then it populates
    'the list view with the values stored in the collection
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        mnuFileSave.Enabled = True
        mnuFileSaveAs.Enabled = True
        mnuFilePrint.Enabled = True
        mnuFilePrintPreview.Enabled = True
        mnuEditNewEmployee.Enabled = True
        mnuEditSearchRecords.Enabled = True
        mnuEditSearchRecords.Enabled = True
        lvwEmployeeDisplay.Enabled = True
        DataFile = access.OpenFile(DataFile, ofdMainFormOpen)

        access.populateCollection()

        populateListView()

    End Sub

    'NewEmployeeToolStripMenuItem_Click - declares a new frmNewEmployee form then opens the form
    Private Sub NewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditNewEmployee.Click
        Dim frmNewEmployee As New frmNewEmployee
        frmNewEmployee.ShowDialog()
    End Sub

    'SelectedRecordToolStripMenuItem_Click - finds the employee number of the selected item in the listview and passes that on to
    'the frmEditEmployee form so when it is opened it automatically finds the employee by employee number so you may edit the employee
    Private Sub SelectedRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditSelectedRecord.Click

        Dim empCount As Integer = 0
        Dim EmployeeNumberPass As Integer

        'checks how many employee's are checked
        For Each item1 As ListViewItem In lvwEmployeeDisplay.Items
            If item1.Checked = True Then
                empCount += 1 'increments employee count to find out if multiple records or no records are selected
            End If
        Next

        If empCount = 1 Then    'if only one record is found pass it to the frmEditEmployee form and opens it
            For Each item1 As ListViewItem In lvwEmployeeDisplay.Items
                If item1.Checked = True Then
                    EmployeeNumberPass = CInt(item1.SubItems(0).Text)
                    Dim frmEditEmployee As New frmEditEmployee(EmployeeNumberPass) 'passes the employee number to the new frmEditEmployee form
                    frmEditEmployee.ShowDialog()
                End If
            Next

            'pass to document
        ElseIf empCount > 1 Then ' if greater than one employee is selected display error
            MessageBox.Show("You must select only one employee", "Error: Selection Error")
        ElseIf empCount = 0 Then 'if no employee is selected then display an error
            MessageBox.Show("You must select one employee to edit", "Error: No Employee Selected")
        End If


       

    End Sub

    'SearchRecordsToolsStripMenuItem_Click - declares a new frmSearch and opens it. FrmSearch is the search form to find specific
    'employees
    Private Sub SearchRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditSearchRecords.Click
        Dim frmSearch As New frmSearch
        frmSearch.ShowDialog()
    End Sub

    'mnuFileSaveAs_Click - Allows you to specify the file name and location you wish to save the data as.
    'then writes the data using the writeFile sub of the accessors class
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        DataFile = access.SaveFileAs(DataFile, sfdMainFormSave)

        access.writeFile(DataFile)
    End Sub

    'mnuFileSave_Click - saves the information back into the file using the writefile sub of the accessors class
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        access.writeFile(DataFile)
    End Sub

    'mnuFilePrint_Click - prints the document formated from docToPrint
    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click


        PrntDlgMain.Document = docToPrint
        Dim result As DialogResult = PrntDlgMain.ShowDialog()
        If (result = Windows.Forms.DialogResult.OK) Then
            docToPrint.Print()
        End If


    End Sub

    'mnuFilePrintPreview_Click - uses the prntpvwDoc for formating and displays a dialogue with that information
    Private Sub mnuFilePrintPreview_Click(sender As Object, e As EventArgs) Handles mnuFilePrintPreview.Click

        prtPrvDialog.ClientSize = New Size(850, 600)
        prtPrvDialog.ShowIcon = False

        prtPrvDialog.Document = prntpvwDoc
        prtPrvDialog.ShowDialog()
        
    End Sub

    'document_PrintPage - clears the collection of list view checked items then steps through the list view employee data to check if 
    'any rows are checked. if checked it counts how many are checked and ads them to the listviewcheckeditems collection. if the collection
    'count is 1 it prints one format of the page displaying the employee data vertically, if greater than one it prints only the employee's checked
    'and if it is 0 it prints the entire collection loaded from file
    Private Sub document_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles docToPrint.PrintPage
        Dim chkCount As Integer
        Dim pc As New PrintClass


        'clear collection before re-populate
        access.clearCollection(listViewCheckedItems)

        'repopulate lvwEmployeeDisplay collection
        For Each item1 As ListViewItem In Me.lvwEmployeeDisplay.Items
            If item1.Checked = True Then
                ' MessageBox.Show(item1.SubItems(0).Text)
                pc.employeeKey = CInt(item1.SubItems(0).Text)
                listViewCheckedItems.Add(pc.employeeKey, pc.employeeKey.ToString)
            End If
        Next
        chkCount = listViewCheckedItems.Count ' get new count

        If chkCount = 1 Then
            numPrint.printSingle(lvwEmployeeDisplay, e) 'for printing a single employee

        ElseIf chkCount > 1 Then
            numPrint.PrintSelected(lvwEmployeeDisplay, e) 'for printing selected employee's if greater than 1

        ElseIf chkCount = 0 Then
            numPrint.PrintAll(lvwEmployeeDisplay, e) ' prints all employee's
        End If


    End Sub

    'prntpvwDoc_PrintPage - formats the document for the print preview the same as Document_PrintPage.
    Sub prntpvwDoc_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles prntpvwDoc.PrintPage

        Dim chkCount As Integer
        Dim pc As New PrintClass


        'clear collection before re-populate
        access.clearCollection(listViewCheckedItems)

        'repopulate lvwEmployeeDisplay collection
        For Each item1 As ListViewItem In Me.lvwEmployeeDisplay.Items
            If item1.Checked = True Then
                ' MessageBox.Show(item1.SubItems(0).Text)
                pc.employeeKey = CInt(item1.SubItems(0).Text)
                listViewCheckedItems.Add(pc.employeeKey, pc.employeeKey.ToString)
            End If
        Next
        chkCount = listViewCheckedItems.Count ' get new count

        If chkCount = 1 Then
            numPrint.printSingle(lvwEmployeeDisplay, e)
           
        ElseIf chkCount > 1 Then
            numPrint.PrintSelected(lvwEmployeeDisplay, e)

        ElseIf chkCount = 0 Then
            numPrint.PrintAll(lvwEmployeeDisplay, e)
        End If
    End Sub

    

    'mnuFileExit_Click - closes main program form
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    'populateListview - This populates the listview control with the contents of the employees collection
    Public Sub populateListView()
        lvwEmployeeDisplay.Items.Clear()
        Dim s As EmployeeData = CType(employees.Item(1), EmployeeData) 'specifies s as employeeData and links it to employees collection

        For Each s In employees                 'loop while there is data left
            Dim item1 As New ListViewItem
            item1 = lvwEmployeeDisplay.Items.Add(s.employeeNumber.ToString)
            item1.SubItems.Add(s.firstName)
            item1.SubItems.Add(s.middleName)
            item1.SubItems.Add(s.lastName)
            item1.SubItems.Add(s.employeeDepartment)
            item1.SubItems.Add(s.employeeTelephone)
            item1.SubItems.Add(s.employeeExtension)
            item1.SubItems.Add(s.employeeEmailAddress)
        Next
    End Sub


    'AboutToolStripMenuItem_Click - declares a new form about and displays it
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()

    End Sub

    'HelpToolStripMenuItem1_Click - declares a new frmMainHelp and opens it
    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuHelpHelp.Click
        Dim frmMainHelp As New frmMainHelp
        frmMainHelp.showDialog()
    End Sub

    'lvwEmployeeDisplay_ColumnClick - allows the sorting of columns and switches between ascending and descending sort. Does not work with the employee
    'numbers however
    Private Sub lvwEmployeeDisplay_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwEmployeeDisplay.ColumnClick
        ' Determine whether the column is the same as the last column clicked.
        Dim sortColumn As Integer = -1

        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            'lvwEmployeeDisplay.Sorting = SortOrder.Ascending
            ' Else
            ' Determine what the last sort order was and change it.
            If lvwEmployeeDisplay.Sorting = SortOrder.Ascending Then
                lvwEmployeeDisplay.Sorting = SortOrder.Descending
            Else
                lvwEmployeeDisplay.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        lvwEmployeeDisplay.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        lvwEmployeeDisplay.ListViewItemSorter = New ListViewItemComparer(e.Column, lvwEmployeeDisplay.Sorting)
    End Sub
End Class

