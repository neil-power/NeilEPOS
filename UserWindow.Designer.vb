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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserWindow))
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.BrandLabel = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.SalesButton = New System.Windows.Forms.Button()
        Me.ProductLookupButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Rockwell", 40.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(153, 9)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(264, 60)
        Me.LogoLabel.TabIndex = 29
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'BrandLabel
        '
        Me.BrandLabel.AutoSize = True
        Me.BrandLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.BrandLabel.Location = New System.Drawing.Point(415, 26)
        Me.BrandLabel.Name = "BrandLabel"
        Me.BrandLabel.Size = New System.Drawing.Size(246, 37)
        Me.BrandLabel.TabIndex = 30
        Me.BrandLabel.Text = "for [business name]"
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.UserLabel.Location = New System.Drawing.Point(743, 26)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(76, 37)
        Me.UserLabel.TabIndex = 30
        Me.UserLabel.Text = "User:"
        '
        'SalesButton
        '
        Me.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesButton.Location = New System.Drawing.Point(0, 0)
        Me.SalesButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(150, 243)
        Me.SalesButton.TabIndex = 31
        Me.SalesButton.Text = "Sales"
        Me.SalesButton.UseVisualStyleBackColor = True
        '
        'ProductLookupButton
        '
        Me.ProductLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductLookupButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLookupButton.Location = New System.Drawing.Point(0, 243)
        Me.ProductLookupButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ProductLookupButton.Name = "ProductLookupButton"
        Me.ProductLookupButton.Size = New System.Drawing.Size(150, 243)
        Me.ProductLookupButton.TabIndex = 32
        Me.ProductLookupButton.Text = "Product Lookup"
        Me.ProductLookupButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(0, 486)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(150, 243)
        Me.LogoutButton.TabIndex = 33
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'UserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.SalesButton)
        Me.Controls.Add(Me.ProductLookupButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.BrandLabel)
        Me.Controls.Add(Me.LogoLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoLabel As Label
    Friend WithEvents BrandLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents SalesButton As Button
    Friend WithEvents ProductLookupButton As Button
    Friend WithEvents LogoutButton As Button
End Class
