Public Class ProductLookupWindow

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

        ISBNMaskedTextBox.Clear() 'Clear all text boxes and labels
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
        If FoundProduct <> "Item not found" Then 'Product lookup will return not found
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
End Class