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
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SalesButton = New System.Windows.Forms.Button()
        Me.ProductLookupButton = New System.Windows.Forms.Button()
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(19, 250)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(100, 75)
        Me.LogoutButton.TabIndex = 25
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'SalesButton
        '
        Me.SalesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesButton.Location = New System.Drawing.Point(19, 68)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(100, 75)
        Me.SalesButton.TabIndex = 28
        Me.SalesButton.Text = "Sales"
        Me.SalesButton.UseVisualStyleBackColor = True
        '
        'ProductLookupButton
        '
        Me.ProductLookupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLookupButton.Location = New System.Drawing.Point(19, 158)
        Me.ProductLookupButton.Name = "ProductLookupButton"
        Me.ProductLookupButton.Size = New System.Drawing.Size(100, 75)
        Me.ProductLookupButton.TabIndex = 27
        Me.ProductLookupButton.Text = "Product Lookup"
        Me.ProductLookupButton.UseVisualStyleBackColor = True
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(12, 9)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(172, 39)
        Me.LogoLabel.TabIndex = 29
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'UserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.LogoLabel)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ProductLookupButton)
        Me.Controls.Add(Me.SalesButton)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "UserWindow"
        Me.Text = "UserWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoutButton As Button
    Friend WithEvents SalesButton As Button
    Friend WithEvents ProductLookupButton As Button
    Friend WithEvents LogoLabel As Label
End Class
