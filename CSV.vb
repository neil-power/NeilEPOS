Imports System.IO 'Imports libraries needed for reading and writing files
Public Class CSV

    ' **************************************************FILE PATHS**************************************************
    Public Shared DesktopFilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop

    Public Shared WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, Date.Today) 'Gets week number

    Public Shared UserFilePath As String = DesktopFilePath & "\" & "NeilEPOSUsers.csv" 'Location of users file
    Public Shared DailySalesFilePath As String = DesktopFilePath & "\" & CStr(Date.Today).Replace("/", "-") & " DAILY SALES.csv" ' Desktop and current date for file to save to
    Public Shared WeeklySalesFilePath As String = DesktopFilePath + "\" & Date.Now.Year & " " & WeekNumber & " WEEKLY SALES.csv" ' Sets week number and year for file to save to on desktop

    ' **************************************************READING FROM FILES**************************************************

    Public Shared Function ReadAsArray(FilePath As String) 'Returns entire file as string array
        Return File.ReadAllLines(FilePath)
    End Function

    Public Shared Function Exists(FilePath As String) 'Returns true if file exists
        If File.Exists(FilePath) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' **************************************************WRITING TO FILES**************************************************

    Public Shared Sub Overwrite(FilePath As String, DataToWrite As String) 'Overwrites file with specific data string
        My.Computer.FileSystem.WriteAllText(FilePath, DataToWrite, False)
    End Sub


    Public Shared Sub ArrayOverwrite(FilePath As String, DataToWrite As String()) 'Overwrites file with specific data array
        File.WriteAllLines(FilePath, DataToWrite)
    End Sub

    Public Shared Sub Append(FilePath As String, DataToWrite As String) 'Appends string line to file
        My.Computer.FileSystem.WriteAllText(FilePath, DataToWrite, True)
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

End Class
