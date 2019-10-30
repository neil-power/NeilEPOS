﻿Public Class UserWindow

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
                LoginWindow.BringToFront()
                LoginWindow.Show() ' Return to login screen
                Hide() 'Closes user window
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

    Private Sub CloseAllMDIWindows() 'Closes all currently open MDI windows. May not be necessary for multiple window use
        SalesWindow.Close()
        ProductLookupWindow.Close()
    End Sub


    Private Sub UserWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then 'If user clicks close button
            CloseAllMDIWindows()
            StartupWindow.Close() 'Ensures program closes fully if user clicks close button
        End If
    End Sub

End Class