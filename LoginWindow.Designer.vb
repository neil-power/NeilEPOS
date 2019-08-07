<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginWindow
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
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.EmployeeIDLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TaglineLabel = New System.Windows.Forms.Label()
        Me.EmployeeIDTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginPromptLabel = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(32, 20)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(333, 76)
        Me.LogoLabel.TabIndex = 0
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'EmployeeIDLabel
        '
        Me.EmployeeIDLabel.AutoSize = True
        Me.EmployeeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDLabel.Location = New System.Drawing.Point(42, 176)
        Me.EmployeeIDLabel.Name = "EmployeeIDLabel"
        Me.EmployeeIDLabel.Size = New System.Drawing.Size(128, 24)
        Me.EmployeeIDLabel.TabIndex = 1
        Me.EmployeeIDLabel.Text = "Employee ID: "
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(42, 218)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(102, 24)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password: "
        '
        'TaglineLabel
        '
        Me.TaglineLabel.AutoSize = True
        Me.TaglineLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TaglineLabel.Location = New System.Drawing.Point(42, 96)
        Me.TaglineLabel.Name = "TaglineLabel"
        Me.TaglineLabel.Size = New System.Drawing.Size(432, 24)
        Me.TaglineLabel.TabIndex = 0
        Me.TaglineLabel.Text = "Welcome to Neil's Electronic Point-Of-Sale System"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(194, 171)
        Me.EmployeeIDTextBox.Mask = "00000"
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(191, 29)
        Me.EmployeeIDTextBox.TabIndex = 3
        Me.EmployeeIDTextBox.ValidatingType = GetType(Integer)
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(194, 218)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(191, 29)
        Me.PasswordTextBox.TabIndex = 4
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'LoginPromptLabel
        '
        Me.LoginPromptLabel.AutoSize = True
        Me.LoginPromptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LoginPromptLabel.Location = New System.Drawing.Point(42, 125)
        Me.LoginPromptLabel.Name = "LoginPromptLabel"
        Me.LoginPromptLabel.Size = New System.Drawing.Size(427, 24)
        Me.LoginPromptLabel.TabIndex = 0
        Me.LoginPromptLabel.Text = "Please login with your employee ID and password"
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(44, 279)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(100, 75)
        Me.LoginButton.TabIndex = 19
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(285, 279)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 75)
        Me.CloseButton.TabIndex = 19
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(164, 279)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 75)
        Me.ClearButton.TabIndex = 19
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LoginWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 376)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.EmployeeIDLabel)
        Me.Controls.Add(Me.LoginPromptLabel)
        Me.Controls.Add(Me.TaglineLabel)
        Me.Controls.Add(Me.LogoLabel)
        Me.Name = "LoginWindow"
        Me.Text = "LoginWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoLabel As Label
    Friend WithEvents EmployeeIDLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents TaglineLabel As Label
    Friend WithEvents EmployeeIDTextBox As MaskedTextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginPromptLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ClearButton As Button
End Class
