Imports System.Configuration
Imports System.Collections.Specialized

Public Class MyPlayers
    Inherits ApplicationSettingsBase

    Public Shared ReadOnly Instance As New MyPlayers()



    <UserScopedSetting()>
    Public ReadOnly Property Players As List(Of Player)
        Get
            If Item(NameOf(Players)) Is Nothing Then Item(NameOf(Players)) = New List(Of Player)
            Return Item(NameOf(Players))
        End Get
    End Property

    Public ReadOnly Property PlayerNames As StringCollection
        Get
            Dim names As New StringCollection()
            For Each player In Players
                names.Add(player.Name)
            Next
            Return names
        End Get
    End Property


    Public Function getPlayerScore(playerName As String) As Integer
        Return getPlayerByName(playerName).BestScore
    End Function

    Public Function getPlayerBestTime(playerName As String) As Integer
        Return getPlayerByName(playerName).BestTime
    End Function

    Public Function getPlayerGamesPlayed(playerName As String) As Integer
        Return getPlayerByName(playerName).GamesPlayed
    End Function

    Public Function getPlayerTimePlayed(playerName As String) As Integer
        Return getPlayerByName(playerName).TimePlayed
    End Function

    Private Function getPlayerByName(playerName As String) As Player
        For Each player In Players
            If player.Name = playerName Then
                Return player
            End If
        Next
        Throw New ArgumentException("The specified player name does not match any existing player.")
    End Function
    Public Sub addPlayer(playerName As String)
        If Players.Any(Function(p) p.Name = playerName) Then
            Return
        End If
        Players.Add(New Player With {
                    .Name = playerName
                    })
        Me.Save()
    End Sub

    Public Sub updatePlayerPlayedTime(playerName As String, time As Integer)
        getPlayerByName(playerName).TimePlayed += time
    End Sub

    Public Sub updatePlayerBestTime(playerName As String, time As Integer)
        getPlayerByName(playerName).updateBestTime(time)
    End Sub

    Public Sub updateGamesPlayed(playerName As String)
        getPlayerByName(playerName).GamesPlayed += 1
    End Sub

    Public Sub updateBestScore(playerName As String, gameScore As Integer)
        getPlayerByName(playerName).updateBestScore(gameScore)
    End Sub

    Public Sub updatePlayer(playerName As String, timePlayed As Integer, gameScore As Integer)
        updatePlayerPlayedTime(playerName, timePlayed)
        updateGamesPlayed(playerName)
        updateBestScore(playerName, gameScore)

        If gameScore = FormCards.CARD_NUMBER Then
            updatePlayerBestTime(playerName, timePlayed)
        End If
        Me.Save()
    End Sub
End Class