<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupWindow
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
        Me.TaglineLabel = New System.Windows.Forms.Label()
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.LoadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ProgressListBox = New System.Windows.Forms.ListBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TaglineLabel
        '
        Me.TaglineLabel.AutoSize = True
        Me.TaglineLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TaglineLabel.Location = New System.Drawing.Point(12, 85)
        Me.TaglineLabel.Name = "TaglineLabel"
        Me.TaglineLabel.Size = New System.Drawing.Size(432, 24)
        Me.TaglineLabel.TabIndex = 1
        Me.TaglineLabel.Text = "Welcome to Neil's Electronic Point-Of-Sale System"
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(3, 9)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(333, 76)
        Me.LogoLabel.TabIndex = 2
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'LoadProgressBar
        '
        Me.LoadProgressBar.Location = New System.Drawing.Point(16, 228)
        Me.LoadProgressBar.Name = "LoadProgressBar"
        Me.LoadProgressBar.Size = New System.Drawing.Size(499, 23)
        Me.LoadProgressBar.TabIndex = 3
        '
        'ProgressListBox
        '
        Me.ProgressListBox.FormattingEnabled = True
        Me.ProgressListBox.Location = New System.Drawing.Point(16, 113)
        Me.ProgressListBox.Name = "ProgressListBox"
        Me.ProgressListBox.Size = New System.Drawing.Size(499, 95)
        Me.ProgressListBox.TabIndex = 4
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(16, 258)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(499, 60)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StartupWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 330)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ProgressListBox)
        Me.Controls.Add(Me.LoadProgressBar)
        Me.Controls.Add(Me.TaglineLabel)
        Me.Controls.Add(Me.LogoLabel)
        Me.Name = "StartupWindow"
        Me.Text = "StartupWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TaglineLabel As Label
    Friend WithEvents LogoLabel As Label
    Friend WithEvents LoadProgressBar As ProgressBar
    Friend WithEvents ProgressListBox As ListBox
    Friend WithEvents StartButton As Button
End Class
