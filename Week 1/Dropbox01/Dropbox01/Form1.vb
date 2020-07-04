Public Class Form1

    Private Sub btnPressMe_Click(sender As Object, e As EventArgs) Handles btnPressMe.Click
        If lblMessage.Visible = True Then
            lblMessage.Visible = False
        ElseIf lblMessage.Visible = False Then
            lblMessage.Visible = True
        End If
    End Sub
End Class
