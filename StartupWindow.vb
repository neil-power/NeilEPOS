''' <todo>
''' TO DO NEXT
''' Replace listbox in sales window with datagrid
''' 
''' FEATURES TO ADD
''' 
''' 
''' POST-PROTOTYPE/FINAL STAGES OF DEVELOPMENT
''' Lots of testing
''' 
''' POTENTIAL NEW THINGS TO ADD
''' Allow user to customise file paths - My.Settings file
''' Allow recording of payment type in payment window 
''' Tidy up user notifications - use labels and custom message boxes
''' Cleanup method - copy all records mentioned in index file to new master file.
''' Indexed file for each attribute - can search based on any attribute of product
'''
''' KNOWN BUGS/ISSUES
''' Can't enter a price higher than 99.99 into price input boxes
''' Prevent the only manager setting self to user
'''
''' INFO
''' Standard window size - 1024 x 768 4:3
''' Standard MDI form size - 850 x 650, starting position 150, 75 
''' Startup window size - 640 x 360 16:9
''' Login window size 480 x 360 4:3
''' Standard border style - FixedSingle
''' ISBN Mask -  0000000000999
''' Username/Author Mask - LL??????????????????
''' Title Mask - AAaaaaaaaaaaaaaaaaaa
''' Password Mask -  ampersand x 8, CCCCCCCCCCCC
''' </todo>

