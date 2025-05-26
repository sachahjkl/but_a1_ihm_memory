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

    Public Sub updatePlayerBestTime(playerName As String, time As Integer, gameScore As Integer)
        getPlayerByName(playerName).updateBestTime(time, gameScore)
    End Sub

    Public Sub updateGamesPlayed(playerName As String)
        getPlayerByName(playerName).GamesPlayed += 1
    End Sub

    Public Sub updateBestScore(playerName As String, gameScore As Integer)
        getPlayerByName(playerName).updateBestScore(gameScore)
    End Sub

    Public Sub updatePlayer(playerName As String, timePlayed As Integer, gameScore As Integer)
        updatePlayerBestTime(playerName, timePlayed, gameScore)
        updateBestScore(playerName, gameScore)
        updatePlayerPlayedTime(playerName, timePlayed)
        updateGamesPlayed(playerName)
        Me.Save()
    End Sub

    Friend Function sortedPlayers(asc As Boolean) As ArrayList
        Dim sorted As List(Of Player) = Players
        sorted.Sort(Function(x As Player, y As Player)
                        Dim comp = y.BestScore.CompareTo(x.BestScore)
                        If comp <> 0 Then
                            Return comp
                        Else
                            Return x.BestTime.CompareTo(y.BestTime)
                        End If
                    End Function)

        Dim names As New ArrayList()
        For Each player In sorted
            names.Add(player.Name)
        Next

        If asc Then
            Return names
        End If

        names.Reverse()
        Return names
    End Function
End Class