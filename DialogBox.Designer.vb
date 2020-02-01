<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogBox))
        Me.Option1Button = New System.Windows.Forms.Button()
        Me.Option2Button = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Option1Button
        '
        Me.Option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Option1Button.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option1Button.Location = New System.Drawing.Point(465, 212)
        Me.Option1Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Option1Button.Name = "Option1Button"
        Me.Option1Button.Size = New System.Drawing.Size(150, 100)
        Me.Option1Button.TabIndex = 10
        Me.Option1Button.Text = "[Option 1]"
        Me.Option1Button.UseVisualStyleBackColor = True
        '
        'Option2Button
        '
        Me.Option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Option2Button.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option2Button.Location = New System.Drawing.Point(315, 212)
        Me.Option2Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Option2Button.Name = "Option2Button"
        Me.Option2Button.Size = New System.Drawing.Size(150, 100)
        Me.Option2Button.TabIndex = 10
        Me.Option2Button.Text = "[Option 2]"
        Me.Option2Button.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.TitleLabel.Location = New System.Drawing.Point(10, 10)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(84, 37)
        Me.TitleLabel.TabIndex = 34
        Me.TitleLabel.Text = "[Title]"
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.MessageLabel.Location = New System.Drawing.Point(10, 60)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(137, 37)
        Me.MessageLabel.TabIndex = 34
        Me.MessageLabel.Text = "[Message]"
        '
        'DialogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 321)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.Option2Button)
        Me.Controls.Add(Me.Option1Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DialogBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Option1Button As Button
    Friend WithEvents Option2Button As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents MessageLabel As Label
End Class
