<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerWindow
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
        Me.SalesButton = New System.Windows.Forms.Button()
        Me.ProductLookupButton = New System.Windows.Forms.Button()
        Me.SalesSummaryButton = New System.Windows.Forms.Button()
        Me.ManageProductsButton = New System.Windows.Forms.Button()
        Me.ManageUsersButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(12, 24)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(172, 39)
        Me.LogoLabel.TabIndex = 1
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'SalesButton
        '
        Me.SalesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesButton.Location = New System.Drawing.Point(19, 79)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(100, 75)
        Me.SalesButton.TabIndex = 1
        Me.SalesButton.Text = "Sales"
        Me.SalesButton.UseVisualStyleBackColor = True
        '
        'ProductLookupButton
        '
        Me.ProductLookupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLookupButton.Location = New System.Drawing.Point(19, 171)
        Me.ProductLookupButton.Name = "ProductLookupButton"
        Me.ProductLookupButton.Size = New System.Drawing.Size(100, 75)
        Me.ProductLookupButton.TabIndex = 2
        Me.ProductLookupButton.Text = "Product Lookup"
        Me.ProductLookupButton.UseVisualStyleBackColor = True
        '
        'SalesSummaryButton
        '
        Me.SalesSummaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesSummaryButton.Location = New System.Drawing.Point(19, 447)
        Me.SalesSummaryButton.Name = "SalesSummaryButton"
        Me.SalesSummaryButton.Size = New System.Drawing.Size(100, 75)
        Me.SalesSummaryButton.TabIndex = 5
        Me.SalesSummaryButton.Text = "Sales Summary"
        Me.SalesSummaryButton.UseVisualStyleBackColor = True
        '
        'ManageProductsButton
        '
        Me.ManageProductsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageProductsButton.Location = New System.Drawing.Point(19, 263)
        Me.ManageProductsButton.Name = "ManageProductsButton"
        Me.ManageProductsButton.Size = New System.Drawing.Size(100, 75)
        Me.ManageProductsButton.TabIndex = 3
        Me.ManageProductsButton.Text = "Manage Products"
        Me.ManageProductsButton.UseVisualStyleBackColor = True
        '
        'ManageUsersButton
        '
        Me.ManageUsersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageUsersButton.Location = New System.Drawing.Point(19, 358)
        Me.ManageUsersButton.Name = "ManageUsersButton"
        Me.ManageUsersButton.Size = New System.Drawing.Size(100, 75)
        Me.ManageUsersButton.TabIndex = 4
        Me.ManageUsersButton.Text = "Manage Users"
        Me.ManageUsersButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(19, 545)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(100, 75)
        Me.LogoutButton.TabIndex = 6
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'ManagerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 687)
        Me.Controls.Add(Me.ManageUsersButton)
        Me.Controls.Add(Me.SalesSummaryButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ManageProductsButton)
        Me.Controls.Add(Me.ProductLookupButton)
        Me.Controls.Add(Me.SalesButton)
        Me.Controls.Add(Me.LogoLabel)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "ManagerWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagerWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoLabel As Label
    Friend WithEvents SalesButton As Button
    Friend WithEvents ProductLookupButton As Button
    Friend WithEvents SalesSummaryButton As Button
    Friend WithEvents ManageProductsButton As Button
    Friend WithEvents ManageUsersButton As Button
    Friend WithEvents LogoutButton As Button
End Class
