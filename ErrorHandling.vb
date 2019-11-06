Public Class ErrorHandling
    Public Shared LogFilePath As String = CSV.MainDirectoryFilePath & "NeilEPOSLog.txt" 'Location of log file
    Public Shared EmergencyLogFilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\NeilEPOSLog.txt" 'Location of log file

    Public Shared Sub Warn(ThrownException As Exception, ExceptionDetails As String) 'Logs an error to file
        Log(ThrownException)
        Notify(ThrownException, ExceptionDetails)
    End Sub


    Public Shared Sub Notify(ThrownException As Exception, ExceptionDetails As String) 'Logs an error to file
        If TypeOf ThrownException Is IO.DirectoryNotFoundException Then 'Unable to find file or folder
            MessageBox.Show("NeilEPOS was unable to access the folder at " & ExceptionDetails & " . Please ensure that this folder exists.", "Folder Not Found Error")
        ElseIf TypeOf ThrownException Is IO.IOException Then 'File is currently in use
            MessageBox.Show("NeilEPOS was unable to access the file at " & ExceptionDetails & " . Please ensure that this file is not currently in use.", "File In Use Error")
        ElseIf TypeOf ThrownException Is IO.FileNotFoundException Then 'File does not exist
            MessageBox.Show("NeilEPOS was unable to access the file at " & ExceptionDetails & " . Please ensure that this file exists.", "File Not Found Error")
        ElseIf TypeOf ThrownException Is IO.PathTooLongException Then 'Path to desktop is too long
            MessageBox.Show("NeilEPOS was unable to access the file or folder at " & ExceptionDetails & " . Please ensure that the path to this location is not too long.", "Path Length Error")
        ElseIf TypeOf ThrownException Is UnauthorizedAccessException Or TypeOf ThrownException Is Security.SecurityException Then 'User does not have write access to file
            MessageBox.Show("NeilEPOS was unable to access the file or folder at " & ExceptionDetails & " . Please ensure that you have permission to write to this location.", "File Access Error")
        Else
            MessageBox.Show("An unknown error occured. See log file at " & LogFilePath & " for more details", "Unknown Error")
        End If

    End Sub

    Public Shared Sub Log(ThrownException As Exception) 'Logs an error to file
        Dim ErrorToLog As String = Date.Now & "," & ThrownException.ToString & "," & Environment.NewLine & Environment.NewLine
        Try
            My.Computer.FileSystem.WriteAllText(LogFilePath, ErrorToLog, True)
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(EmergencyLogFilePath, ErrorToLog, True) 'If the main directory does not exist, write to desktop
            MessageBox.Show("Unable to access log file. Emergency log file created at " & LogFilePath, "Log File Error")
        End Try
    End Sub

End Class
