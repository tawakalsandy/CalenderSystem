Imports Microsoft.VisualBasic.Devices
Imports System.Data.OleDb
Imports CalenderSysy.RetrieveFromDatabase
Public Class Form1
    Private _calenderInfo As MonthlyCalenderInfo
    Dim Reminder As New Form2
    Dim dates As New List(Of DateTime)
    Dim info As New List(Of String)
    Dim times As New List(Of String)
    Dim labelcolors As New List(Of Color)
    Dim songs As New List(Of String)
    Dim images As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SizeContainers()
        CreateMonthYear()
        SizeMonthYear()
        CreateDaysOfWeek()
        SizeDaysOfWeek()
        CreateDays()
        SizeDays()
        SizeEventButton()
        _calenderInfo = New MonthlyCalenderInfo(2022, 4)
        PopulateCalender()
        DisplayAlarmData()
    End Sub

    Private Sub Form1_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        SizeContainers()
        SizeMonthYear()
        SizeDaysOfWeek()
        SizeDays()
        SizeEventButton()
    End Sub

    Private Sub SizeContainers()
        Dim daysHeight As Integer
        Dim daysStart As Integer

        monthYearContainer.Size = New Size(ClientSize.Width, 50)
        monthYearContainer.Location = New Point(0, 0)
        daysOfWeekContainer.Size = New Size(ClientSize.Width, 30)
        daysOfWeekContainer.Location = New Point(0, monthYearContainer.Height)

        daysHeight = (ClientSize.Height - monthYearContainer.Height - daysOfWeekContainer.Height) / 6
        daysStart = monthYearContainer.Height + daysOfWeekContainer.Height

        daysRow0Container.Size = New Size(ClientSize.Width, daysHeight)
        daysRow0Container.Location = New Point(0, daysStart)
        daysRow1Container.Size = New Size(ClientSize.Width, daysHeight)
        daysRow1Container.Location = New Point(0, daysStart + (daysHeight))
        daysRow2Container.Size = New Size(ClientSize.Width, daysHeight)
        daysRow2Container.Location = New Point(0, daysStart + (daysHeight * 2))
        daysRow3Container.Size = New Size(ClientSize.Width, daysHeight)
        daysRow3Container.Location = New Point(0, daysStart + (daysHeight * 3))
        daysRow4Container.Size = New Size(ClientSize.Width, daysHeight)
        daysRow4Container.Location = New Point(0, daysStart + (daysHeight * 4))
        daysRow5Container.Size = New Size(ClientSize.Width, daysHeight)
        daysRow5Container.Location = New Point(0, daysStart + (daysHeight * 5))
    End Sub

    Private Sub CreateMonthYear()
        Dim lbl As Label = New Label()
        lbl.Name = "lblMonthYear"
        lbl.Font = New Font("Segoe Script", 18, FontStyle.Regular)
        lbl.AutoSize = True
        lbl.Text = "Month Year"

        monthYearContainer.Controls.Add(lbl)
    End Sub

    Private Sub SizeMonthYear()
        Dim x As Integer
        Dim y As Integer
        Dim lbl As Label
        If monthYearContainer.Controls.Count > 0 Then
            lbl = monthYearContainer.Controls.Find("lblMonthYear", False).First
            x = (monthYearContainer.Width - lbl.Width) / 2
            y = (monthYearContainer.Height - lbl.Height) / 2
            lbl.Location = New Point(x, y)
        End If
    End Sub

    Private Sub CreateDaysOfWeek()
        Dim lbl As Label
        Dim days As String() = New String(6) {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
        For i = 0 To 6
            lbl = New Label
            lbl.Name = String.Format("lbl.(0)", days(i))
            lbl.Text = days(i)
            lbl.AutoSize = False
            lbl.Font = New Font("Segoe Script", 10, FontStyle.Regular)
            lbl.TextAlign = ContentAlignment.MiddleLeft
            daysOfWeekContainer.Controls.Add(lbl)
        Next
    End Sub

    Private Sub SizeDaysOfWeek()
        SizeWidthEqually(daysOfWeekContainer)
    End Sub

    Private Sub SizeWidthEqually(ByVal c As Control)
        Dim width As Integer
        Dim x As Integer
        If c.Controls.Count = 0 Then
            Return
        End If
        width = c.Width / c.Controls.Count
        For Each ctrl As Control In c.Controls
            ctrl.Height = c.Height
            ctrl.Width = width
            ctrl.Location = New Point(x, 0)
            x += width
        Next
    End Sub

    Private Sub CreateDays()
        Dim dayPanel As Panel
        Dim DayofMonthlbl As Label

        For rowindex = 0 To 5
            For colIndex = 0 To 6
                dayPanel = New Panel
                dayPanel.Name = String.Format("PnlDay{0}{1}", rowindex, colIndex)
                DayofMonthlbl = New Label
                DayofMonthlbl.Name = String.Format("LblDayOfMonth{0}{1}", rowindex, colIndex)
                DayofMonthlbl.Text = DayofMonthlbl.Name
                dayPanel.Controls.Add(DayofMonthlbl)

                Select Case rowindex
                    Case 0
                        daysRow0Container.Controls.Add(dayPanel)
                    Case 1
                        daysRow1Container.Controls.Add(dayPanel)
                    Case 2
                        daysRow2Container.Controls.Add(dayPanel)
                    Case 3
                        daysRow3Container.Controls.Add(dayPanel)
                    Case 4
                        daysRow4Container.Controls.Add(dayPanel)
                    Case 5
                        daysRow5Container.Controls.Add(dayPanel)
                End Select
            Next
        Next

    End Sub

    Private Sub SizeDays()
        SizeWidthEqually(daysRow0Container)
        SizeWidthEqually(daysRow1Container)
        SizeWidthEqually(daysRow2Container)
        SizeWidthEqually(daysRow3Container)
        SizeWidthEqually(daysRow4Container)
        SizeWidthEqually(daysRow5Container)
    End Sub

    Private Sub PopulateCalender()
        Dim lbl As Control
        Dim lblName As String

        lbl = monthYearContainer.Controls.Find("LblMonthYear", False).First
        lbl.Text = String.Format("{0} {1}", MonthName(_calenderInfo.Month), _calenderInfo.Year)

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                lblName = String.Format("LblDayOfMonth{0}{1}", rowIndex, colIndex)
                lbl = Me.Controls.Find(lblName, True).First
                lbl.Text = _calenderInfo.DayInMonth(rowIndex, colIndex)

                If _calenderInfo.IsActiveMonth(rowIndex, colIndex) Then
                    lbl.ForeColor = Color.Black
                Else
                    lbl.ForeColor = Color.Gray
                End If
                If _calenderInfo.IsToday(rowIndex, colIndex) Then
                    lbl.ForeColor = Color.Red
                End If
            Next
        Next
    End Sub

    Private Sub MonthYearContainer_Click(sender As Object, e As EventArgs) Handles monthYearContainer.Click
        Dim PointClicked As Point
        Dim midpointX As Integer
        Dim activeMonth As DateTime
        Dim newMonth As DateTime

        midpointX = monthYearContainer.Width / 2

        PointClicked = monthYearContainer.PointToClient(Cursor.Position)
        activeMonth = New Date(_calenderInfo.Year, _calenderInfo.Month, 1)

        If PointClicked.X < midpointX Then
            newMonth = activeMonth.AddMonths(-1)
        Else
            newMonth = activeMonth.AddMonths(1)
        End If

        _calenderInfo.GoToMonth(newMonth.Year, newMonth.Month)
        RemoveDispayedData(Me)
        PopulateCalender()
        DisplayAlarmData()
    End Sub

    Private Sub SizeEventButton()
        EventButton.BringToFront()
        EventButton.Size = New Size(50, 50)
        EventButton.Location = New Point(0, 0)
    End Sub

    Private Sub EventButton_Click(sender As Object, e As EventArgs) Handles EventButton.Click
        Form2.Show()
    End Sub

    Private Sub FillingDataTables()
        For Each r As DataRow In infodt.Rows
            info.Add(r.Item(0).ToString)
        Next

        For Each r As DataRow In datedt.Rows
            dates.Add(Convert.ToDateTime(r.Item(0).ToString))
        Next

        For Each r As DataRow In colordt.Rows
            labelcolors.Add(Color.FromArgb(r.Item(0).ToString))
        Next

        For Each r As DataRow In timedt.Rows
            times.Add(r.Item(0).ToString)
        Next

        For Each r As DataRow In songdt.Rows
            songs.Add(r.Item(0).ToString)
        Next

        For Each r As DataRow In imagedt.Rows
            images.Add(r.Item(0).ToString)
        Next
    End Sub

    Public Sub DisplayAlarmData()
        Dim Col As Integer
        Dim row As Integer
        Dim pnl As Panel
        Dim lbl As Label
        Dim pnlName As String
        accessDatabase()
        FillingDataTables()


        For i = 0 To dates.Count - 1
            If _calenderInfo.DateExists(dates(i)) Then
                Col = _calenderInfo.Col(dates(i))
                row = _calenderInfo.Row(dates(i))
                pnlName = String.Format("PnlDay{0}{1}", row, Col)
                pnl = Controls.Find(pnlName, True).First
                lbl = New Label
                lbl.BackColor = labelcolors(i)
                lbl.Name = String.Format("LblTest{0}{1}", row, Col)
                lbl.Text = info(i)
                lbl.TextAlign = ContentAlignment.MiddleLeft
                lbl.Location = New Point(0, 25)
                pnl.Controls.Add(lbl)
            End If
        Next
    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i = 0 To dates.Count - 1
            If (dates(i) = Date.Today) Then
                If (times(i) = TimeOfDay.ToString("HH:mm:ss")) Then
                    ringtone = songs(i)
                    imagePath = images(i)
                    imagePicked = Image.FromFile(imagePath)
                    eventName = info(i)
                    My.Computer.Audio.Play(ringtone)
                    AlarmForm.Show()
                    Form2.Hide()
                End If
            End If
        Next
        'If ringtone = Nothing Then
        ' My.Computer.Audio.Play("C:\Windows\Media\Ring07")
        ' Else

        ' End if

    End Sub

    Private Sub RemoveDispayedData(c As Control)
        For Each ctrl As Control In c.Controls
            RemoveDispayedData(ctrl)
        Next
        If c.Name.Contains("LblTest") Then
            c.Parent.Controls.Remove(c)
        End If

    End Sub

End Class