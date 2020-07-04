Public Class Form1
    'Rian Booyer
    'Week 2 chapter 2 program assignment 2
    'Name and Address
    'Create an application that displays your name and address when a button is clicked.
    'The application’s form should appear as shown in Figure 2-83 when it first runs.
    'Once the Show Info button is clicked, the form should appear similar to the one
    'shown in Figure 2-84.
    'Here are the detailed property specifications:
    'a. The button that displays the name and address should be named btnShowInfo.
    'Its text should read Show Info.
    'b. The button that closes the application should be named btnExit. Its text
    'should read Exit.
    'c. The form should have three Label controls. The first will hold your name, the second
    'will hold your street address, and the third will hold your city, state, and ZIP
    'code. The labels should be named lblName, lblStreet, and lblCityStateZip,
    'respectively. The labels’ Font property should be set to Times New Roman, bold,
    '12 point. The labels’ TextAlign property should be set to MiddleCenter.
    'd. The form’s title bar should read Name and Address.

    'I did this through code for practice. 


    'declare labels for address display
    Private lblName As New Label()
    Private lblStreet As New Label()
    Private lblCityStateZip As New Label()
    Private btnExit As New Button()
    Private btnShowInfo As New Button()



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MyFont sets a variable to hold font settings
        Dim MyFont As New Drawing.Font("Times New Roman", 12, FontStyle.Bold)

        'setup some strings for labels
        Dim MyName As String = "Rian Booyer"
        Dim MyStreet As String = "24 Countryside ln"
        Dim MyCityStateZip As String = "Montreal, MO 65591"

        'Customize Labels
        With lblName
            .Name = "lblName"
            .Location = New Point(0, 20)
            .Font = MyFont
            .Visible = False
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = MyName
            .Size = New Size(Me.Width, 30)
            .AutoSize = False
        End With
        With lblStreet
            .Name = "lblStreet"
            .Location = New Point(0, 50)
            .Visible = False
            .Font = MyFont
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = MyFont
            .Text = MyStreet
            .Size = New Size(Me.Width, 30)
            .AutoSize = False
        End With
        With lblCityStateZip
            .Name = "lblCityStateZip"
            .Location = New Point(0, 80)
            .Visible = False
            .Font = MyFont
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = MyCityStateZip
            .Size = New Size(Me.Width, 30)
            .AutoSize = False
        End With

        'event handlers for button actions
        AddHandler btnExit.Click, AddressOf Me.btnExit_Click
        AddHandler btnShowInfo.Click, AddressOf Me.btnShowInfo_Click

        'customize buttons
        With btnExit
            .Name = "btnExit"
            .Location = New Point(147, 151)
            .Text = "Exit"
        End With
        With btnShowInfo
            .Name = "btnShowInfo"
            .Location = New Point(66, 151)
            .Text = "Show Info"
        End With

        'add labels to form
        With Me.Controls
            .Add(lblName)
            .Add(lblStreet)
            .Add(lblCityStateZip)
            .Add(btnExit)
            .Add(btnShowInfo)
        End With






    End Sub


    'btnShowInfo_Click - changes the value of the labels visible state to true
    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs)
        lblName.Visible = True
        lblStreet.Visible = True
        lblCityStateZip.Visible = True
    End Sub

    'btnExit_Click - causes program to close with me.close()
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
