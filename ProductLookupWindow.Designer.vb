<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductLookupWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductLookupWindow))
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FoundGenreLabel = New System.Windows.Forms.Label()
        Me.FoundPriceLabel = New System.Windows.Forms.Label()
        Me.FoundAuthorLabel = New System.Windows.Forms.Label()
        Me.FoundTitleLabel = New System.Windows.Forms.Label()
        Me.ISBNMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.WebCrawler = New System.Windows.Forms.WebBrowser()
        Me.OnlineLookupButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.RRPLabel = New System.Windows.Forms.Label()
        Me.GenreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionLabel.Location = New System.Drawing.Point(20, 20)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(158, 37)
        Me.InstructionLabel.TabIndex = 54
        Me.InstructionLabel.Text = "[Instruction]"
        '
        'CloseButton
        '
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.CloseButton.Location = New System.Drawing.Point(320, 380)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(150, 100)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.SearchButton.Location = New System.Drawing.Point(20, 380)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(150, 100)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FoundGenreLabel
        '
        Me.FoundGenreLabel.AutoSize = True
        Me.FoundGenreLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundGenreLabel.Location = New System.Drawing.Point(181, 320)
        Me.FoundGenreLabel.Name = "FoundGenreLabel"
        Me.FoundGenreLabel.Size = New System.Drawing.Size(214, 37)
        Me.FoundGenreLabel.TabIndex = 43
        Me.FoundGenreLabel.Text = "[FOUND GENRE]"
        '
        'FoundPriceLabel
        '
        Me.FoundPriceLabel.AutoSize = True
        Me.FoundPriceLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundPriceLabel.Location = New System.Drawing.Point(181, 260)
        Me.FoundPriceLabel.Name = "FoundPriceLabel"
        Me.FoundPriceLabel.Size = New System.Drawing.Size(200, 37)
        Me.FoundPriceLabel.TabIndex = 44
        Me.FoundPriceLabel.Text = "[FOUND PRICE]"
        '
        'FoundAuthorLabel
        '
        Me.FoundAuthorLabel.AutoSize = True
        Me.FoundAuthorLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundAuthorLabel.Location = New System.Drawing.Point(181, 200)
        Me.FoundAuthorLabel.Name = "FoundAuthorLabel"
        Me.FoundAuthorLabel.Size = New System.Drawing.Size(235, 37)
        Me.FoundAuthorLabel.TabIndex = 45
        Me.FoundAuthorLabel.Text = "[FOUND AUTHOR]"
        '
        'FoundTitleLabel
        '
        Me.FoundTitleLabel.AutoSize = True
        Me.FoundTitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundTitleLabel.Location = New System.Drawing.Point(181, 140)
        Me.FoundTitleLabel.Name = "FoundTitleLabel"
        Me.FoundTitleLabel.Size = New System.Drawing.Size(193, 37)
        Me.FoundTitleLabel.TabIndex = 46
        Me.FoundTitleLabel.Text = "[FOUND TITLE]"
        '
        'ISBNMaskedTextBox
        '
        Me.ISBNMaskedTextBox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNMaskedTextBox.Location = New System.Drawing.Point(181, 77)
        Me.ISBNMaskedTextBox.Mask = "0000000000999"
        Me.ISBNMaskedTextBox.Name = "ISBNMaskedTextBox"
        Me.ISBNMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ISBNMaskedTextBox.Size = New System.Drawing.Size(439, 43)
        Me.ISBNMaskedTextBox.TabIndex = 1
        Me.ISBNMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.ISBNMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNLabel.Location = New System.Drawing.Point(20, 80)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(148, 37)
        Me.ISBNLabel.TabIndex = 42
        Me.ISBNLabel.Text = "ISBN/EAN: "
        '
        'ClearButton
        '
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.ClearButton.Location = New System.Drawing.Point(170, 380)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(150, 100)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'WebCrawler
        '
        Me.WebCrawler.Location = New System.Drawing.Point(752, 529)
        Me.WebCrawler.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebCrawler.Name = "WebCrawler"
        Me.WebCrawler.Size = New System.Drawing.Size(20, 20)
        Me.WebCrawler.TabIndex = 57
        Me.WebCrawler.TabStop = False
        Me.WebCrawler.Visible = False
        '
        'OnlineLookupButton
        '
        Me.OnlineLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OnlineLookupButton.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.OnlineLookupButton.Location = New System.Drawing.Point(470, 380)
        Me.OnlineLookupButton.Margin = New System.Windows.Forms.Padding(0)
        Me.OnlineLookupButton.Name = "OnlineLookupButton"
        Me.OnlineLookupButton.Size = New System.Drawing.Size(150, 100)
        Me.OnlineLookupButton.TabIndex = 5
        Me.OnlineLookupButton.Text = "Online Lookup"
        Me.OnlineLookupButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(20, 140)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(74, 37)
        Me.TitleLabel.TabIndex = 58
        Me.TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLabel.Location = New System.Drawing.Point(20, 200)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(104, 37)
        Me.AuthorLabel.TabIndex = 59
        Me.AuthorLabel.Text = "Author:"
        '
        'RRPLabel
        '
        Me.RRPLabel.AutoSize = True
        Me.RRPLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRPLabel.Location = New System.Drawing.Point(20, 260)
        Me.RRPLabel.Name = "RRPLabel"
        Me.RRPLabel.Size = New System.Drawing.Size(77, 37)
        Me.RRPLabel.TabIndex = 61
        Me.RRPLabel.Text = "RRP: "
        '
        'GenreLabel
        '
        Me.GenreLabel.AutoSize = True
        Me.GenreLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreLabel.Location = New System.Drawing.Point(20, 320)
        Me.GenreLabel.Name = "GenreLabel"
        Me.GenreLabel.Size = New System.Drawing.Size(94, 37)
        Me.GenreLabel.TabIndex = 60
        Me.GenreLabel.Text = "Genre:"
        '
        'ProductLookupWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 650)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.RRPLabel)
        Me.Controls.Add(Me.GenreLabel)
        Me.Controls.Add(Me.WebCrawler)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.OnlineLookupButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.FoundGenreLabel)
        Me.Controls.Add(Me.FoundPriceLabel)
        Me.Controls.Add(Me.FoundAuthorLabel)
        Me.Controls.Add(Me.FoundTitleLabel)
        Me.Controls.Add(Me.ISBNMaskedTextBox)
        Me.Controls.Add(Me.ISBNLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "ProductLookupWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NeilEPOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InstructionLabel As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents FoundGenreLabel As Label
    Friend WithEvents FoundPriceLabel As Label
    Friend WithEvents FoundAuthorLabel As Label
    Friend WithEvents FoundTitleLabel As Label
    Friend WithEvents ISBNMaskedTextBox As MaskedTextBox
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents WebCrawler As WebBrowser
    Friend WithEvents OnlineLookupButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents RRPLabel As Label
    Friend WithEvents GenreLabel As Label
End Class
