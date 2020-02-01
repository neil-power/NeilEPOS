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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUsersWindow))
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
        Me.PasswordTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.UserNameTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.UsersDataGrid = New System.Windows.Forms.DataGridView()
        Me.ClearButton = New System.Windows.Forms.Button()
        CType(Me.UsersDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(200, 174)
        Me.UserIDTextBox.Mask = "00000"
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UserIDTextBox.Size = New System.Drawing.Size(270, 43)
        Me.UserIDTextBox.TabIndex = 4
        Me.UserIDTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.UserIDTextBox.ValidatingType = GetType(Integer)
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(20, 300)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(141, 37)
        Me.PasswordLabel.TabIndex = 6
        Me.PasswordLabel.Text = "Password: "
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDLabel.Location = New System.Drawing.Point(20, 180)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(116, 37)
        Me.UserIDLabel.TabIndex = 5
        Me.UserIDLabel.Text = "User ID: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username: "
        '
        'NewUserButton
        '
        Me.NewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewUserButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewUserButton.Location = New System.Drawing.Point(20, 0)
        Me.NewUserButton.Margin = New System.Windows.Forms.Padding(0)
        Me.NewUserButton.Name = "NewUserButton"
        Me.NewUserButton.Size = New System.Drawing.Size(150, 100)
        Me.NewUserButton.TabIndex = 1
        Me.NewUserButton.Text = "New User"
        Me.NewUserButton.UseVisualStyleBackColor = True
        '
        'EditUserButton
        '
        Me.EditUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditUserButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditUserButton.Location = New System.Drawing.Point(170, 0)
        Me.EditUserButton.Margin = New System.Windows.Forms.Padding(0)
        Me.EditUserButton.Name = "EditUserButton"
        Me.EditUserButton.Size = New System.Drawing.Size(150, 100)
        Me.EditUserButton.TabIndex = 2
        Me.EditUserButton.Text = "Edit User Details"
        Me.EditUserButton.UseVisualStyleBackColor = True
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteUserButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserButton.Location = New System.Drawing.Point(320, 0)
        Me.DeleteUserButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(150, 100)
        Me.DeleteUserButton.TabIndex = 3
        Me.DeleteUserButton.Text = "Delete User"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Access Level:"
        '
        'AccessLevelComboBox
        '
        Me.AccessLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccessLevelComboBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessLevelComboBox.FormattingEnabled = True
        Me.AccessLevelComboBox.Items.AddRange(New Object() {"None", "User", "Manager"})
        Me.AccessLevelComboBox.Location = New System.Drawing.Point(200, 352)
        Me.AccessLevelComboBox.Name = "AccessLevelComboBox"
        Me.AccessLevelComboBox.Size = New System.Drawing.Size(270, 45)
        Me.AccessLevelComboBox.TabIndex = 7
        '
        'SaveUserButton
        '
        Me.SaveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveUserButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveUserButton.Location = New System.Drawing.Point(20, 420)
        Me.SaveUserButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SaveUserButton.Name = "SaveUserButton"
        Me.SaveUserButton.Size = New System.Drawing.Size(150, 100)
        Me.SaveUserButton.TabIndex = 8
        Me.SaveUserButton.Text = "Save User"
        Me.SaveUserButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(470, 420)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(150, 100)
        Me.CloseButton.TabIndex = 10
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(170, 420)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(150, 100)
        Me.SearchButton.TabIndex = 9
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionLabel.Location = New System.Drawing.Point(20, 120)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(158, 37)
        Me.InstructionLabel.TabIndex = 23
        Me.InstructionLabel.Text = "[Instruction]"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(200, 294)
        Me.PasswordTextBox.Mask = "&&&&&&&&CCCCCCCCCCCC"
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.PasswordTextBox.Size = New System.Drawing.Size(270, 43)
        Me.PasswordTextBox.TabIndex = 6
        Me.PasswordTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.PasswordTextBox.UseSystemPasswordChar = True
        Me.PasswordTextBox.ValidatingType = GetType(Integer)
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(200, 234)
        Me.UserNameTextBox.Mask = "LL??????????????????"
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UserNameTextBox.Size = New System.Drawing.Size(270, 43)
        Me.UserNameTextBox.TabIndex = 5
        Me.UserNameTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.UserNameTextBox.ValidatingType = GetType(Integer)
        '
        'UsersDataGrid
        '
        Me.UsersDataGrid.AllowUserToAddRows = False
        Me.UsersDataGrid.AllowUserToDeleteRows = False
        Me.UsersDataGrid.AllowUserToOrderColumns = True
        Me.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGrid.Location = New System.Drawing.Point(489, 174)
        Me.UsersDataGrid.Name = "UsersDataGrid"
        Me.UsersDataGrid.ReadOnly = True
        Me.UsersDataGrid.RowHeadersVisible = False
        Me.UsersDataGrid.ShowCellToolTips = False
        Me.UsersDataGrid.ShowEditingIcon = False
        Me.UsersDataGrid.Size = New System.Drawing.Size(338, 234)
        Me.UsersDataGrid.TabIndex = 26
        Me.UsersDataGrid.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(320, 420)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(150, 100)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ManageUsersWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 650)
        Me.Controls.Add(Me.UsersDataGrid)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.AccessLevelComboBox)
        Me.Controls.Add(Me.ClearButton)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "ManageUsersWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NeilEPOS"
        CType(Me.UsersDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PasswordTextBox As MaskedTextBox
    Friend WithEvents UserNameTextBox As MaskedTextBox
    Friend WithEvents UsersDataGrid As DataGridView
    Friend WithEvents ClearButton As Button
End Class