Public Class StartupWindow

    'THEME
    Public Shared BackgroundColour As Color = Color.White
    Public Shared ThemeColour As Color = Color.DeepSkyBlue
    Public Shared HoverColour As Color = Color.LightSkyBlue
    Public Shared LogoFont As String = "Rockwell"
    Public Shared MainFont As String = "Segoe UI"
    Public Shared BusinessName As String = "Penarth Books"
    Public Shared ReadOnly Version As String = "0.26"

    Private ReadOnly NoOfChecks As Integer = 9
    Private ChecksCompleted As Integer = 0

    Private Sub StartupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BringToFront() 'Brings to front
        LoadTheme()
        VersionLabel.Text = "v " & Version 'Updates logo label with version
        StartButton.Hide() 'Resets window
        LoadProgressBar.Value = 0
        PerformStartupChecks() 'Runs file checks
        StartButton.Show()
        StartButton.Select() 'Selects start button so user can press enter key

    End Sub

    Private Sub LoadTheme() 'GUI setup
        BackColor = BackgroundColour
        StartButton.BackColor = ThemeColour
        StartButton.FlatAppearance.BorderColor = ThemeColour
        StartButton.FlatAppearance.MouseOverBackColor = HoverColour
        StartButton.FlatAppearance.MouseDownBackColor = HoverColour
        LogoLabel.Font = New Font(LogoFont, 60, GraphicsUnit.Point)
        VersionLabel.Font = New Font("Segoe UI", 50, GraphicsUnit.Point)
        TaglineLabel.Font = New Font(MainFont, 20, GraphicsUnit.Point)
        ProgressListBox.Font = New Font(MainFont, 10, GraphicsUnit.Point)
        StartButton.Font = New Font(MainFont, 20, GraphicsUnit.Point)
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
            Dim DefaultUserDetails As String = "00001" & CSV.Delimiter & "Default" & CSV.Delimiter & User.CreatePasswordHash("NeilEPOSv" & Version) & CSV.Delimiter & "0" & Environment.NewLine
            CSV.Overwrite(CSV.UserFilePath, DefaultUserDetails) 'Writes a default manager account to the file to create a file for storing data.
            ProgressListBox.Items.Add("A new users file has been created.")
            ProgressListBox.Items.Add("A default manager account with ID 00001 and password NeilEPOSv" & Version & " has been created.")
        End If
        IncrementProgressBar()

        'DOES DAILY SALES FILE EXIST?
        ProgressListBox.Items.Add("Checking daily sales file exists")
        If Not CSV.Exists(CSV.DailySalesFilePath) Then ' Checks to see if a daily sales file has already been created
            Dim HeadingsRow As String = "Transaction ID" & CSV.Comma & "Date" & CSV.Comma & "Time" & CSV.Comma & "Item" & CSV.Comma & "Item Cost" & CSV.Comma & "Item Quantity" & CSV.Comma & "Sales Total" & CSV.Comma & "Sales Quantity" & CSV.Comma & "Change Given" & CSV.Comma & "User" & Environment.NewLine
            CSV.Overwrite(CSV.DailySalesFilePath, HeadingsRow) 'Writes a headings row to file.
            ProgressListBox.Items.Add("A new daily sales file has been created at:") 'Gives notification that a new sales file has been created
            ProgressListBox.Items.Add(CSV.DailySalesFilePath)

        End If
        IncrementProgressBar()

        'DOES WEEKLY SALES FILE EXIST?
        ProgressListBox.Items.Add("Checking weekly sales file exists")
        If Not CSV.Exists(CSV.WeeklySalesFilePath) Then ' Checks to see if a weekly sales file has already been created
            Dim HeadingsRow As String = "Date" & CSV.Comma & "Sale Total" & CSV.Comma & "No of Items" & Environment.NewLine
            CSV.Overwrite(CSV.WeeklySalesFilePath, HeadingsRow) 'Writes a headings row to file.
            ProgressListBox.Items.Add("A new weekly sales file has been created at:") 'Gives notification that a new sales file has been created
            ProgressListBox.Items.Add(CSV.WeeklySalesFilePath)
        End If
        IncrementProgressBar()

        'DOES PRODUCT MASTER FILE EXIST?
        ProgressListBox.Items.Add("Checking product master file exists")
        If Not CSV.Exists(Product.ProductsFilePath) Then ' Checks to see if master file exists
            CSV.Overwrite(Product.ProductsFilePath, "") 'Create a new blank master file
            ProgressListBox.Items.Add("A new product file has been created at:") 'Gives notification that a new master file has been created
            ProgressListBox.Items.Add(Product.ProductsFilePath)
        End If
        IncrementProgressBar()

        'DOES PRODUCT INDEX FILE EXIST?
        ProgressListBox.Items.Add("Checking product index file exists")
        If Not CSV.Exists(Product.ProductsIndexPath) Then ' Checks to see if product file exists
            CSV.Overwrite(Product.ProductsIndexPath, "") 'Create a new blank file
            ProgressListBox.Items.Add("A new product index file has been created at:") 'Gives notification that a new product file has been created
            ProgressListBox.Items.Add(Product.ProductsIndexPath)
        End If
        IncrementProgressBar()

        'SORT PRODUCT INDEX FILE
        ProgressListBox.Items.Add("Sorting product index file")
        RandomFile.SortIndex(Product.ProductsIndexPath)
        IncrementProgressBar()

        'HAS A WEEKLY BACKUP BEEN MADE?
        MakeBackups()
        ProgressListBox.Items.Add("A new backup of all files has been made at:")
        ProgressListBox.Items.Add(My.Computer.FileSystem.SpecialDirectories.Desktop)
        IncrementProgressBar()

        ProgressListBox.Items.Add("Checks complete")
        ProgressListBox.TopIndex = ProgressListBox.Items.Count - 1 'Moves to bottom of listbox
    End Sub

    Private Sub IncrementProgressBar()
        ChecksCompleted += 1
        LoadProgressBar.Value = (ChecksCompleted / NoOfChecks) * 100
        ProgressListBox.TopIndex = ProgressListBox.Items.Count - 1 'Moves to bottom of listbox
    End Sub

    Private Sub MakeBackups()
        Dim BackupDirectoryFilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "/BACKUP WEEK " & DatePart(DateInterval.WeekOfYear, Date.Today)
        Try
            My.Computer.FileSystem.CopyDirectory(CSV.MainDirectoryFilePath, BackupDirectoryFilePath, True) 'Overwrite previous weekly backup
        Catch ThrownException As Exception
            ErrorHandling.Warn(ThrownException, BackupDirectoryFilePath)
        End Try
    End Sub
End Class