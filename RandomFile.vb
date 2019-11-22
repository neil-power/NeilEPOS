Imports System.IO
Public Class RandomFile
    Public Shared Function Exists(FilePath As String) 'Returns true if file exists
        Return File.Exists(FilePath)
    End Function

    Public Shared Function Read(FieldID As Long, FilePath As String, FileIndexPath As String)
        'LOCATE ID IN INDEX FILE AND EXTRACT LOCATION AND LENGTH
        Dim Position As Integer = 0 'Sets position to read from from file
        Dim LengthToRead As Integer = 0
        Dim Index As String() = CSV.ReadAsArray(FileIndexPath) 'Reads index file as array
        Array.Sort(Index) 'Sorts index file - REPLACE WITH SORT ALGORITHM
        For Each line As String In Index 'Searches for matching product ID - REPLACE WITH BETTER SEARCH
            If FieldID = line.Split(",")(0) Then 'If first line is equivalent to field id
                Position = line.Split(",")(1) 'Set position to the position stored in the index file
                LengthToRead = line.Split(",")(2) 'Set length to the length stored in the index file
            End If
        Next

        If LengthToRead = 0 Then 'If a length to read is not returned
            Return Nothing 'Item is not found
        End If

        'NAVIGATE TO LOCATION AND EXTRACT PRODUCT DETAILS
        Try
            Using fs As New FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite) 'Creates new file stream to directly read from file
                Dim bytesToRead(LengthToRead) As Byte 'Creates byte array to store read text
                fs.Seek(Position, SeekOrigin.Begin) 'Navigates to position
                fs.Read(bytesToRead, 0, LengthToRead) 'Reads array of bytes from position
                Dim FinalText As String = Text.Encoding.UTF8.GetString(bytesToRead) 'Converts from bytes to string
                FinalText = FinalText.Replace(vbNullChar, "") 'Removes any null characters
                Return FinalText 'Returns read text
            End Using
        Catch ThrownException As Exception
            ErrorHandling.Warn(ThrownException, FilePath)
            Return "" 'Returns an empty string if error occurs
        End Try

    End Function

    Public Shared Sub Write(ItemToWrite As String, FilePath As String, FileIndexPath As String)

        Dim Position As Integer
        'WRITE FULL PRODUCT TO PRODUCTS FILE AT POSITION = LENGTH OF FILE
        Dim bytesToWrite() As Byte = Text.Encoding.UTF8.GetBytes(ItemToWrite)
        Try
            Using fs As New FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                Position = fs.Length
                fs.Seek(Position, SeekOrigin.Begin) 'Offset is location to begin writing or reading
                fs.Write(bytesToWrite, 0, bytesToWrite.Length) 'Offset is where to start from array, Count is no of bytes from array to write
            End Using
        Catch ThrownException As Exception
            ErrorHandling.Warn(ThrownException, FilePath)
        End Try

        'Write ISBN And File LOCATION TO INDEX FILE
        CSV.Append(FileIndexPath, ItemToWrite.Split(",")(0) & "," & Position & "," & bytesToWrite.Length)

    End Sub

    Public Shared Sub Delete(FieldID As Long, FileIndexPath As String, Confirm As Boolean) 'Remove item from indexed file
        Dim IndexFileContents() As String = CSV.ReadAsArray(FileIndexPath) 'Gets entire contents of index file
        For i = 0 To UBound(IndexFileContents) 'Runs through each line
            If FieldID = IndexFileContents(i).Split(",")(0) Then 'If item ID matches field ID
                If Confirm = True Then 'If user is deleting item, confirm
                    If InputBox("Please type 'YES' to confirm deletion of item " & IndexFileContents(i).Split(",")(0)) = "YES" Then 'Confirms item deletion
                        CSV.ArrayOverwrite(FileIndexPath, CSV.RemoveFromArray(IndexFileContents, i)) 'Overwrites file with new list of products
                    End If
                ElseIf Confirm = False Then 'If system is deleting item, do not confirm
                    CSV.ArrayOverwrite(FileIndexPath, CSV.RemoveFromArray(IndexFileContents, i)) 'Overwrites file with new list of products
                End If

            End If

        Next
    End Sub

    Public Shared Sub Replace(FieldID As String, NewItemToWrite As String, FilePath As String, FileIndexPath As String)
        Delete(FieldID, FileIndexPath, False) 'Remove ID from index file, does not confirm
        Write(NewItemToWrite, FilePath, FileIndexPath) 'Write new product details and add new index to file
    End Sub

End Class