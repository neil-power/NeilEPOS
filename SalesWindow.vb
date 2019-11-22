Public Class SalesWindow

    ' **************************************************ON LOAD**************************************************
    'GLOBAL VARIABLES

    Private InputMode As Mode 'Sets which box for the keypad to write to
    Public Shared CurrentSale As List(Of Item) 'Creates a list of items in the current sale
    Public Shared SaleTotal As Double ' Creates a variable for the total for the current sale


    Public Structure Item 'Creates an item structure
        Dim ISBN As String
        Dim Price As Double
        Dim Quantity As String
    End Structure

    Public Enum Mode
        ISBN
        Price
        Quantity
    End Enum

    Private Sub SalesWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Runs when form opens

        'The startup location is set in the form properties to 1024, 768 to prevent visual issue
        FormBorderStyle = FormBorderStyle.None 'No border
        StartPosition = FormStartPosition.Manual 'Manual start position
        Location = New Point(100, 50) 'Set location to inside manager/user form

        MainWindowClearAll() 'Resets all variables and textboxes

    End Sub

    ' **************************************************INPUTS**************************************************

    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles PriceTextBox.Click, ISBNTextBox.Click, QuantityTextBox.Click ' Changes selected field on click

        Select Case sender.Name ' Selects the textbox that was clicked on

            Case ISBNTextBox.Name
                ISBNTextBox.Select(Trim(ISBNTextBox.Text).Length, 0) 'Sets cursor to the end of data in the textbox (with spaces removed)
                InputMode = Mode.ISBN 'Sets input mode to ISBN
            Case PriceTextBox.Name
                PriceTextBox.Select(PriceTextBox.Text.Length + 1, 0) 'Sets cursor to the "end" of the right-to-left textbox
                InputMode = Mode.Price 'Sets input mode to price
            Case QuantityTextBox.Name
                QuantityTextBox.Select(Trim(QuantityTextBox.Text).Length, 0) 'Sets cursor to the end of data in the textbox (with spaces removed)
                InputMode = Mode.Quantity 'Sets input mode to quantity
            Case Else
                Exit Select
        End Select

    End Sub

    Private Sub NumButton_Click(sender As Object, e As EventArgs) Handles NumButton9.Click, NumButton8.Click, NumButton7.Click, NumButton6.Click, NumButton5.Click, NumButton4.Click, NumButton3.Click, NumButton2.Click, NumButton1.Click, NumButton0.Click 'Enters keypad into selected field

        Select Case InputMode 'Detects which of the boxes was last clicked on

            Case Mode.ISBN
                If Trim(ISBNTextBox.Text).Length < 13 Then 'If ISBN field is not full
                    ISBNTextBox.Text = ISBNTextBox.Text & Mid(sender.Name, 10, 1) ' Add key pressed to the textbox
                End If

            Case Mode.Price
                If PriceTextBox.Text(0) = "0" Then 'If first digit is a 0, then more numbers can still be added
                    PriceTextBox.Text = PriceTextBox.Text.Substring(1, 3) & Mid(sender.Name, 10, 1) ' Removes first 0 and adds key pressed to the textbox
                End If

            Case Mode.Quantity
                If Trim(QuantityTextBox.Text).Length < 2 Then 'If quantity field is not full
                    QuantityTextBox.Text = QuantityTextBox.Text & Mid(sender.Name, 10, 1) ' Add key pressed to the textbox
                End If

            Case Else
                Exit Select
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

            Case Mode.ISBN
                ISBNTextBox.Text = "" 'Resets to default
            Case Mode.Price
                PriceTextBox.Text = "0000" 'Resets to default
            Case Mode.Quantity
                QuantityTextBox.Text = "01" 'Resets to default
            Case Else
                Exit Select
        End Select

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click 'Removes last character of selected field when delete button pressed

        If InputMode = Mode.ISBN And Trim(ISBNTextBox.Text).Length > 0 Then 'If ISBN is selected and not empty
            ISBNTextBox.Text = Mid(ISBNTextBox.Text, 1, ISBNTextBox.Text.Length - 1) 'Removes last character from textbox

        ElseIf InputMode = Mode.Price And Trim(PriceTextBox.Text).Length > 0 Then 'If price is selected and not empty
            PriceTextBox.Text = "0" & PriceTextBox.Text.Substring(0, PriceTextBox.Text.Length - 1) 'Removes last character from textbox and adds 0 to front

        ElseIf InputMode = Mode.Quantity And Trim(QuantityTextBox.Text).Length > 0 Then 'If quantity is selected and not empty
            QuantityTextBox.Text = Mid(QuantityTextBox.Text, 1, QuantityTextBox.Text.Length - 1) 'Removes last character from textbox

        End If

    End Sub

    Private Sub AbandonSale_Click(sender As Object, e As EventArgs) Handles AbandonSale.Click ' Clears all if sale is abandoned
        MainWindowClearAll() ' Resets all variables and textboxes to default
    End Sub

    Public Sub MainWindowClearAll() 'Resets all items in main window to default

        ISBNTextBox.Clear() 'Sets the textboxes to their default values
        PriceTextBox.Text = "0000"
        QuantityTextBox.Text = "01"
        ItemsSoldListBox.Items.Clear()

        SaleTotal = 0.00 'Sets global variables to their default values

        CurrentSale = New List(Of Item)

        InputMode = Mode.ISBN 'Selects ISBN text box
        ISBNTextBox.Select()

    End Sub

    ' **************************************************TRANSACTION PROCESSING**************************************************

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click 'Adds the data in the fields to the listbox, and current sale list

        If Trim(ISBNTextBox.Text).Length >= 10 And Trim(PriceTextBox.Text).Length > 0 And Trim(QuantityTextBox.Text).Length > 0 Then 'If all textboxes have data and isbn is >= 10

            Dim TidiedPrice As Double = PriceTextBox.Text / 100 'Converts data in textbox to a decimal and divides by 100

            Dim Divider As String = " | " 'Creates a divider to separate data in listbox

            CurrentSale.Add(New Item With {.ISBN = ISBNTextBox.Text, .Price = TidiedPrice, .Quantity = QuantityTextBox.Text}) 'Adds the current item to the current sale list
            ItemsSoldListBox.Items.Add(LSet(ISBNTextBox.Text, 13) & Divider & LSet(TidiedPrice, 5) & Divider & LSet(QuantityTextBox.Text, 2)) 'Displays the current item in the listbox

            ISBNTextBox.Clear() 'Resets textboxes to default values
            PriceTextBox.Text = "0000"
            QuantityTextBox.Text = "01"

            InputMode = Mode.ISBN 'Selects ISBN text box
            ISBNTextBox.Select()

        End If

    End Sub

    Private Sub TakePaymentButton_Click(sender As Object, e As EventArgs) Handles TakePaymentButton.Click ' Calculates the total and opens payment window
        SaleTotal = 0 'Sets saletotal to 0 before it is calculated
        For Each ItemBought As Item In CurrentSale ' Runs through all items in the current sale
            SaleTotal += ItemBought.Price * ItemBought.Quantity ' Calculates sale total
        Next ItemBought

        PaymentWindow.Show() ' Opens payment window

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click 'Closes and returns to correct screen
        Close()
    End Sub


    ' **************************************************PRICE LOOKUP**************************************************

    Private Sub PriceLookupButton_Click(sender As Object, e As EventArgs) Handles PriceLookupButton.Click 'When lookup button clicked, search local database and then Bertrams website
        Dim FoundProduct As String = Product.GetProductFromID(ISBNTextBox.Text) 'Attempt to search local database
        If FoundProduct <> Nothing Then 'If product is in local database
            ShowPrice(Product.FromLine(FoundProduct).RRP)
        Else
            If Trim(ISBNTextBox.Text).Length = 13 Then 'Checks if data in textbox is the right ISBN length
                If Product.ValidateISBN(ISBNTextBox.Text) Then 'Checks if ISBN is valid
                    WebCrawler.Navigate("https://www.bertrams.com/BertWeb/public/itemLookup.do?method=list&ITEM=" & ISBNTextBox.Text) 'Navigates to the bertrams webpage for the book
                End If
            End If
        End If
    End Sub

    Private Sub WebCrawler_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebCrawler.DocumentCompleted ' Runs when webpage is loaded
        If e.Url = WebCrawler.Url Then 'Checks if webpage has loaded - if full url equals current url
            Dim ListOfDivs As HtmlElementCollection = WebCrawler.Document.GetElementsByTagName("div") 'Finds all HTML divs and adds them to a list
            Dim FoundPrice As String = "" 'Creates a blank string for the price

            For Each Element As HtmlElement In ListOfDivs 'Runs through all the divs to find the price div
                If Element.GetAttribute("classname").ToString = "col-7 priceInfo" Then 'Checks if the class of the div is the price info
                    FoundPrice = Element.InnerText 'Gets the inner text of the price div
                    Exit For 'Ends loop when found
                End If
            Next Element

            If FoundPrice <> "" Then 'If the price is not empty (either no price, or 404 error)
                FoundPrice = FoundPrice.Substring(0, FoundPrice.Length - 5) ' Removes last 5 characters of the price (" GDP")
                ShowPrice(FoundPrice)

            Else
                MessageBox.Show("Item not found") 'Gives error if the book is not found
            End If

        End If

    End Sub

    Private Sub ShowPrice(Price As String)
        If Double.TryParse(Price, New Double) Then ' Checks to see if the price is a decimal

            If Price.Length = 4 Then 'Checks if price is 4 digits (0.00) 
                PriceTextBox.Text = "0" & Price 'Updates price textbox with price
            ElseIf Price.Length = 5 Then 'Checks if price is 5 digits (00.00) - greater than 99.99 will not work
                PriceTextBox.Text = Price 'Updates price textbox with price
            End If

        End If
    End Sub

End Class