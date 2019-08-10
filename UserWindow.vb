Public Class UserWindow
    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles SalesButton.Click, ProductLookupButton.Click, LogoutButton.Click 'When a button is clicked, opens the correct window
        Me.Hide() 'Closes manager window
        Select Case sender.Name 'Selects the button pressed
            Case SalesButton.Name 'If it is the make sales button, open window
                SalesWindow.Show() 'Opens the sales window
                MsgBox(LoginWindow.CurrentUser.UserID & LoginWindow.CurrentUser.AccessLevel) 'TESTING ####################################################################

            Case ProductLookupButton.Name
                'Opens the window
            Case LogoutButton.Name 'If it is the log out button, logout
                LoginWindow.CurrentUser = Nothing 'Set user access rights to none as logging out
                LoginWindow.Show() ' Return to login screen
        End Select
    End Sub
End Class