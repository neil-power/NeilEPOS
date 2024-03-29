﻿Public Class ManageProductsWindow

    ' **************************************************ON LOAD**************************************************
    Private Enum ProductMode 'Mode to select what action to be taken for saving and searching
        NewProduct
        EditProduct
        DeleteProduct
        None
    End Enum

    Private Mode As ProductMode = ProductMode.None 'Sets current mode to nothing

    Private Sub ManageProductWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent visual issue
        LoadTheme()
        ResetProductsWindow()
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

    Private Sub MaskedTextBox_Click(sender As Object, e As EventArgs) Handles TitleTextBox.Click, ProductIDTextBox.Click, AuthorTextBox.Click
        sender.Select(sender.Text.Length, 0) 'Selects first character on click for masked text boxes
    End Sub

    Private Sub ResetProductsWindow() 'Resets all values to default

        ProductIDTextBox.Clear() 'Clear all text boxes
        TitleTextBox.Clear()
        AuthorTextBox.Clear()
        RRPTextBox.Clear()
        GenreComboBox.Items.Clear()
        GenreComboBox.Items.AddRange(Product.GenreList) 'Adds list of genres to combo box
        GenreComboBox.Text = "Select Genre"
        InstructionLabel.Text = "Please select which action you would like to perform."

        ProductIDTextBox.Enabled = False 'Disable all text boxes
        TitleTextBox.Enabled = False
        AuthorTextBox.Enabled = False
        RRPTextBox.Enabled = False
        GenreComboBox.Enabled = False

        SaveProductButton.Hide() 'Hide all buttons
        SearchButton.Hide()
        OnlineLookupButton.Hide()
        Mode = ProductMode.None 'Set mode to none
    End Sub

    ' **************************************************UTILITY BUTTONS**************************************************
    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SaveProductButton.Click, OnlineLookupButton.Click, NewProductButton.Click, EditProductButton.Click, DeleteProductButton.Click, CloseButton.Click, ClearButton.Click  'Handles clicks of utility buttons
        Select Case sender.Name 'Selects button pressed
            Case NewProductButton.Name 'If new product, create a new product
                ResetProductsWindow()
                Mode = ProductMode.NewProduct
                InstructionLabel.Text = "Please fill in the details for the new product and click save."
                OnlineLookupButton.Show()
                AllowTextboxExit()
            Case EditProductButton.Name 'If edit product, search for then edit product
                PrepareForSearch() 'Sets fields and shows search button
                Mode = ProductMode.EditProduct
            Case DeleteProductButton.Name
                PrepareForSearch() 'Sets fields and shows search button
                Mode = ProductMode.DeleteProduct
            Case SaveProductButton.Name
                SaveProduct()
            Case SearchButton.Name
                SearchForProduct()
            Case ClearButton.Name
                ResetProductsWindow()
            Case CloseButton.Name 'If close, return to manager window
                Close() 'Close current window
            Case Else
                Exit Select
        End Select
    End Sub

    ' **************************************************NEW PRODUCTS**************************************************

    Private Sub AllowTextboxExit() 'Allows user to type in all text boxes
        TitleTextBox.Enabled = True
        ProductIDTextBox.Enabled = True
        AuthorTextBox.Enabled = True
        RRPTextBox.Enabled = True
        GenreComboBox.Enabled = True
        SaveProductButton.Show()
    End Sub

    Private Sub SaveProduct()

        Dim ProductToSave As String = ProductIDTextBox.Text.Trim & CSV.Delimiter & TitleTextBox.Text.Trim & CSV.Delimiter & AuthorTextBox.Text.Trim & CSV.Delimiter & If(RRPTextBox.Text <> "", RRPTextBox.Text.Replace("£", ""), 0) & CSV.Delimiter & GenreComboBox.Text 'If RRP is blank, set price to 0, otherwise replace space with decimal
        If Product.CheckValidProduct(ProductToSave.Split(CSV.Delimiter)) Then
            If Mode = ProductMode.EditProduct Then 'If a product is being edited, the new details need to be inserted
                Product.EditProduct(Product.FromLine(ProductToSave))
            ElseIf Mode = ProductMode.NewProduct Then 'If a new product is being made, they can be added at the end of the file
                Dim FoundProduct As String = Product.GetProductFromID(ProductIDTextBox.Text) 'Attempt to read product from file
                If FoundProduct = Nothing Then 'If an existing product is not found
                    Product.AddNewProduct(Product.FromLine(ProductToSave))
                Else
                    Dim ConflictDisplay As New DialogBox("Product already exists", "A product with ID " & ProductIDTextBox.Text & " already exists." & Environment.NewLine & "Use the Edit Product button to change its details," & Environment.NewLine & "or the Delete Product button to remove it.", "OK")
                    ConflictDisplay.ShowDialog()
                End If

            End If

                ResetProductsWindow() 'Prevents user from entering text
        End If
    End Sub

    ' **************************************************VIEW USERS**************************************************
    Private Sub PrepareForSearch() 'Sets fields and shows search button
        ResetProductsWindow()
        InstructionLabel.Text = "Please fill in the ID for the product and click search."
        TitleTextBox.Enabled = False 'Allows user to type in all text boxes except password for searching
        ProductIDTextBox.Enabled = True
        ProductIDTextBox.ReadOnly = False
        AuthorTextBox.Enabled = False
        GenreComboBox.Enabled = False
        SearchButton.Show()
    End Sub


    Private Sub SearchForProduct()
        If ProductIDTextBox.Text.Trim.Length >= 10 Then 'If the ID is 10 or more characters
            If Not ProductIDTextBox.Text.Trim.Contains(" ") Then 'If the ID does not contain spaces
                Dim FoundProduct As String = Product.GetProductFromID(ProductIDTextBox.Text) 'Attempt to read product from file
                If FoundProduct <> Nothing Then 'If read subroutine does not return "not found"

                    If Mode = ProductMode.EditProduct Then 'If a product is being edited, the new details need to be inserted
                        EditProduct(Product.FromLine(FoundProduct)) 'Sends product to edit to the edit subroutine

                    ElseIf Mode = ProductMode.DeleteProduct Then 'If a product is being deleted, they need to be removed
                        Product.RemoveProduct(Product.FromLine(FoundProduct)) 'Sends product to delete to the edit subroutine
                        ResetProductsWindow()
                    End If

                Else
                    InstructionLabel.Text = "No products were found."
                End If
            Else
                InstructionLabel.Text = "Product ID must not contain spaces."
            End If
        Else
            InstructionLabel.Text = "Product ID must be between 10 and 13 characters long."
        End If
    End Sub


    ' **************************************************EDIT/DELETE PRODUCTS**************************************************

    Private Sub EditProduct(ProductToEdit As Product)
        InstructionLabel.Text = "Edit the product's details and click save"
        SearchButton.Hide()
        ProductIDTextBox.Text = ProductToEdit.ISBN
        TitleTextBox.Text = ProductToEdit.Title
        AuthorTextBox.Text = ProductToEdit.Author
        RRPTextBox.Text = ProductToEdit.RRP.ToString("00.00")
        GenreComboBox.Text = ProductToEdit.Genre
        AllowTextboxExit()
    End Sub

    Private Function ArrayRemove(array As String(), index As Integer) 'Removes an item from a string array
        Dim TempList As New List(Of String)
        TempList.AddRange(array) 'Converts into list
        TempList.RemoveAt(index) 'Removes item from list
        Return TempList.ToArray 'Converts back into array
    End Function


    ' **************************************************ONLINE LOOKUP**************************************************

    Private Sub OnlineLookupButton_Click(sender As Object, e As EventArgs) Handles OnlineLookupButton.Click
        If Trim(ProductIDTextBox.Text).Length = 13 Then 'Checks if data in textbox is the right ISBN length
            If Not Trim(ProductIDTextBox.Text).Contains(" ") Then 'If the ID does not contain spaces
                If ProductIDTextBox.Text.Substring(0, 3) = "978" And Product.ValidateISBN(ProductIDTextBox.Text) Then 'Checks if ISBN is valid
                    WebCrawler.Navigate("https://www.bertrams.com/BertWeb/public/itemLookup.do?method=list&ITEM=" & ProductIDTextBox.Text) 'Navigates to the bertrams webpage for the book
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

            Dim FoundProduct As New Product With {.ISBN = Trim(ProductIDTextBox.Text)}  'Creates a blank product

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
                EditProduct(FoundProduct) 'Displays the found product
            Else
                InstructionLabel.Text = "Unable to find product"
            End If

        End If

    End Sub

End Class