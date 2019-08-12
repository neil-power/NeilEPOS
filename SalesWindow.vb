Imports System.IO 'Imports libraries needed for reading and writing files
Public Class SalesWindow

    ' **************************************************ON LOAD**************************************************
    'GLOBAL VARIABLES

    Private InputMode As String 'Sets which box for the keypad to write to
    Public Shared CurrentSale As List(Of Item) 'Creates a list of items in the current sale
    Public Shared SaleTotal As Double ' Creates a variable for the total for the current sale
    Public Shared FilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & CStr(DateTime.Today).Replace("/", "-") + " SALES.csv" ' Desktop and current date for file to save to
    Public Shared SaleNumber As Integer ' Creates a variable for a running total of sales

    Public Structure Item 'Creates an item structure
        Dim ISBN As String
        Dim Price As Double
        Dim Quantity As String
    End Structure

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Runs when form opens

        'The startup location is set in the form properties to 1024, 768 to prevent glitching
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None 'No border
        Me.StartPosition = FormStartPosition.Manual 'Manual start position
        Me.Location = New Point(100, 50) 'Set location to inside manager/user form

        If Not File.Exists(FilePath) Then ' Checks to see if a sales file has already been created

            Dim sw As New StreamWriter(FilePath, True) 'Creates a file writer
            sw.WriteLine("Date + Time" & "," & "Sale Number" & "," & "ISBN" & "," & "Price" & "," & "Quantity" & "," & "Sale Total") 'Writes headings row
            sw.Close() 'Closes opened file
            MsgBox("A new sales file has been created at " & FilePath, vbInformation, "New file created!") 'Gives notification that a new sales file has been created

        End If

        MainWindowClearAll() 'Resets all variables and textboxes

    End Sub

    Private Function ReadSaleNumberFromFile() ' Gets most recent sales number from the sales file
        Dim SaleData() As String = File.ReadAllLines(FilePath) ' This reads all data from the sales file
        Dim CurrentSaleNumber As Integer = 0 ' Sets current sale number to 0

        If SaleData.Length > 1 Then ' Tests to see if there is more than one line in the sales file (there will be a header row)

            Dim LastSaleNumber As String = Trim(Mid(SaleData(SaleData.Length - 1), 21, 5)) 'Takes the sale number from the last line (most recent sale) of the file and removes spaces

            If Integer.TryParse(LastSaleNumber, New Integer) Then 'Tests to see if the sales number is an integer to prevent errors
                CurrentSaleNumber = LastSaleNumber 'Returns the last sale number (1 will be added to it when finish sale is clicked)
            End If

        End If

        Return CurrentSaleNumber 'Returns sale number, which will be 0 unless the sales file has a more recent sale number

    End Function

    ' **************************************************INPUTS**************************************************

    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles PriceTextBox.Click, ISBNTextBox.Click, QuantityTextBox.Click ' Changes selected field on click

        Select Case sender.Name ' Selects the textbox that was clicked on

            Case ISBNTextBox.Name
                ISBNTextBox.Select(Trim(ISBNTextBox.Text).Length, 0) 'Sets cursor to the end of data in the textbox (with spaces removed)
                InputMode = "ISBN" 'Sets input mode to ISBN
            Case PriceTextBox.Name
                PriceTextBox.Select(PriceTextBox.Text.Length + 1, 0) 'Sets cursor to the "end" of the right-to-left textbox
                InputMode = "PRICE" 'Sets input mode to price
            Case QuantityTextBox.Name
                QuantityTextBox.Select(Trim(QuantityTextBox.Text).Length, 0) 'Sets cursor to the end of data in the textbox (with spaces removed)
                InputMode = "QUANTITY" 'Sets input mode to quantity

        End Select

    End Sub

    Private Sub NumButton_Click(sender As Object, e As EventArgs) Handles NumButton9.Click, NumButton8.Click, NumButton7.Click, NumButton6.Click, NumButton5.Click, NumButton4.Click, NumButton3.Click, NumButton2.Click, NumButton1.Click, NumButton0.Click 'Enters keypad into selected field

        Select Case InputMode 'Detects which of the boxes was last clicked on

            Case "ISBN"
                If Trim(ISBNTextBox.Text).Length < 13 Then 'If ISBN field is not full
                    ISBNTextBox.Text = ISBNTextBox.Text & Mid(sender.Name, 10, 1) ' Add key pressed to the textbox
                End If

            Case "PRICE"
                If PriceTextBox.Text(0) = "0" Then 'If first digit is a 0, then more numbers can still be added
                    PriceTextBox.Text = PriceTextBox.Text.Substring(1, 3) & Mid(sender.Name, 10, 1) ' Removes first 0 and adds key pressed to the textbox
                End If

            Case "QUANTITY"
                If Trim(QuantityTextBox.Text).Length < 2 Then 'If quantity field is not full
                    QuantityTextBox.Text = QuantityTextBox.Text & Mid(sender.Name, 10, 1) ' Add key pressed to the textbox
                End If

        End Select

    End Sub

    Private Sub PriceTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles PriceTextBox.KeyUp 'Handles adding zeroes when typing in price text box

        While PriceTextBox.Text.Trim().Length <> 4  'If the length of the pricebox is less than 4, then numbers have been deleted
            PriceTextBox.Text = "0" & PriceTextBox.Text 'Adds an 0 in front to keep the price at 4 characters
        End While

    End Sub

    Private Sub PriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PriceTextBox.KeyDown 'Handles removing zeroes when typing in price text box
        If PriceTextBox.Text.Length = 4 Then 'If the length is 4 and a key is pressed, a number needs to be added

            If PriceTextBox.Text(0) = "0" Then 'If the first number is 0, then there is still space for a character to be added
                PriceTextBox.Text = PriceTextBox.Text.Substring(1, PriceTextBox.Text.Length - 1) 'Removes the 0, as this is a keydown event the key pressed will then be added
            End If

        End If

    End Sub


    ' **************************************************UTILITY BUTTONS**************************************************

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click 'Empties selected field when clear button pressed

        Select Case InputMode 'Selects which field to be emptied

            Case "ISBN"
                ISBNTextBox.Text = "" 'Resets to default
            Case "PRICE"
                PriceTextBox.Text = "0000" 'Resets to default
            Case "QUANTITY"
                QuantityTextBox.Text = "01" 'Resets to default

        End Select

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click 'Removes last character of selected field when delete button pressed

        If InputMode = "ISBN" And Trim(ISBNTextBox.Text).Length > 0 Then 'If ISBN is selected and not empty
            ISBNTextBox.Text = Mid(ISBNTextBox.Text, 1, ISBNTextBox.Text.Length - 1) 'Removes last character from textbox

        ElseIf InputMode = "PRICE" And Trim(PriceTextBox.Text).Length > 0 Then 'If price is selected and not empty
            PriceTextBox.Text = "0" & PriceTextBox.Text.Substring(0, PriceTextBox.Text.Length - 1) 'Removes last character from textbox and adds 0 to front

        ElseIf InputMode = "QUANTITY" And Trim(QuantityTextBox.Text).Length > 0 Then 'If quantity is selected and not empty
            QuantityTextBox.Text = Mid(QuantityTextBox.Text, 1, QuantityTextBox.Text.Length - 1) 'Removes last character from textbox

        End If

    End Sub

    Private Sub AbandonSale_Click(sender As Object, e As EventArgs) Handles AbandonSale.Click ' Clears all if sale is abandoned
        MainWindowClearAll() ' Resets all variables and textboxes to default
    End Sub

    Public Sub MainWindowClearAll() 'Resets all items in main window to default

        ISBNTextBox.Text = "" 'Sets the textboxes to their default values
        PriceTextBox.Text = "0000"
        QuantityTextBox.Text = "01"
        ItemsSoldListBox.Items.Clear()

        SaleTotal = 0.00 'Sets global variables to their default values
        SaleNumber = ReadSaleNumberFromFile()
        CurrentSale = New List(Of Item)

        InputMode = "ISBN" 'Selects ISBN text box
        ISBNTextBox.Select()

    End Sub

    ' **************************************************TRANSACTION PROCESSING**************************************************

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click 'Adds the data in the fields to the listbox, and current sale list

        If Trim(ISBNTextBox.Text).Length >= 10 And Trim(PriceTextBox.Text).Length > 0 And Trim(QuantityTextBox.Text).Length > 0 Then 'If all textboxes have data and isbn is >= 10

            Dim TidiedPrice As Double = CDbl(PriceTextBox.Text) / 100 'Converts data in textbox to a decimal and divides by 100

            Dim Divider As String = " | " 'Creates a divider to separate data in listbox

            CurrentSale.Add(New Item With {.ISBN = ISBNTextBox.Text, .Price = TidiedPrice, .Quantity = QuantityTextBox.Text}) 'Adds the current item to the current sale list
            ItemsSoldListBox.Items.Add(LSet(ISBNTextBox.Text, 13) & Divider & LSet(TidiedPrice, 5) & Divider & LSet(QuantityTextBox.Text, 2)) 'Displays the current item in the listbox

            ISBNTextBox.Text = "" 'Resets textboxes to default values
            PriceTextBox.Text = "0000"
            QuantityTextBox.Text = "01"

            InputMode = "ISBN" ' Selects ISBN text box
            ISBNTextBox.Select()

        End If

    End Sub

    Private Sub TakePaymentButton_Click(sender As Object, e As EventArgs) Handles TakePaymentButton.Click ' Calculates the total and opens payment window
        SaleTotal = 0 'Sets saletotal to 0 before it is calculated
        For Each ItemBought In CurrentSale ' Runs through all items in the current sale
            SaleTotal += ItemBought.Price * ItemBought.Quantity ' Calculates sale total
        Next

        PaymentWindow.Show() ' Opens payment window

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click 'Closes and returns to correct screen
        Select Case LoginWindow.CurrentUser.AccessLevel ' Selects access level of current user
            Case LoginWindow.UserAccessLevel.Manager ' If manager, return to manager window
                Me.Close()
                ManagerWindow.Show()
            Case LoginWindow.UserAccessLevel.User 'If user, return to user window
                Me.Close()
                UserWindow.Show()
            Case Else 'Else, return to login window
                Me.Close()
                LoginWindow.Show()
        End Select
    End Sub


    ' **************************************************PRICE LOOKUP**************************************************

    Private Sub PriceLookupButton_Click(sender As Object, e As EventArgs) Handles PriceLookupButton.Click 'When lookup button clicked, search Bertrams website

        If Trim(ISBNTextBox.Text).Length >= 10 And Trim(ISBNTextBox.Text).Length <= 13 Then 'Checks if data in textbox is the right ISBN length
            WebCrawler.Navigate("https://www.bertrams.com/BertWeb/public/itemLookup.do?method=list&ITEM=" & Trim(ISBNTextBox.Text)) 'Navigates to the bertrams webpage for the book
        End If

    End Sub

    Private Sub WebCrawler_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebCrawler.DocumentCompleted ' Runs when webpage is loaded
        If e.Url = WebCrawler.Url Then 'Checks if webpage has loaded - if full url equals current url
            Dim ListOfDivs As HtmlElementCollection = WebCrawler.Document.GetElementsByTagName("div") 'Finds all HTML divs and adds them to a list
            Dim FoundPrice As String = "" 'Creates a blank string for the price

            For Each element As HtmlElement In ListOfDivs 'Runs through all the divs to find the price div
                If element.GetAttribute("classname").ToString = "col-7 priceInfo" Then 'Checks if the class of the div is the price info
                    FoundPrice = element.InnerText 'Gets the inner text of the price div
                    Exit For 'Ends loop when found
                End If
            Next

            If FoundPrice <> "" Then 'If the price is not empty (either no price, or 404 error)
                FoundPrice = FoundPrice.Substring(0, FoundPrice.Length - 5) ' Removes last 5 characters of the price (" GDP")

                If Double.TryParse(FoundPrice, New Double) Then ' Checks to see if the price is a decimal

                    If FoundPrice.Length = 4 Then 'Checks if price is 4 digits (0.00) 
                        PriceTextBox.Text = "0" & FoundPrice 'Updates price textbox with price
                    ElseIf FoundPrice.Length = 5 Then 'Checks if price is 5 digits (00.00) - greater than 99.99 will not work
                        PriceTextBox.Text = FoundPrice 'Updates price textbox with price
                    End If

                End If

            Else
                MsgBox("Item not found") 'Gives error if the book is not found
            End If

        End If

    End Sub

End Class
