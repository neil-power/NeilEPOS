Public Class ManagerWindow
    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles SalesButton.Click, ProductLookupButton.Click, EditProductButton.Click, DailySummaryButton.Click, ManageUsersButton.Click, LogoutButton.Click 'When a button is clicked, opens the correct window
        Me.Hide() 'Closes manager window
        Select Case sender.Name 'Gets and selects the name of the button pressed
            Case SalesButton.Name 'If it is the make sales button, open window
                SalesWindow.Show() 'Opens the sales window
                SalesWindow.BringToFront()
            Case ProductLookupButton.Name
                'Opens the window
            Case EditProductButton.Name
                'Opens the window
            Case DailySummaryButton.Name
                'Opens the window
            Case ManageUsersButton.Name
                ManageUsersWindow.Show()
                ManageUsersWindow.BringToFront()
            Case LogoutButton.Name 'If it is the log out button, logout
                LoginWindow.CurrentUser = Nothing 'Set user access rights to none as logging out
                LoginWindow.Show() ' Return to login screen
        End Select

    End Sub

End Class