Public Class Product
    Public Shared ProductsFilePath As String = CSV.MainDirectoryFilePath & "Products.dat"
    Public Shared ProductsIndexPath As String = CSV.MainDirectoryFilePath & "Products.idx"

    Public Property ISBN As Long
    Public Property Title As String
    Public Property Author As String
    Public Property RRP As Double
    Public Property Genre As String

    Public Shared Function GetProductFromID(ProductID As Long)
        Return RandomFile.Read(ProductID, ProductsFilePath, ProductsIndexPath)
    End Function

    Public Shared Function FromLine(Line As String) 'Converts from line in file to product data type
        Dim SplitLine As String() = Line.Split(",") 'Splits line on commas
        Return New Product With {.ISBN = SplitLine(0), .Title = SplitLine(1), .Author = SplitLine(2), .RRP = SplitLine(3), .Genre = SplitLine(4)} 'Adds product on line to product structure
    End Function

    Public Shared Function ToLine(ProductToConvert As Product)
        Return ProductToConvert.ISBN & "," & ProductToConvert.Title & "," & ProductToConvert.Author & "," & ProductToConvert.RRP & "," & ProductToConvert.Genre
    End Function
    Public Shared Sub AddNewProduct(ProductToAdd As Product)
        RandomFile.Write(ToLine(ProductToAdd), ProductsFilePath, ProductsIndexPath)
    End Sub

    Public Shared Sub EditProduct(ProductToEdit As Product)
        RandomFile.Replace(ProductToEdit.ISBN, ToLine(ProductToEdit), ProductsFilePath, ProductsIndexPath)
    End Sub

    Public Shared Sub RemoveProduct(ProductToEdit As Product)
        RandomFile.Delete(ProductToEdit.ISBN, ProductsIndexPath)
    End Sub
End Class
