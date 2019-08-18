﻿Imports System.IO 'Imports libraries needed for reading and writing files
Public Class PaymentWindow

    ' **************************************************ON LOAD**************************************************
    Public Shared DailySalesFilePath As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & CStr(DateTime.Today).Replace("/", "-") + " DAILY SALES.csv" ' Desktop and current date for file to save to
    Public Shared TransactionID As Integer ' Creates a variable for a running total of sales

    Private Sub Payment_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated 'Runs when payment form opened

        TotalLabel.Text = SalesWindow.SaleTotal 'Sets total to the sale total

        ChangeLabel.Text = "" 'Resets label to default value
        AmountPaidTextBox.Text = "0000" ''Resets textbox to default value
        ChangeToGiveLabel.Text = "Amount to pay:" 'Resets label to default value

        If Not File.Exists(DailySalesFilePath) Then ' Checks to see if a sales file has already been created

            Dim sw As New StreamWriter(DailySalesFilePath, True) 'Creates a file writer
            sw.WriteLine("TransactionID" & "," & "Date" & "," & "Time" & "," & "Sale Total" & "," & "No of Items" & "," & "Items Bought" & "," & "Change Given") 'Writes headings row
            sw.Close() 'Closes opened file
            MsgBox("A new sales file has been created at " & DailySalesFilePath, vbInformation, "New file created!") 'Gives notification that a new sales file has been created

        End If

        TransactionID = ReadTransactionIDFromFile()

        Me.BringToFront() 'Brings window to front
        AmountPaidTextBox.Select(AmountPaidTextBox.Text.Length + 1, 0) 'Selects amount paid textbox

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

        If Double.TryParse(AmountPaidTextBox.Text, New Double) Then ' Checks if the amount paid text box text can be converted to a decimal
            Dim Change As Double = (CDbl(AmountPaidTextBox.Text) / 100) - SalesWindow.SaleTotal ' Converts the amount paid to a decimal
            ChangeLabel.Text = Change.ToString("0.00") 'Updates the change label to show the change to be given

            If Change <= 0 Then 'If the change is less than 0, then not enough has been paid
                ChangeToGiveLabel.Text = "Amount to pay:" 'Updates change label
            ElseIf Change >= 0 Then 'If the change is more than 0, then enough has been paid
                ChangeToGiveLabel.Text = "Change:" 'Updates change label
            End If

        End If

    End Sub

    ' **************************************************DAILY SALES FILE**************************************************

    Private Function ReadTransactionIDFromFile() ' Gets most recent sales number from the sales file
        Dim SaleData() As String = File.ReadAllLines(DailySalesFilePath) ' This reads all data from the sales file
        Dim CurrentSaleNumber As Integer = 0 ' Sets current sale number to 0

        If SaleData.Length > 1 Then ' Tests to see if there is more than one line in the sales file (there will be a header row)

            Dim LastSaleNumber As String = Trim(Mid(SaleData(SaleData.Length - 1), 21, 5)) 'Takes the sale number from the last line (most recent sale) of the file and removes spaces

            If Integer.TryParse(LastSaleNumber, New Integer) Then 'Tests to see if the sales number is an integer to prevent errors
                CurrentSaleNumber = LastSaleNumber 'Returns the last sale number (1 will be added to it when finish sale is clicked)
            End If

        End If

        Return CurrentSaleNumber 'Returns sale number, which will be 0 unless the sales file has a more recent sale number

    End Function

    Private Sub FinishSale_Click(sender As Object, e As EventArgs) Handles FinishSale.Click ' Writes the information to the sales file
        TransactionID += 1 'Increments transaction ID by 1
        Dim sw As New StreamWriter(DailySalesFilePath, True) 'Creates a file writer
        Dim ItemsBought As String = ""
        Dim NoOfItems As Integer = 0
        For Each ItemBought In SalesWindow.CurrentSale 'Interates through every item in the current sale
            ItemsBought += ItemBought.ISBN & " "
            NoOfItems += 1
        Next

        sw.WriteLine(TransactionID & "," & DateTime.Today & "," & DateTime.Now.ToShortTimeString() & "," & SalesWindow.SaleTotal & "," & NoOfItems & "," & ItemsBought & "," & ChangeLabel.Text)
        sw.Close() 'Closes opened file

        TotalLabel.Text = "" 'Resets label to default
        ChangeLabel.Text = "" 'Resets label to default
        AmountPaidTextBox.Text = "0000" 'Resets textbox to default
        SalesWindow.MainWindowClearAll() 'Clears all mainwindow variables
        Me.Close() 'Closes payment window
    End Sub

    Private Sub ContinueSale_Click(sender As Object, e As EventArgs) Handles ContinueSaleButton.Click ' Continues the sale
        Me.Close() 'Closes payment window without saving data to text file
    End Sub

End Class