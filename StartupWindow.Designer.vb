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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartupWindow))
        Me.TaglineLabel = New System.Windows.Forms.Label()
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.LoadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ProgressListBox = New System.Windows.Forms.ListBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TaglineLabel
        '
        Me.TaglineLabel.AutoSize = True
        Me.TaglineLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TaglineLabel.Location = New System.Drawing.Point(3, 84)
        Me.TaglineLabel.Name = "TaglineLabel"
        Me.TaglineLabel.Size = New System.Drawing.Size(624, 31)
        Me.TaglineLabel.TabIndex = 1
        Me.TaglineLabel.Text = "Welcome to Neil's Electronic Point-Of-Sale System"
        '
        'LogoLabel
        '
        Me.LogoLabel.AutoSize = True
        Me.LogoLabel.Font = New System.Drawing.Font("Rockwell", 60.0!)
        Me.LogoLabel.Location = New System.Drawing.Point(-7, 0)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(390, 88)
        Me.LogoLabel.TabIndex = 2
        Me.LogoLabel.Text = "NeilEPOS"
        '
        'LoadProgressBar
        '
        Me.LoadProgressBar.Location = New System.Drawing.Point(0, 221)
        Me.LoadProgressBar.Name = "LoadProgressBar"
        Me.LoadProgressBar.Size = New System.Drawing.Size(625, 40)
        Me.LoadProgressBar.TabIndex = 3
        '
        'ProgressListBox
        '
        Me.ProgressListBox.FormattingEnabled = True
        Me.ProgressListBox.HorizontalScrollbar = True
        Me.ProgressListBox.Location = New System.Drawing.Point(0, 125)
        Me.ProgressListBox.Name = "ProgressListBox"
        Me.ProgressListBox.Size = New System.Drawing.Size(625, 95)
        Me.ProgressListBox.TabIndex = 2
        Me.ProgressListBox.TabStop = False
        '
        'StartButton
        '
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(0, 261)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(625, 60)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Segoe UI", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(389, -5)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(205, 89)
        Me.VersionLabel.TabIndex = 4
        Me.VersionLabel.Text = "v[X.X]"
        '
        'StartupWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 321)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ProgressListBox)
        Me.Controls.Add(Me.LoadProgressBar)
        Me.Controls.Add(Me.TaglineLabel)
        Me.Controls.Add(Me.LogoLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartupWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NeilEPOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TaglineLabel As Label
    Friend WithEvents LogoLabel As Label
    Friend WithEvents LoadProgressBar As ProgressBar
    Friend WithEvents ProgressListBox As ListBox
    Friend WithEvents StartButton As Button
    Friend WithEvents VersionLabel As Label
End Class
