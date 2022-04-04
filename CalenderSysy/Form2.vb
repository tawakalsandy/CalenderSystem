Imports System.Data.OleDb
Imports CalenderSysy.RetrieveFromDatabase
Imports CalenderSysy.SaveToDatabase
Imports System.IO

Public Class Form2
    Dim lbl As Label

    Private createEvent As Form1

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddImageIcon()
        ColorPicker.BackColor = Color.Red
        eventColor = ColorPicker.BackColor.ToArgb.ToString
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Form1.Show()
        Me.Hide()
        lbl.Show()
        DatePicker.ResetText()
        ImageIcon.Show()
        EventImage.Image = Nothing

    End Sub

    Private Sub AddImageIcon()

        lbl = New Label
        lbl.Text = "Add Image"
        lbl.Location = EventImage.Location
        lbl.AutoSize = True
        lbl.Font = New Font("Segoe Script", 10, FontStyle.Regular)
        lbl.TextAlign = ContentAlignment.MiddleCenter
        EventImage.Controls.Add(lbl)


    End Sub

    Private Sub EventImage_Click(sender As Object, e As EventArgs) Handles EventImage.Click
        ChooseImage()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ImageIcon.Click
        ChooseImage()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        chooseAudio()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        eventTime = TimePicker.Value.ToString("HH:mm:ss")
        eventDate = DatePicker.Value.ToString("yyyy,MM,dd")
        eventName = TxtEventName.Text
        AddData()
        Form1.DisplayAlarmData()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub ChooseImage()
        ImageIcon.Hide()
        lbl.Hide()
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
            If img1.ShowDialog() = DialogResult.OK Then
                imagePicked = Image.FromFile(img1.FileName)
                imagePath = Path.GetFullPath(img1.FileName)
                EventImage.Image = imagePicked
            End If

        End Using
    End Sub

    Private Sub chooseAudio()
        Using Audio1 As OpenFileDialog = New OpenFileDialog

            Audio1.Filter = "choose Audio(*.wav;*.mp3)|*.wav;*.mp3"
            If Audio1.ShowDialog() = DialogResult.OK Then
                lblRingtone.Text = Path.GetFileName(Audio1.FileName)
                ringtone = Path.GetFullPath(Audio1.FileName)
            End If
        End Using
    End Sub

    Private Sub lblRingtone_Click(sender As Object, e As EventArgs) Handles lblRingtone.Click
        chooseAudio()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        chooseAudio()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Colorpicker_clicked(sender As Object, e As EventArgs) Handles ColorPicker.Click
        Dim color As DialogResult
        color = ColorDialog1.ShowDialog()

        If color = Windows.Forms.DialogResult.OK Then
            ColorPicker.BackColor = ColorDialog1.Color
            eventColor = ColorPicker.BackColor.ToArgb.ToString
        End If
    End Sub

End Class


