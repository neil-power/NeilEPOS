Public Class ManageProductsWindow

    ' **************************************************ON LOAD**************************************************
    Private Enum ProductMode 'Mode to select what action to be taken for saving and searching
        NewProduct
        EditProduct
        DeleteProduct
        None
    End Enum

    Private Mode As ProductMode = ProductMode.None 'Sets current mode to nothing

    Private Sub ManageProductWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent glitching
        FormBorderStyle = FormBorderStyle.None 'Removes border
        StartPosition = FormStartPosition.Manual 'Prevents automatic cascade of MDI windows
        Location = New Point(100, 50) 'Sets form location to centre of Manager window
        ResetProductsWindow()
    End Sub

    Private Sub ResetProductsWindow() 'Resets all values to default

        ProductIDTextBox.Clear() 'Clear all text boxes
        TitleTextBox.Clear()
        AuthorTextBox.Clear()
        RRPTextBox.Clear()
        GenreComboBox.Items.Clear()
        Dim ListOfGenres As String() = {"Fiction", "Non-Fiction", "Other", "ADD MORE LATER"} 'Add more later
        GenreComboBox.Items.AddRange(ListOfGenres) 'Adds list of genres to combo box
        GenreComboBox.Text = "Select Genre"
        InstructionLabel.Text = "Please select which action you would like to perform."

        ProductIDTextBox.Enabled = False 'Disable all text boxes
        TitleTextBox.Enabled = False
        AuthorTextBox.Enabled = False
        RRPTextBox.Enabled = False
        GenreComboBox.Enabled = False

        SaveProductButton.Hide() 'Hide all buttons
        SearchButton.Hide()
        Mode = ProductMode.None 'Set mode to none
    End Sub

    ' **************************************************UTILITY BUTTONS**************************************************
    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles NewProductButton.Click, EditProductButton.Click, DeleteProductButton.Click, SaveProductButton.Click, CloseButton.Click, SearchButton.Click 'Handles clicks of utility buttons
        Select Case sender.Name 'Selects button pressed
            Case NewProductButton.Name 'If new product, create a new product
                ResetProductsWindow()
                Mode = ProductMode.NewProduct
                InstructionLabel.Text = "Please fill in the details for the new product and click save."
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
            Case CloseButton.Name 'If close, return to manager window
                Close() 'Close current window
            Case Else
                Exit Select
        End Select
    End Sub

    ' **************************************************NEW USERS**************************************************

    Private Sub AllowTextboxExit() 'Allows user to type in all text boxes
        TitleTextBox.Enabled = True
        ProductIDTextBox.Enabled = True
        AuthorTextBox.Enabled = True
        RRPTextBox.Enabled = True
        GenreComboBox.Enabled = True
        SaveProductButton.Show()
    End Sub

    Private Sub SaveProduct()

        If Mode = ProductMode.EditProduct Then 'If a product is being edited, the new details need to be inserted
            Dim ProductToSave As String = ProductIDTextBox.Text & "," & TitleTextBox.Text & "," & AuthorTextBox.Text & "," & RRPTextBox.Text & "," & GenreComboBox.Text
            Product.EditProduct(Product.FromLine(ProductToSave))
        ElseIf Mode = ProductMode.NewProduct Then 'If a new product is being made, they can be added at the end of the file
            Dim LineToWrite As String = ProductIDTextBox.Text & "," & TitleTextBox.Text & "," & AuthorTextBox.Text & "," & RRPTextBox.Text & "," & GenreComboBox.Text 'Verification needed
            Product.AddNewProduct(Product.FromLine(LineToWrite))
        End If

        ResetProductsWindow() 'Prevents user from entering text
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
        Dim FoundProduct As String = Product.GetProductFromID(ProductIDTextBox.Text) 'Attempt to read product from file
        If FoundProduct <> "Item not found" Then 'If read subroutine does not return "not found"

            If Mode = ProductMode.EditProduct Then 'If a product is being edited, the new details need to be inserted
                EditProduct(Product.FromLine(FoundProduct)) 'Sends product to edit to the edit subroutine

            ElseIf Mode = ProductMode.DeleteProduct Then 'If a product is being deleted, they need to be removed
                Product.RemoveProduct(Product.FromLine(FoundProduct)) 'Sends product to delete to the edit subroutine
                ResetProductsWindow()
            End If

        Else
            InstructionLabel.Text = "No products were found."
        End If
    End Sub


    ' **************************************************EDIT/DELETE PRODUCTS**************************************************

    Private Sub EditProduct(ProductToEdit As Product)
        InstructionLabel.Text = "Edit the product's details and click save"
        SearchButton.Hide()
        ProductIDTextBox.Text = ProductToEdit.ISBN
        TitleTextBox.Text = ProductToEdit.Title
        AuthorTextBox.Text = ProductToEdit.Author
        RRPTextBox.Text = ProductToEdit.RRP
        GenreComboBox.Text = ProductToEdit.Genre
        AllowTextboxExit()
    End Sub

    Private Function ArrayRemove(array As String(), index As Integer) 'Removes an item from a string array
        Dim tempList As New List(Of String)
        tempList.AddRange(array) 'Converts into list
        tempList.RemoveAt(index) 'Removes item from list
        Return tempList.ToArray 'Converts back into array
    End Function

End Class