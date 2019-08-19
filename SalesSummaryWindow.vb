Imports System.IO
Public Class SalesSummaryWindow
    Private Sub SalesSummaryWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent glitching
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(100, 50)
        ClearSales()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles DailySummaryButton.Click, WeeklySummaryButton.Click
        ClearSales()
        Select Case sender.Name
            Case DailySummaryButton.Name
                GetDailySalesFileSummary()
            Case WeeklySummaryButton.Name
                GetWeeklySalesFileSummary()
        End Select
    End Sub

    Private Sub ClearSales()
        SalesListBox.Items.Clear()
    End Sub

    Private Sub GetDailySalesFileSummary()
        Dim DailySalesFileContents() As String = File.ReadAllLines(LoginWindow.DailySalesFilePath)
        For Each Transaction In DailySalesFileContents
            SalesListBox.Items.Add(Transaction)
        Next

        '(TransactionID & "," & DateTime.Today & "," & DateTime.Now.ToShortTimeString() & "," & SalesWindow.SaleTotal & "," & NoOfItems & "," & ItemsBought & "," & ChangeLabel.Text)

    End Sub

    Private Sub GetWeeklySalesFileSummary()
        Dim WeeklySalesFileContents() As String = File.ReadAllLines(LoginWindow.WeeklySalesFilePath)
        For Each Transaction In WeeklySalesFileContents
            SalesListBox.Items.Add(Transaction)
        Next

    End Sub

    'Private Sub WriteToWeeklySalesFile(NoOfItems As Integer)
    '    Dim WeeklySaleFileContents() As String = File.ReadAllLines(WeeklySalesFilePath) 'Gets entire contents of weekly sales file
    '    For i = 0 To UBound(WeeklySaleFileContents) 'Runs through each line

    '        Dim day As String() = WeeklySaleFileContents(i).Split(",") 'Splits line on commas

    '        If day(0) = "Date" Then 'If the line is the title line
    '            If UBound(WeeklySaleFileContents) = 0 Then 'If there is only one line in the file
    '                Dim sw As New StreamWriter(WeeklySalesFilePath, True) 'Creates a file writer
    '                sw.WriteLine(DateTime.Today & "," & SalesWindow.SaleTotal & "," & NoOfItems) 'Writes date, total and no of items to file
    '                sw.Close() 'Closes opened file
    '            End If

    '        ElseIf day(0) = DateTime.Today Then 'If date matches with current date
    '            Dim NewSalesTotal As Double = SalesWindow.SaleTotal + CDbl(day(1)) 'Adds current sale total to the total in the file
    '            Dim NewNoOfItems As Integer = NoOfItems + CDbl(day(2)) 'Adds current no of items to the no of items in the file

    '            WeeklySaleFileContents(i) = (DateTime.Today & "," & NewSalesTotal & "," & NewNoOfItems) 'Replace line with updated day
    '            File.WriteAllLines(WeeklySalesFilePath, WeeklySaleFileContents) 'Replace file with updated version

    '        ElseIf i = UBound(WeeklySaleFileContents) Then 'If it is not the title line, the date does not match with current date and the current line is the last line in the file
    '            Dim sw As New StreamWriter(WeeklySalesFilePath, True) 'Creates a file writer
    '            sw.WriteLine(DateTime.Today & "," & SalesWindow.SaleTotal & "," & NoOfItems) 'Writes date, total and no of items to file
    '            sw.Close() 'Closes opened file
    '        End If

    '    Next

    'End Sub
End Class