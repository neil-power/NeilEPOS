Public Class LoginWindow

    ' **************************************************LOGIN MECHANISM**************************************************

    Public UserAccessRights As Char = "" 'Selects which access menu to return to (manager/user). Replace with full user as data structure later.
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click 'Temporary shortcut - file-based user login checks will be added.
        If EmployeeIDTextBox.Text = "00001" And PasswordTextBox.Text = "123" Then
            ClearFields()
            UserAccessRights = "M"
            Me.Hide()
            ManagerWindow.Show()
        ElseIf EmployeeIDTextBox.Text = "00002" And PasswordTextBox.Text = "123" Then
            ClearFields()
            UserAccessRights = "U"
            Me.Hide()
            UserWindow.Show()
        Else
            MsgBox("Incorrect Login")
        End If
    End Sub

    ' **************************************************UTILITY BUTTONS**************************************************

    Public Sub ClearFields() 'Clears all entered login details
        EmployeeIDTextBox.Text = "" 'Resets contents of employee ID text box
        PasswordTextBox.Text = "" 'Resets contents of employee password text box
        UserAccessRights = "X" 'Removes all user access rights on logged in windows
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click 'When clear button pressed, all fields are cleared.
        ClearFields() 'Run clear fields subroutine
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click ' When close button clicked, close all programs
        Environment.Exit(0) ' Closes all windows and exits
    End Sub

End Class