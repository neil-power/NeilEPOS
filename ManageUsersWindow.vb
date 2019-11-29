Public Class ManageUsersWindow

    ' **************************************************ON LOAD**************************************************
    Private Enum UserMode 'Mode to select what action to be taken for saving and searching
        NewUser
        EditUser
        DeleteUser
        None
    End Enum

    Private Mode As UserMode = UserMode.None
    Private Sub ManageUsersWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent visual issue
        FormBorderStyle = FormBorderStyle.None 'Removes border
        StartPosition = FormStartPosition.Manual 'Prevents automatic cascade of MDI windows
        Location = New Point(100, 50) 'Sets form location to centre of Manager window
        ResetUsersWindow()
    End Sub

    Private Sub MaskedTextBox_Click(sender As Object, e As EventArgs) Handles UserNameTextBox.Click, UserIDTextBox.Click, PasswordTextBox.Click
        sender.Select(sender.Text.Length, 0) 'Selects first character on click for masked text boxes
    End Sub

    Private Sub ResetUsersWindow() 'Resets all values to default

        UserIDTextBox.Clear() 'Clear all text boxes
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        AccessLevelComboBox.Text = ""
        InstructionLabel.Text = "Please select which action you would like to perform."

        UserIDTextBox.Enabled = False 'Disable all text boxes
        UsernameTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        AccessLevelComboBox.Enabled = False

        SaveUserButton.Hide() 'Hide all buttons
        SearchButton.Hide()
        FoundUsersListBox.Hide()
        FoundUsersListBox.Items.Clear() 'Empty listbox
        Mode = UserMode.None 'Set mode to none
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
                Close() 'Close current window
            Case Else
                Exit Select
        End Select
    End Sub


    ' **************************************************NEW USERS**************************************************

    Private Sub CreateNewUser() 'For creating a new user
        UsernameTextBox.Enabled = True 'Allows user to type in all text boxes except ID
        UserIDTextBox.Enabled = True
        UserIDTextBox.ReadOnly = True
        PasswordTextBox.Enabled = True
        AccessLevelComboBox.Enabled = True
        AccessLevelComboBox.Text = "None"
        UserIDTextBox.Text = GetNewUserID() 'Gets most recent user ID
        SaveUserButton.Show()
    End Sub

    Private Sub SaveUser()

        Dim UserToSave As String = UserIDTextBox.Text & CSV.Delimiter & UserNameTextBox.Text.Trim() & CSV.Delimiter & PasswordTextBox.Text.Trim() & CSV.Delimiter & GetUserAccessFromTextBox()
        If User.CheckValidUser(UserToSave.Split(CSV.Delimiter)) Then

            If Mode = UserMode.EditUser Then 'If a user is being edited, the new details need to be inserted
                CSV.Replace(CSV.UserFilePath, UserIDTextBox.Text, UserToSave) 'Replaces any lines matching UserID text box
            ElseIf Mode = UserMode.NewUser Then 'If a new user is being made, they can be added at the end of the file
                CSV.Append(CSV.UserFilePath, UserToSave) 'Writes line to file
            End If

            ResetUsersWindow() 'Prevents user from entering text
        End If

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
        Dim UserFileContents() As String = CSV.ReadAsArray(CSV.UserFilePath) 'Read entire users file

        For Each Line As String In UserFileContents 'Runs through each line
            Dim user As String() = Line.Split(CSV.Delimiter) 'Splits line on delimiter character
            If user(0) = UserIDTextBox.Text Or user(1) = UsernameTextBox.Text Or GetUserAccessFromFile(user(3)) = AccessLevelComboBox.Text Then 'If ID or username or access level match
                FoundUsersListBox.Items.Add(Line) 'Add to displayed listbox
            End If
        Next Line

        If FoundUsersListBox.Items.Count <> 0 Then
            InstructionLabel.Text = "Please double-click the user you would like to edit."
            FoundUsersListBox.Show()
        Else
            InstructionLabel.Text = "No users were found."
        End If
    End Sub

    Private Function GetUserAccessFromTextBox() 'Converts from dropdown to enum
        Select Case AccessLevelComboBox.Text
            Case "Manager"
                Return User.UserAccessLevel.Manager
            Case "User"
                Return User.UserAccessLevel.User
            Case Else
                Return User.UserAccessLevel.None
        End Select
    End Function

    Private Function GetUserAccessFromFile(UserAccess As String) 'Converts from file to dropdown
        Select Case UserAccess
            Case User.UserAccessLevel.Manager
                Return "Manager"
            Case User.UserAccessLevel.User
                Return "User"
            Case Else
                Return "None"
        End Select
    End Function

    Private Function GetNewUserID()
        Dim UserFileContents() As String = CSV.ReadAsArray(CSV.UserFilePath) 'Read entire users file
        Dim LastUser As String() = UserFileContents.Last.Split(CSV.Delimiter) 'Gets last user - needs verification/error handling
        Dim LastUserID As Integer = CInt(LastUser(0)) + 1 'Definitely needs error handling
        Return LastUserID.ToString("00000")
    End Function

    ' **************************************************EDIT/DELETE USERS**************************************************

    Private Sub EditUser(UserToEdit As User)
        InstructionLabel.Text = "Edit the user's details and click save"
        SearchButton.Hide()
        FoundUsersListBox.Hide()
        UserIDTextBox.Text = UserToEdit.UserID.ToString("00000")
        UserIDTextBox.ReadOnly = True
        PasswordTextBox.Enabled = True
        AccessLevelComboBox.Enabled = True
        UsernameTextBox.Text = UserToEdit.UserName
        PasswordTextBox.Text = UserToEdit.Password
        AccessLevelComboBox.Text = GetUserAccessFromFile(UserToEdit.AccessLevel) 'Converts from file to dropdown
        SaveUserButton.Show()
    End Sub

    Private Sub DeleteUser(UserToEdit As User)
        If UserToEdit.UserID <> LoginWindow.CurrentUser.UserID Then
            Dim UserFileContents() As String = CSV.ReadAsArray(CSV.UserFilePath) 'Gets entire contents of user file
            For i = 0 To UBound(UserFileContents) 'Runs through each line
                Dim UserFound As User = User.FromLine(UserFileContents(i)) 'Converts to user
                If UserFound.UserID = UserToEdit.UserID Then 'If ID matches with edited user
                    If InputBox("Please type 'YES' to confirm deletion of user " & UserFound.UserID & " " & UserFound.UserName) = "YES" Then 'Confirms user deletion
                        CSV.ArrayOverwrite(CSV.UserFilePath, CSV.RemoveFromArray(UserFileContents, i)) 'Overwrites file with new list of users
                    End If
                End If
            Next
            ResetUsersWindow()
        Else
            InstructionLabel.Text = "You cannot delete the current user"
        End If
    End Sub

    Private Sub FoundUsersListBox_DoubleClick(sender As Object, e As EventArgs) Handles FoundUsersListBox.DoubleClick
        If FoundUsersListBox.SelectedItem <> Nothing Then 'If a user is selected
            If Mode = UserMode.EditUser Then 'If a user is being edited, the new details need to be inserted
                EditUser(User.FromLine(FoundUsersListBox.SelectedItem)) 'Sends user to edit to the edit subroutine

            ElseIf Mode = UserMode.DeleteUser Then 'If a user is being deleted, they need to be removed
                DeleteUser(User.FromLine(FoundUsersListBox.SelectedItem)) 'Sends user to delete to the edit subroutine
            End If
        End If
    End Sub

End Class