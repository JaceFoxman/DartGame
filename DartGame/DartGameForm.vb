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
    Private Sub DartGameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
        RoundTrack()
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

    Sub AskToStartNewRound()
        Dim result As DialogResult
        result = MessageBox.Show("Thats 3 Darts, Do you want to start a new round?", "New Round", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SetDefaults()
            RoundTrack()

        Else
            SetDefaults()
            RoundTrack()

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

    Function RoundTrack() As Integer
        Static roundCount As Integer = 0 'Static variable to hold round count value
        roundCount += 1 'Increase round count    'Return round count value
        Return roundCount
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

        Round += 1 'RoundCountToString()
        roundString = Round.ToString
        FileOpen(1, path, OpenMode.Append)
        PrintLine(1, "-------------------")
        WriteLine(1, $"Round: {roundString}")
        FileClose(1)
        ThrowDart()
        ThrowDart()
        ThrowDart()
    End Sub
    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        SetDefaults()
        RoundTrack()

    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        SetDefaults()

        RoundTrack()
        ThrowDart_Button.Enabled = False
    End Sub
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        SetDefaults()

        RoundTrack()
        ThrowDart_Button.Enabled = True
    End Sub
    Private Sub Quit_Button_Click(sender As Object, e As EventArgs) Handles Quit_Button.Click
        Me.Close()
    End Sub
End Class
