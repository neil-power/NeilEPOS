Public Class UserWindow

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles SalesButton.Click, ProductLookupButton.Click, LogoutButton.Click 'When a button is clicked, opens the correct window
        CloseAllMDIWindows()
        Select Case sender.Name 'Selects the button pressed
            Case SalesButton.Name 'If it is the make sales button, open window
                SalesWindow.MdiParent = Me 'Sets user form as MDI parent of sales form
                SalesWindow.Show() 'Opens the sales window
            Case ProductLookupButton.Name 'Opens the window
                ProductLookupWindow.MdiParent = Me
                ProductLookupWindow.Show()
            Case LogoutButton.Name 'If it is the log out button, logout
                LoginWindow.CurrentUser = Nothing 'Set user access rights to none as logging out
                LoginWindow.Show() ' Return to login screen
                Close() 'Closes user window
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub UserWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True 'Sets current form as MDI container

        For Each ctl As Control In Controls ' Changes colour - runs through every control in form
            If TypeOf ctl Is MdiClient Then 'If control is part of MDI
                ctl.BackColor = BackColor 'Set control colour to the form colour
            End If
        Next ctl
    End Sub


    Private Sub CloseAllMDIWindows() 'Closes all currently open MDI windows
        SalesWindow.Close() 'Add more

    End Sub
End Class