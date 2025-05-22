<Serializable()>
Public Class Player
    Private _name As String
    Private _bestScore As Integer
    Private _bestTime As Integer
    Private _gamesPlayed As Integer
    Private _timePlayed As Integer

    Public Sub New()
        _bestTime = 0
        _gamesPlayed = 0
        _timePlayed = 0
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property


    Public Property BestScore As Integer
        Get
            Return _bestScore
        End Get
        Set(value As Integer)
            _bestScore = value
        End Set
    End Property


    Public Property BestTime As Integer
        Get
            Return _bestTime
        End Get
        Set(value As Integer)
            _bestTime = value
        End Set
    End Property


    Public Property GamesPlayed As Integer
        Get
            Return _gamesPlayed
        End Get
        Set(value As Integer)
            _gamesPlayed = value
        End Set
    End Property


    Public Property TimePlayed As Integer
        Get
            Return _timePlayed
        End Get
        Set(value As Integer)
            _timePlayed = value
        End Set
    End Property

    Public Sub updateBestTime(time As Integer)
        If BestTime = 0 Then
            BestTime = time
            Return
        End If

        If time < BestTime Then
            BestTime = time
        End If
    End Sub

    Public Sub updateBestScore(gameScore As Integer)
        If BestScore < gameScore Then
            BestScore = gameScore
        End If
    End Sub
End Class
