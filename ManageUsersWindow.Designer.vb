<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsersWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UserIDTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewUserButton = New System.Windows.Forms.Button()
        Me.EditUserButton = New System.Windows.Forms.Button()
        Me.DeleteUserButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AccessLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveUserButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.FoundUsersListBox = New System.Windows.Forms.ListBox()
        Me.PasswordTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.UserNameTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(195, 137)
        Me.UserIDTextBox.Mask = "00000"
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UserIDTextBox.Size = New System.Drawing.Size(207, 29)
        Me.UserIDTextBox.TabIndex = 4
        Me.UserIDTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.UserIDTextBox.ValidatingType = GetType(Integer)
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(43, 224)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(102, 24)
        Me.PasswordLabel.TabIndex = 6
        Me.PasswordLabel.Text = "Password: "
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDLabel.Location = New System.Drawing.Point(43, 142)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(81, 24)
        Me.UserIDLabel.TabIndex = 5
        Me.UserIDLabel.Text = "User ID: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username: "
        '
        'NewUserButton
        '
        Me.NewUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewUserButton.Location = New System.Drawing.Point(34, 26)
        Me.NewUserButton.Name = "NewUserButton"
        Me.NewUserButton.Size = New System.Drawing.Size(100, 75)
        Me.NewUserButton.TabIndex = 1
        Me.NewUserButton.Text = "New User"
        Me.NewUserButton.UseVisualStyleBackColor = True
        '
        'EditUserButton
        '
        Me.EditUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditUserButton.Location = New System.Drawing.Point(152, 26)
        Me.EditUserButton.Name = "EditUserButton"
        Me.EditUserButton.Size = New System.Drawing.Size(100, 75)
        Me.EditUserButton.TabIndex = 2
        Me.EditUserButton.Text = "Edit User Details"
        Me.EditUserButton.UseVisualStyleBackColor = True
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserButton.Location = New System.Drawing.Point(273, 26)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(100, 75)
        Me.DeleteUserButton.TabIndex = 3
        Me.DeleteUserButton.Text = "Delete User"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Access Level:"
        '
        'AccessLevelComboBox
        '
        Me.AccessLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccessLevelComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.AccessLevelComboBox.FormattingEnabled = True
        Me.AccessLevelComboBox.Items.AddRange(New Object() {"None", "User", "Manager"})
        Me.AccessLevelComboBox.Location = New System.Drawing.Point(195, 264)
        Me.AccessLevelComboBox.Name = "AccessLevelComboBox"
        Me.AccessLevelComboBox.Size = New System.Drawing.Size(207, 32)
        Me.AccessLevelComboBox.TabIndex = 7
        '
        'SaveUserButton
        '
        Me.SaveUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveUserButton.Location = New System.Drawing.Point(34, 374)
        Me.SaveUserButton.Name = "SaveUserButton"
        Me.SaveUserButton.Size = New System.Drawing.Size(100, 75)
        Me.SaveUserButton.TabIndex = 8
        Me.SaveUserButton.Text = "Save User"
        Me.SaveUserButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(273, 374)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 75)
        Me.CloseButton.TabIndex = 10
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(152, 374)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 75)
        Me.SearchButton.TabIndex = 9
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.InstructionLabel.Location = New System.Drawing.Point(30, 107)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(105, 24)
        Me.InstructionLabel.TabIndex = 23
        Me.InstructionLabel.Text = "[Instruction]"
        '
        'FoundUsersListBox
        '
        Me.FoundUsersListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FoundUsersListBox.FormattingEnabled = True
        Me.FoundUsersListBox.ItemHeight = 16
        Me.FoundUsersListBox.Location = New System.Drawing.Point(34, 302)
        Me.FoundUsersListBox.Name = "FoundUsersListBox"
        Me.FoundUsersListBox.Size = New System.Drawing.Size(339, 68)
        Me.FoundUsersListBox.TabIndex = 24
        Me.FoundUsersListBox.TabStop = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(195, 224)
        Me.PasswordTextBox.Mask = "&&&&&&&&CCCCCCCCCCCC"
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.PasswordTextBox.Size = New System.Drawing.Size(207, 29)
        Me.PasswordTextBox.TabIndex = 6
        Me.PasswordTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.PasswordTextBox.UseSystemPasswordChar = True
        Me.PasswordTextBox.ValidatingType = GetType(Integer)
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(195, 181)
        Me.UserNameTextBox.Mask = "LL??????????????????"
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UserNameTextBox.Size = New System.Drawing.Size(207, 29)
        Me.UserNameTextBox.TabIndex = 5
        Me.UserNameTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.UserNameTextBox.ValidatingType = GetType(Integer)
        '
        'ManageUsersWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.FoundUsersListBox)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.AccessLevelComboBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SaveUserButton)
        Me.Controls.Add(Me.DeleteUserButton)
        Me.Controls.Add(Me.EditUserButton)
        Me.Controls.Add(Me.NewUserButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserIDLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "ManageUsersWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "UserManageWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserIDTextBox As MaskedTextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UserIDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NewUserButton As Button
    Friend WithEvents EditUserButton As Button
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents AccessLevelComboBox As ComboBox
    Friend WithEvents SaveUserButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents InstructionLabel As Label
    Friend WithEvents FoundUsersListBox As ListBox
    Friend WithEvents PasswordTextBox As MaskedTextBox
    Friend WithEvents UserNameTextBox As MaskedTextBox
End Class
