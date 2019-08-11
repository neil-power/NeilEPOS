Imports System.IO
Public Class ManageUsersWindow

    ' **************************************************ON LOAD**************************************************

    Private Sub ManageUsersWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent glitching
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(100, 50)
        DisableTextEntry()
    End Sub

    Private Sub DisableTextEntry()
        EmployeeIDTextBox.Text = ""
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        AccessLevelComboBox.Text = ""

        EmployeeIDTextBox.Enabled = False
        UsernameTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        AccessLevelComboBox.Enabled = False
        SaveUserButton.Hide()
    End Sub

    ' **************************************************UTILITY BUTTONS**************************************************
    Private Sub UserButton_Click(sender As Object, e As EventArgs) Handles NewUserButton.Click, EditUserButton.Click, DeleteUserButton.Click, SaveUserButton.Click, CloseButton.Click 'Handles clicks of utility buttons
        Select Case sender.Name 'Selects button pressed
            Case NewUserButton.Name 'If new user, create a new user
                CreateNewUser()
            Case EditUserButton.Name 'If edit user, search for then edit user
                EditUser(SearchForUser())
            Case DeleteUserButton.Name
                DeleteUser(SearchForUser) 'If delete user, search for then delete user
            Case SaveUserButton.Name
                SaveUser()
            Case CloseButton.Name 'If close, return to manager window
                Me.Close()
        End Select
    End Sub


    ' **************************************************NEW USERS**************************************************

    Private Sub CreateNewUser() 'For creating a new user
        UsernameTextBox.Enabled = True 'Allows user to type in all text boxes except ID
        EmployeeIDTextBox.Enabled = True
        EmployeeIDTextBox.ReadOnly = True
        PasswordTextBox.Enabled = True
        AccessLevelComboBox.Enabled = True
        EmployeeIDTextBox.Text = GetNewUserID()
        SaveUserButton.Show()
    End Sub

    Private Sub SaveUser()

        Dim sw As New System.IO.StreamWriter(LoginWindow.UserFilePath, True) 'Creates new streamwriter to add user to file
        sw.WriteLine(EmployeeIDTextBox.Text & "," & UsernameTextBox.Text & "," & PasswordTextBox.Text & "," & GetUserAccess()) 'Verification needed
        sw.Close() 'Closes file
        DisableTextEntry() 'Prevents user from entering text
    End Sub

    ' **************************************************VIEW USERS**************************************************

    Private Function SearchForUser()
        Return New LoginWindow.User
    End Function

    Private Function GetUserAccess()
        Select Case AccessLevelComboBox.Text
            Case "Manager"
                Return 0
            Case "User"
                Return 1
            Case Else
                Return 2
        End Select
    End Function

    Private Function GetNewUserID()
        Dim UserFileContents() As String = File.ReadAllLines(LoginWindow.UserFilePath) 'Read entire users file
        Dim LastUser As String() = UserFileContents.Last.Split(",") 'Gets last user - needs verification/error handling
        Dim LastUserID As Integer = CInt(LastUser(0)) + 1 'Definitely needs error handling
        Return LastUserID.ToString("00000")
    End Function

    ' **************************************************EDIT/DELETE USERS**************************************************

    Private Sub EditUser(UserToEdit As LoginWindow.User)

    End Sub

    Private Sub DeleteUser(UserToEdit As LoginWindow.User)

    End Sub


End Class