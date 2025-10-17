<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DartGameForm
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
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Quit_Button = New System.Windows.Forms.Button()
        Me.Drawing_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ThrowDart_Button = New System.Windows.Forms.Button()
        Me.RoundLabel = New System.Windows.Forms.Label()
        Me.ClearFileButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReviewPictureBox = New System.Windows.Forms.PictureBox()
        Me.DisplayRecordsButton = New System.Windows.Forms.Button()
        Me.ReviewBoardButton = New System.Windows.Forms.Button()
        Me.ReviewComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.Drawing_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ReviewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clear_Button
        '
        Me.Clear_Button.BackColor = System.Drawing.Color.DodgerBlue
        Me.Clear_Button.ForeColor = System.Drawing.Color.Cornsilk
        Me.Clear_Button.Location = New System.Drawing.Point(253, 424)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(241, 133)
        Me.Clear_Button.TabIndex = 1
        Me.Clear_Button.Text = "Clear Board"
        Me.Clear_Button.UseVisualStyleBackColor = False
        '
        'Quit_Button
        '
        Me.Quit_Button.BackColor = System.Drawing.Color.DarkRed
        Me.Quit_Button.ForeColor = System.Drawing.Color.Cornsilk
        Me.Quit_Button.Location = New System.Drawing.Point(807, 424)
        Me.Quit_Button.Name = "Quit_Button"
        Me.Quit_Button.Size = New System.Drawing.Size(241, 133)
        Me.Quit_Button.TabIndex = 2
        Me.Quit_Button.Text = "Quit Game"
        Me.Quit_Button.UseVisualStyleBackColor = False
        '
        'Drawing_PictureBox
        '
        Me.Drawing_PictureBox.Location = New System.Drawing.Point(6, 6)
        Me.Drawing_PictureBox.Name = "Drawing_PictureBox"
        Me.Drawing_PictureBox.Size = New System.Drawing.Size(1042, 412)
        Me.Drawing_PictureBox.TabIndex = 3
        Me.Drawing_PictureBox.TabStop = False
        '
        'ThrowDart_Button
        '
        Me.ThrowDart_Button.BackColor = System.Drawing.Color.ForestGreen
        Me.ThrowDart_Button.ForeColor = System.Drawing.Color.Cornsilk
        Me.ThrowDart_Button.Location = New System.Drawing.Point(6, 424)
        Me.ThrowDart_Button.Name = "ThrowDart_Button"
        Me.ThrowDart_Button.Size = New System.Drawing.Size(241, 133)
        Me.ThrowDart_Button.TabIndex = 0
        Me.ThrowDart_Button.Text = "Throw Dart"
        Me.ThrowDart_Button.UseVisualStyleBackColor = False
        '
        'RoundLabel
        '
        Me.RoundLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.RoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RoundLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RoundLabel.Location = New System.Drawing.Point(596, 437)
        Me.RoundLabel.Name = "RoundLabel"
        Me.RoundLabel.Size = New System.Drawing.Size(104, 34)
        Me.RoundLabel.TabIndex = 4
        '
        'ClearFileButton
        '
        Me.ClearFileButton.BackColor = System.Drawing.Color.DarkRed
        Me.ClearFileButton.ForeColor = System.Drawing.Color.Cornsilk
        Me.ClearFileButton.Location = New System.Drawing.Point(511, 505)
        Me.ClearFileButton.Name = "ClearFileButton"
        Me.ClearFileButton.Size = New System.Drawing.Size(275, 52)
        Me.ClearFileButton.TabIndex = 5
        Me.ClearFileButton.Text = "Clear Records"
        Me.ClearFileButton.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1067, 599)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Drawing_PictureBox)
        Me.TabPage1.Controls.Add(Me.ClearFileButton)
        Me.TabPage1.Controls.Add(Me.Quit_Button)
        Me.TabPage1.Controls.Add(Me.RoundLabel)
        Me.TabPage1.Controls.Add(Me.Clear_Button)
        Me.TabPage1.Controls.Add(Me.ThrowDart_Button)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1059, 566)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dart Game"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReviewComboBox)
        Me.TabPage2.Controls.Add(Me.ReviewBoardButton)
        Me.TabPage2.Controls.Add(Me.ReviewPictureBox)
        Me.TabPage2.Controls.Add(Me.DisplayRecordsButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1059, 566)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Review"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReviewPictureBox
        '
        Me.ReviewPictureBox.BackColor = System.Drawing.Color.DarkSalmon
        Me.ReviewPictureBox.Location = New System.Drawing.Point(6, 6)
        Me.ReviewPictureBox.Name = "ReviewPictureBox"
        Me.ReviewPictureBox.Size = New System.Drawing.Size(1047, 405)
        Me.ReviewPictureBox.TabIndex = 3
        Me.ReviewPictureBox.TabStop = False
        '
        'DisplayRecordsButton
        '
        Me.DisplayRecordsButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.DisplayRecordsButton.ForeColor = System.Drawing.Color.Cornsilk
        Me.DisplayRecordsButton.Location = New System.Drawing.Point(812, 417)
        Me.DisplayRecordsButton.Name = "DisplayRecordsButton"
        Me.DisplayRecordsButton.Size = New System.Drawing.Size(241, 133)
        Me.DisplayRecordsButton.TabIndex = 2
        Me.DisplayRecordsButton.Text = "Review Records"
        Me.DisplayRecordsButton.UseVisualStyleBackColor = False
        '
        'ReviewBoardButton
        '
        Me.ReviewBoardButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.ReviewBoardButton.ForeColor = System.Drawing.Color.Cornsilk
        Me.ReviewBoardButton.Location = New System.Drawing.Point(6, 417)
        Me.ReviewBoardButton.Name = "ReviewBoardButton"
        Me.ReviewBoardButton.Size = New System.Drawing.Size(241, 133)
        Me.ReviewBoardButton.TabIndex = 4
        Me.ReviewBoardButton.Text = "Review Board"
        Me.ReviewBoardButton.UseVisualStyleBackColor = False
        '
        'ReviewComboBox
        '
        Me.ReviewComboBox.FormattingEnabled = True
        Me.ReviewComboBox.Location = New System.Drawing.Point(263, 426)
        Me.ReviewComboBox.Name = "ReviewComboBox"
        Me.ReviewComboBox.Size = New System.Drawing.Size(258, 28)
        Me.ReviewComboBox.TabIndex = 5
        '
        'DartGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 620)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "DartGameForm"
        Me.Text = "DartGame"
        CType(Me.Drawing_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ReviewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clear_Button As Button
    Friend WithEvents Quit_Button As Button
    Friend WithEvents Drawing_PictureBox As PictureBox
    Friend WithEvents ThrowDart_Button As Button
    Friend WithEvents RoundLabel As Label
    Friend WithEvents ClearFileButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DisplayRecordsButton As Button
    Friend WithEvents ReviewPictureBox As PictureBox
    Friend WithEvents ReviewBoardButton As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ReviewComboBox As ComboBox
End Class
