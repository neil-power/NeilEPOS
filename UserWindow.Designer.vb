<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ActionPromptLabel = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SalesButton = New System.Windows.Forms.Button()
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.ProductLookupButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ActionPromptLabel
        '
        Me.ActionPromptLabel.AutoSize = True
        Me.ActionPromptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ActionPromptLabel.Location = New System.Drawing.Point(35, 91)
        Me.ActionPromptLabel.Name = "ActionPromptLabel"
        Me.ActionPromptLabel.Size = New System.Drawing.Size(376, 24)
        Me.ActionPromptLabel.TabIndex = 29
        Me.ActionPromptLabel.Text = "Please select the action you wish to perform"
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(274, 130)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(100, 75)
        Me.LogoutButton.TabIndex = 25
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'SalesButton
        '
        Me.SalesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesButton.Location = New System.Drawing.Point(39, 130)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(100, 75)
        Me.SalesButton.TabIndex = 28
        Me.SalesButton.Text = "Sales"
        Me.SalesButton.UseVisualStyleBackColor = True
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(26, 20)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(333, 76)
        Me.LogoLabel.TabIndex = 22
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'ProductLookupButton
        '
        Me.ProductLookupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLookupButton.Location = New System.Drawing.Point(156, 130)
        Me.ProductLookupButton.Name = "ProductLookupButton"
        Me.ProductLookupButton.Size = New System.Drawing.Size(100, 75)
        Me.ProductLookupButton.TabIndex = 27
        Me.ProductLookupButton.Text = "Product Lookup"
        Me.ProductLookupButton.UseVisualStyleBackColor = True
        '
        'UserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 230)
        Me.Controls.Add(Me.ActionPromptLabel)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ProductLookupButton)
        Me.Controls.Add(Me.SalesButton)
        Me.Controls.Add(Me.LogoLabel)
        Me.Name = "UserWindow"
        Me.Text = "UserWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ActionPromptLabel As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents SalesButton As Button
    Friend WithEvents LogoLabel As Label
    Friend WithEvents ProductLookupButton As Button
End Class
