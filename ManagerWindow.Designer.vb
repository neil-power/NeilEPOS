﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ActionPromptLabel = New System.Windows.Forms.Label()
        Me.DailySummaryButton = New System.Windows.Forms.Button()
        Me.EditProductButton = New System.Windows.Forms.Button()
        Me.ManageUsersButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(12, 24)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(333, 76)
        Me.LogoLabel.TabIndex = 1
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'SalesButton
        '
        Me.SalesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesButton.Location = New System.Drawing.Point(25, 134)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(100, 75)
        Me.SalesButton.TabIndex = 20
        Me.SalesButton.Text = "Sales"
        Me.SalesButton.UseVisualStyleBackColor = True
        '
        'ProductLookupButton
        '
        Me.ProductLookupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLookupButton.Location = New System.Drawing.Point(142, 134)
        Me.ProductLookupButton.Name = "ProductLookupButton"
        Me.ProductLookupButton.Size = New System.Drawing.Size(100, 75)
        Me.ProductLookupButton.TabIndex = 20
        Me.ProductLookupButton.Text = "Product Lookup"
        Me.ProductLookupButton.UseVisualStyleBackColor = True
        '
        'ActionPromptLabel
        '
        Me.ActionPromptLabel.AutoSize = True
        Me.ActionPromptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ActionPromptLabel.Location = New System.Drawing.Point(21, 95)
        Me.ActionPromptLabel.Name = "ActionPromptLabel"
        Me.ActionPromptLabel.Size = New System.Drawing.Size(376, 24)
        Me.ActionPromptLabel.TabIndex = 21
        Me.ActionPromptLabel.Text = "Please select the action you wish to perform"
        '
        'DailySummaryButton
        '
        Me.DailySummaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailySummaryButton.Location = New System.Drawing.Point(25, 224)
        Me.DailySummaryButton.Name = "DailySummaryButton"
        Me.DailySummaryButton.Size = New System.Drawing.Size(100, 75)
        Me.DailySummaryButton.TabIndex = 20
        Me.DailySummaryButton.Text = "Daily Summary"
        Me.DailySummaryButton.UseVisualStyleBackColor = True
        '
        'EditProductButton
        '
        Me.EditProductButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditProductButton.Location = New System.Drawing.Point(262, 134)
        Me.EditProductButton.Name = "EditProductButton"
        Me.EditProductButton.Size = New System.Drawing.Size(100, 75)
        Me.EditProductButton.TabIndex = 20
        Me.EditProductButton.Text = "Edit Product"
        Me.EditProductButton.UseVisualStyleBackColor = True
        '
        'ManageUsersButton
        '
        Me.ManageUsersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageUsersButton.Location = New System.Drawing.Point(142, 224)
        Me.ManageUsersButton.Name = "ManageUsersButton"
        Me.ManageUsersButton.Size = New System.Drawing.Size(100, 75)
        Me.ManageUsersButton.TabIndex = 20
        Me.ManageUsersButton.Text = "Manage Users"
        Me.ManageUsersButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(262, 224)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(100, 75)
        Me.LogoutButton.TabIndex = 20
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'ManagerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 337)
        Me.Controls.Add(Me.ActionPromptLabel)
        Me.Controls.Add(Me.ManageUsersButton)
        Me.Controls.Add(Me.DailySummaryButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.EditProductButton)
        Me.Controls.Add(Me.ProductLookupButton)
        Me.Controls.Add(Me.SalesButton)
        Me.Controls.Add(Me.LogoLabel)
        Me.Name = "ManagerWindow"
        Me.Text = "ManagerWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoLabel As Label
    Friend WithEvents SalesButton As Button
    Friend WithEvents ProductLookupButton As Button
    Friend WithEvents ActionPromptLabel As Label
    Friend WithEvents DailySummaryButton As Button
    Friend WithEvents EditProductButton As Button
    Friend WithEvents ManageUsersButton As Button
    Friend WithEvents LogoutButton As Button
End Class
