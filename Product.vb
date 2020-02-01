Public Class Product
    Public Shared ProductsFilePath As String = CSV.MainDirectoryFilePath & "Products.dat"
    Public Shared ProductsIndexPath As String = CSV.MainDirectoryFilePath & "Products.idx"

    Public Shared WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, Date.Today) 'Gets week number

    Public Shared DailySalesFilePath As String = CSV.MainDirectoryFilePath & Date.Today.ToString("yyyy-MM-dd") & " DAILY SALES.csv" ' Desktop and current date for file to save to
    Public Shared WeeklySalesFilePath As String = CSV.MainDirectoryFilePath & Date.Now.Year & " " & WeekNumber & " WEEKLY SALES.csv" ' Sets week number and year for file to save to on desktop


    Public Property ISBN As Long
    Public Property Title As String
    Public Property Author As String
    Public Property RRP As Decimal
    Public Property Genre As String

    Public Shared ReadOnly GenreList As String() = {"General Fiction", "Children's Fiction", "General Non-Fiction", "Children's Non-Fiction", "Education and Reference", "Biography and Memoir", "Other"}

    Public Shared Function CheckValidProduct(Product As String())
        'Input mask limits ID to 13 digits and numeric characters
        'Input mask limits RRP to price between 00.00 and 99.99
        'Input mask limits author to 20 alphabetical characters
        'Input mask limits title to 20 alphanumeric characters
        If Product(0).Length >= 10 Then 'If the ID is 10 or more characters
            If Not Product(0).Contains(" ") Then 'If the ID does not contain spaces
                If If(Product(0).Substring(0, 3) = "978" And Product(0).Length = 13, ValidateISBN(Product(0)), True) Then 'If ID begins with 978 and is 13 chars, validate, else move on to next check
                    If Product(1).Length >= 2 Then 'If the title is at least 2 characters
                        If Product(2).Length >= 2 Then 'If the author is at least 2 characters
                            If Product(4) <> "" Then 'If the genre is not blank
                                Return True
                            Else
                                ManageProductsWindow.InstructionLabel.Text = "Please select a genre"
                            End If
                        Else
                            ManageProductsWindow.InstructionLabel.Text = "The author must be between 2 and 40 characters"

                        End If
                    Else
                        ManageProductsWindow.InstructionLabel.Text = "The title must be between 2 and 40 characters"
                    End If

                Else
                    ManageProductsWindow.InstructionLabel.Text = "The Product ID is not a valid ISBN."
                End If
            Else
                ManageProductsWindow.InstructionLabel.Text = "Product ID must not contain spaces"
            End If
        Else
            ManageProductsWindow.InstructionLabel.Text = "Product ID must be between 10 and 13 characters long."
        End If
        Return False
    End Function

    Public Shared Function ValidateISBN(ISBN As String)

        Dim Sum As Integer = 0
        For i = 0 To ISBN.Length - 2 'First 12 digits (13th is check digit)
            If i Mod 2 = 0 Then 'If digit position is even, add to sum
                Sum += Val(ISBN(i)) 'If digit position is odd, multiply by 3 and add to sum
            Else
                Sum += Val(ISBN(i)) * 3 'If digit position is even, add to sum
            End If
        Next
        Dim CheckDigit As Integer = Sum Mod 10 'Calculate mod 10 of check digit
        If CheckDigit <> 0 Then 'Subtract check digit from 10 if non-zero
            CheckDigit = 10 - CheckDigit
        End If

        If CheckDigit.ToString = ISBN(12) Then 'Check digit should be last digit of ISBN
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function GetProductFromID(ProductID As Long)
        Return RandomFile.Read(ProductID, ProductsFilePath, ProductsIndexPath)
    End Function

    Public Shared Function FromLine(Line As String) 'Converts from line in file to product data type
        Dim SplitLine As String() = Line.Split(CSV.Delimiter) 'Splits line on delimiter character
        Return New Product With {.ISBN = SplitLine(0), .Title = SplitLine(1), .Author = SplitLine(2), .RRP = SplitLine(3), .Genre = SplitLine(4)} 'Adds product on line to product structure
    End Function

    Public Shared Function ToLine(ProductToConvert As Product)
        Return ProductToConvert.ISBN & CSV.Delimiter & ProductToConvert.Title & CSV.Delimiter & ProductToConvert.Author & CSV.Delimiter & ProductToConvert.RRP & CSV.Delimiter & ProductToConvert.Genre
    End Function
    Public Shared Sub AddNewProduct(ProductToAdd As Product)
        RandomFile.Write(ToLine(ProductToAdd), ProductsFilePath, ProductsIndexPath)
    End Sub

    Public Shared Sub EditProduct(ProductToEdit As Product)
        RandomFile.Replace(ProductToEdit.ISBN, ToLine(ProductToEdit), ProductsFilePath, ProductsIndexPath)
    End Sub

    Public Shared Sub RemoveProduct(ProductToEdit As Product)
        Dim ConfirmDelete As New DialogBox("Do you want to delete the selected product?", "Product ID: " & ProductToEdit.ISBN & Environment.NewLine & "Title: " & ProductToEdit.Title & Environment.NewLine & "Author: " & ProductToEdit.Author, "Yes", "No")
        If ConfirmDelete.ShowDialog() = DialogResult.Yes Then 'Confirms product deletion
            RandomFile.Delete(ProductToEdit.ISBN, ProductsIndexPath)
        End If
    End Sub
End Class