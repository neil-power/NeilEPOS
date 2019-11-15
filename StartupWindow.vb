''' <todo>
''' TO DO NEXT
''' User Input Validation for manageproductwindow, productlookupwindow, saleswindow
''' ISBN check digit calculation for saleswindow, manageproductwindow, productlookupwindow (for those beginning with 978 only)
''' 
''' FEATURES TO ADD
''' Binary search and sorting for index file
''' Functional UI design - prevent selection of some objects, set up tabbing, etc
''' Visual UI design - colours, logos, branding
''' Add more detailed sales summary information
''' 
''' POST-PROTOTYPE/FINAL STAGES OF DEVELOPMENT
''' Lots of testing
''' 
''' POTENTIAL NEW THINGS TO ADD
''' My.Settings file - for file paths etc
''' Stock in?
''' Payment types?
''' Single numpad for all screens?
''' Make payment window mdi
''' Custom msgbox form for notifications
''' Encryption for users file
''' Cleanup method - copy all records mentioned in index file to new master file.
''' Indexed file for each attribute - can search based on any attribute of product
''' Add user name to sales files
'''
''' KNOWN BUGS/ISSUES
''' Can't enter a price higher than 99.99 into price input boxes
''' Commas in author names, or passwords
'''
''' INFO
''' Standard window size - 1024 x 768
''' Standard MDI form size - 800 x 600, starting position 100, 50
''' ISBN Mask -  0000000000999
''' Username Mask - LL??????????????????
''' Password Mask -  ampersand x 8, CCCCCCCCCCCC
''' </todo>

Public Class StartupWindow

    Private ReadOnly NoOfChecks As Integer = 8
    Private ChecksCompleted As Integer = 0

    Private Sub StartupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BringToFront() 'Brings to front
        StartButton.Hide() 'Resets window
        LoadProgressBar.Value = 0
        PerformStartupChecks() 'Runs file checks
        StartButton.Show()
        StartButton.Select() 'Selects start button so user can press enter key

    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        LoginWindow.Show()
        LoginWindow.BringToFront()
        Hide()
    End Sub

    Private Sub PerformStartupChecks()

        'DOES MAIN DIRECTORY EXIST?
        ProgressListBox.Items.Add("Checking main directory exists")
        CSV.CheckMainDirectoryExists() 'Checks if the main directory folder exists, if not, one is created
        IncrementProgressBar()

        'DOES LOG FILE EXIST?
        ProgressListBox.Items.Add("Checking log file exists")
        If Not CSV.Exists(ErrorHandling.LogFilePath) Then ' Checks to see if the log file exists
            CSV.Overwrite(ErrorHandling.LogFilePath, "") 'Creates log file
            ProgressListBox.Items.Add("A new log file has been created.")
        End If
        IncrementProgressBar()

        'DOES USERS FILE EXIST?
        ProgressListBox.Items.Add("Checking users file exists")
        If Not CSV.Exists(CSV.UserFilePath) Then ' Checks to see if the NeilEPOSUsers.csv file exists
            Dim DefaultUserDetails As String = "00001" & "," & "Default" & "," & "NeilEPOSv0.21" & "," & "0" & Environment.NewLine
            CSV.Overwrite(CSV.UserFilePath, DefaultUserDetails) 'Writes a default manager account to the file to create a file for storing data.
            ProgressListBox.Items.Add("A new users file has been created. A default manager account with ID 00001 and password NeilEPOSv0.21 has been created.")
        End If
        IncrementProgressBar()

        'DOES DAILY SALES FILE EXIST?
        ProgressListBox.Items.Add("Checking daily sales file exists")
        If Not CSV.Exists(CSV.DailySalesFilePath) Then ' Checks to see if a daily sales file has already been created
            Dim HeadingsRow As String = "TransactionID" & "," & "Date" & "," & "Time" & "," & "Sale Total" & "," & "No of Items" & "," & "Items Bought" & "," & "Change Given"
            CSV.Overwrite(CSV.DailySalesFilePath, HeadingsRow) 'Writes a headings row to file.
            ProgressListBox.Items.Add("A new daily sales file has been created at " & CSV.DailySalesFilePath) 'Gives notification that a new sales file has been created

        End If
        IncrementProgressBar()

        'DOES WEEKLY SALES FILE EXIST?
        ProgressListBox.Items.Add("Checking weekly sales file exists")
        If Not CSV.Exists(CSV.WeeklySalesFilePath) Then ' Checks to see if a weekly sales file has already been created
            Dim HeadingsRow As String = "Date" & "," & "Sale Total" & "," & "No of Items"
            CSV.Overwrite(CSV.WeeklySalesFilePath, HeadingsRow) 'Writes a headings row to file.
            ProgressListBox.Items.Add("A new weekly sales file has been created at " & CSV.WeeklySalesFilePath) 'Gives notification that a new sales file has been created
        End If
        IncrementProgressBar()

        'DOES PRODUCT MASTER FILE EXIST?
        ProgressListBox.Items.Add("Checking product master file exists")
        If Not CSV.Exists(Product.ProductsFilePath) Then ' Checks to see if master file exists
            CSV.Overwrite(Product.ProductsFilePath, "") 'Create a new blank master file
            ProgressListBox.Items.Add("A new product file has been created at " & Product.ProductsFilePath) 'Gives notification that a new master file has been created
        End If
        IncrementProgressBar()

        'DOES PRODUCT INDEX FILE EXIST?
        ProgressListBox.Items.Add("Checking product index file exists")
        If Not CSV.Exists(Product.ProductsIndexPath) Then ' Checks to see if product file exists
            CSV.Overwrite(Product.ProductsIndexPath, "") 'Create a new blank file
            ProgressListBox.Items.Add("A new product index file has been created at " & Product.ProductsIndexPath) 'Gives notification that a new product file has been created
        End If
        IncrementProgressBar()

        'HAS A WEEKLY BACKUP BEEN MADE?
        If MakeBackups() = True Then
            ProgressListBox.Items.Add("A new backup of all files has been made at " & My.Computer.FileSystem.SpecialDirectories.Desktop)
        ElseIf MakeBackups = False Then
            ProgressListBox.Items.Add("A weekly backup of all files already exists at " & My.Computer.FileSystem.SpecialDirectories.Desktop)
        End If
        IncrementProgressBar()

        ProgressListBox.Items.Add("Checks complete")
    End Sub

    Private Sub IncrementProgressBar()
        ChecksCompleted += 1
        LoadProgressBar.Value = (ChecksCompleted / NoOfChecks) * 100
    End Sub

    Private Function MakeBackups()
        Dim BackupDirectoryFilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "/BACKUP WEEK " & DatePart(DateInterval.WeekOfYear, Date.Today)
        If Not CSV.DirectoryExists(BackupDirectoryFilePath) Then
            Try
                My.Computer.FileSystem.CopyDirectory(CSV.MainDirectoryFilePath, BackupDirectoryFilePath)
            Catch ThrownException As Exception
                ErrorHandling.Warn(ThrownException, BackupDirectoryFilePath)
                Return False
            End Try
            Return True
        Else
            Return False
        End If
    End Function
End Class