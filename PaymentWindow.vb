Public Class PaymentWindow

    ' **************************************************ON LOAD**************************************************

    Public Shared TransactionID As Integer ' Creates a variable for a running total of sales

    Private Sub Payment_Activated(sender As Object, e As EventArgs) Handles MyBase.Load 'Runs when payment form opened
        'The startup location is set in the form properties to 1024, 768 to prevent visual issue
        LoadTheme()

        TotalLabel.Text = SalesWindow.SaleTotal.ToString("C") 'Sets total to the sale total

        ChangeLabel.Text = "" 'Resets label to default value
        AmountPaidTextBox.Text = "0000" ''Resets textbox to default value
        ChangeToGiveLabel.Text = "Amount to pay:" 'Resets label to default value

        TransactionID = ReadTransactionIDFromFile()

        AmountPaidTextBox.Select(AmountPaidTextBox.Text.Length + 1, 0) 'Selects amount paid textbox

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
            ElseIf TypeOf Ctl Is MaskedTextBox Then 'If control is text box
                Dim CurrentTextBox As MaskedTextBox = TryCast(Ctl, MaskedTextBox)
                CurrentTextBox.Font = StartupWindow.LabelFont
            End If
        Next Ctl

    End Sub

    ' **************************************************INPUTS**************************************************

    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles AmountPaidTextBox.Click ' Changes selected field on click

        AmountPaidTextBox.Select(AmountPaidTextBox.Text.Length + 1, 0) 'Sets cursor to the "end" of the right-to-left textbox

    End Sub

    Private Sub NumButton_Click(sender As Object, e As EventArgs) Handles NumButton9.Click, NumButton8.Click, NumButton7.Click, NumButton6.Click, NumButton5.Click, NumButton4.Click, NumButton3.Click, NumButton2.Click, NumButton1.Click, NumButton0.Click 'Enters keypad into selected field

        If AmountPaidTextBox.Text(0) = "0" Then 'If first digit is a 0, then more numbers can still be added
            AmountPaidTextBox.Text = AmountPaidTextBox.Text.Substring(1, 3) & Mid(sender.Name, 10, 1) ' Removes first 0 and adds key pressed to the textbox
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click 'Empties the amount paid field

        AmountPaidTextBox.Text = "0000" 'Sets amount paid text box to default

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click 'Removes last character of amount paid field when delete button pressed

        If Trim(AmountPaidTextBox.Text).Length > 0 Then 'If amount paid textbox is not empty
            AmountPaidTextBox.Text = "0" & AmountPaidTextBox.Text.Substring(0, AmountPaidTextBox.Text.Length - 1) 'Removes last character from textbox and adds 0 to front
        End If

    End Sub

    Private Sub AmountPaidTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles AmountPaidTextBox.KeyUp 'Handles adding zeroes when typing in amount paid text box

        While AmountPaidTextBox.Text.Trim(" ").Length <> 4  'If the length of the amount paid text box is less than 4, then numbers have been deleted
            AmountPaidTextBox.Text = "0" & AmountPaidTextBox.Text 'Adds an 0 in front to keep the amount paid at 4 characters
        End While

    End Sub


    Private Sub AmountPaidTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AmountPaidTextBox.KeyDown 'Handles removing zeroes when typing in amount paid text box
        If AmountPaidTextBox.Text.Length = 4 Then 'If the length is 4 and a key is pressed, a number needs to be added

            If AmountPaidTextBox.Text(0) = "0" Then 'If the first number is 0, then there is still space for a character to be added
                AmountPaidTextBox.Text = AmountPaidTextBox.Text.Substring(1, AmountPaidTextBox.Text.Length - 1) 'Removes the 0, as this is a keydown event the key pressed will then be added
            End If

        End If

    End Sub

    ' **************************************************SALES PROCESSING**************************************************

    Private Sub AmountPaidTextBox_TextChanged(sender As Object, e As EventArgs) Handles AmountPaidTextBox.TextChanged ' Updates the change to give box

        If Decimal.TryParse(AmountPaidTextBox.Text, New Decimal) Then ' Checks if the amount paid text box text can be converted to a decimal
            Dim Change As Decimal = (CDec(AmountPaidTextBox.Text) / 100) - SalesWindow.SaleTotal ' Converts the amount paid to a decimal
            ChangeLabel.Text = Change.ToString("C") 'Converts to currency 'Updates the change label to show the change to be given

            If Change <= 0 Then 'If the change is less than 0, then not enough has been paid
                ChangeToGiveLabel.Text = "Amount to pay:" 'Updates change label
            ElseIf Change >= 0 Then 'If the change is more than 0, then enough has been paid
                ChangeToGiveLabel.Text = "Change:" 'Updates change label
            End If

        End If

    End Sub

    Private Sub ContinueSale_Click(sender As Object, e As EventArgs) Handles ContinueSaleButton.Click ' Continues the sale
        Close() 'Closes payment window without saving data to text file
    End Sub

    ' **************************************************DAILY SALES FILE**************************************************

    Private Function ReadTransactionIDFromFile() ' Gets most recent sales number from the sales file
        Dim SaleData() As String = CSV.ReadAsArray(Product.DailySalesFilePath) ' This reads all data from the sales file

        If SaleData.Length > 1 Then ' Tests to see if there is more than one line in the sales file (there will be a header row)
            Dim LastSale As String = SaleData.Last 'Gets last line of saledata

            Dim LastSaleNumber As String = LastSale.Split(CSV.Comma)(0) 'Takes the sale number from the last line (most recent sale) of the file and removes spaces

            If Integer.TryParse(LastSaleNumber, New Integer) Then 'Tests to see if the sales number is an integer to prevent errors
                Return LastSaleNumber 'Returns the last sale number (1 will be added to it when finish sale is clicked)
            End If

        End If

        Return 0 'Returns sale number 0 as the sales file does not have more recent sale number

    End Function

    Private Sub WriteToDailySalesFile(NoOfItems As Integer)
        For Each Item As SalesWindow.Item In SalesWindow.CurrentSale 'Iterate through every item in current transaction
            ' Write Transaction ID, Date, Time, Item, Item Cost, Item Quantity,Sales Total,Sales Quantity,Change Given, User
            If SalesWindow.CurrentSale.IndexOf(Item) = SalesWindow.CurrentSale.Count - 1 Then 'If item is last item in current sale, write sales totals
                Dim LineToWrite As String = TransactionID & CSV.Comma & Date.Today & CSV.Comma & Date.Now.ToShortTimeString() & CSV.Comma & Item.ISBN & CSV.Comma & Item.Price & CSV.Comma & Item.Quantity & CSV.Comma & SalesWindow.SaleTotal & CSV.Comma & NoOfItems & CSV.Comma & ChangeLabel.Text.Replace("£", "") & CSV.Comma & LoginWindow.CurrentUser.UserName
                CSV.Append(Product.DailySalesFilePath, LineToWrite) 'Writes line to file. Pound sign is removed from change label
            Else 'Don't write sales totals
                Dim LineToWrite As String = TransactionID & CSV.Comma & Date.Today & CSV.Comma & Date.Now.ToShortTimeString() & CSV.Comma & Item.ISBN & CSV.Comma & Item.Price & CSV.Comma & Item.Quantity
                CSV.Append(Product.DailySalesFilePath, LineToWrite) 'Writes line to file
            End If

        Next Item
    End Sub

    Private Sub WriteToWeeklySalesFile(NoOfItems As Integer)
        Dim WeeklySaleFileContents() As String = CSV.ReadAsArray(Product.WeeklySalesFilePath) 'Gets entire contents of weekly sales file
        For i = 0 To UBound(WeeklySaleFileContents) 'Runs through each line

            Dim Day As String() = WeeklySaleFileContents(i).Split(CSV.Comma) 'Splits line on delimiter character

            If Day(0) = "Date" Then 'If the line is the title line
                If UBound(WeeklySaleFileContents) = 0 Then 'If there is only one line in the file
                    Dim LineToWrite As String = Date.Today & CSV.Comma & SalesWindow.SaleTotal & CSV.Comma & NoOfItems 'Writes date, total and no of items to file
                    CSV.Append(Product.WeeklySalesFilePath, LineToWrite) 'Writes line to file
                End If

            ElseIf Day(0) = Date.Today Then 'If date matches with current date
                Dim NewSalesTotal As Decimal = SalesWindow.SaleTotal + Day(1) 'Adds current sale total to the total in the file
                Dim NewNoOfItems As Integer = NoOfItems + Day(2) 'Adds current no of items to the no of items in the file

                WeeklySaleFileContents(i) = (Date.Today & CSV.Comma & NewSalesTotal & CSV.Comma & NewNoOfItems) 'Replace line with updated day
                CSV.ArrayOverwrite(Product.WeeklySalesFilePath, WeeklySaleFileContents) 'Replace file with updated version

            ElseIf i = UBound(WeeklySaleFileContents) Then 'If it is not the title line, the date does not match with current date and the current line is the last line in the file

                Dim LineToWrite As String = Date.Today & CSV.Comma & SalesWindow.SaleTotal & CSV.Comma & NoOfItems 'Writes date, total and no of items to file
                CSV.Append(Product.WeeklySalesFilePath, LineToWrite) 'Writes line to file
            End If

        Next

    End Sub

    Private Sub FinishSale_Click(sender As Object, e As EventArgs) Handles FinishSale.Click ' Writes the information to the sales file
        TransactionID += 1 'Increments transaction ID by 1
        Dim NoOfItems As Integer = 0
        For Each ItemBought As SalesWindow.Item In SalesWindow.CurrentSale 'Interates through every item in the current sale
            NoOfItems += ItemBought.Quantity 'Adds quantity of item bought to running total
        Next ItemBought

        WriteToDailySalesFile(NoOfItems)
        WriteToWeeklySalesFile(NoOfItems)

        TotalLabel.Text = "" 'Resets label to default
        ChangeLabel.Text = "" 'Resets label to default
        AmountPaidTextBox.Text = "0000" 'Resets textbox to default
        SalesWindow.ClearSalesWindow() 'Clears all mainwindow variables
        Close() 'Closes payment window
    End Sub

End Class