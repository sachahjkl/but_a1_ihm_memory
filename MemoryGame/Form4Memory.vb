Imports System.Configuration
Imports System.Runtime.CompilerServices

Public Class Form4Memory
    Private Function CheckNom()
        Const NAME_MINIMUM_LENGTH = 3
        Return cbNom.Text.Trim().Length >= NAME_MINIMUM_LENGTH
    End Function
    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        Dim name = cbNom.Text.Trim()
        If Not MyPlayers.Instance.PlayerNames.Contains(name) Then
            MyPlayers.Instance.addPlayer(name)
        End If
        Hide()
        FormCards.Show()
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If MsgBox("Voulez vous vraiment quitter ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub



    Private Sub Form4Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        cbNom.Items.Clear()
        cbNom.Items.AddRange(MyPlayers.Instance.PlayerNames.OfType(Of String).ToArray())
        btnJouer.Enabled = CheckNom()
    End Sub



    Private Sub tbNom_TextChanged(sender As Object, e As EventArgs) Handles cbNom.TextChanged
        btnJouer.Enabled = CheckNom()
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        FormOptions.ShowDialog()
    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        FormScores.ShowDialog()
    End Sub


End Class
