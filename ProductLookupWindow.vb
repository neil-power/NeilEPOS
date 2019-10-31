﻿Public Class ProductLookupWindow

    ' **************************************************ON LOAD**************************************************
    Private Sub ProductLookupWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent glitching
        FormBorderStyle = FormBorderStyle.None 'Removes border
        StartPosition = FormStartPosition.Manual 'Prevents automatic cascade of MDI windows
        Location = New Point(100, 50) 'Sets form location to centre of Manager/User window
        ResetProductLookupWindow()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ''''''''''''''FOR TESTING 

        RandomFile.Write("978122345124,The Hunger Games,Suzanne Collins,£9.99,Fiction", Product.ProductsFilePath, Product.ProductsIndexPath)
        RandomFile.Write("978645353561,Harry Potter,J.K.Rowling,£6.99,Fiction", Product.ProductsFilePath, Product.ProductsIndexPath)
        RandomFile.Write("978564323565,How to VB,Pyn Wrice,£19.99,Computer Science", Product.ProductsFilePath, Product.ProductsIndexPath)

    End Sub

    Private Sub ResetProductLookupWindow() 'Resets all values to default
        SearchButton.Show()
        ISBNMaskedTextBox.Clear() 'Clear all text boxes and labels
        ISBNMaskedTextBox.ReadOnly = False
        FoundTitleLabel.Text = ""
        FoundAuthorLabel.Text = ""
        FoundPriceLabel.Text = ""
        FoundGenreLabel.Text = ""
        InstructionLabel.Text = "Please enter Product ISBN or EAN"

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
        Dim FoundProduct As String = Product.GetProductFromID(ISBNMaskedTextBox.Text.Trim()) 'Gets product based on ID from master file
        If FoundProduct <> Nothing Then 'Product lookup will return not found
            InstructionLabel.Text = "Product found" 'Change instruction label
            ShowProduct(Product.FromLine(FoundProduct)) 'Display product on form
        Else
            InstructionLabel.Text = "Item not found" 'Notifies user that product was not found
        End If
    End Sub

    Private Sub ShowProduct(ProductToShow As Product) 'Displays all product details on the form
        SearchButton.Hide()
        ISBNMaskedTextBox.Text = ProductToShow.ISBN
        ISBNMaskedTextBox.ReadOnly = True
        FoundTitleLabel.Text = ProductToShow.Title
        FoundAuthorLabel.Text = ProductToShow.Author
        FoundPriceLabel.Text = ProductToShow.RRP
        FoundGenreLabel.Text = ProductToShow.Genre
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetProductLookupWindow()
    End Sub

    ' **************************************************ONLINE LOOKUP**************************************************

    Private Sub OnlineLookupButton_Click(sender As Object, e As EventArgs) Handles OnlineLookupButton.Click
        If Trim(ISBNMaskedTextBox.Text).Length >= 10 And Trim(ISBNMaskedTextBox.Text).Length <= 13 Then 'Checks if data in textbox is the right ISBN length
            WebCrawler.Navigate("https://www.bertrams.com/BertWeb/public/itemLookup.do?method=list&ITEM=" & ISBNMaskedTextBox.Text) 'Navigates to the bertrams webpage for the book
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
                    FoundProduct.Author = Element.InnerText.Substring(12) 'Gets the inner text of the author div, without the first 12 characters ("By author: ")
                End If
                'RRP
                If Element.GetAttribute("classname").ToString = "col-7 priceInfo" Then 'Checks if the class of the element is the price info
                    FoundProduct.RRP = Element.InnerText.Substring(0, Element.InnerText.Length - 5) 'Gets the inner text of the price div, without the last 5 characters (" GDP")
                End If

            Next Element

            If FoundProduct.RRP <> Nothing And FoundProduct.Author <> Nothing And FoundProduct.Title <> Nothing Then 'Checks if a product was found
                ShowProduct(FoundProduct) 'Displays the found product
            Else
                MessageBox.Show("Unable to find product")
            End If

        End If

    End Sub


End Class