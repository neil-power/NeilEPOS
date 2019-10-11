<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductLookupWindow
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FoundGenreLabel = New System.Windows.Forms.Label()
        Me.FoundPriceLabel = New System.Windows.Forms.Label()
        Me.FoundAuthorLabel = New System.Windows.Forms.Label()
        Me.FoundTitleLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.GenreLabel = New System.Windows.Forms.Label()
        Me.ISBNMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RRPLabel = New System.Windows.Forms.Label()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.InstructionLabel.Location = New System.Drawing.Point(16, 11)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(105, 24)
        Me.InstructionLabel.TabIndex = 54
        Me.InstructionLabel.Text = "[Instruction]"
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(236, 318)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 75)
        Me.CloseButton.TabIndex = 52
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(21, 318)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 75)
        Me.SearchButton.TabIndex = 53
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FoundGenreLabel
        '
        Me.FoundGenreLabel.AutoSize = True
        Me.FoundGenreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundGenreLabel.Location = New System.Drawing.Point(177, 211)
        Me.FoundGenreLabel.Name = "FoundGenreLabel"
        Me.FoundGenreLabel.Size = New System.Drawing.Size(159, 24)
        Me.FoundGenreLabel.TabIndex = 43
        Me.FoundGenreLabel.Text = "[FOUND GENRE]"
        '
        'FoundPriceLabel
        '
        Me.FoundPriceLabel.AutoSize = True
        Me.FoundPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundPriceLabel.Location = New System.Drawing.Point(177, 168)
        Me.FoundPriceLabel.Name = "FoundPriceLabel"
        Me.FoundPriceLabel.Size = New System.Drawing.Size(147, 24)
        Me.FoundPriceLabel.TabIndex = 44
        Me.FoundPriceLabel.Text = "[FOUND PRICE]"
        '
        'FoundAuthorLabel
        '
        Me.FoundAuthorLabel.AutoSize = True
        Me.FoundAuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundAuthorLabel.Location = New System.Drawing.Point(177, 116)
        Me.FoundAuthorLabel.Name = "FoundAuthorLabel"
        Me.FoundAuthorLabel.Size = New System.Drawing.Size(172, 24)
        Me.FoundAuthorLabel.TabIndex = 45
        Me.FoundAuthorLabel.Text = "[FOUND AUTHOR]"
        '
        'FoundTitleLabel
        '
        Me.FoundTitleLabel.AutoSize = True
        Me.FoundTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoundTitleLabel.Location = New System.Drawing.Point(177, 78)
        Me.FoundTitleLabel.Name = "FoundTitleLabel"
        Me.FoundTitleLabel.Size = New System.Drawing.Size(143, 24)
        Me.FoundTitleLabel.TabIndex = 46
        Me.FoundTitleLabel.Text = "[FOUND TITLE]"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(29, 78)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(50, 24)
        Me.TitleLabel.TabIndex = 47
        Me.TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorLabel.Location = New System.Drawing.Point(29, 116)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(71, 24)
        Me.AuthorLabel.TabIndex = 48
        Me.AuthorLabel.Text = "Author:"
        '
        'GenreLabel
        '
        Me.GenreLabel.AutoSize = True
        Me.GenreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreLabel.Location = New System.Drawing.Point(29, 211)
        Me.GenreLabel.Name = "GenreLabel"
        Me.GenreLabel.Size = New System.Drawing.Size(68, 24)
        Me.GenreLabel.TabIndex = 49
        Me.GenreLabel.Text = "Genre:"
        '
        'ISBNMaskedTextBox
        '
        Me.ISBNMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNMaskedTextBox.Location = New System.Drawing.Point(181, 41)
        Me.ISBNMaskedTextBox.Mask = "000000000999"
        Me.ISBNMaskedTextBox.Name = "ISBNMaskedTextBox"
        Me.ISBNMaskedTextBox.Size = New System.Drawing.Size(191, 29)
        Me.ISBNMaskedTextBox.TabIndex = 51
        Me.ISBNMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'RRPLabel
        '
        Me.RRPLabel.AutoSize = True
        Me.RRPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRPLabel.Location = New System.Drawing.Point(29, 168)
        Me.RRPLabel.Name = "RRPLabel"
        Me.RRPLabel.Size = New System.Drawing.Size(58, 24)
        Me.RRPLabel.TabIndex = 50
        Me.RRPLabel.Text = "RRP: "
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNLabel.Location = New System.Drawing.Point(29, 46)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(107, 24)
        Me.ISBNLabel.TabIndex = 42
        Me.ISBNLabel.Text = "ISBN/EAN: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 93)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Write examples"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(128, 318)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 75)
        Me.ClearButton.TabIndex = 52
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ProductLookupWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.FoundGenreLabel)
        Me.Controls.Add(Me.FoundPriceLabel)
        Me.Controls.Add(Me.FoundAuthorLabel)
        Me.Controls.Add(Me.FoundTitleLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.GenreLabel)
        Me.Controls.Add(Me.ISBNMaskedTextBox)
        Me.Controls.Add(Me.RRPLabel)
        Me.Controls.Add(Me.ISBNLabel)
        Me.Controls.Add(Me.Button1)
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "ProductLookupWindow"
        Me.Text = "ProductLookupWindow"
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
    Friend WithEvents TitleLabel As Label
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents GenreLabel As Label
    Friend WithEvents ISBNMaskedTextBox As MaskedTextBox
    Friend WithEvents RRPLabel As Label
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ClearButton As Button
End Class
