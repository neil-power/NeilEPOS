﻿''' <todo>
''' TO DO NEXT
''' Add more detailed sales summary information
''' Integrate product lookup with sales window
''' Add new search button to product lookup window
''' 
''' FEATURES TO ADD
''' Backups
''' Binary search and sorting for index file
''' Store all files within a central folder
''' 
''' FINAL STAGES OF DEVELOPMENT
''' Validation - use built-in validation event
''' Try catch loops for everything that can go wrong
''' Functional UI design - prevent selection of some objects, set up tabbing, etc
''' Visual UI design - colours, logos, branding
''' Lots of testing
'''
''' POTENTIAL NEW THINGS TO ADD
''' My.Settings file - for file paths etc
''' Stock in?
''' Payment types?
''' Single numpad for all screens?
''' Make payment window mdi
''' Custom msgbox form for notifications
''' Error logging?
''' Encryption for users file
''' Cleanup method - copy all records mentioned in index file to new master file.
''' Indexed file for each attribute - can search based on any attribute of product
'''
''' KNOWN BUGS/ISSUES
''' Can't enter a price higher than 99.99.
''' Date should be in YYYY-MM-DD for file names
'''
''' INFO
''' Standard window size - 1024 x 768
''' Standard MDI form size - 800 x 600, starting position 100, 50
''' </todo>

Public Class StartupWindow

    Private ReadOnly NoOfChecks As Integer = 6
    Private ChecksCompleted As Integer = 0

    Private Sub StartupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BringToFront() 'Brings to front
        StartButton.Hide() 'Resets window
        LoadProgressBar.Value = 0
        PerformStartupChecks() 'Runs file checks
        StartButton.Show()

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

        'DOES USERS FILE EXIST?
        ProgressListBox.Items.Add("Checking users file exists")
        If Not CSV.Exists(CSV.UserFilePath) Then ' Checks to see if the NeilEPOSUsers.csv file exists
            Dim DefaultUserDetails As String = "00001" & "," & "Default" & "," & "123" & "," & "0"
            CSV.Overwrite(CSV.UserFilePath, DefaultUserDetails) 'Writes a default manager account to the file to create a file for storing data.
            ProgressListBox.Items.Add("A new users file has been created. A default manager account with ID 00001 and password 123 has been created.")
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

        ProgressListBox.Items.Add("Checks complete")
    End Sub

    Private Sub IncrementProgressBar()
        ChecksCompleted += 1
        LoadProgressBar.Value = (ChecksCompleted / NoOfChecks) * 100
    End Sub
End Class