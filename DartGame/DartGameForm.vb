'Jason Permann
'Fall 2025
'RCET 3371
'Dart Game
'

Option Strict On
Option Explicit On
Option Compare Text

Public Class DartGameForm
    Public Round As Integer
    Public roundString As String
    Public currentRound As Integer
    Public currentRoundToString As String
    Private Sub DartGameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentRound += 1
        currentRoundToString = currentRound.ToString
        RoundLabel.Text = $"Round: {currentRoundToString}"
        SetDefaults()
    End Sub

    Sub SetDefaults()
        'clear the drawing area
        Drawing_PictureBox.Refresh()
        Drawing_PictureBox.BackColor = Color.AliceBlue
        Drawing_PictureBox.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Sub DrawDart(x%, y%)
        Dim g As Graphics = Drawing_PictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim dartWidth% = 30

        g.DrawEllipse(pen, x - (dartWidth \ 2), y - (dartWidth \ 2), dartWidth, dartWidth)
        g.DrawLine(pen, x - 3, y, x + 3, y)
        g.DrawLine(pen, x, y - 3, x, y + 3)

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawDart2(x%, y%)
        Dim g As Graphics = ReviewPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim dartWidth% = 30

        g.DrawEllipse(pen, x - (dartWidth \ 2), y - (dartWidth \ 2), dartWidth, dartWidth)
        g.DrawLine(pen, x - 3, y, x + 3, y)
        g.DrawLine(pen, x, y - 3, x, y + 3)

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub AskToStartNewRound()
        Dim result As DialogResult
        result = MessageBox.Show("Thats 3 Darts, Do you want to start a new round?", "New Round", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SetDefaults()
        Else
            ThrowDart_Button.Enabled = False
        End If
    End Sub

    Function DartTrack() As Integer
        Static count As Integer = 0 'Static variable to hold count value
        count += 1 'Increase count
        If count = 3 Then
            AskToStartNewRound()
            count = 0 'Reset count

        End If
        Return count    'Return count value
    End Function

    Sub ThrowDart()
        Dim path As String = "DartGame.log"
        Dim X As Integer = GetRandomNumberZeroTo(Drawing_PictureBox.Width)
        Dim Y As Integer = GetRandomNumberZeroTo(Drawing_PictureBox.Height)
        DrawDart(X, Y)


        FileOpen(1, path, OpenMode.Append)
        PrintLine(1, $"X Coordinate: {X}" & $" Y Coordinate: {Y}")
        FileClose(1)

        DartTrack()

    End Sub

    Function GetRandomNumberZeroTo(max%) As Integer
        Dim result As Integer
        Randomize()
        result = CInt(System.Math.Floor(CDbl(Rnd() * max))) + 1
        'record the random number generated
        Return result
    End Function

    Private Sub ThrowDart_Button_Click(sender As Object, e As EventArgs) Handles ThrowDart_Button.Click
        Dim path As String = "DartGame.log"
        currentRound += 1
        currentRoundToString = currentRound.ToString
        Round += 1 'RoundCountToString()
        roundString = Round.ToString
        RoundLabel.Text = $"Round: {currentRoundToString}"

        FileOpen(1, path, OpenMode.Append)
        PrintLine(1, "-------------------")
        WriteLine(1, $"Round: {roundString}")
        FileClose(1)
        ThrowDart()
        ThrowDart()
        ThrowDart()
    End Sub

    Private Sub DartGameForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
            ThrowDart()
        End If
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        ThrowDart_Button.Enabled = True
        SetDefaults()
    End Sub

    Sub ReadLogFile()
        'read the text file "DartGame.log" and display its contents in a message box
        Dim path As String = "DartGame.log"
        Dim fileContents As String
        If FileIO.FileSystem.FileExists(path) Then
            fileContents = My.Computer.FileSystem.ReadAllText(path)
            MessageBox.Show(fileContents, "Dart Game Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No records found.", "Dart Game Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs)
        SetDefaults()
        ThrowDart_Button.Enabled = False
    End Sub
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs)
        ThrowDart_Button.Enabled = True
    End Sub
    Private Sub Quit_Button_Click(sender As Object, e As EventArgs) Handles Quit_Button.Click
        'clear the text file "DartGame.log"
        Dim path As String = "DartGame.log"
        FileOpen(1, path, OpenMode.Append)
        PrintLine(1, $"Game Ended")
        FileClose(1)
        'close the form
        Me.Close()
    End Sub

    Private Sub ClearFileButton_Click(sender As Object, e As EventArgs) Handles ClearFileButton.Click
        'clear the text file "DartGame.log"
        'ask user to confirm
        Dim result As DialogResult
        result = MessageBox.Show("Doing this will clear all previous records and close the game." & vbNewLine _
        & "Are you sure you want to proceed?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim path As String = "DartGame.log"
            FileOpen(1, path, OpenMode.Output)
            FileClose(1)
            Me.Close()
        Else

        End If

    End Sub

    Private Sub DisplayRecordsButton_Click(sender As Object, e As EventArgs) Handles DisplayRecordsButton.Click
        ReadLogFile()
    End Sub

    Private Sub ReviewBoardButton_Click(sender As Object, e As EventArgs) Handles ReviewBoardButton.Click
        'grab previous dart positions from log file and redraw them on the drawing area
        Dim path As String = "DartGame.log"
        Dim line As String
        If FileIO.FileSystem.FileExists(path) Then
            FileOpen(1, path, OpenMode.Input)
            SetDefaults()
            Do While Not EOF(1)
                line = LineInput(1)
                If line.StartsWith("X Coordinate:") Then
                    'extract X and Y coordinates
                    Dim parts() As String = line.Split(" "c)
                    Dim x As Integer = CInt(parts(2))
                    Dim y As Integer = CInt(parts(5))
                    DrawDart2(x, y)
                End If
            Loop
            FileClose(1)
        Else
            MessageBox.Show("No records found to review.", "Dart Game Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class
