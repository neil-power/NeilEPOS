Public Class SalesSummaryWindow
    Private Sub SalesSummaryWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent glitching
        FormBorderStyle = FormBorderStyle.None 'Removes border
        StartPosition = FormStartPosition.Manual 'Prevents automatic cascade of MDI windows
        Location = New Point(100, 50) 'Sets form location to centre of Manager window
        ClearSales()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles DailySummaryButton.Click, WeeklySummaryButton.Click
        ClearSales()
        Select Case sender.Name
            Case DailySummaryButton.Name
                GetDailySalesFileSummary()
            Case WeeklySummaryButton.Name
                GetWeeklySalesFileSummary()
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub ClearSales()
        SalesListBox.Items.Clear()
    End Sub

    Private Sub GetDailySalesFileSummary()
        Dim DailySalesFileContents() As String = CSV.ReadAsArray(CSV.DailySalesFilePath)
        For Each Transaction As String In DailySalesFileContents
            SalesListBox.Items.Add(Transaction.Replace(",", " | "))
        Next Transaction
    End Sub

    Private Sub GetWeeklySalesFileSummary()
        Dim WeeklySalesFileContents() As String = CSV.ReadAsArray(CSV.WeeklySalesFilePath)
        For Each Transaction As String In WeeklySalesFileContents
            SalesListBox.Items.Add(Transaction.Replace(",", " | "))
        Next Transaction

    End Sub
    'Summary of total sales for day, total no of items, 
    'Close button
End Class