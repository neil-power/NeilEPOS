''' <todo>
''' TO DO NEXT
''' Add more detailed sales summary information
''' Integrate product lookup with sales window
''' Add new search button to product lookup window
''' 
''' FEATURES TO ADD
''' Backups
''' Binary search and sorting for index file
''' Store all files within a central folder
''' 
''' FINAL STAGES OF DEVELOPMENT
''' Validation - use built-in validation event
''' Try catch loops for everything that can go wrong
''' Functional UI design - prevent selection of some objects, set up tabbing, etc
''' Visual UI design - colours, logos, branding
''' Lots of testing
'''
''' POTENTIAL NEW THINGS TO ADD
''' Stock in?
''' Payment types?
''' Single numpad for all screens?
''' Make payment window mdi
''' Custom msgbox form for notifications
''' Error logging?
''' Cleanup method - copy all records mentioned in index file to new master file.
''' Indexed file for each attribute - can search based on any attribute of product
'''
''' KNOWN BUGS/ISSUES
''' Can't enter a price higher than 99.99.
''' Date should be in YYYY-MM-DD for file names
'''
''' INFO
''' Standard window size - 1024 x 768
''' Standard MDI form size - 800 x 600, starting position 100, 50
''' </todo>

Public Class LoginWindow

    ' **************************************************FILE INPUT**************************************************

    Private Sub LoginWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CSV.CheckMainDirectoryExists() 'Checks if the main directory folder exists, if not, one is created

        If Not CSV.Exists(CSV.UserFilePath) Then ' Checks to see if the NeilEPOSUsers.csv file exists
            Dim DefaultUserDetails As String = "00001" & "," & "Default" & "," & "123" & "," & "0"
            CSV.Overwrite(CSV.UserFilePath, DefaultUserDetails) 'Writes a default manager account to the file to create a file for storing data.
            MsgBox("A new users file has been created. A default manager account with ID 00001 and password 123 has been created.", vbExclamation, "Warning!")
        End If
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
                    Me.Hide() 'Hides login window as variables still in use
                    ManagerWindow.Show() 'Open manager window
                Case User.UserAccessLevel.User
                    ClearFields() 'Clear ID and password fields
                    Me.Hide() 'Hides login window as variables still in use
                    UserWindow.Show() 'Open user window
                Case User.UserAccessLevel.None
                    MsgBox("You do not have access rights to log in to this system.")
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
            For Each Line In UserFileContents ' Runs through each line in user file - INEFFICIENT
                Dim UserOnLine As User = User.FromLine(Line) 'Gets the user on the line as a user data type
                If UserOnLine.UserID = UserID And UserOnLine.Password = Password Then ' If ID and password match
                    Return UserOnLine 'Return the user on that line if the details match
                End If
            Next Line
        End If
        Return New User With {.UserID = 0, .UserName = "", .Password = "", .AccessLevel = User.UserAccessLevel.None} 'Returns blank user if false
    End Function

End Class