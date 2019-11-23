Imports System.IO
Public Class RandomFile
    Public Shared Function Exists(FilePath As String) 'Returns true if file exists
        Return File.Exists(FilePath)
    End Function

    Public Shared Function Read(FieldID As Long, FilePath As String, FileIndexPath As String)
        'LOCATE ID IN INDEX FILE AND EXTRACT LOCATION AND LENGTH
        Dim Position As Integer 'Sets position to read from from file
        Dim LengthToRead As Integer
        Dim Index As String() = CSV.ReadAsArray(FileIndexPath) 'Reads index file as array. Index file will be sorted when written to and on load
        Dim FoundLine As String = BinarySearch(Index, FieldID)

        If FoundLine = Nothing Then 'If a matching line is not returned
            Return Nothing 'Item is not found
        Else
            Position = FoundLine.Split(",")(1) 'Get item position from line
            LengthToRead = FoundLine.Split(",")(2) 'Get item length from line
        End If

        'NAVIGATE TO LOCATION AND EXTRACT ITEM DETAILS
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
        'WRITE FULL ITEM TO ITEM FILE AT POSITION = LENGTH OF FILE
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

        'WRITE ITEM ID AND ITEM LOCATION TO INDEX FILE
        CSV.Append(FileIndexPath, ItemToWrite.Split(",")(0) & "," & Position & "," & bytesToWrite.Length)
        SortIndex(FileIndexPath) 'Sort index file
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

    Public Shared Sub SortIndex(FileIndexPath As String) 'Sorts index file
        Dim IndexFileContents() As String = CSV.ReadAsArray(FileIndexPath)

        'Insertion Sort
        Dim SelectedItem As String
        Dim Pointer1 As Integer 'Main pointer for unsorted list
        Dim Pointer2 As Integer 'Secondary pointer for looping through sorted list to determine insertion point

        For Pointer1 = 1 To IndexFileContents.Length - 1 'Iterate through every item in unsorted list
            SelectedItem = IndexFileContents(Pointer1) 'Select second item in unsorted list
            Pointer2 = Pointer1 - 1 'Set secondary pointer to first item in unsorted list
            While Pointer2 >= 0 'If secondary pointer is not at beginning of list
                If IndexFileContents(Pointer2) > SelectedItem Then 'Is selected item smaller than item before it, if so swap
                    IndexFileContents(Pointer2 + 1) = IndexFileContents(Pointer2) 'Set selected item with item before it
                    Pointer2 -= 1 'Move secondary pointer back
                Else
                    Exit While 'Reached start of sorted array - end loop
                End If
            End While
            IndexFileContents(Pointer2 + 1) = SelectedItem 'Complete the swap - Set item before selected item to selected item
        Next Pointer1

        CSV.ArrayOverwrite(FileIndexPath, IndexFileContents)
    End Sub

    Private Shared Function BinarySearch(IndexFile As String(), FieldID As String) 'Binary searches given array for query
        Dim LowerBound As Integer = 0 'Sets lower bound of search to beginning of array
        Dim UpperBound As Integer = IndexFile.Length - 1 'Sets upper bound of search to beginning of array
        Dim ItemFound As Boolean = False 'Item has not yet been found
        Dim Midpoint As New Integer

        Do Until ItemFound = True Or LowerBound > UpperBound 'Loops until item is found, or every element in list has been checked
            Midpoint = (UpperBound + LowerBound) / 2 'Sets midpoint to midway between bounds
            If IndexFile(Midpoint).Split(",")(0) = FieldID Then 'If field ID of array matches query
                ItemFound = True 'Item has been found
            ElseIf IndexFile(Midpoint).Split(",")(0) < FieldID Then 'If field ID is greater than item at the midpoint
                LowerBound = Midpoint + 1 'Set new lower bound to one place above midpoint
            ElseIf IndexFile(Midpoint).Split(",")(0) > FieldID Then 'If field ID is less than item at the midpoint
                UpperBound = Midpoint - 1 'Set new upper bound to one place below midpoint
            End If

        Loop

        If ItemFound Then 'If an item has been found
            Return IndexFile(Midpoint) 'Return the line with the matching ID
        Else 'If an item has not been found
            Return Nothing 'Return nothing
        End If

    End Function

End Class