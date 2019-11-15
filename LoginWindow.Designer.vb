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
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TaglineLabel = New System.Windows.Forms.Label()
        Me.UserIDTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.LoginPromptLabel = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(75, 49)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(333, 76)
        Me.LogoLabel.TabIndex = 0
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDLabel.Location = New System.Drawing.Point(344, 274)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(128, 24)
        Me.UserIDLabel.TabIndex = 1
        Me.UserIDLabel.Text = "Employee ID: "
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(344, 316)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(102, 24)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password: "
        '
        'TaglineLabel
        '
        Me.TaglineLabel.AutoSize = True
        Me.TaglineLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TaglineLabel.Location = New System.Drawing.Point(84, 125)
        Me.TaglineLabel.Name = "TaglineLabel"
        Me.TaglineLabel.Size = New System.Drawing.Size(432, 24)
        Me.TaglineLabel.TabIndex = 0
        Me.TaglineLabel.Text = "Welcome to Neil's Electronic Point-Of-Sale System"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(480, 269)
        Me.UserIDTextBox.Mask = "00000"
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UserIDTextBox.Size = New System.Drawing.Size(207, 29)
        Me.UserIDTextBox.TabIndex = 3
        Me.UserIDTextBox.ValidatingType = GetType(Integer)
        '
        'LoginPromptLabel
        '
        Me.LoginPromptLabel.AutoSize = True
        Me.LoginPromptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LoginPromptLabel.Location = New System.Drawing.Point(304, 207)
        Me.LoginPromptLabel.Name = "LoginPromptLabel"
        Me.LoginPromptLabel.Size = New System.Drawing.Size(427, 24)
        Me.LoginPromptLabel.TabIndex = 0
        Me.LoginPromptLabel.Text = "Please login with your employee ID and password"
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(346, 377)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(100, 75)
        Me.LoginButton.TabIndex = 19
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(587, 377)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 75)
        Me.CloseButton.TabIndex = 19
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(466, 377)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 75)
        Me.ClearButton.TabIndex = 19
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(480, 316)
        Me.PasswordTextBox.Mask = "&&&&&&&&CCCCCCCCCCCC"
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.PasswordTextBox.Size = New System.Drawing.Size(207, 29)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.UseSystemPasswordChar = True
        Me.PasswordTextBox.ValidatingType = GetType(Integer)
        '
        'LoginWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 687)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserIDLabel)
        Me.Controls.Add(Me.LoginPromptLabel)
        Me.Controls.Add(Me.TaglineLabel)
        Me.Controls.Add(Me.LogoLabel)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "LoginWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoLabel As Label
    Friend WithEvents UserIDLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents TaglineLabel As Label
    Friend WithEvents UserIDTextBox As MaskedTextBox
    Friend WithEvents LoginPromptLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PasswordTextBox As MaskedTextBox
End Class
