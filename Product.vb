Public Class Product
    Public Shared DesktopFilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop
    Public Shared ProductsFilePath As String = DesktopFilePath & "\" & "Products.dat"
    Public Shared ProductsIndexPath As String = DesktopFilePath & "\" & "Products.idx"

    Public Property ISBN As Integer
    Public Property Title As String
    Public Property Author As String
    Public Property RRP As Double
    Public Property Genre As String

    Public Shared Function GetProductFromID(ProductID As Integer)
        Return RandomFile.Read(ProductID, 100, ProductsFilePath, ProductsIndexPath) '100 may need to be changed
    End Function

    Public Shared Function FromLine(Line As String)
        Return New Product
    End Function

    Public Shared Sub AddNewProduct(ProductToAdd As String)
        'Dim StringProduct As String = ProductToAdd.ISBN & "," & ProductToAdd.Name & "," & ProductToAdd.Author
        RandomFile.Write(ProductToAdd, ProductsFilePath, ProductsIndexPath)
    End Sub
End Class
