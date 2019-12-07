Public Class UserWindow

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles SalesButton.Click, ProductLookupButton.Click, LogoutButton.Click  'When a button is clicked, opens the correct window
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