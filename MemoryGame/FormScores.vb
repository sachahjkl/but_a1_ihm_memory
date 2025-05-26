Public Class FormScores

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub

    Private Sub FormScores_Activated(sender As Object, e As EventArgs) Handles Me.Load
        lbJoueurs.Items.Clear()
        lbJoueurs.Items.AddRange(MyPlayers.Instance.sortedPlayers(True).OfType(Of String).ToArray)
        cbJoueurSelectionne.Items.AddRange(MyPlayers.Instance.PlayerNames.OfType(Of String).ToArray)
    End Sub

    Private Sub btnCroissant_Click(sender As Object, e As EventArgs) Handles btnCroissant.Click
        lbJoueurs.Items.Clear()
        lbJoueurs.Items.AddRange(MyPlayers.Instance.sortedPlayers(False).OfType(Of String).ToArray)
    End Sub

    Private Sub btnDecroissant_Click(sender As Object, e As EventArgs) Handles btnDecroissant.Click
        lbJoueurs.Items.Clear()
        lbJoueurs.Items.AddRange(MyPlayers.Instance.sortedPlayers(True).OfType(Of String).ToArray)
    End Sub

    Private Sub lbJoueurs_Select(sender As Object, e As EventArgs) Handles lbJoueurs.SelectedIndexChanged
        cbJoueurSelectionne.SelectedItem = lbJoueurs.SelectedItem
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        If lbJoueurs.SelectedIndex = -1 Or Not lbJoueurs.Items.Contains(cbJoueurSelectionne.Text) Then
            MsgBox("Veuillez selectionner un joueur avant d'appuyer sur ce bouton.", MsgBoxStyle.OkOnly)
            Return
        End If
        Dim nom = cbJoueurSelectionne.Text
        Dim partiesJouees = MyPlayers.Instance.getPlayerGamesPlayed(nom)
        Dim tempsJoue = MyPlayers.Instance.getPlayerTimePlayed(nom)
        Dim meilleurScore = MyPlayers.Instance.getPlayerScore(nom)
        Dim meilleurTemps = MyPlayers.Instance.getPlayerBestTime(nom)

        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(tempsJoue)

        Dim hJoue = iSpan.Hours.ToString.PadLeft(2, "0"c)
        Dim mJoue = iSpan.Minutes.ToString.PadLeft(2, "0"c)
        Dim sJoue = iSpan.Seconds.ToString.PadLeft(2, "0"c)

        Dim hmsJoue = hJoue & ":" & mJoue & ":" & sJoue

        MsgBox(cbJoueurSelectionne.Text & vbCrLf &
               "Parties jouées : " & partiesJouees & vbCrLf &
               "Temps joué : " & hmsJoue & vbCrLf &
               "Meilleur score : " & meilleurScore & vbCrLf &
               "Meilleur temps : " & meilleurTemps & " secondes",
                MsgBoxStyle.OkOnly)
    End Sub
End Class