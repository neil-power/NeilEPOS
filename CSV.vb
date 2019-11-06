Imports System.IO 'Imports libraries needed for reading and writing files
Public Class CSV

    ' **************************************************FILE PATHS**************************************************

    Public Shared MainDirectoryFilePath = My.Computer.FileSystem.SpecialDirectories.Desktop & "\NeilEPOS Data\"

    Public Shared WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, Date.Today) 'Gets week number

    Public Shared UserFilePath As String = MainDirectoryFilePath & "NeilEPOSUsers.csv" 'Location of users file
    Public Shared DailySalesFilePath As String = MainDirectoryFilePath & Date.Today.ToString("yyyy-MM-dd") & " DAILY SALES.csv" ' Desktop and current date for file to save to
    Public Shared WeeklySalesFilePath As String = MainDirectoryFilePath & Date.Now.Year & " " & WeekNumber & " WEEKLY SALES.csv" ' Sets week number and year for file to save to on desktop

    Public Shared Sub CheckMainDirectoryExists() 'Checks if the main directory folder exists, if not, one is created
        If Not Directory.Exists(MainDirectoryFilePath) Then
            Try
                Directory.CreateDirectory(MainDirectoryFilePath)
            Catch ThrownException As Exception
                ErrorHandling.Warn(ThrownException, MainDirectoryFilePath)
            End Try
        End If
    End Sub

    Public Shared Function DirectoryExists(DirectoryPath As String) 'Checks if the directory exists
        Return Directory.Exists(DirectoryPath)
    End Function

    ' **************************************************READING FROM FILES**************************************************

    Public Shared Function ReadAsArray(FilePath As String) 'Returns entire file as string array
        Try
            Return File.ReadAllLines(FilePath)
        Catch ThrownException As Exception
            ErrorHandling.Warn(ThrownException, FilePath)
            Return New String() {} 'Returns empty string if an error occurs
        End Try
    End Function

    Public Shared Function Exists(FilePath As String) 'Returns true if file exists
        Return File.Exists(FilePath)
    End Function

    ' **************************************************WRITING TO FILES**************************************************

    Public Shared Sub Overwrite(FilePath As String, DataToWrite As String) 'Overwrites file with specific data string
        Try
            My.Computer.FileSystem.WriteAllText(FilePath, DataToWrite, False)
        Catch ThrownException As Exception
            ErrorHandling.Warn(ThrownException, FilePath)
        End Try
    End Sub


    Public Shared Sub ArrayOverwrite(FilePath As String, DataToWrite As String()) 'Overwrites file with specific data array
        Try
            File.WriteAllLines(FilePath, DataToWrite)
        Catch ThrownException As Exception
            ErrorHandling.Warn(ThrownException, FilePath)
        End Try
    End Sub

    Public Shared Sub Append(FilePath As String, DataToWrite As String) 'Appends string line to file
        Try
            My.Computer.FileSystem.WriteAllText(FilePath, DataToWrite & Environment.NewLine, True)
        Catch ThrownException As Exception
            ErrorHandling.Warn(ThrownException, FilePath)
        End Try
    End Sub

    Public Shared Sub Replace(FilePath As String, LineToReplaceID As Integer, NewLine As String) 'Replaces line starting with specified ID
        Dim FileContents() As String = ReadAsArray(FilePath) 'Gets entire contents of specified file
        For i = 0 To UBound(FileContents) 'Runs through each line
            Dim Line As String() = FileContents(i).Split(",") 'Splits line on commas
            If Line(0) = LineToReplaceID Then 'If ID matches with line to edit ID
                FileContents(i) = NewLine 'Replace line with edit
                ArrayOverwrite(FilePath, FileContents)
            End If
        Next
    End Sub

    Public Shared Function RemoveFromArray(Array As String(), Index As Integer) 'Removes an item from a string array
        Dim TempList As New List(Of String)
        TempList.AddRange(Array) 'Converts into list
        TempList.RemoveAt(Index) 'Removes item from list
        Return TempList.ToArray 'Converts back into array
    End Function

End Class
