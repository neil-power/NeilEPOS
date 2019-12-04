<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesSummaryWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesSummaryWindow))
        Me.WeeklySummaryButton = New System.Windows.Forms.Button()
        Me.DailySummaryButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SalesDataGrid = New System.Windows.Forms.DataGridView()
        Me.CalculationLabel = New System.Windows.Forms.Label()
        CType(Me.SalesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WeeklySummaryButton
        '
        Me.WeeklySummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WeeklySummaryButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeeklySummaryButton.Location = New System.Drawing.Point(170, 0)
        Me.WeeklySummaryButton.Margin = New System.Windows.Forms.Padding(0)
        Me.WeeklySummaryButton.Name = "WeeklySummaryButton"
        Me.WeeklySummaryButton.Size = New System.Drawing.Size(150, 100)
        Me.WeeklySummaryButton.TabIndex = 2
        Me.WeeklySummaryButton.Text = "This Week"
        Me.WeeklySummaryButton.UseVisualStyleBackColor = True
        '
        'DailySummaryButton
        '
        Me.DailySummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DailySummaryButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailySummaryButton.Location = New System.Drawing.Point(20, 0)
        Me.DailySummaryButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DailySummaryButton.Name = "DailySummaryButton"
        Me.DailySummaryButton.Size = New System.Drawing.Size(150, 100)
        Me.DailySummaryButton.TabIndex = 1
        Me.DailySummaryButton.Text = "Today"
        Me.DailySummaryButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(320, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(150, 100)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SalesDataGrid
        '
        Me.SalesDataGrid.AllowUserToAddRows = False
        Me.SalesDataGrid.AllowUserToDeleteRows = False
        Me.SalesDataGrid.AllowUserToOrderColumns = True
        Me.SalesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataGrid.Location = New System.Drawing.Point(20, 103)
        Me.SalesDataGrid.Name = "SalesDataGrid"
        Me.SalesDataGrid.ReadOnly = True
        Me.SalesDataGrid.RowHeadersVisible = False
        Me.SalesDataGrid.ShowCellToolTips = False
        Me.SalesDataGrid.ShowEditingIcon = False
        Me.SalesDataGrid.Size = New System.Drawing.Size(731, 278)
        Me.SalesDataGrid.TabIndex = 25
        Me.SalesDataGrid.TabStop = False
        '
        'CalculationLabel
        '
        Me.CalculationLabel.AutoSize = True
        Me.CalculationLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculationLabel.Location = New System.Drawing.Point(13, 393)
        Me.CalculationLabel.Name = "CalculationLabel"
        Me.CalculationLabel.Size = New System.Drawing.Size(214, 37)
        Me.CalculationLabel.TabIndex = 26
        Me.CalculationLabel.Text = "CalculationLabel"
        '
        'SalesSummaryWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 611)
        Me.Controls.Add(Me.CalculationLabel)
        Me.Controls.Add(Me.SalesDataGrid)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.WeeklySummaryButton)
        Me.Controls.Add(Me.DailySummaryButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "SalesSummaryWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NeilEPOS"
        CType(Me.SalesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WeeklySummaryButton As Button
    Friend WithEvents DailySummaryButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents SalesDataGrid As DataGridView
    Friend WithEvents CalculationLabel As Label
End Class
