Imports System.Threading

Public Class FormCards
    Private Const TOTAL_TIME = 60
    Private Const INTERVAL = 1000
    Private Const MAXIMUM_CARDS_SHOWN = 4
    Private Const WAIT_TIME_MS = 1500
    Friend Const CARD_NUMBER = 20
    Private Const IMAGE_NUMBER = 5

    Private totalTime = TOTAL_TIME * getTotalTimeMult()

    Private WithEvents timerTpsRestant As New Windows.Forms.Timer()
    Private tpsRestant As Integer = totalTime

    Private pictureBoxes() As PictureBox
    Private backCardImage As Image
    Private cardImages(IMAGE_NUMBER - 1) As Image

    Private randomizedCardImages(CARD_NUMBER - 1) As Image

    Private cts As CancellationTokenSource
    Private playerName As String = Form4Memory.cbNom.Text
    Private playerScore As Integer = 0
    Private playerTime As Integer = 0


    Private Function createRandomizedCardImages()
        Dim randomizedCards(CARD_NUMBER - 1) As Image
        Dim groupSize As Integer = randomizedCards.Length \ cardImages.Length
        For i = 0 To CARD_NUMBER - 1
            Dim imageIndex As Integer = i \ groupSize
            randomizedCards(i) = cardImages(imageIndex)
        Next

        Dim rnd As New Random()

        For i As Integer = randomizedCards.Length - 1 To 1 Step -1
            Dim j As Integer = rnd.Next(i + 1)
            Dim temp As Image = randomizedCards(i)
            randomizedCards(i) = randomizedCards(j)
            randomizedCards(j) = temp
        Next
        Return randomizedCards
    End Function


    Private Sub FormCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelTpsRestant.Text = (totalTime).ToString() & " secondes"
        timerTpsRestant.Interval = INTERVAL


        pictureBoxes = {
            PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5,
            PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10,
            PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15,
            PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20
        }

        For Each pb In pictureBoxes
            AddHandler pb.Click, AddressOf PictureBox_Click
        Next

        labelJoueur.Text = playerName

        loadImages()
        randomizedCardImages = createRandomizedCardImages()

    End Sub

    Private Sub updateTimeLeft(sender As Object, e As EventArgs) Handles timerTpsRestant.Tick
        If tpsRestant > 0 Then
            tpsRestant -= 1
            playerTime += 1
            labelTpsRestant.Text = tpsRestant.ToString() & " secondes"
        Else
            timerTpsRestant.Stop()
            If MsgBox("Temps écoulé, vous avez perdu !", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                MyPlayers.Instance.updatePlayer(playerName, playerTime, playerScore)
                Me.Hide()
                Form4Memory.Show()
            End If
        End If
    End Sub

    Private Async Sub PictureBox_Click(sender As Object, e As EventArgs)
        If Not timerTpsRestant.Enabled Then
            timerTpsRestant.Enabled = True
            timerTpsRestant.Start()
        End If

        Dim clickedCard = CType(sender, PictureBox)

        If shownCardsCount() = 0 Then
            showCard(clickedCard)
            Return
        End If

        cts?.Cancel()
        cts = New CancellationTokenSource()
        If cardIsSameAsShownCards(clickedCard) Then
            showCard(clickedCard)
        End If

        If Not cardIsSameAsShownCards(clickedCard) Then
            showCard(clickedCard)
            Try
                Await Task.Delay(WAIT_TIME_MS, cts.Token)
            Catch ex As OperationCanceledException
            End Try
            hideAllCards()
            Return
        End If

        showCard(clickedCard)

        If shownCardsCount() = MAXIMUM_CARDS_SHOWN Then
            For Each pb In pictureBoxes
                If Not isCardHidden(pb) And pb.Enabled Then
                    pb.Image = ToolStripRenderer.CreateDisabledImage(New Bitmap(pb.Image))
                    pb.Enabled = False
                End If
            Next
            playerScore += MAXIMUM_CARDS_SHOWN
        End If

        If gameIsWon() Then
            timerTpsRestant.Stop()
            MsgBox("Vous avez gagné ! Temps restant : " & tpsRestant.ToString & " secondes", MsgBoxStyle.OkOnly)
            MyPlayers.Instance.updatePlayer(playerName, playerTime, playerScore)
            Form4Memory.Show()
            Me.Close()
        End If
    End Sub

    Private Function gameIsWon() As Boolean
        For Each pb In pictureBoxes
            If pb.Enabled Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function cardIsSameAsShownCards(clickedCard As PictureBox) As Boolean
        Dim index = Array.IndexOf(pictureBoxes, clickedCard)
        Dim cardImage = randomizedCardImages(index)
        For Each pb In pictureBoxes
            If (Not isCardHidden(pb) And pb.Enabled) And pb.Image IsNot cardImage Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        If MsgBox("Voulez vous vraiment quitter ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MyPlayers.Instance.updatePlayer(playerName, playerTime, playerScore)
            Me.Close()
            Form4Memory.Show()
        End If
    End Sub

    Private Function isCardHidden(pb As PictureBox)
        Return pb.Image Is backCardImage
    End Function

    Private Function shownCardsCount()
        Dim total = 0
        For Each pb In pictureBoxes
            If Not isCardHidden(pb) And pb.Enabled Then
                total += 1
            End If
        Next
        Return total
    End Function

    Private Sub hideAllCards()
        For Each pb In pictureBoxes
            If pb.Enabled Then
                pb.Image = backCardImage
            End If
        Next
    End Sub

    Private Sub showAllCards()
        For Each pb In pictureBoxes
            showCard(pb)
        Next
    End Sub

    Private Sub loadImages()
        Dim rbAlice = FormOptions.rbAlice
        Dim rbBrainrot = FormOptions.rbBrainrot
        backCardImage = Image.FromFile("assets/BackCard.png")

        If rbAlice.Checked Then
            cardImages = {
                Image.FromFile("assets/cards_alice/Card0.png"),
                Image.FromFile("assets/cards_alice/Card1.png"),
                Image.FromFile("assets/cards_alice/Card2.png"),
                Image.FromFile("assets/cards_alice/Card3.png"),
                Image.FromFile("assets/cards_alice/Card4.png")
            }
        ElseIf rbBrainrot.Checked Then
            cardImages = {
                Image.FromFile("assets/cards_brainrot/CardBC.png"),
                Image.FromFile("assets/cards_brainrot/CardBP.png"),
                Image.FromFile("assets/cards_brainrot/CardCP.png"),
                Image.FromFile("assets/cards_brainrot/CardTS.png"),
                Image.FromFile("assets/cards_brainrot/CardTT.png")}
        End If

        For Each pb In pictureBoxes
            pb.Image = backCardImage
        Next
    End Sub

    Private Sub showCard(pb As PictureBox)
        Dim index = Array.IndexOf(pictureBoxes, pb)
        pb.Image = randomizedCardImages(index)
    End Sub

    Private Function getTotalTimeMult()
        If FormOptions.rb30.Checked Then
            Return 0.5
        End If
        If FormOptions.rb60.Checked Then
            Return 1
        End If
        If FormOptions.rb90.Checked Then
            Return 1.5
        End If
        Return -1
    End Function

    Function CompareExact(img1 As Bitmap, img2 As Bitmap) As Boolean
        If img1.Width <> img2.Width OrElse img1.Height <> img2.Height Then
            Return False
        End If

        For x As Integer = 0 To img1.Width - 1
            For y As Integer = 0 To img1.Height - 1
                If img1.GetPixel(x, y) <> img2.GetPixel(x, y) Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function
End Class