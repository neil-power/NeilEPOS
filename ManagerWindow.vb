Public Class ManagerWindow

    Private Sub ManagerWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True 'Sets current form as MDI container

        For Each ctl As Control In Controls ' Changes colour - runs through every control in form
            If TypeOf ctl Is MdiClient Then 'If control is part of MDI
                ctl.BackColor = BackColor 'Set control colour to the form colour
            End If
        Next ctl
    End Sub


    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles SalesButton.Click, ProductLookupButton.Click, EditProductButton.Click, SalesSummaryButton.Click, ManageUsersButton.Click, LogoutButton.Click 'When a button is clicked, opens the correct window
        CloseAllMDIWindows()
        Select Case sender.Name 'Gets and selects the name of the button pressed
            Case SalesButton.Name 'If it is the make sales button, open window
                SalesWindow.MdiParent = Me 'Sets manager form as MDI parent of sales form
                SalesWindow.Show() 'Opens the sales window
            Case ProductLookupButton.Name 'Opens the product window
                ProductLookupWindow.MdiParent = Me 'Sets manager form as MDI parent of product lookup form
                ProductLookupWindow.Show() 'Opens the product window
            Case EditProductButton.Name 'Opens the product management window
                ManageProductsWindow.MdiParent = Me 'Sets manager form as MDI parent of product management form
                ManageProductsWindow.Show() 'Opens the product management window
            Case SalesSummaryButton.Name
                SalesSummaryWindow.MdiParent = Me 'Sets manager form as MDI parent of summary form
                SalesSummaryWindow.Show()  'Opens the summary window
            Case ManageUsersButton.Name
                ManageUsersWindow.MdiParent = Me 'Sets manager form as MDI parent of users form
                ManageUsersWindow.Show() 'Opens the manage users window
            Case LogoutButton.Name 'If it is the log out button, logout
                LoginWindow.CurrentUser = Nothing 'Set user access rights to none as logging out
                LoginWindow.Show() ' Return to login screen
                Close() 'Closes the manager window
            Case Else
                Exit Select
        End Select

    End Sub

    Private Sub CloseAllMDIWindows() 'Closes all currently open MDI windows. May not be necessary for multiple window use
        SalesWindow.Close()
        ProductLookupWindow.Close()
        ManageProductsWindow.Close()
        SalesSummaryWindow.Close()
        ManageUsersWindow.Close()
    End Sub

End Class