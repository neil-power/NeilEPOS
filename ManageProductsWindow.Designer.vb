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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProductsWindow))
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.GenreComboBox = New System.Windows.Forms.ComboBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SaveProductButton = New System.Windows.Forms.Button()
        Me.DeleteProductButton = New System.Windows.Forms.Button()
        Me.EditProductButton = New System.Windows.Forms.Button()
        Me.NewProductButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GenreLabel = New System.Windows.Forms.Label()
        Me.RRPLabel = New System.Windows.Forms.Label()
        Me.ProductIDTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.ProductIDLabel = New System.Windows.Forms.Label()
        Me.OnlineLookupButton = New System.Windows.Forms.Button()
        Me.WebCrawler = New System.Windows.Forms.WebBrowser()
        Me.RRPTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TitleTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AuthorTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionLabel.Location = New System.Drawing.Point(20, 120)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(158, 37)
        Me.InstructionLabel.TabIndex = 56
        Me.InstructionLabel.Text = "[Instruction]"
        '
        'GenreComboBox
        '
        Me.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenreComboBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreComboBox.FormattingEnabled = True
        Me.GenreComboBox.Items.AddRange(New Object() {"None", "User", "Manager"})
        Me.GenreComboBox.Location = New System.Drawing.Point(198, 412)
        Me.GenreComboBox.Name = "GenreComboBox"
        Me.GenreComboBox.Size = New System.Drawing.Size(422, 45)
        Me.GenreComboBox.TabIndex = 8
        '
        'CloseButton
        '
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(470, 500)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(150, 100)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(320, 500)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(150, 100)
        Me.SearchButton.TabIndex = 11
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SaveProductButton
        '
        Me.SaveProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveProductButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveProductButton.Location = New System.Drawing.Point(20, 500)
        Me.SaveProductButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SaveProductButton.Name = "SaveProductButton"
        Me.SaveProductButton.Size = New System.Drawing.Size(150, 100)
        Me.SaveProductButton.TabIndex = 9
        Me.SaveProductButton.Text = "Save Product"
        Me.SaveProductButton.UseVisualStyleBackColor = True
        '
        'DeleteProductButton
        '
        Me.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteProductButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProductButton.Location = New System.Drawing.Point(320, 0)
        Me.DeleteProductButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteProductButton.Name = "DeleteProductButton"
        Me.DeleteProductButton.Size = New System.Drawing.Size(150, 100)
        Me.DeleteProductButton.TabIndex = 3
        Me.DeleteProductButton.Text = "Delete Product"
        Me.DeleteProductButton.UseVisualStyleBackColor = True
        '
        'EditProductButton
        '
        Me.EditProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditProductButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditProductButton.Location = New System.Drawing.Point(170, 0)
        Me.EditProductButton.Margin = New System.Windows.Forms.Padding(0)
        Me.EditProductButton.Name = "EditProductButton"
        Me.EditProductButton.Size = New System.Drawing.Size(150, 100)
        Me.EditProductButton.TabIndex = 2
        Me.EditProductButton.Text = "Edit Product"
        Me.EditProductButton.UseVisualStyleBackColor = True
        '
        'NewProductButton
        '
        Me.NewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewProductButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewProductButton.Location = New System.Drawing.Point(20, 0)
        Me.NewProductButton.Margin = New System.Windows.Forms.Padding(0)
        Me.NewProductButton.Name = "NewProductButton"
        Me.NewProductButton.Size = New System.Drawing.Size(150, 100)
        Me.NewProductButton.TabIndex = 1
        Me.NewProductButton.Text = "New Product"
        Me.NewProductButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(20, 240)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(74, 37)
        Me.TitleLabel.TabIndex = 41
        Me.TitleLabel.Text = "Title:"
        '
        'GenreLabel
        '
        Me.GenreLabel.AutoSize = True
        Me.GenreLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreLabel.Location = New System.Drawing.Point(20, 420)
        Me.GenreLabel.Name = "GenreLabel"
        Me.GenreLabel.Size = New System.Drawing.Size(94, 37)
        Me.GenreLabel.TabIndex = 42
        Me.GenreLabel.Text = "Genre:"
        '
        'RRPLabel
        '
        Me.RRPLabel.AutoSize = True
        Me.RRPLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRPLabel.Location = New System.Drawing.Point(20, 360)
        Me.RRPLabel.Name = "RRPLabel"
        Me.RRPLabel.Size = New System.Drawing.Size(70, 37)
        Me.RRPLabel.TabIndex = 43
        Me.RRPLabel.Text = "RRP:"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(198, 174)
        Me.ProductIDTextBox.Mask = "0000000000999"
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ProductIDTextBox.Size = New System.Drawing.Size(422, 43)
        Me.ProductIDTextBox.TabIndex = 4
        Me.ProductIDTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.ProductIDTextBox.ValidatingType = GetType(Integer)
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLabel.Location = New System.Drawing.Point(20, 300)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(111, 37)
        Me.AuthorLabel.TabIndex = 44
        Me.AuthorLabel.Text = "Author: "
        '
        'ProductIDLabel
        '
        Me.ProductIDLabel.AutoSize = True
        Me.ProductIDLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDLabel.Location = New System.Drawing.Point(20, 180)
        Me.ProductIDLabel.Name = "ProductIDLabel"
        Me.ProductIDLabel.Size = New System.Drawing.Size(155, 37)
        Me.ProductIDLabel.TabIndex = 40
        Me.ProductIDLabel.Text = "Product ID: "
        '
        'OnlineLookupButton
        '
        Me.OnlineLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OnlineLookupButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnlineLookupButton.Location = New System.Drawing.Point(170, 500)
        Me.OnlineLookupButton.Margin = New System.Windows.Forms.Padding(0)
        Me.OnlineLookupButton.Name = "OnlineLookupButton"
        Me.OnlineLookupButton.Size = New System.Drawing.Size(150, 100)
        Me.OnlineLookupButton.TabIndex = 10
        Me.OnlineLookupButton.Text = "Online Lookup"
        Me.OnlineLookupButton.UseVisualStyleBackColor = True
        '
        'WebCrawler
        '
        Me.WebCrawler.Location = New System.Drawing.Point(752, 529)
        Me.WebCrawler.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebCrawler.Name = "WebCrawler"
        Me.WebCrawler.Size = New System.Drawing.Size(20, 20)
        Me.WebCrawler.TabIndex = 58
        Me.WebCrawler.TabStop = False
        Me.WebCrawler.Visible = False
        '
        'RRPTextBox
        '
        Me.RRPTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRPTextBox.Location = New System.Drawing.Point(198, 354)
        Me.RRPTextBox.Mask = "£00.00"
        Me.RRPTextBox.Name = "RRPTextBox"
        Me.RRPTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.RRPTextBox.Size = New System.Drawing.Size(422, 43)
        Me.RRPTextBox.TabIndex = 7
        Me.RRPTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.RRPTextBox.ValidatingType = GetType(Integer)
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(198, 234)
        Me.TitleTextBox.Mask = "AAaaaaaaaaaaaaaaaaaa"
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TitleTextBox.Size = New System.Drawing.Size(422, 43)
        Me.TitleTextBox.TabIndex = 5
        Me.TitleTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.TitleTextBox.ValidatingType = GetType(Integer)
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(198, 294)
        Me.AuthorTextBox.Mask = "LL??????????????????"
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.AuthorTextBox.Size = New System.Drawing.Size(422, 43)
        Me.AuthorTextBox.TabIndex = 6
        Me.AuthorTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.AuthorTextBox.ValidatingType = GetType(Integer)
        '
        'ManageProductsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 650)
        Me.Controls.Add(Me.WebCrawler)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.GenreComboBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.OnlineLookupButton)
        Me.Controls.Add(Me.SaveProductButton)
        Me.Controls.Add(Me.DeleteProductButton)
        Me.Controls.Add(Me.EditProductButton)
        Me.Controls.Add(Me.NewProductButton)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.GenreLabel)
        Me.Controls.Add(Me.RRPLabel)
        Me.Controls.Add(Me.RRPTextBox)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.ProductIDLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "ManageProductsWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NeilEPOS"
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
    Friend WithEvents TitleLabel As Label
    Friend WithEvents GenreLabel As Label
    Friend WithEvents RRPLabel As Label
    Friend WithEvents ProductIDTextBox As MaskedTextBox
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents ProductIDLabel As Label
    Friend WithEvents OnlineLookupButton As Button
    Friend WithEvents WebCrawler As WebBrowser
    Friend WithEvents RRPTextBox As MaskedTextBox
    Friend WithEvents TitleTextBox As MaskedTextBox
    Friend WithEvents AuthorTextBox As MaskedTextBox
End Class
