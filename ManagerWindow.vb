Public Class ManagerWindow

    Private Sub ManagerWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True 'Sets current form as MDI container

        LoadTheme()
    End Sub

    Private Sub LoadTheme() 'GUI setup
        BackColor = StartupWindow.BackgroundColour
        ForeColor = StartupWindow.ForegroundColor

        For Each Ctl As Control In Controls ' Runs through every control in form

            If TypeOf Ctl Is Button Then 'If control is button
                Dim CurrentButton As Button = TryCast(Ctl, Button)
                CurrentButton.BackColor = StartupWindow.ThemeColour
                CurrentButton.ForeColor = StartupWindow.ForegroundColor
                CurrentButton.FlatAppearance.BorderColor = StartupWindow.ThemeColour
                CurrentButton.FlatAppearance.MouseOverBackColor = StartupWindow.HoverColour
                CurrentButton.FlatAppearance.MouseDownBackColor = StartupWindow.HoverColour
                CurrentButton.Font = StartupWindow.LabelFont

            ElseIf TypeOf Ctl Is MdiClient Then 'If control is part of MDI
                Ctl.BackColor = StartupWindow.BackgroundColour 'Set control colour to the form colour
            End If
        Next Ctl

        LogoLabel.Font = New Font(StartupWindow.LogoFont, 40, GraphicsUnit.Point)
        BrandLabel.Font = StartupWindow.LabelFont
        BrandLabel.Text = "for " & StartupWindow.BusinessName
        UserLabel.Font = StartupWindow.LabelFont
        UserLabel.Text = "User: " & LoginWindow.CurrentUser.UserName

    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles SalesButton.Click, ProductLookupButton.Click, ManageProductsButton.Click, SalesSummaryButton.Click, ManageUsersButton.Click, LogoutButton.Click 'When a button is clicked, opens the correct window
        HideAllMDIWindows()
        Select Case sender.Name 'Gets and selects the name of the button pressed
            Case SalesButton.Name 'If it is the make sales button, open window
                SalesWindow.MdiParent = Me 'Sets manager form as MDI parent of sales form
                SalesWindow.Show() 'Opens the sales window
            Case ProductLookupButton.Name 'Opens the product window
                ProductLookupWindow.MdiParent = Me 'Sets manager form as MDI parent of product lookup form
                ProductLookupWindow.Show() 'Opens the product window
            Case ManageProductsButton.Name 'Opens the product management window
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
                LoginWindow.BringToFront()
                LoginWindow.Show() ' Return to login screen
                Hide() 'Closes the manager window
            Case Else
                Exit Select
        End Select

    End Sub

    Private Sub CloseAllMDIWindows() 'Closes all currently open MDI windows
        SalesWindow.Close()
        ProductLookupWindow.Close()
        ManageProductsWindow.Close()
        SalesSummaryWindow.Close()
        ManageUsersWindow.Close()
        PaymentWindow.Close()
    End Sub

    Private Sub HideAllMDIWindows() 'Hides all currently open MDI windows to allow multiple simultaneous windows
        SalesWindow.Hide()
        ProductLookupWindow.Hide()
        ManageProductsWindow.Hide()
        SalesSummaryWindow.Hide()
        ManageUsersWindow.Hide()
        PaymentWindow.Hide()
    End Sub

    Private Sub ManagerWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then 'If user clicks close button
            CloseAllMDIWindows()
            StartupWindow.Close() 'Ensures program closes fully if user clicks close button
        End If
    End Sub
End Class