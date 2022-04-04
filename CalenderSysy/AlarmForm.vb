Imports CalenderSysy.RetrieveFromDatabase

Public Class AlarmForm
    Dim snoozeTime As Integer = 20000


    Private Sub AlarmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' PictureBox1.Width = ClientSize.Width * 25 / 100
        'PictureBox1.Height = ClientSize.Height * 25 / 100
        Create_AlarmObjects()

    End Sub

    Private Sub Create_AlarmObjects()
        Label1.Text = eventName
        PictureBox1.Image = imagePicked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        My.Computer.Audio.Stop()
        Timer1.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSnooze.Click
        Timer1.Enabled = True
        Timer1.Interval = snoozeTime
        My.Computer.Audio.Stop()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Computer.Audio.Play(ringtone)
        Me.Show()
        Form2.Hide()
    End Sub
End Class

