Public Class ErrorHandling
    Public Shared LogFilePath As String = CSV.MainDirectoryFilePath & "NeilEPOSLog.txt" 'Location of log file
    Public Shared EmergencyLogFilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\NeilEPOSLog.txt" 'Location of log file

    Public Shared Sub Warn(ThrownException As Exception, ExceptionDetails As String) 'Logs an error to file
        Log(ThrownException)
        Notify(ThrownException, ExceptionDetails)
    End Sub


    Public Shared Sub Notify(ThrownException As Exception, ExceptionDetails As String) 'Logs an error to file
        If TypeOf ThrownException Is IO.DirectoryNotFoundException Then 'Unable to find file or folder
            Dim ErrorDisplay As New DialogBox("Folder Not Found Error", "NeilEPOS was unable to access the folder at " & Environment.NewLine & ExceptionDetails & Environment.NewLine & "Please ensure that this folder exists.", "OK")
            ErrorDisplay.ShowDialog()
        ElseIf TypeOf ThrownException Is IO.IOException Then 'File is currently in use
            Dim ErrorDisplay As New DialogBox("File In Use Error", "NeilEPOS was unable to access the file at " & Environment.NewLine & ExceptionDetails & Environment.NewLine & "Please ensure that this file is not currently in use.", "OK")
            ErrorDisplay.ShowDialog()
        ElseIf TypeOf ThrownException Is IO.FileNotFoundException Then 'File does not exist
            Dim ErrorDisplay As New DialogBox("File Not Found Error", "NeilEPOS was unable to access the file at " & Environment.NewLine & ExceptionDetails & Environment.NewLine & "Please ensure that this file exists.", "OK")
            ErrorDisplay.ShowDialog()
        ElseIf TypeOf ThrownException Is IO.PathTooLongException Then 'Path to desktop is too long
            Dim ErrorDisplay As New DialogBox("Path Length Error", "NeilEPOS was unable to access the file or folder at " & Environment.NewLine & ExceptionDetails & Environment.NewLine & "Please ensure that the path to this location is not too long.", "OK")
            ErrorDisplay.ShowDialog()
        ElseIf TypeOf ThrownException Is UnauthorizedAccessException Or TypeOf ThrownException Is Security.SecurityException Then 'User does not have write access to file
            Dim ErrorDisplay As New DialogBox("File Access Error", "NeilEPOS was unable to access the file or folder at " & Environment.NewLine & ExceptionDetails & Environment.NewLine & "Please ensure that you have permission to write to this location.", "OK")
            ErrorDisplay.ShowDialog()
        Else 'Any other error
            Dim ErrorDisplay As New DialogBox("Unknown Error", "An unknown error occured. See log file at " & Environment.NewLine & LogFilePath & Environment.NewLine & " for more details.", "OK")
            ErrorDisplay.ShowDialog()
        End If

    End Sub

    Public Shared Sub Log(ThrownException As Exception) 'Logs an error to file
        Dim ErrorToLog As String = Date.Now & CSV.Delimiter & ThrownException.ToString & CSV.Delimiter & Environment.NewLine & Environment.NewLine
        Try
            My.Computer.FileSystem.WriteAllText(LogFilePath, ErrorToLog, True)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(EmergencyLogFilePath, ErrorToLog, True) 'If the main directory does not exist, write to desktop
            Dim ErrorDisplay As New DialogBox("Unable to access log file", "Emergency log file created at" & Environment.NewLine & LogFilePath, "OK")
            ErrorDisplay.ShowDialog()
        End Try
    End Sub

End Class
