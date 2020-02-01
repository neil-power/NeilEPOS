<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesWindow))
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.NumButton7 = New System.Windows.Forms.Button()
        Me.NumButton8 = New System.Windows.Forms.Button()
        Me.NumButton9 = New System.Windows.Forms.Button()
        Me.NumButton4 = New System.Windows.Forms.Button()
        Me.NumButton5 = New System.Windows.Forms.Button()
        Me.NumButton6 = New System.Windows.Forms.Button()
        Me.NumButton1 = New System.Windows.Forms.Button()
        Me.NumButton2 = New System.Windows.Forms.Button()
        Me.NumButton3 = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.NumButton0 = New System.Windows.Forms.Button()
        Me.DelButton = New System.Windows.Forms.Button()
        Me.TakePaymentButton = New System.Windows.Forms.Button()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.AbandonSale = New System.Windows.Forms.Button()
        Me.PriceTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ISBNTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.QuantityTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PriceLookupButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.WebCrawler = New System.Windows.Forms.WebBrowser()
        Me.SalesDataGrid = New System.Windows.Forms.DataGridView()
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.RemoveItemButton = New System.Windows.Forms.Button()
        CType(Me.SalesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNLabel.Location = New System.Drawing.Point(20, 20)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(79, 37)
        Me.ISBNLabel.TabIndex = 0
        Me.ISBNLabel.Text = "ISBN:"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(20, 80)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(80, 37)
        Me.PriceLabel.TabIndex = 0
        Me.PriceLabel.Text = "Price:"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLabel.Location = New System.Drawing.Point(20, 140)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(125, 37)
        Me.QuantityLabel.TabIndex = 0
        Me.QuantityLabel.Text = "Quantity:"
        '
        'NumButton7
        '
        Me.NumButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton7.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton7.Location = New System.Drawing.Point(20, 210)
        Me.NumButton7.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton7.Name = "NumButton7"
        Me.NumButton7.Size = New System.Drawing.Size(100, 100)
        Me.NumButton7.TabIndex = 2
        Me.NumButton7.TabStop = False
        Me.NumButton7.Text = "7"
        Me.NumButton7.UseVisualStyleBackColor = True
        '
        'NumButton8
        '
        Me.NumButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton8.Location = New System.Drawing.Point(120, 210)
        Me.NumButton8.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton8.Name = "NumButton8"
        Me.NumButton8.Size = New System.Drawing.Size(100, 100)
        Me.NumButton8.TabIndex = 2
        Me.NumButton8.TabStop = False
        Me.NumButton8.Text = "8"
        Me.NumButton8.UseVisualStyleBackColor = True
        '
        'NumButton9
        '
        Me.NumButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton9.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton9.Location = New System.Drawing.Point(220, 210)
        Me.NumButton9.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton9.Name = "NumButton9"
        Me.NumButton9.Size = New System.Drawing.Size(100, 100)
        Me.NumButton9.TabIndex = 2
        Me.NumButton9.TabStop = False
        Me.NumButton9.Text = "9"
        Me.NumButton9.UseVisualStyleBackColor = True
        '
        'NumButton4
        '
        Me.NumButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton4.Location = New System.Drawing.Point(20, 310)
        Me.NumButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton4.Name = "NumButton4"
        Me.NumButton4.Size = New System.Drawing.Size(100, 100)
        Me.NumButton4.TabIndex = 2
        Me.NumButton4.TabStop = False
        Me.NumButton4.Text = "4"
        Me.NumButton4.UseVisualStyleBackColor = True
        '
        'NumButton5
        '
        Me.NumButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton5.Location = New System.Drawing.Point(120, 309)
        Me.NumButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton5.Name = "NumButton5"
        Me.NumButton5.Size = New System.Drawing.Size(100, 100)
        Me.NumButton5.TabIndex = 2
        Me.NumButton5.TabStop = False
        Me.NumButton5.Text = "5"
        Me.NumButton5.UseVisualStyleBackColor = True
        '
        'NumButton6
        '
        Me.NumButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton6.Location = New System.Drawing.Point(220, 309)
        Me.NumButton6.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton6.Name = "NumButton6"
        Me.NumButton6.Size = New System.Drawing.Size(100, 100)
        Me.NumButton6.TabIndex = 2
        Me.NumButton6.TabStop = False
        Me.NumButton6.Text = "6"
        Me.NumButton6.UseVisualStyleBackColor = True
        '
        'NumButton1
        '
        Me.NumButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton1.Location = New System.Drawing.Point(20, 409)
        Me.NumButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton1.Name = "NumButton1"
        Me.NumButton1.Size = New System.Drawing.Size(100, 100)
        Me.NumButton1.TabIndex = 2
        Me.NumButton1.TabStop = False
        Me.NumButton1.Text = "1"
        Me.NumButton1.UseVisualStyleBackColor = True
        '
        'NumButton2
        '
        Me.NumButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton2.Location = New System.Drawing.Point(120, 409)
        Me.NumButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton2.Name = "NumButton2"
        Me.NumButton2.Size = New System.Drawing.Size(100, 100)
        Me.NumButton2.TabIndex = 2
        Me.NumButton2.TabStop = False
        Me.NumButton2.Text = "2"
        Me.NumButton2.UseVisualStyleBackColor = True
        '
        'NumButton3
        '
        Me.NumButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton3.Location = New System.Drawing.Point(220, 409)
        Me.NumButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton3.Name = "NumButton3"
        Me.NumButton3.Size = New System.Drawing.Size(100, 100)
        Me.NumButton3.TabIndex = 2
        Me.NumButton3.TabStop = False
        Me.NumButton3.Text = "3"
        Me.NumButton3.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(20, 509)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 100)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.TabStop = False
        Me.ClearButton.Text = "CLR"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'NumButton0
        '
        Me.NumButton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumButton0.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumButton0.Location = New System.Drawing.Point(120, 509)
        Me.NumButton0.Margin = New System.Windows.Forms.Padding(0)
        Me.NumButton0.Name = "NumButton0"
        Me.NumButton0.Size = New System.Drawing.Size(100, 100)
        Me.NumButton0.TabIndex = 2
        Me.NumButton0.TabStop = False
        Me.NumButton0.Text = "0"
        Me.NumButton0.UseVisualStyleBackColor = True
        '
        'DelButton
        '
        Me.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelButton.Location = New System.Drawing.Point(220, 509)
        Me.DelButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DelButton.Name = "DelButton"
        Me.DelButton.Size = New System.Drawing.Size(100, 100)
        Me.DelButton.TabIndex = 2
        Me.DelButton.TabStop = False
        Me.DelButton.Text = "DEL"
        Me.DelButton.UseVisualStyleBackColor = True
        '
        'TakePaymentButton
        '
        Me.TakePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TakePaymentButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TakePaymentButton.Location = New System.Drawing.Point(665, 415)
        Me.TakePaymentButton.Margin = New System.Windows.Forms.Padding(0)
        Me.TakePaymentButton.Name = "TakePaymentButton"
        Me.TakePaymentButton.Size = New System.Drawing.Size(150, 100)
        Me.TakePaymentButton.TabIndex = 6
        Me.TakePaymentButton.Text = "Take Payment"
        Me.TakePaymentButton.UseVisualStyleBackColor = True
        '
        'AddItemButton
        '
        Me.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddItemButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItemButton.Location = New System.Drawing.Point(365, 415)
        Me.AddItemButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(150, 100)
        Me.AddItemButton.TabIndex = 4
        Me.AddItemButton.Text = "Add Item"
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'AbandonSale
        '
        Me.AbandonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbandonSale.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbandonSale.Location = New System.Drawing.Point(515, 515)
        Me.AbandonSale.Margin = New System.Windows.Forms.Padding(0)
        Me.AbandonSale.Name = "AbandonSale"
        Me.AbandonSale.Size = New System.Drawing.Size(150, 100)
        Me.AbandonSale.TabIndex = 8
        Me.AbandonSale.Text = "Abandon Sale"
        Me.AbandonSale.UseVisualStyleBackColor = True
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.PriceTextBox.Location = New System.Drawing.Point(151, 74)
        Me.PriceTextBox.Mask = "##.## $"
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.PriceTextBox.ResetOnPrompt = False
        Me.PriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PriceTextBox.Size = New System.Drawing.Size(181, 43)
        Me.PriceTextBox.TabIndex = 2
        Me.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PriceTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.ISBNTextBox.Location = New System.Drawing.Point(106, 9)
        Me.ISBNTextBox.Mask = "0000000000999"
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ISBNTextBox.Size = New System.Drawing.Size(226, 43)
        Me.ISBNTextBox.TabIndex = 1
        Me.ISBNTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.QuantityTextBox.Location = New System.Drawing.Point(152, 134)
        Me.QuantityTextBox.Mask = "##"
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.QuantityTextBox.Size = New System.Drawing.Size(180, 43)
        Me.QuantityTextBox.TabIndex = 3
        Me.QuantityTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'PriceLookupButton
        '
        Me.PriceLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriceLookupButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLookupButton.Location = New System.Drawing.Point(515, 415)
        Me.PriceLookupButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PriceLookupButton.Name = "PriceLookupButton"
        Me.PriceLookupButton.Size = New System.Drawing.Size(150, 100)
        Me.PriceLookupButton.TabIndex = 5
        Me.PriceLookupButton.Text = "Price Lookup"
        Me.PriceLookupButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(665, 515)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(150, 100)
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'WebCrawler
        '
        Me.WebCrawler.Location = New System.Drawing.Point(744, 529)
        Me.WebCrawler.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebCrawler.Name = "WebCrawler"
        Me.WebCrawler.Size = New System.Drawing.Size(20, 20)
        Me.WebCrawler.TabIndex = 56
        Me.WebCrawler.Visible = False
        '
        'SalesDataGrid
        '
        Me.SalesDataGrid.AllowUserToAddRows = False
        Me.SalesDataGrid.AllowUserToDeleteRows = False
        Me.SalesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataGrid.Location = New System.Drawing.Point(365, 57)
        Me.SalesDataGrid.Name = "SalesDataGrid"
        Me.SalesDataGrid.ReadOnly = True
        Me.SalesDataGrid.RowHeadersVisible = False
        Me.SalesDataGrid.Size = New System.Drawing.Size(450, 338)
        Me.SalesDataGrid.TabIndex = 57
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionLabel.Location = New System.Drawing.Point(358, 9)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(158, 37)
        Me.InstructionLabel.TabIndex = 0
        Me.InstructionLabel.Text = "[Instruction]"
        '
        'RemoveItemButton
        '
        Me.RemoveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveItemButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveItemButton.Location = New System.Drawing.Point(365, 515)
        Me.RemoveItemButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RemoveItemButton.Name = "RemoveItemButton"
        Me.RemoveItemButton.Size = New System.Drawing.Size(150, 100)
        Me.RemoveItemButton.TabIndex = 7
        Me.RemoveItemButton.Text = "Remove Item"
        Me.RemoveItemButton.UseVisualStyleBackColor = True
        '
        'SalesWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 650)
        Me.Controls.Add(Me.SalesDataGrid)
        Me.Controls.Add(Me.WebCrawler)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.PriceLookupButton)
        Me.Controls.Add(Me.RemoveItemButton)
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.AbandonSale)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TakePaymentButton)
        Me.Controls.Add(Me.DelButton)
        Me.Controls.Add(Me.NumButton6)
        Me.Controls.Add(Me.NumButton0)
        Me.Controls.Add(Me.NumButton5)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.NumButton4)
        Me.Controls.Add(Me.NumButton3)
        Me.Controls.Add(Me.NumButton9)
        Me.Controls.Add(Me.NumButton2)
        Me.Controls.Add(Me.NumButton8)
        Me.Controls.Add(Me.NumButton1)
        Me.Controls.Add(Me.NumButton7)
        Me.Controls.Add(Me.QuantityLabel)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.ISBNLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "SalesWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NeilEPOS"
        CType(Me.SalesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ISBNLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents NumButton7 As Button
    Friend WithEvents NumButton8 As Button
    Friend WithEvents NumButton9 As Button
    Friend WithEvents NumButton4 As Button
    Friend WithEvents NumButton5 As Button
    Friend WithEvents NumButton6 As Button
    Friend WithEvents NumButton1 As Button
    Friend WithEvents NumButton2 As Button
    Friend WithEvents NumButton3 As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents NumButton0 As Button
    Friend WithEvents DelButton As Button
    Friend WithEvents TakePaymentButton As Button
    Friend WithEvents AddItemButton As Button
    Friend WithEvents AbandonSale As Button
    Friend WithEvents PriceTextBox As MaskedTextBox
    Friend WithEvents ISBNTextBox As MaskedTextBox
    Friend WithEvents QuantityTextBox As MaskedTextBox
    Friend WithEvents PriceLookupButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents WebCrawler As WebBrowser
    Friend WithEvents SalesDataGrid As DataGridView
    Friend WithEvents InstructionLabel As Label
    Friend WithEvents RemoveItemButton As Button
End Class
