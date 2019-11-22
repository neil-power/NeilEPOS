Public Class LoginWindow

    Private Sub LoginWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserIDTextBox.Select() ' Sets cursor to start of ID text box
    End Sub

    Private Sub MaskedTextBox_Click(sender As Object, e As EventArgs) Handles UserIDTextBox.Click, PasswordTextBox.Click
        sender.Select(sender.Text.Length, 0) 'Selects first character on click for masked text boxes
    End Sub

    ' **************************************************UTILITY BUTTONS**************************************************
    Private Sub UtilityButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, CloseButton.Click, LoginButton.Click
        Select Case sender.name
            Case ClearButton.Name
                CurrentUser = Nothing 'Removes all user access rights on logged in windows
                ClearFields() 'Run clear fields subroutine
            Case CloseButton.Name
                Environment.Exit(0)' Closes all windows and exits
            Case LoginButton.Name
                LoginUser()
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub ClearFields() 'Clears all entered login details
        UserIDTextBox.Clear() 'Resets contents of employee ID text box
        PasswordTextBox.Clear() 'Resets contents of employee password text box
    End Sub

    ' **************************************************LOGIN MECHANISM**************************************************
    Public Shared CurrentUser As New User 'Creates a variable to store the currently logged in user

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UserIDTextBox.KeyDown, PasswordTextBox.KeyDown 'To handle enter key presses
        If e.KeyCode = Keys.Enter Then 'If enter key is pressed
            Select Case sender.name
                Case UserIDTextBox.Name
                    PasswordTextBox.Focus() 'Switch to password box
                Case PasswordTextBox.Name
                    LoginUser() 'Login user
                Case Else
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub LoginUser() 'Logs in user
        CurrentUser = VerifyUserLogin(UserIDTextBox.Text, PasswordTextBox.Text) 'Verifies ID and Password

        If CurrentUser.AccessLevel <> User.UserAccessLevel.None Then 'If returned user access level is not none, open correct window
            Select Case CurrentUser.AccessLevel 'Select access level
                Case User.UserAccessLevel.Manager 'If manager, open manager window
                    ClearFields() 'Clear ID and password fields
                    Hide() 'Hides login window as variables still in use
                    ManagerWindow.Show() 'Open manager window
                Case User.UserAccessLevel.User
                    ClearFields() 'Clear ID and password fields
                    Hide() 'Hides login window as variables still in use
                    UserWindow.Show() 'Open user window
                Case User.UserAccessLevel.None
                    MessageBox.Show("You do not have access rights to log in to this system.")
                Case Else
                    Exit Select
            End Select
        Else 'If user does not exist
            MsgBox("Incorrect Login") 'Alerts user to incorrect password
        End If

    End Sub

    Private Function VerifyUserLogin(ByVal UserID As Integer, ByVal Password As String) 'Reads file and matches ID and password
        Dim UserFileContents() As String = CSV.ReadAsArray(CSV.UserFilePath) 'Read entire users file as array
        If UserFileContents.Length <> 0 Then 'Tests to see if there are any users in the sale file.
            For Each Line As String In UserFileContents ' Runs through each line in user file - INEFFICIENT
                Dim UserOnLine As User = User.FromLine(Line) 'Gets the user on the line as a user data type
                If UserOnLine.UserID = UserID And UserOnLine.Password = Password Then ' If ID and password match
                    Return UserOnLine 'Return the user on that line if the details match
                End If
            Next Line
        End If
        Return New User With {.UserID = 0, .UserName = "", .Password = "", .AccessLevel = User.UserAccessLevel.None} 'Returns blank user if false
    End Function

End Class