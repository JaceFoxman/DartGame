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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RoundLabel = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ClearFileButton = New System.Windows.Forms.Button()
        CType(Me.Drawing_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Clear_Button
        '
        Me.Clear_Button.BackColor = System.Drawing.Color.DodgerBlue
        Me.Clear_Button.ForeColor = System.Drawing.Color.Cornsilk
        Me.Clear_Button.Location = New System.Drawing.Point(264, 424)
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
        Me.Quit_Button.Location = New System.Drawing.Point(818, 424)
        Me.Quit_Button.Name = "Quit_Button"
        Me.Quit_Button.Size = New System.Drawing.Size(241, 133)
        Me.Quit_Button.TabIndex = 2
        Me.Quit_Button.Text = "Quit Game"
        Me.Quit_Button.UseVisualStyleBackColor = False
        '
        'Drawing_PictureBox
        '
        Me.Drawing_PictureBox.Location = New System.Drawing.Point(17, 6)
        Me.Drawing_PictureBox.Name = "Drawing_PictureBox"
        Me.Drawing_PictureBox.Size = New System.Drawing.Size(1042, 412)
        Me.Drawing_PictureBox.TabIndex = 3
        Me.Drawing_PictureBox.TabStop = False
        '
        'ThrowDart_Button
        '
        Me.ThrowDart_Button.BackColor = System.Drawing.Color.ForestGreen
        Me.ThrowDart_Button.ForeColor = System.Drawing.Color.Cornsilk
        Me.ThrowDart_Button.Location = New System.Drawing.Point(17, 424)
        Me.ThrowDart_Button.Name = "ThrowDart_Button"
        Me.ThrowDart_Button.Size = New System.Drawing.Size(241, 133)
        Me.ThrowDart_Button.TabIndex = 0
        Me.ThrowDart_Button.Text = "Throw Dart"
        Me.ThrowDart_Button.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 604)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ClearFileButton)
        Me.TabPage1.Controls.Add(Me.RoundLabel)
        Me.TabPage1.Controls.Add(Me.ThrowDart_Button)
        Me.TabPage1.Controls.Add(Me.Quit_Button)
        Me.TabPage1.Controls.Add(Me.Clear_Button)
        Me.TabPage1.Controls.Add(Me.Drawing_PictureBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1076, 568)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RoundLabel
        '
        Me.RoundLabel.Location = New System.Drawing.Point(609, 436)
        Me.RoundLabel.Name = "RoundLabel"
        Me.RoundLabel.Size = New System.Drawing.Size(100, 40)
        Me.RoundLabel.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1076, 568)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ClearFileButton
        '
        Me.ClearFileButton.BackColor = System.Drawing.Color.DarkRed
        Me.ClearFileButton.ForeColor = System.Drawing.Color.Cornsilk
        Me.ClearFileButton.Location = New System.Drawing.Point(536, 494)
        Me.ClearFileButton.Name = "ClearFileButton"
        Me.ClearFileButton.Size = New System.Drawing.Size(241, 52)
        Me.ClearFileButton.TabIndex = 5
        Me.ClearFileButton.Text = "Clear Records"
        Me.ClearFileButton.UseVisualStyleBackColor = False
        '
        'DartGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 623)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "DartGameForm"
        Me.Text = "DartGame"
        CType(Me.Drawing_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clear_Button As Button
    Friend WithEvents Quit_Button As Button
    Friend WithEvents Drawing_PictureBox As PictureBox
    Friend WithEvents ThrowDart_Button As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RoundLabel As Label
    Friend WithEvents ClearFileButton As Button
End Class
