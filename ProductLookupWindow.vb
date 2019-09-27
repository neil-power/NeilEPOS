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

        RandomFile.Write("978122345124,The Hunger Games,Suzanne Collins,£9.99", Product.ProductsFilePath, Product.ProductsIndexPath)
        RandomFile.Write("978645353561,Harry Potter,J.K.Rowling,£6.99", Product.ProductsFilePath, Product.ProductsIndexPath)
        RandomFile.Write("978564323565,How to VB,Pyn Wrice,£19.99", Product.ProductsFilePath, Product.ProductsIndexPath)

    End Sub

    Private Sub ResetProductLookupWindow() 'Resets all values to default

        ISBNMaskedTextBox.Clear() 'Clear all text boxes and labels
        FoundTitleLabel.Text = ""
        FoundAuthorLabel.Text = ""
        FoundPriceLabel.Text = ""
        FoundGenreLabel.Text = ""
        InstructionLabel.Text = "Please enter Product ISBN or EAN"

        FoundProductsListBox.Hide()
        FoundProductsListBox.Items.Clear() 'Empty listbox
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

    Private Sub SearchForProduct()
        FoundProductsListBox.Items.Add(Product.GetProductFromID(ISBNMaskedTextBox.Text.Trim()))
    End Sub

    Private Sub ShowProduct(ProductToShow As Product)
        SearchButton.Hide()
        FoundProductsListBox.Hide()
        ISBNMaskedTextBox.Text = ProductToShow.ISBN
        ISBNMaskedTextBox.ReadOnly = True
        FoundTitleLabel.Text = ProductToShow.Title
        FoundAuthorLabel.Text = ProductToShow.Author
        FoundPriceLabel.Text = ProductToShow.RRP
        FoundGenreLabel.Text = ProductToShow.Genre
    End Sub

    Private Sub FoundProductsListBox_DoubleClick(sender As Object, e As EventArgs) Handles FoundProductsListBox.DoubleClick
        If FoundProductsListBox.SelectedItem <> Nothing Then 'If a user is selected
            ShowProduct(Product.FromLine(FoundProductsListBox.SelectedItem)) 'Sends user to edit to the edit subroutine
        End If
    End Sub
End Class