<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProductsWindow
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
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.GenreComboBox = New System.Windows.Forms.ComboBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SaveProductButton = New System.Windows.Forms.Button()
        Me.DeleteProductButton = New System.Windows.Forms.Button()
        Me.EditProductButton = New System.Windows.Forms.Button()
        Me.NewProductButton = New System.Windows.Forms.Button()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.RRPTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GenreLabel = New System.Windows.Forms.Label()
        Me.RRPLabel = New System.Windows.Forms.Label()
        Me.ProductIDTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.ProductIDLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.InstructionLabel.Location = New System.Drawing.Point(21, 105)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(105, 24)
        Me.InstructionLabel.TabIndex = 56
        Me.InstructionLabel.Text = "[Instruction]"
        '
        'GenreComboBox
        '
        Me.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GenreComboBox.FormattingEnabled = True
        Me.GenreComboBox.Items.AddRange(New Object() {"None", "User", "Manager"})
        Me.GenreComboBox.Location = New System.Drawing.Point(186, 298)
        Me.GenreComboBox.Name = "GenreComboBox"
        Me.GenreComboBox.Size = New System.Drawing.Size(191, 32)
        Me.GenreComboBox.TabIndex = 55
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(264, 369)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 75)
        Me.CloseButton.TabIndex = 49
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(143, 369)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 75)
        Me.SearchButton.TabIndex = 50
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SaveProductButton
        '
        Me.SaveProductButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveProductButton.Location = New System.Drawing.Point(25, 369)
        Me.SaveProductButton.Name = "SaveProductButton"
        Me.SaveProductButton.Size = New System.Drawing.Size(100, 75)
        Me.SaveProductButton.TabIndex = 51
        Me.SaveProductButton.Text = "Save Product"
        Me.SaveProductButton.UseVisualStyleBackColor = True
        '
        'DeleteProductButton
        '
        Me.DeleteProductButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProductButton.Location = New System.Drawing.Point(264, 24)
        Me.DeleteProductButton.Name = "DeleteProductButton"
        Me.DeleteProductButton.Size = New System.Drawing.Size(100, 75)
        Me.DeleteProductButton.TabIndex = 52
        Me.DeleteProductButton.Text = "Delete Product"
        Me.DeleteProductButton.UseVisualStyleBackColor = True
        '
        'EditProductButton
        '
        Me.EditProductButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditProductButton.Location = New System.Drawing.Point(143, 24)
        Me.EditProductButton.Name = "EditProductButton"
        Me.EditProductButton.Size = New System.Drawing.Size(100, 75)
        Me.EditProductButton.TabIndex = 53
        Me.EditProductButton.Text = "Edit Product"
        Me.EditProductButton.UseVisualStyleBackColor = True
        '
        'NewProductButton
        '
        Me.NewProductButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewProductButton.Location = New System.Drawing.Point(25, 24)
        Me.NewProductButton.Name = "NewProductButton"
        Me.NewProductButton.Size = New System.Drawing.Size(100, 75)
        Me.NewProductButton.TabIndex = 54
        Me.NewProductButton.Text = "New Product"
        Me.NewProductButton.UseVisualStyleBackColor = True
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(186, 182)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(191, 29)
        Me.TitleTextBox.TabIndex = 46
        '
        'RRPTextBox
        '
        Me.RRPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRPTextBox.Location = New System.Drawing.Point(186, 259)
        Me.RRPTextBox.Name = "RRPTextBox"
        Me.RRPTextBox.Size = New System.Drawing.Size(191, 29)
        Me.RRPTextBox.TabIndex = 47
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(186, 222)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(191, 29)
        Me.AuthorTextBox.TabIndex = 48
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(34, 182)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(50, 24)
        Me.TitleLabel.TabIndex = 41
        Me.TitleLabel.Text = "Title:"
        '
        'GenreLabel
        '
        Me.GenreLabel.AutoSize = True
        Me.GenreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreLabel.Location = New System.Drawing.Point(34, 301)
        Me.GenreLabel.Name = "GenreLabel"
        Me.GenreLabel.Size = New System.Drawing.Size(68, 24)
        Me.GenreLabel.TabIndex = 42
        Me.GenreLabel.Text = "Genre:"
        '
        'RRPLabel
        '
        Me.RRPLabel.AutoSize = True
        Me.RRPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRPLabel.Location = New System.Drawing.Point(34, 261)
        Me.RRPLabel.Name = "RRPLabel"
        Me.RRPLabel.Size = New System.Drawing.Size(53, 24)
        Me.RRPLabel.TabIndex = 43
        Me.RRPLabel.Text = "RRP:"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(186, 135)
        Me.ProductIDTextBox.Mask = "000000000999"
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(191, 29)
        Me.ProductIDTextBox.TabIndex = 45
        Me.ProductIDTextBox.ValidatingType = GetType(Integer)
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLabel.Location = New System.Drawing.Point(34, 222)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(76, 24)
        Me.AuthorLabel.TabIndex = 44
        Me.AuthorLabel.Text = "Author: "
        '
        'ProductIDLabel
        '
        Me.ProductIDLabel.AutoSize = True
        Me.ProductIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDLabel.Location = New System.Drawing.Point(34, 140)
        Me.ProductIDLabel.Name = "ProductIDLabel"
        Me.ProductIDLabel.Size = New System.Drawing.Size(107, 24)
        Me.ProductIDLabel.TabIndex = 40
        Me.ProductIDLabel.Text = "Product ID: "
        '
        'ManageProductsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.GenreComboBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SaveProductButton)
        Me.Controls.Add(Me.DeleteProductButton)
        Me.Controls.Add(Me.EditProductButton)
        Me.Controls.Add(Me.NewProductButton)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.RRPTextBox)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.GenreLabel)
        Me.Controls.Add(Me.RRPLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.ProductIDLabel)
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "ManageProductsWindow"
        Me.Text = "ManageProductsWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InstructionLabel As Label
    Friend WithEvents GenreComboBox As ComboBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents SaveProductButton As Button
    Friend WithEvents DeleteProductButton As Button
    Friend WithEvents EditProductButton As Button
    Friend WithEvents NewProductButton As Button
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents RRPTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents GenreLabel As Label
    Friend WithEvents RRPLabel As Label
    Friend WithEvents ProductIDTextBox As MaskedTextBox
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents ProductIDLabel As Label
End Class
