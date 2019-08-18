Imports System.IO
Public Class ManageUsersWindow

    ' **************************************************ON LOAD**************************************************

    Private Mode As UserMode = UserMode.None
    Private Sub ManageUsersWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent glitching
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(100, 50)
        ResetUsersWindow()
    End Sub

    Private Enum UserMode
        NewUser
        EditUser
        DeleteUser
        None
    End Enum

    Private Sub ResetUsersWindow() 'Resets all values to default
        UserIDTextBox.Text = ""
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        AccessLevelComboBox.Text = ""
        InstructionLabel.Text = "Please select which action you would like to perform."

        UserIDTextBox.Enabled = False
        UsernameTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        AccessLevelComboBox.Enabled = False
        SaveUserButton.Hide()
        SearchButton.Hide()
        FoundUsersListBox.Hide()
        FoundUsersListBox.Items.Clear()
        Mode = UserMode.None
    End Sub

    ' **************************************************UTILITY BUTTONS**************************************************
    Private Sub UserButton_Click(sender As Object, e As EventArgs) Handles NewUserButton.Click, EditUserButton.Click, DeleteUserButton.Click, SaveUserButton.Click, CloseButton.Click, SearchButton.Click 'Handles clicks of utility buttons
        Select Case sender.Name 'Selects button pressed
            Case NewUserButton.Name 'If new user, create a new user
                ResetUsersWindow()
                Mode = UserMode.NewUser
                InstructionLabel.Text = "Please fill in the details for the new user and click save."
                CreateNewUser()
            Case EditUserButton.Name 'If edit user, search for then edit user
                PrepareForSearch() 'Sets fields and shows search button
                Mode = UserMode.EditUser
            Case DeleteUserButton.Name
                PrepareForSearch() 'Sets fields and shows search button
                Mode = UserMode.DeleteUser
            Case SaveUserButton.Name
                SaveUser()
            Case SearchButton.Name
                SearchForUser()
            Case CloseButton.Name 'If close, return to manager window
                Me.Close()
        End Select
    End Sub


    ' **************************************************NEW USERS**************************************************

    Private Sub CreateNewUser() 'For creating a new user
        UsernameTextBox.Enabled = True 'Allows user to type in all text boxes except ID
        UserIDTextBox.Enabled = True
        UserIDTextBox.ReadOnly = True
        PasswordTextBox.Enabled = True
        AccessLevelComboBox.Enabled = True
        UserIDTextBox.Text = GetNewUserID() 'Gets most recent user ID
        SaveUserButton.Show()
    End Sub

    Private Sub SaveUser()

        If Mode = UserMode.EditUser Then 'If a user is being edited, the new details need to be inserted
            Dim UserFileContents() As String = File.ReadAllLines(LoginWindow.UserFilePath) 'Gets entire contents of user file
            For i = 0 To UBound(UserFileContents) 'Runs through each line
                Dim user As String() = UserFileContents(i).Split(",") 'Splits line on commas
                If user(0) = UserIDTextBox.Text Then 'If ID matches with edited user
                    UserFileContents(i) = (UserIDTextBox.Text & "," & UsernameTextBox.Text & "," & PasswordTextBox.Text & "," & GetUserAccessFromTextBox()) 'Replace line with edit
                    File.WriteAllLines(LoginWindow.UserFilePath, UserFileContents)
                End If
            Next

        ElseIf Mode = UserMode.NewUser Then 'If a new user is being made, they can be added at the end of the file
            Dim sw As New System.IO.StreamWriter(LoginWindow.UserFilePath, True) 'Creates new streamwriter to add user to file
            sw.WriteLine(UserIDTextBox.Text & "," & UsernameTextBox.Text & "," & PasswordTextBox.Text & "," & GetUserAccessFromTextBox()) 'Verification needed
            sw.Close() 'Closes file
        End If

        ResetUsersWindow() 'Prevents user from entering text
    End Sub

    ' **************************************************VIEW USERS**************************************************
    Private Sub PrepareForSearch() 'Sets fields and shows search button
        ResetUsersWindow()
        InstructionLabel.Text = "Please fill in the ID or username for the user and click search."
        UsernameTextBox.Enabled = True 'Allows user to type in all text boxes except password for searching
        UserIDTextBox.Enabled = True
        UserIDTextBox.ReadOnly = False
        PasswordTextBox.Enabled = False
        AccessLevelComboBox.Enabled = True
        SearchButton.Show()
    End Sub


    Private Sub SearchForUser()
        Dim UserFileContents() As String = File.ReadAllLines(LoginWindow.UserFilePath) 'Read entire users file

        For i = 0 To UBound(UserFileContents) 'Runs through each line
            Dim user As String() = UserFileContents(i).Split(",") 'Splits line on commas
            If user(0) = UserIDTextBox.Text Or user(1) = UsernameTextBox.Text Or GetUserAccessFromFile(user(3)) = AccessLevelComboBox.Text Then 'If ID or username or access level match
                FoundUsersListBox.Items.Add(UserFileContents(i)) 'Add to displayed listbox
            End If
        Next

        If FoundUsersListBox.Items.Count >= 1 Then
            InstructionLabel.Text = "Please double-click the user you would like to edit."
            FoundUsersListBox.Show()
        Else
            InstructionLabel.Text = "No users were found."
        End If
    End Sub

    Private Function GetUserAccessFromTextBox() 'Converts from dropdown to enum
        Select Case AccessLevelComboBox.Text
            Case "Manager"
                Return LoginWindow.UserAccessLevel.Manager
            Case "User"
                Return LoginWindow.UserAccessLevel.User
            Case Else
                Return LoginWindow.UserAccessLevel.None
        End Select
    End Function

    Private Function GetUserAccessFromFile(UserAccess As String) 'Converts from file to dropdown
        Select Case UserAccess
            Case LoginWindow.UserAccessLevel.Manager
                Return "Manager"
            Case LoginWindow.UserAccessLevel.User
                Return "User"
            Case Else
                Return "None"
        End Select
    End Function

    Private Function GetNewUserID()
        Dim UserFileContents() As String = File.ReadAllLines(LoginWindow.UserFilePath) 'Read entire users file
        Dim LastUser As String() = UserFileContents.Last.Split(",") 'Gets last user - needs verification/error handling
        Dim LastUserID As Integer = CInt(LastUser(0)) + 1 'Definitely needs error handling
        Return LastUserID.ToString("00000")
    End Function

    ' **************************************************EDIT/DELETE USERS**************************************************

    Private Sub EditUser(UserToEdit As String())
        InstructionLabel.Text = "Edit the user's details and click save"
        SearchButton.Hide()
        FoundUsersListBox.Hide()
        UserIDTextBox.Text = UserToEdit(0)
        UserIDTextBox.ReadOnly = True
        UsernameTextBox.Text = UserToEdit(1)
        PasswordTextBox.Text = UserToEdit(2)
        AccessLevelComboBox.Text = GetUserAccessFromFile(UserToEdit(3)) 'Converts from file to dropdown
        SaveUserButton.Show()
    End Sub

    Private Sub DeleteUser(UserToEdit As String())
        Dim UserFileContents() As String = File.ReadAllLines(LoginWindow.UserFilePath) 'Gets entire contents of user file
        For i = 0 To UBound(UserFileContents) 'Runs through each line
            Dim user As String() = UserFileContents(i).Split(",") 'Splits line on commas
            If user(0) = UserToEdit(0) Then 'If ID matches with edited user
                If InputBox("Please type 'YES' to confirm deletion of user " & user(0) & " " & user(1)) = "YES" Then 'Confirms user deletion
                    File.WriteAllLines(LoginWindow.UserFilePath, ArrayRemove(UserFileContents, i)) 'Overwrites file with new list of users
                End If
            End If
        Next
        ResetUsersWindow()
    End Sub

    Private Function ArrayRemove(array As String(), index As Integer) 'Removes an item from a string array
        Dim tempList As New List(Of String)
        tempList.AddRange(array) 'Converts into list
        tempList.RemoveAt(index) 'Removes item from list
        Return tempList.ToArray 'Converts back into array
    End Function

    Private Sub FoundUsersListBox_DoubleClick(sender As Object, e As EventArgs) Handles FoundUsersListBox.DoubleClick
        If Mode = UserMode.EditUser Then 'If a user is being edited, the new details need to be inserted
            EditUser(FoundUsersListBox.SelectedItem.Split(",")) 'Sends user to edit to the edit subroutine

        ElseIf Mode = UserMode.DeleteUser Then 'If a user is being deleted, they need to be removed
            DeleteUser(FoundUsersListBox.SelectedItem.Split(",")) 'Sends user to delete to the edit subroutine
        End If

    End Sub
End Class