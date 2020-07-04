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

Imports System.Int32
Public Class Motor

    <VBFixedString(5)> Public MotorId As String

    Public Description As String
    Public RPM As Double
    Public voltage As Double
    Public status(3) As Char


End Class
