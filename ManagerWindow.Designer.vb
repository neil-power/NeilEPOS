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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerWindow))
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.BrandLabel = New System.Windows.Forms.Label()
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.SalesButton = New System.Windows.Forms.Button()
        Me.ProductLookupButton = New System.Windows.Forms.Button()
        Me.ManageProductsButton = New System.Windows.Forms.Button()
        Me.ManageUsersButton = New System.Windows.Forms.Button()
        Me.SalesSummaryButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.UserLabel.Location = New System.Drawing.Point(745, 26)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(76, 37)
        Me.UserLabel.TabIndex = 33
        Me.UserLabel.Text = "User:"
        '
        'BrandLabel
        '
        Me.BrandLabel.AutoSize = True
        Me.BrandLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.BrandLabel.Location = New System.Drawing.Point(417, 26)
        Me.BrandLabel.Name = "BrandLabel"
        Me.BrandLabel.Size = New System.Drawing.Size(246, 37)
        Me.BrandLabel.TabIndex = 32
        Me.BrandLabel.Text = "for [business name]"
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Rockwell", 40.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(155, 9)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(264, 60)
        Me.LogoLabel.TabIndex = 31
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'SalesButton
        '
        Me.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesButton.Location = New System.Drawing.Point(0, 0)
        Me.SalesButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(150, 120)
        Me.SalesButton.TabIndex = 34
        Me.SalesButton.Text = "Sales"
        Me.SalesButton.UseVisualStyleBackColor = True
        '
        'ProductLookupButton
        '
        Me.ProductLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductLookupButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLookupButton.Location = New System.Drawing.Point(0, 120)
        Me.ProductLookupButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ProductLookupButton.Name = "ProductLookupButton"
        Me.ProductLookupButton.Size = New System.Drawing.Size(150, 120)
        Me.ProductLookupButton.TabIndex = 35
        Me.ProductLookupButton.Text = "Product Lookup"
        Me.ProductLookupButton.UseVisualStyleBackColor = True
        '
        'ManageProductsButton
        '
        Me.ManageProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageProductsButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageProductsButton.Location = New System.Drawing.Point(0, 240)
        Me.ManageProductsButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ManageProductsButton.Name = "ManageProductsButton"
        Me.ManageProductsButton.Size = New System.Drawing.Size(150, 120)
        Me.ManageProductsButton.TabIndex = 36
        Me.ManageProductsButton.Text = "Manage Products"
        Me.ManageProductsButton.UseVisualStyleBackColor = True
        '
        'ManageUsersButton
        '
        Me.ManageUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageUsersButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageUsersButton.Location = New System.Drawing.Point(0, 360)
        Me.ManageUsersButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ManageUsersButton.Name = "ManageUsersButton"
        Me.ManageUsersButton.Size = New System.Drawing.Size(150, 120)
        Me.ManageUsersButton.TabIndex = 37
        Me.ManageUsersButton.Text = "Manage Users"
        Me.ManageUsersButton.UseVisualStyleBackColor = True
        '
        'SalesSummaryButton
        '
        Me.SalesSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesSummaryButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesSummaryButton.Location = New System.Drawing.Point(0, 480)
        Me.SalesSummaryButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesSummaryButton.Name = "SalesSummaryButton"
        Me.SalesSummaryButton.Size = New System.Drawing.Size(150, 120)
        Me.SalesSummaryButton.TabIndex = 38
        Me.SalesSummaryButton.Text = "Sales Summary"
        Me.SalesSummaryButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(0, 600)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(150, 128)
        Me.LogoutButton.TabIndex = 39
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'ManagerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.SalesButton)
        Me.Controls.Add(Me.ProductLookupButton)
        Me.Controls.Add(Me.ManageProductsButton)
        Me.Controls.Add(Me.ManageUsersButton)
        Me.Controls.Add(Me.SalesSummaryButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.BrandLabel)
        Me.Controls.Add(Me.LogoLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManagerWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NeilEPOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserLabel As Label
    Friend WithEvents BrandLabel As Label
    Friend WithEvents LogoLabel As Label
    Friend WithEvents SalesButton As Button
    Friend WithEvents ProductLookupButton As Button
    Friend WithEvents ManageProductsButton As Button
    Friend WithEvents ManageUsersButton As Button
    Friend WithEvents SalesSummaryButton As Button
    Friend WithEvents LogoutButton As Button
End Class
