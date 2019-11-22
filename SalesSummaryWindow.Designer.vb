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
        Me.WeeklySummaryButton = New System.Windows.Forms.Button()
        Me.DailySummaryButton = New System.Windows.Forms.Button()
        Me.SalesListBox = New System.Windows.Forms.ListBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WeeklySummaryButton
        '
        Me.WeeklySummaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeeklySummaryButton.Location = New System.Drawing.Point(146, 26)
        Me.WeeklySummaryButton.Name = "WeeklySummaryButton"
        Me.WeeklySummaryButton.Size = New System.Drawing.Size(100, 75)
        Me.WeeklySummaryButton.TabIndex = 2
        Me.WeeklySummaryButton.Text = "This Week"
        Me.WeeklySummaryButton.UseVisualStyleBackColor = True
        '
        'DailySummaryButton
        '
        Me.DailySummaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailySummaryButton.Location = New System.Drawing.Point(28, 26)
        Me.DailySummaryButton.Name = "DailySummaryButton"
        Me.DailySummaryButton.Size = New System.Drawing.Size(100, 75)
        Me.DailySummaryButton.TabIndex = 1
        Me.DailySummaryButton.Text = "Today"
        Me.DailySummaryButton.UseVisualStyleBackColor = True
        '
        'SalesListBox
        '
        Me.SalesListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SalesListBox.FormattingEnabled = True
        Me.SalesListBox.ItemHeight = 20
        Me.SalesListBox.Location = New System.Drawing.Point(28, 119)
        Me.SalesListBox.Name = "SalesListBox"
        Me.SalesListBox.Size = New System.Drawing.Size(507, 224)
        Me.SalesListBox.TabIndex = 24
        Me.SalesListBox.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(28, 406)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 75)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SalesSummaryWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SalesListBox)
        Me.Controls.Add(Me.WeeklySummaryButton)
        Me.Controls.Add(Me.DailySummaryButton)
        Me.Location = New System.Drawing.Point(1024, 768)
        Me.Name = "SalesSummaryWindow"
        Me.Text = "SalesSummary"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WeeklySummaryButton As Button
    Friend WithEvents DailySummaryButton As Button
    Friend WithEvents SalesListBox As ListBox
    Friend WithEvents CloseButton As Button
End Class
