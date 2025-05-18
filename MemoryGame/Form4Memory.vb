Imports System.Configuration
Imports System.Runtime.CompilerServices

Public Class Form4Memory
    Private Function CheckNom()
        Const NAME_MINIMUM_LENGTH = 3
        Return cbNom.Text.Trim().Length >= NAME_MINIMUM_LENGTH
    End Function
    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        Dim value = cbNom.Text.Trim()
        If Not Settings.RecentUsers.Contains(value) Then
            Settings.RecentUsers.Add(value)
            cbNom.Items.Add(value)
        End If
        Me.Hide()
        FormCards.Show()
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        If MsgBox("Voulez vous vraiment quitter ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Settings.Save()
            Close()
        End If
    End Sub

    Private Settings As MySettings

    Public Sub New()
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Settings = New MySettings()
    End Sub

    Private Sub Form4Memory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbNom.Items.AddRange(Settings.RecentUsers.OfType(Of String).ToArray())
        btnJouer.Enabled = CheckNom()
    End Sub

    Private Sub tbNom_TextChanged(sender As Object, e As EventArgs) Handles cbNom.TextChanged
        btnJouer.Enabled = CheckNom()
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        FormOptions.ShowDialog()
    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        FormPodium.ShowDialog()
    End Sub
End Class
