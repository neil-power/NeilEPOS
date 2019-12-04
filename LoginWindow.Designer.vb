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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginWindow))
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
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
        Me.LogoLabel.Font = New System.Drawing.Font("Rockwell", 60.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(1, -3)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(390, 88)
        Me.LogoLabel.TabIndex = 0
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.UserIDLabel.Location = New System.Drawing.Point(9, 118)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(116, 37)
        Me.UserIDLabel.TabIndex = 1
        Me.UserIDLabel.Text = "User ID: "
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.PasswordLabel.Location = New System.Drawing.Point(9, 171)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(141, 37)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password: "
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.UserIDTextBox.Location = New System.Drawing.Point(157, 117)
        Me.UserIDTextBox.Mask = "00000"
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UserIDTextBox.Size = New System.Drawing.Size(250, 38)
        Me.UserIDTextBox.TabIndex = 1
        Me.UserIDTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.UserIDTextBox.ValidatingType = GetType(Integer)
        '
        'LoginPromptLabel
        '
        Me.LoginPromptLabel.AutoSize = True
        Me.LoginPromptLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LoginPromptLabel.Location = New System.Drawing.Point(12, 74)
        Me.LoginPromptLabel.Name = "LoginPromptLabel"
        Me.LoginPromptLabel.Size = New System.Drawing.Size(395, 28)
        Me.LoginPromptLabel.TabIndex = 0
        Me.LoginPromptLabel.Text = "Please login with your User ID and Password"
        '
        'LoginButton
        '
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(0, 248)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(155, 75)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(310, 248)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(155, 75)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(155, 248)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(155, 75)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(157, 170)
        Me.PasswordTextBox.Mask = "&&&&&&&&CCCCCCCCCCCC"
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.PasswordTextBox.Size = New System.Drawing.Size(250, 38)
        Me.PasswordTextBox.TabIndex = 2
        Me.PasswordTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.PasswordTextBox.UseSystemPasswordChar = True
        Me.PasswordTextBox.ValidatingType = GetType(Integer)
        '
        'LoginWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 321)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserIDLabel)
        Me.Controls.Add(Me.LoginPromptLabel)
        Me.Controls.Add(Me.LogoLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NeilEPOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoLabel As Label
    Friend WithEvents UserIDLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UserIDTextBox As MaskedTextBox
    Friend WithEvents LoginPromptLabel As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PasswordTextBox As MaskedTextBox
End Class
