Public Class DialogBox

    Private Sub DialogBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTheme()
    End Sub

    Private Sub LoadTheme() 'GUI setup
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

            ElseIf TypeOf Ctl Is MdiClient Then 'If control is part of MDI
                Ctl.BackColor = StartupWindow.BackgroundColour 'Set control colour to the form colour
            End If
        Next Ctl

        BringToFront()
        Text = "NeilEPOS" 'Sets window title
        TitleLabel.Font = StartupWindow.LabelFont
        MessageLabel.Font = New Font(StartupWindow.MainFont, 12, GraphicsUnit.Point)

    End Sub

    Public Sub New(Title As String, Message As String, Option1 As String, Option2 As String) 'Runs when show dialog is used
        InitializeComponent() 'Sets up the dialog box

        TitleLabel.Text = Title
        MessageLabel.Text = Message
        Option1Button.Show()
        Option1Button.Text = Option1
        Option2Button.Show()
        Option2Button.Text = Option2

    End Sub

    Public Sub New(Title As String, Message As String, Option1 As String) 'Runs when show dialog is used
        InitializeComponent() 'Sets up the dialog box

        TitleLabel.Text = Title
        MessageLabel.Text = Message
        Option1Button.Show()
        Option1Button.Text = Option1
        Option2Button.Hide()

    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles Option1Button.Click, Option2Button.Click
        Select Case sender.name
            Case Option1Button.Name
                DialogResult = DialogResult.Yes 'Returns Yes
            Case Option2Button.Name
                DialogResult = DialogResult.No 'Returns No
        End Select
        Close()
    End Sub

End Class