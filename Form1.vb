Public Class frm2048

    Dim rooster(3, 3) As Label
    Public Sub frm2048_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Matrix van 4 breed (0 tot 3) en 4 hoog (0 tot 3)

        Dim Xstartpunt = 30
        'Initialisatie van het rooster
        For i As Integer = rooster.GetLowerBound(0) To rooster.GetUpperBound(0)
            For j As Integer = rooster.GetLowerBound(1) To rooster.GetUpperBound(1)


                rooster(i, j) = New Label
                rooster(i, j).Size = New Size(50, 50)
                rooster(i, j).TextAlign = ContentAlignment.MiddleCenter
                rooster(i, j).Font = New Font("Calibri", 20, FontStyle.Bold)
                rooster(i, j).Name = "tile_" & i & "_" & j
                'x,y locatie in het venster
                rooster(i, j).Location = New Point((30 + j * 5) + j * 50, (30 + i * 5) + i * 50)
                'kleur van de tegel
                rooster(i, j).BackColor = Color.White
                'text op de tegel (initieel leeg)
                rooster(i, j).Text = ""
                Me.Controls.Add(rooster(i, j))

            Next
        Next

    End Sub
    Private Sub btnJoker_Click(sender As Object, e As EventArgs) Handles btnJoker.Click



    End Sub
    Private Function Tile_Color(ByVal value As String) As Color
        Select Case value
            Case ""
                'Lege tegel
                Return Color.LightGray
            Case "2"
                '2-tegel
                Return Color.FromArgb(238, 228, 218)
            Case "4"
                '4-tegel
                Return Color.FromArgb(237, 224, 200)
            Case "8"
                '8-tegel
                Return Color.FromArgb(242, 177, 121)
            Case "16"
                '16-tegel
                Return Color.FromArgb(245, 149, 99)
            Case "32"
                '32-tegel
                Return Color.FromArgb(246, 124, 95)
            Case "64"
                '64-tegel
                Return Color.FromArgb(246, 94, 59)
            Case "128"
                '128-tegel
                Return Color.FromArgb(237, 207, 114)
            Case "256"
                '256-tegel
                Return Color.FromArgb(237, 204, 97)
            Case "512"
                '512-tegel
                Return Color.FromArgb(237, 200, 80)
            Case "1024"
                '1024-tegel
                Return Color.FromArgb(237, 197, 63)
            Case "2048"
                '2048-tegel
                Return Color.FromArgb(237, 194, 46)

        End Select
    End Function
    Private Sub Form1_KeyUp(ByVal sender As Object, _
    ByVal e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                'Rechts

            Case Keys.Left
                'Links

            Case Keys.Up
                'Omhoog

            Case Keys.Down
                'Omlaag
        End Select
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
     

        'vullen van 1 willekeurig vakske in de matrix met 2 of 4 :)
        Dim x, y As New Random
        Dim teller As Integer = 0
        While teller < 2
            Dim rij = x.Next(0, 3)
            Dim kolom = y.Next(0, 3)
            Dim list As New List(Of Integer)(New Integer() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9})


            Dim rnd = New Random()
            'Haalt een willekeurig element uit een lijst genaamd ’list’
            Dim randomElement = list(rnd.Next(0, list.Count))
            'If-else constructie met kansverdelingen
            'Er wordt een willekeurig getal opgevraagd [0,10[
            'bijgevolg is er 10 pct. kans dat dit getal 0 is.
            If rnd.Next(0, 10) = 0 Then
                '10 pct. kans
                rooster(rij, kolom).Text = "4"
            Else
                '90 pct. kans
                rooster(rij, kolom).Text = "2"
            End If
            teller += 1
        End While

    End Sub
    Public Sub StartScreen()



        'vullen van 1 willekeurig vakske in de matrix met 2 of 4 :)
        Dim x, y As New Random
        Dim teller As Integer = 0
        While teller < 2
            Dim rij = x.Next(0, 3)
            Dim kolom = y.Next(0, 3)
            Dim list As New List(Of Integer)(New Integer() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9})


            Dim rnd = New Random()
            'Haalt een willekeurig element uit een lijst genaamd ’list’
            Dim randomElement = list(rnd.Next(0, list.Count))
           
            If rnd.Next(0, 10) = 0 Then
                '10 pct. kans
                rooster(rij, kolom).Text = "4"
            Else
                '90 pct. kans
                rooster(rij, kolom).Text = "2"
            End If
            teller += 1
        End While







    End Sub


End Class
