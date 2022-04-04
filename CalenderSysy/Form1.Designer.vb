<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.monthYearContainer = New System.Windows.Forms.Panel()
        Me.daysOfWeekContainer = New System.Windows.Forms.Panel()
        Me.daysRow0Container = New System.Windows.Forms.Panel()
        Me.daysRow1Container = New System.Windows.Forms.Panel()
        Me.daysRow3Container = New System.Windows.Forms.Panel()
        Me.daysRow4Container = New System.Windows.Forms.Panel()
        Me.daysRow5Container = New System.Windows.Forms.Panel()
        Me.daysRow2Container = New System.Windows.Forms.Panel()
        Me.EventButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.EventButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'monthYearContainer
        '
        Me.monthYearContainer.BackColor = System.Drawing.Color.Aquamarine
        Me.monthYearContainer.Location = New System.Drawing.Point(138, 44)
        Me.monthYearContainer.Name = "monthYearContainer"
        Me.monthYearContainer.Size = New System.Drawing.Size(524, 32)
        Me.monthYearContainer.TabIndex = 33
        '
        'daysOfWeekContainer
        '
        Me.daysOfWeekContainer.BackColor = System.Drawing.Color.Transparent
        Me.daysOfWeekContainer.Location = New System.Drawing.Point(138, 82)
        Me.daysOfWeekContainer.Name = "daysOfWeekContainer"
        Me.daysOfWeekContainer.Size = New System.Drawing.Size(524, 44)
        Me.daysOfWeekContainer.TabIndex = 26
        '
        'daysRow0Container
        '
        Me.daysRow0Container.BackColor = System.Drawing.Color.Transparent
        Me.daysRow0Container.Location = New System.Drawing.Point(138, 132)
        Me.daysRow0Container.Name = "daysRow0Container"
        Me.daysRow0Container.Size = New System.Drawing.Size(524, 44)
        Me.daysRow0Container.TabIndex = 27
        '
        'daysRow1Container
        '
        Me.daysRow1Container.BackColor = System.Drawing.Color.Transparent
        Me.daysRow1Container.Location = New System.Drawing.Point(138, 182)
        Me.daysRow1Container.Name = "daysRow1Container"
        Me.daysRow1Container.Size = New System.Drawing.Size(524, 34)
        Me.daysRow1Container.TabIndex = 28
        '
        'daysRow3Container
        '
        Me.daysRow3Container.BackColor = System.Drawing.Color.Transparent
        Me.daysRow3Container.Location = New System.Drawing.Point(138, 271)
        Me.daysRow3Container.Name = "daysRow3Container"
        Me.daysRow3Container.Size = New System.Drawing.Size(524, 35)
        Me.daysRow3Container.TabIndex = 30
        '
        'daysRow4Container
        '
        Me.daysRow4Container.BackColor = System.Drawing.Color.Transparent
        Me.daysRow4Container.Location = New System.Drawing.Point(138, 321)
        Me.daysRow4Container.Name = "daysRow4Container"
        Me.daysRow4Container.Size = New System.Drawing.Size(524, 44)
        Me.daysRow4Container.TabIndex = 31
        '
        'daysRow5Container
        '
        Me.daysRow5Container.BackColor = System.Drawing.Color.Transparent
        Me.daysRow5Container.Location = New System.Drawing.Point(138, 371)
        Me.daysRow5Container.Name = "daysRow5Container"
        Me.daysRow5Container.Size = New System.Drawing.Size(524, 35)
        Me.daysRow5Container.TabIndex = 32
        '
        'daysRow2Container
        '
        Me.daysRow2Container.BackColor = System.Drawing.Color.Transparent
        Me.daysRow2Container.Location = New System.Drawing.Point(138, 222)
        Me.daysRow2Container.Name = "daysRow2Container"
        Me.daysRow2Container.Size = New System.Drawing.Size(524, 43)
        Me.daysRow2Container.TabIndex = 29
        '
        'EventButton
        '
        Me.EventButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EventButton.BackColor = System.Drawing.Color.Aquamarine
        Me.EventButton.BackgroundImage = CType(resources.GetObject("EventButton.BackgroundImage"), System.Drawing.Image)
        Me.EventButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EventButton.Location = New System.Drawing.Point(668, 371)
        Me.EventButton.Name = "EventButton"
        Me.EventButton.Size = New System.Drawing.Size(35, 35)
        Me.EventButton.TabIndex = 35
        Me.EventButton.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EventButton)
        Me.Controls.Add(Me.monthYearContainer)
        Me.Controls.Add(Me.daysOfWeekContainer)
        Me.Controls.Add(Me.daysRow0Container)
        Me.Controls.Add(Me.daysRow1Container)
        Me.Controls.Add(Me.daysRow3Container)
        Me.Controls.Add(Me.daysRow4Container)
        Me.Controls.Add(Me.daysRow5Container)
        Me.Controls.Add(Me.daysRow2Container)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EventButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents monthYearContainer As Panel
    Friend WithEvents daysOfWeekContainer As Panel
    Friend WithEvents daysRow0Container As Panel
    Friend WithEvents daysRow1Container As Panel
    Friend WithEvents daysRow3Container As Panel
    Friend WithEvents daysRow4Container As Panel
    Friend WithEvents daysRow5Container As Panel
    Friend WithEvents daysRow2Container As Panel
    Friend WithEvents EventButton As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
