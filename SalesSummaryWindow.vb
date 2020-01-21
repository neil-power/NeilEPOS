Public Class SalesSummaryWindow
    Private Sub SalesSummaryWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The startup location is set in the form properties to 1024, 768 to prevent visual issue
        LoadTheme()

        ClearSales()
    End Sub

    Private Sub LoadTheme() 'GUI setup
        FormBorderStyle = FormBorderStyle.None 'Removes border
        StartPosition = FormStartPosition.Manual 'Prevents automatic cascade of MDI windows
        Location = New Point(150, 75) 'Sets form location to centre of Manager/User window

        BackColor = StartupWindow.BackgroundColour
        ForeColor = StartupWindow.ForegroundColor

        For Each Ctl As Control In Controls ' Runs through every control in form
            If TypeOf Ctl Is Button Then 'If control is button
                Dim CurrentButton As Button = TryCast(Ctl, Button)
                CurrentButton.BackColor = StartupWindow.ThemeColour
                CurrentButton.ForeColor = StartupWindow.ForegroundColor
                CurrentButton.FlatAppearance.BorderColor = StartupWindow.ThemeColour
                CurrentButton.FlatAppearance.MouseOverBackColor = StartupWindow.HoverColour
                CurrentButton.FlatAppearance.MouseDownBackColor = StartupWindow.HoverColour
                CurrentButton.Font = StartupWindow.LabelFont
            ElseIf TypeOf Ctl Is Label Then 'If control is label
                Dim CurrentLabel As Label = TryCast(Ctl, Label)
                CurrentLabel.Font = StartupWindow.LabelFont
                CurrentLabel.ForeColor = StartupWindow.ForegroundColor
            ElseIf TypeOf Ctl Is DataGridView Then 'If control is data grid
                Dim CurrentDataGrid As DataGridView = TryCast(Ctl, DataGridView)
                CurrentDataGrid.ForeColor = Color.Black
                CurrentDataGrid.BackgroundColor = StartupWindow.BackgroundColour
            End If
        Next Ctl

        SalesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells 'Sets resize mode
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles DailySummaryButton.Click, WeeklySummaryButton.Click, CloseButton.Click
        ClearSales()
        Select Case sender.Name
            Case DailySummaryButton.Name
                GetDailySalesFileSummary() 'Generates daily sales file summary
            Case WeeklySummaryButton.Name
                GetWeeklySalesFileSummary() 'Generates weekly sales file summary
            Case CloseButton.Name
                Close() 'Closes window
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub DisplaySales(SalesFileContents As String()) 'Displays sales info in data grid
        For Each Heading As String In SalesFileContents(0).Split(CSV.Comma) 'Run through every heading in header row
            SalesDataGrid.Columns.Add(Heading, Heading) 'Add heading to grid
        Next Heading

        For i = 1 To UBound(SalesFileContents) 'Iterate through every line in file (except header)
            SalesDataGrid.Rows.Add(SalesFileContents(i).Split(CSV.Comma)) 'Add row to data grid
        Next i

        SalesDataGrid.AutoResizeColumns() 'Resize columns to fit contents
    End Sub

    Private Sub ClearSales() 'Resets window
        SalesDataGrid.Columns.Clear() 'Clears data grid
        CalculationLabel.Text = "" 'Sets calculation label to blank
    End Sub

    Private Sub GetDailySalesFileSummary() 'Generates daily sales file summary
        Dim DailySalesFileContents As String() = CSV.ReadAsArray(Product.DailySalesFilePath) 'Reads contents of daily sales file
        DisplaySales(DailySalesFileContents) 'Adds to data grid
        If SalesDataGrid.RowCount > 0 Then 'If data grid is not empty
            Dim LastTransactionNumber As String = SalesDataGrid.Rows.GetLastRow(0) 'Gets last transaction id from file 
            Dim ItemsSold As Integer = 0
            Dim DailySales As Decimal = 0

            For Each Line As DataGridViewRow In SalesDataGrid.Rows 'Iterates through every row in the data grid
                If Line.Cells.Count >= 7 Then 'If more than 7 cells (last line in transaction with summaries)
                    ItemsSold += Line.Cells(7).Value 'Add sales quantity to running total
                    DailySales += Line.Cells(6).Value 'Add sales value to running total
                End If
            Next

            CalculationLabel.Text = "Total number of transactions: " & LastTransactionNumber & Environment.NewLine & "Total number of items sold: " & ItemsSold & Environment.NewLine & "Total value of items sold: " & DailySales.ToString("C") & Environment.NewLine & "Average cost of item: " & Math.Round(DailySales / ItemsSold, 2).ToString("C")
        Else 'If there are no rows in the data grid
            CalculationLabel.Text = "No data found"
        End If

    End Sub

    Private Sub GetWeeklySalesFileSummary() 'Generates weekly sales file summary
        Dim WeeklySalesFileContents As String() = CSV.ReadAsArray(Product.WeeklySalesFilePath)
        DisplaySales(WeeklySalesFileContents)

        If SalesDataGrid.RowCount > 0 Then 'If data grid is not empty
            Dim ItemsSoldTotal As Integer = 0
            Dim WeeklySales As Decimal = 0

            For Each Line As DataGridViewRow In SalesDataGrid.Rows 'Iterates through every row in the data grid
                ItemsSoldTotal += Line.Cells(2).Value 'Add sales quantity to running total
                WeeklySales += Line.Cells(1).Value 'Add sales value to running total
            Next

            CalculationLabel.Text = "Total number of items sold: " & ItemsSoldTotal & Environment.NewLine & "Total value of items sold: " & WeeklySales.ToString("C")
        Else 'If there are no rows in the data grid
            CalculationLabel.Text = "No data found"
        End If

    End Sub

End Class