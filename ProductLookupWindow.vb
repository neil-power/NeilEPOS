Public Class ProductLookupWindow

    ' **************************************************ON LOAD**************************************************
    Private Sub ProductLookupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent visual issue
        LoadTheme()
        ResetProductLookupWindow()
    End Sub

    Private Sub LoadTheme() 'GUI setup
        FormBorderStyle = FormBorderStyle.None 'Removes border
        StartPosition = FormStartPosition.Manual 'Prevents automatic cascade of MDI windows
        Location = New Point(150, 75) 'Sets form location to centre of Manager/User window

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
            ElseIf TypeOf Ctl Is Label Then 'If control is label
                Dim CurrentLabel As Label = TryCast(Ctl, Label)
                CurrentLabel.Font = StartupWindow.LabelFont
                CurrentLabel.ForeColor = StartupWindow.ForegroundColor
            End If
        Next Ctl

    End Sub

    Private Sub MaskedTextBox_Click(sender As Object, e As EventArgs) Handles ISBNMaskedTextBox.Click
        sender.Select(sender.Text.Length, 0) 'Selects first character on click for masked text boxes
    End Sub

    Private Sub ResetProductLookupWindow() 'Resets all values to default
        SearchButton.Show()
        OnlineLookupButton.Show()
        ISBNMaskedTextBox.Clear() 'Clear all text boxes and labels
        ISBNMaskedTextBox.ReadOnly = False
        FoundTitleLabel.Text = ""
        FoundAuthorLabel.Text = ""
        FoundPriceLabel.Text = ""
        FoundGenreLabel.Text = ""
        InstructionLabel.Text = "Please enter Product ISBN or EAN:"
    End Sub

    ' **************************************************UTILITY BUTTONS**************************************************
    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click, SearchButton.Click 'Handles clicks of utility buttons
        Select Case sender.Name 'Selects button pressed
            Case SearchButton.Name
                SearchForProduct()
            Case CloseButton.Name 'If close, return to manager window
                Close() 'Close current window
            Case Else
                Exit Select
        End Select
    End Sub


    ' **************************************************VIEW PRODUCTS**************************************************

    Private Sub SearchForProduct() 'Searches for product based on ID
        If Trim(ISBNMaskedTextBox.Text).Length >= 10 Then 'If the ID is 10 or more characters
            If Not Trim(ISBNMaskedTextBox.Text).Contains(" ") Then 'If the ID does not contain spaces
                Dim FoundProduct As String = Product.GetProductFromID(ISBNMaskedTextBox.Text.Trim()) 'Gets product based on ID from master file
                If FoundProduct <> Nothing Then 'Product lookup will return not found
                    InstructionLabel.Text = "Product found." 'Change instruction label
                    ShowProduct(Product.FromLine(FoundProduct)) 'Display product on form
                Else
                    InstructionLabel.Text = "Item not found." 'Notifies user that product was not found
                End If
            Else
                InstructionLabel.Text = "Product ID must not contain spaces."
            End If
        Else
            InstructionLabel.Text = "Product ID must be between 10 and 13 characters long."
        End If
    End Sub

    Private Sub ShowProduct(ProductToShow As Product) 'Displays all product details on the form
        SearchButton.Hide()
        OnlineLookupButton.Hide()
        ISBNMaskedTextBox.Text = ProductToShow.ISBN
        ISBNMaskedTextBox.ReadOnly = True
        FoundTitleLabel.Text = ProductToShow.Title
        FoundAuthorLabel.Text = ProductToShow.Author
        FoundPriceLabel.Text = ProductToShow.RRP.ToString("C") 'Converts to currency
        FoundGenreLabel.Text = ProductToShow.Genre
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetProductLookupWindow()
    End Sub

    ' **************************************************ONLINE LOOKUP**************************************************

    Private Sub OnlineLookupButton_Click(sender As Object, e As EventArgs) Handles OnlineLookupButton.Click
        If Trim(ISBNMaskedTextBox.Text).Length = 13 Then 'Checks if data in textbox is the right ISBN length
            If Not Trim(ISBNMaskedTextBox.Text).Contains(" ") Then 'If the ID does not contain spaces
                If ISBNMaskedTextBox.Text.Substring(0, 3) = "978" And Product.ValidateISBN(ISBNMaskedTextBox.Text) Then 'Checks if ISBN is valid
                    WebCrawler.Navigate("https://www.bertrams.com/BertWeb/public/itemLookup.do?method=list&ITEM=" & ISBNMaskedTextBox.Text) 'Navigates to the bertrams webpage for the book
                Else
                    InstructionLabel.Text = "The ISBN is invalid. Please enter a valid ISBN."
                End If
            Else
                InstructionLabel.Text = "Product ID must not contain spaces."
            End If
        Else
                InstructionLabel.Text = "The ISBN must be 13 characters for online lookup."
        End If

    End Sub


    Private Sub WebCrawler_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebCrawler.DocumentCompleted ' Runs when webpage is loaded
        If e.Url = WebCrawler.Url Then 'Checks if webpage has loaded - if full url equals current url

            Dim FoundProduct As New Product With {.ISBN = Trim(ISBNMaskedTextBox.Text)}  'Creates a blank product

            'TITLE
            Dim ListOfH1s As HtmlElementCollection = WebCrawler.Document.GetElementsByTagName("h1") 'Finds all HTML h1s and adds them to a list
            For Each Element As HtmlElement In ListOfH1s 'Runs through all the h1s to find the title h1
                If Element.GetAttribute("classname") = "b" Then 'If class of h1 is the title h1
                    FoundProduct.Title = Element.InnerText 'Add title to found product
                End If
            Next Element

            'AUTHOR AND RRP
            Dim ListOfDivs As HtmlElementCollection = WebCrawler.Document.GetElementsByTagName("div") 'Finds all HTML divs and adds them to a list
            For Each Element As HtmlElement In ListOfDivs 'Runs through all the divs to find the price and author divs
                'AUTHOR
                If Element.GetAttribute("classname").ToString = "contributorInfo col-12" Then 'Checks if the class of the element is the author
                    FoundProduct.Author = Trim(Element.InnerText.Substring(11)) 'Gets the inner text of the author div, without the first 11 characters ("By author: ")
                End If
                'RRP
                If Element.GetAttribute("classname").ToString = "col-7 priceInfo" Then 'Checks if the class of the element is the price info
                    FoundProduct.RRP = Element.InnerText.Substring(0, Element.InnerText.Length - 5) 'Gets the inner text of the price div, without the last 5 characters (" GDP")
                End If

            Next Element

            If FoundProduct.RRP <> Nothing And FoundProduct.Author <> Nothing And FoundProduct.Title <> Nothing Then 'Checks if a product was found
                ShowProduct(FoundProduct) 'Displays the found product
            Else
                InstructionLabel.Text = "Unable to find product."
            End If

        End If

    End Sub


End Class