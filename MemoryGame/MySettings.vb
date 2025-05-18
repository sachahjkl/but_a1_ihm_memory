Imports System.Configuration
Imports System.Collections.Specialized

Public Class MySettings
    Inherits ApplicationSettingsBase

    <UserScopedSetting()>
    Public Property RecentUsers As StringCollection
        Get
            If Item(NameOf(RecentUsers)) Is Nothing Then Item(NameOf(RecentUsers)) = New StringCollection()
            Return Item(NameOf(RecentUsers))
        End Get
        Set(value As StringCollection)
            Item(NameOf(RecentUsers)) = value
        End Set
    End Property

    <UserScopedSetting()>
    Public Property UsersScore As Dictionary(Of String, Integer)
        Get
            If Item(NameOf(UsersScore)) Is Nothing Then Item(NameOf(UsersScore)) = New Dictionary(Of String, Integer)
            Return Item(NameOf(RecentUsers))
        End Get
        Set(value As Dictionary(Of String, Integer))
            Item(NameOf(UsersScore)) = value
        End Set
    End Property

End Class