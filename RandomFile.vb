Imports System.IO
Public Class RandomFile
    Public Shared Function Exists(FilePath As String) 'Returns true if file exists
        Return File.Exists(FilePath)
    End Function

    Public Shared Function Read(FieldID As String, LengthToRead As Integer, FilePath As String, FileIndexPath As String)
        'LOCATE ID IN MASTER FILE AND EXTRACT LOCATION
        Dim Position As Integer = -1 'Sets position to read from from file
        Dim Index As String() = File.ReadAllLines(FileIndexPath) 'Reads index file as array
        Array.Sort(Index) 'Sorts index file - REPLACE WITH SORT ALGORITHM
        For Each line In Index 'Searches for matching product ID - REPLACE WITH BETTER SEARCH
            If FieldID = line.Split(",")(0) Then 'If first line is equivalent to field id
                Position = line.Split(",")(1) 'Set position to the position stored in the index file
            End If
        Next

        If Position < 0 Then 'If a position is not returned
            Return "Item not found" 'Item is not found
        End If

        'NAVIGATE TO LOCATION AND EXTRACT PRODUCT DETAILS
        Using fs As New FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite) 'Creates new file stream to directly read from file
            Dim bytesToRead(LengthToRead) As Byte 'Creates byte array to store read text
            fs.Seek(Position, SeekOrigin.Begin) 'Navigates to position
            fs.Read(bytesToRead, 0, LengthToRead) 'Reads array of bytes from position
            Dim FinalText As String = Text.Encoding.UTF8.GetString(bytesToRead) 'Converts from bytes to string
            FinalText = FinalText.Replace(vbNullChar, "") 'Removes any null characters
            Return FinalText 'Returns read text

        End Using
    End Function

    Public Shared Sub Write(ItemToWrite As String, FilePath As String, FileIndexPath As String)

        If Not Exists(FilePath) Then ' Checks to see if product file exists
            CSV.Overwrite(FilePath, "") 'Writes a headings row to file.
            MsgBox("A new product file has been created at " & FilePath, vbInformation, "New file created!") 'Gives notification that a new sales file has been created
        End If

        If Not Exists(FileIndexPath) Then ' Checks to see if product file exists
            CSV.Overwrite(FileIndexPath, "") 'Writes a headings row to file.
            MsgBox("A new product index file has been created at " & FileIndexPath, vbInformation, "New file created!") 'Gives notification that a new sales file has been created
        End If

        Dim Position As Integer
        'WRITE FULL PRODUCT TO PRODUCTS FILE AT POSITION = LENGTH OF FILE /LENGTH OF RECORD (100)
        Using fs As New FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            Position = fs.Length
            Dim bytesToWrite() As Byte = Text.Encoding.UTF8.GetBytes(ItemToWrite)
            fs.Seek(Position, SeekOrigin.Begin) 'Offset is location to begin writing or reading
            fs.Write(bytesToWrite, 0, bytesToWrite.Length) 'Offset is where to start from array, Count is no of bytes from array to write
        End Using

        'Write ISBN And File LOCATION TO INDEX FILE
        CSV.Append(FileIndexPath, ItemToWrite.Split(",")(0) & "," & Position)

    End Sub

End Class
