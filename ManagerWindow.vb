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
                'Opens the window
            Case LogoutButton.Name 'If it is the log out button, logout
                LoginWindow.CurrentUser = Nothing 'Set user access rights to none as logging out
                LoginWindow.Show() ' Return to login screen
        End Select

    End Sub


    'FOR GETTING LATEST ID NUMBER FOR ADDING USERS
    'Private Function ReadSaleNumberFromFile() ' Gets most recent employee ID number from the sales file
    '    Dim SaleData() As String = File.ReadAllLines(FilePath) ' This reads all data from the sales file
    '    Dim CurrentSaleNumber As Integer = 0 ' Sets current sale number to 0

    '    If SaleData.Length > 1 Then ' Tests to see if there is more than one line in the sales file (there will be a header row)

    '        Dim LastSaleNumber As String = Trim(Mid(SaleData(SaleData.Length - 1), 21, 5)) 'Takes the sale number from the last line (most recent sale) of the file and removes spaces

    '        If Integer.TryParse(LastSaleNumber, New Integer) Then 'Tests to see if the sales number is an integer to prevent errors
    '            CurrentSaleNumber = LastSaleNumber 'Returns the last sale number (1 will be added to it when finish sale is clicked)
    '        End If

    '    End If

    '    Return CurrentSaleNumber 'Returns sale number, which will be 0 unless the sales file has a more recent sale number

    'End Function






End Class