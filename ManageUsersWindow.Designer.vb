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
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.EmployeeIDLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.NewUserButton = New System.Windows.Forms.Button()
        Me.EditUserButton = New System.Windows.Forms.Button()
        Me.DeleteUserButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AccessLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveUserButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(195, 224)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(191, 29)
        Me.PasswordTextBox.TabIndex = 8
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(195, 137)
        Me.EmployeeIDTextBox.Mask = "00000"
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(191, 29)
        Me.EmployeeIDTextBox.TabIndex = 7
        Me.EmployeeIDTextBox.ValidatingType = GetType(Integer)
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
        'EmployeeIDLabel
        '
        Me.EmployeeIDLabel.AutoSize = True
        Me.EmployeeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDLabel.Location = New System.Drawing.Point(43, 142)
        Me.EmployeeIDLabel.Name = "EmployeeIDLabel"
        Me.EmployeeIDLabel.Size = New System.Drawing.Size(128, 24)
        Me.EmployeeIDLabel.TabIndex = 5
        Me.EmployeeIDLabel.Text = "Employee ID: "
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
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(195, 184)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(191, 29)
        Me.UsernameTextBox.TabIndex = 8
        '
        'NewUserButton
        '
        Me.NewUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewUserButton.Location = New System.Drawing.Point(34, 32)
        Me.NewUserButton.Name = "NewUserButton"
        Me.NewUserButton.Size = New System.Drawing.Size(100, 75)
        Me.NewUserButton.TabIndex = 21
        Me.NewUserButton.Text = "New User"
        Me.NewUserButton.UseVisualStyleBackColor = True
        '
        'EditUserButton
        '
        Me.EditUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditUserButton.Location = New System.Drawing.Point(152, 32)
        Me.EditUserButton.Name = "EditUserButton"
        Me.EditUserButton.Size = New System.Drawing.Size(100, 75)
        Me.EditUserButton.TabIndex = 21
        Me.EditUserButton.Text = "Edit User Details"
        Me.EditUserButton.UseVisualStyleBackColor = True
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserButton.Location = New System.Drawing.Point(276, 32)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(100, 75)
        Me.DeleteUserButton.TabIndex = 21
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
        Me.AccessLevelComboBox.Size = New System.Drawing.Size(191, 32)
        Me.AccessLevelComboBox.TabIndex = 22
        '
        'SaveUserButton
        '
        Me.SaveUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveUserButton.Location = New System.Drawing.Point(34, 314)
        Me.SaveUserButton.Name = "SaveUserButton"
        Me.SaveUserButton.Size = New System.Drawing.Size(100, 75)
        Me.SaveUserButton.TabIndex = 21
        Me.SaveUserButton.Text = "Save User"
        Me.SaveUserButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(329, 314)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 75)
        Me.CloseButton.TabIndex = 21
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ManageUsersWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AccessLevelComboBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SaveUserButton)
        Me.Controls.Add(Me.DeleteUserButton)
        Me.Controls.Add(Me.EditUserButton)
        Me.Controls.Add(Me.NewUserButton)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.EmployeeIDLabel)
        Me.Name = "ManageUsersWindow"
        Me.Text = "UserManageWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents EmployeeIDTextBox As MaskedTextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents EmployeeIDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents NewUserButton As Button
    Friend WithEvents EditUserButton As Button
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents AccessLevelComboBox As ComboBox
    Friend WithEvents SaveUserButton As Button
    Friend WithEvents CloseButton As Button
End Class
