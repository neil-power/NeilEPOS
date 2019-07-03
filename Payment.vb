Imports System.IO 'Imports libraries needed for reading and writing files
Public Class Payment

    ' **************************************************ON LOAD**************************************************

    Private Sub Payment_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated 'Runs when payment form opened

        TotalLabel.Text = MainWindow.SaleTotal 'Sets total to the sale total

        ChangeLabel.Text = "" 'Resets label to default value
        AmountPaidTextBox.Text = "0000" ''Resets textbox to default value
        ChangeToGiveLabel.Text = "Amount to pay:" 'Resets label to default value

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
            Dim Change As Double = (CDbl(AmountPaidTextBox.Text) / 100) - MainWindow.SaleTotal ' Converts the amount paid to a decimal
            ChangeLabel.Text = Change.ToString("0.00") 'Updates the change label to show the change to be given

            If Change <= 0 Then 'If the change is less than 0, then not enough has been paid
                ChangeToGiveLabel.Text = "Amount to pay:" 'Updates change label
            ElseIf Change >= 0 Then 'If the change is more than 0, then enough has been paid
                ChangeToGiveLabel.Text = "Change:" 'Updates change label
            End If

        End If

    End Sub

    Private Sub FinishSale_Click(sender As Object, e As EventArgs) Handles FinishSale.Click ' Writes the information to the sales file
        MainWindow.SaleNumber += 1 'Increments sale number by 1
        Dim sw As New StreamWriter(MainWindow.FilePath, True) 'Creates a file writer
        For Each ItemBought In MainWindow.CurrentSale 'Interates through every item in the current sale
            sw.WriteLine(LSet(DateTime.Now, 19) & "," & LSet(MainWindow.SaleNumber, 5) & "," & LSet(ItemBought.ISBN, 13) & "," & LSet(ItemBought.Price, 5) & "," & LSet(ItemBought.Quantity, 2) & "," & MainWindow.SaleTotal & ",") 'Adds item properties to the text file
        Next
        sw.Close() 'Closes opened file

        TotalLabel.Text = "" 'Resets label to default
        ChangeLabel.Text = "" 'Resets label to default
        AmountPaidTextBox.Text = "0000" 'Resets textbox to default
        MainWindow.MainWindowClearAll() 'Clears all mainwindow variables

        Me.Hide() 'Closes payment window
    End Sub

    Private Sub ContinueSale_Click(sender As Object, e As EventArgs) Handles ContinueSaleButton.Click ' Continues the sale
        Me.Hide() 'Closes payment window without saving data to text file
    End Sub

End Class