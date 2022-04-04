Public Class MonthlyCalenderInfo
    Private _Month As Integer
    Private _Year As Integer
    Private ReadOnly _Days(5, 6) As DateTime

    Public ReadOnly Property Month
        Get
            Return _Month
        End Get
    End Property

    Public ReadOnly Property Year
        Get
            Return _Year
        End Get
    End Property

    Public Sub New()
        _Month = Now.Month
        _Year = Now.Year
        SetDays()
    End Sub

    Public Sub New(Year As Integer, month As Integer)
        If Year < 1 Or Year > 9999 Then
            Throw New ArgumentOutOfRangeException("year")
        End If
        If month < 1 Or month > 12 Then
            Throw New ArgumentOutOfRangeException("Month")
        End If

        _Month = month
        _Year = Year
        SetDays()
    End Sub

    Private Sub SetDays()
        Dim firstDayofMonth As DateTime
        Dim column As Integer
        Dim firstDayofGrid As DateTime
        Dim gridDate As DateTime

        firstDayofMonth = New Date(_Year, _Month, 1)
        column = CInt(firstDayofMonth.DayOfWeek)
        firstDayofGrid = firstDayofMonth.AddDays(column * -1)

        gridDate = firstDayofGrid

        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                _Days(rowIndex, colIndex) = gridDate
                gridDate = gridDate.AddDays(1)
            Next
        Next
    End Sub

    Public Sub GoToMonth(Year As Integer, month As Integer)
        If Year < 1 Or Year > 9999 Then
            Throw New ArgumentOutOfRangeException("year")
        End If
        If month < 1 Or month > 12 Then
            Throw New ArgumentOutOfRangeException("month")
        End If

        _Year = Year
        _Month = month
        SetDays()

    End Sub

    Public Function DayInMonth(row As Integer, column As Integer) As Integer
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("row")
        End If

        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("column")
        End If

        Return _Days(row, column).Day
    End Function

    Public Function IsActiveMonth(row As Integer, column As Integer) As Boolean
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("row")
        End If

        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("column")
        End If

        Return _Days(row, column).Month = Month
    End Function

    Public Function IsToday(row As Integer, column As Integer) As Boolean
        If row < 0 Or row > 5 Then
            Throw New ArgumentOutOfRangeException("row")
        End If

        If column < 0 Or column > 6 Then
            Throw New ArgumentOutOfRangeException("column")
        End If

        Return _Days(row, column).Date = Now.Date
    End Function

    Public Function Row(dt As DateTime) As Integer

        Dim colIndex = 0
        Dim rowIndex = 0
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                If _Days(rowIndex, colIndex) = dt Then
                    Return rowIndex
                End If
            Next
        Next
        Return -1
    End Function

    Public Function Col(dt As DateTime) As Integer

        Dim colIndex = 0
        Dim rowIndex = 0
        For rowIndex = 0 To 5
            For colIndex = 0 To 6
                If _Days(rowIndex, colIndex) = dt Then
                    Return colIndex
                End If
            Next
        Next
        Return -1
    End Function

    Public Function DateExists(dt As DateTime) As Boolean
        If Row(dt) > -1 Then
            Return True
        End If
        Return False
    End Function
End Class
