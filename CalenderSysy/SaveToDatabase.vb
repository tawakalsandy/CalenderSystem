Imports System.Data.OleDb
Imports CalenderSysy.RetrieveFromDatabase
Public Class SaveToDatabase

    Public Shared Sub AddData()

        Dim conString As String
        Dim command As String
        Dim myconnection As OleDbConnection = New OleDbConnection

        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\tawak\Desktop\CalenderSystem2.0\AlarmData.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
        command = "Insert into AlarmInfoTable([AlarmDate],[AlarmTime],[AlarmColor],[AlarmTitle],[AlarmImage],[AlarmSong])values('" & eventDate & "','" & eventTime & "','" & eventColor & "','" & eventName & "','" & imagePath & "','" & ringtone & "')"

        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("AlarmDate", CType(eventDate, String)))
        cmd.Parameters.Add(New OleDbParameter("AlarmTime", CType(eventTime, String)))
        cmd.Parameters.Add(New OleDbParameter("AlarmColor", CType(eventColor, String)))
        cmd.Parameters.Add(New OleDbParameter("AlarmTitle", CType(eventName, String)))
        cmd.Parameters.Add(New OleDbParameter("AlarmImage", CType(imagePath, String)))
        cmd.Parameters.Add(New OleDbParameter("AlarmSound", CType(ringtone, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class