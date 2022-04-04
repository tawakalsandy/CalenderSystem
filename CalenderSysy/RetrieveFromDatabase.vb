Imports System.Data.OleDb
Public Class RetrieveFromDatabase
    Public Shared imagePicked As Image
    Public Shared eventTime As String
    Public Shared ringtone As String
    Public Shared eventName As String
    Public Shared eventDate As String
    Public Shared eventColor As String
    Public Shared imagePath As String

    Public Shared dateda As New OleDbDataAdapter
    Public Shared timeda As New OleDbDataAdapter
    Public Shared colorda As New OleDbDataAdapter
    Public Shared infoda As New OleDbDataAdapter
    Public Shared songda As New OleDbDataAdapter
    Public Shared imageda As New OleDbDataAdapter

    Public Shared datedt As New DataTable
    Public Shared timedt As New DataTable
    Public Shared colordt As New DataTable
    Public Shared infodt As New DataTable
    Public Shared songdt As New DataTable
    Public Shared imagedt As New DataTable

    Public Shared Sub accessDatabase()
        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim con As New OleDbConnection

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\tawak\Desktop\CalenderSystem2.0\AlarmData.mdb"
        con.Open()
        dateda = New OleDbDataAdapter("SELECT AlarmDate FROM AlarmInfoTable", con)
        dateda.Fill(datedt)
        timeda = New OleDbDataAdapter("SELECT AlarmTime FROM AlarmInfoTable", con)
        timeda.Fill(timedt)
        infoda = New OleDbDataAdapter("SELECT AlarmTitle FROM AlarmInfoTable", con)
        infoda.Fill(infodt)
        colorda = New OleDbDataAdapter("SELECT AlarmColor FROM AlarmInfoTable", con)
        colorda.Fill(colordt)
        songda = New OleDbDataAdapter("SELECT AlarmSong FROM AlarmInfoTable", con)
        songda.Fill(songdt)
        imageda = New OleDbDataAdapter("SELECT AlarmImage FROM AlarmInfoTable", con)
        imageda.Fill(imagedt)

        con.Close()
    End Sub


End Class

