Imports System.IO
''' <summary>
''' TO DO NEXT
''' Create weekly summary file
''' Create transaction file - auto update 
''' 
''' FEATURES TO ADD
''' Create products file, read from products file, search and sort products file, edit product in file, scrape details off internet, change stock number
''' Create product lookup page
''' 
''' FINAL STAGES OF DEVELOPMENT
''' Validation - use built-in validation event
''' Try catch loops for everything that can go wrong
''' Make code shorter and more efficient
''' Lots of testing
''' 
''' POTENTIAL NEW THINGS TO ADD
''' Stock in?
''' Payment types?
''' Single numpad for all screens?
''' Make payment window mdi
''' Custom msgbox form for notifications
''' Error logging?
''' Random/direct file access
''' Search that doesn't require a direct match
''' 
''' KNOWN BUGS/ISSUES
''' Can't enter a price higher than 99.99.
''' Space added to end of ISBN list in daily sales
''' 
''' INFO
''' Standard window size - 1024 x 768
''' Standard MDI form size - 800 x 600, starting position 100, 50
''' </summary>


Public Class LoginWindow

    ' **************************************************FILE INPUT**************************************************
    Public Shared UserFilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "NeilEPOSUsers.csv" ' Desktop and location of users file

    Private Sub LoginWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dir$(UserFilePath) = "" Then ' Checks to see if the NeilEPOSUsers.csv file exists
            Dim sw As New StreamWriter(UserFilePath, True) 'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            sw.WriteLine("00001,Default,123,0") 'Writes a default manager account to the file to create a file for storing data.
            'sw.WriteLine("00002,Default,123,1") 'USER ACCOUNT FOR TESTING - REMOVE LATER
            sw.Close() 'Closes file after writing to it
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
        End Select
    End Sub


    Private Sub ClearFields() 'Clears all entered login details
        UserIDTextBox.Text = "" 'Resets contents of employee ID text box
        PasswordTextBox.Text = "" 'Resets contents of employee password text box
    End Sub

    ' **************************************************LOGIN MECHANISM**************************************************
    Public Enum UserAccessLevel 'Data structure containg possible access levels
        Manager 'Can add/remove users, edit product details, view summaries and all user actions
        User 'Can make sales, lookup product details
        None 'No permissions
    End Enum

    Public Structure User 'Data structure for a user
        Public UserID As Integer 'Unique UserID 
        Public UserName As String 'User display name
        Public Password As String ' Password to login
        Public AccessLevel As UserAccessLevel 'Access level
    End Structure

    Public Shared CurrentUser As New User 'Creates a variable to store the currently logged in user

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UserIDTextBox.KeyDown, PasswordTextBox.KeyDown 'To handle enter key presses
        If e.KeyCode = Keys.Enter Then
            Select Case sender.name
                Case UserIDTextBox.Name
                    PasswordTextBox.Focus() 'Switch to password box
                Case PasswordTextBox.Name
                    LoginUser() 'Login user
            End Select
        End If
    End Sub

    Private Sub LoginUser() 'Logs in user
        CurrentUser = VerifyUserLogin(UserIDTextBox.Text, PasswordTextBox.Text) 'Verifies ID and Password

        If CurrentUser.AccessLevel <> UserAccessLevel.None Then 'If returned user access level is not none, open correct window
            Select Case CurrentUser.AccessLevel 'Select access level
                Case UserAccessLevel.Manager 'If manager, open manager window
                    ClearFields() 'Clear ID and password fields
                    Me.Hide() 'Hides login window as variables still in use
                    ManagerWindow.Show() 'Open manager window
                Case UserAccessLevel.User
                    ClearFields() 'Clear ID and password fields
                    Me.Hide() 'Hides login window as variables still in use
                    UserWindow.Show() 'Open user window
            End Select
        Else 'If user does not exist or have login rights
            MsgBox("Incorrect Login") 'Alerts user to incorrect password 
        End If

    End Sub

    Private Function VerifyUserLogin(ByVal UserID As Integer, ByVal Password As String) 'Reads file and matches ID and password
        Dim UserFileContents() As String = File.ReadAllLines(UserFilePath) 'Read entire users file
        If UserFileContents.Length >= 1 Then 'Tests to see if there are any users in the sale file.
            For Each user In UserFileContents ' Runs through each line in user file - INEFFICIENT
                If user.Split(",")(0) = UserID And user.Split(",")(2) = Password Then ' If ID and password match
                    Return New User With {.UserID = user.Split(",")(0), .UserName = user.Split(",")(1), .Password = user.Split(",")(2), .AccessLevel = user.Split(",")(3)} 'Return user with details from file
                End If
            Next
        End If
        Return New User With {.UserID = 0, .UserName = "", .Password = "", .AccessLevel = UserAccessLevel.None} 'Returns blank user if false
    End Function

End Class