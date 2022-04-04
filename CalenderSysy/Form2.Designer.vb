<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblEventDetails = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.TxtEventName = New System.Windows.Forms.TextBox()
        Me.EventImage = New System.Windows.Forms.PictureBox()
        Me.ImageIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRingtone = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblEventTime = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColorPicker = New System.Windows.Forms.PictureBox()
        CType(Me.EventImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(12, 9)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 23)
        Me.cmdBack.TabIndex = 0
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'DatePicker
        '
        Me.DatePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatePicker.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Location = New System.Drawing.Point(516, 114)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DatePicker.ShowUpDown = True
        Me.DatePicker.Size = New System.Drawing.Size(299, 33)
        Me.DatePicker.TabIndex = 1
        '
        'lblEventDetails
        '
        Me.lblEventDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEventDetails.AutoSize = True
        Me.lblEventDetails.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDetails.Location = New System.Drawing.Point(329, 38)
        Me.lblEventDetails.Name = "lblEventDetails"
        Me.lblEventDetails.Size = New System.Drawing.Size(181, 33)
        Me.lblEventDetails.TabIndex = 2
        Me.lblEventDetails.Text = "Event Details :"
        '
        'lblEventDate
        '
        Me.lblEventDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDate.Location = New System.Drawing.Point(329, 114)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(156, 33)
        Me.lblEventDate.TabIndex = 3
        Me.lblEventDate.Text = "Event Date :"
        '
        'TxtEventName
        '
        Me.TxtEventName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEventName.Location = New System.Drawing.Point(516, 50)
        Me.TxtEventName.Name = "TxtEventName"
        Me.TxtEventName.Size = New System.Drawing.Size(299, 20)
        Me.TxtEventName.TabIndex = 4
        '
        'EventImage
        '
        Me.EventImage.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.EventImage.Location = New System.Drawing.Point(12, 38)
        Me.EventImage.Name = "EventImage"
        Me.EventImage.Size = New System.Drawing.Size(311, 255)
        Me.EventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EventImage.TabIndex = 5
        Me.EventImage.TabStop = False
        '
        'ImageIcon
        '
        Me.ImageIcon.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ImageIcon.Image = CType(resources.GetObject("ImageIcon.Image"), System.Drawing.Image)
        Me.ImageIcon.Location = New System.Drawing.Point(133, 131)
        Me.ImageIcon.Name = "ImageIcon"
        Me.ImageIcon.Size = New System.Drawing.Size(67, 67)
        Me.ImageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageIcon.TabIndex = 6
        Me.ImageIcon.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(103, 322)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(67, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "RingTone :"
        '
        'lblRingtone
        '
        Me.lblRingtone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRingtone.AutoSize = True
        Me.lblRingtone.Font = New System.Drawing.Font("Segoe Script", 15.75!)
        Me.lblRingtone.Location = New System.Drawing.Point(152, 397)
        Me.lblRingtone.Name = "lblRingtone"
        Me.lblRingtone.Size = New System.Drawing.Size(98, 33)
        Me.lblRingtone.TabIndex = 10
        Me.lblRingtone.Text = "Default"
        '
        'Save
        '
        Me.Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Save.Location = New System.Drawing.Point(655, 398)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 13
        Me.Save.Text = "&save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.Red
        '
        'TimePicker
        '
        Me.TimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimePicker.CustomFormat = "HH:mm"
        Me.TimePicker.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimePicker.Location = New System.Drawing.Point(516, 181)
        Me.TimePicker.Name = "TimePicker"
        Me.TimePicker.ShowUpDown = True
        Me.TimePicker.Size = New System.Drawing.Size(299, 33)
        Me.TimePicker.TabIndex = 17
        Me.TimePicker.Value = New Date(2022, 3, 31, 14, 53, 0, 0)
        '
        'lblEventTime
        '
        Me.lblEventTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEventTime.AutoSize = True
        Me.lblEventTime.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTime.Location = New System.Drawing.Point(329, 181)
        Me.lblEventTime.Name = "lblEventTime"
        Me.lblEventTime.Size = New System.Drawing.Size(162, 33)
        Me.lblEventTime.TabIndex = 18
        Me.lblEventTime.Text = "Event Time :"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(531, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 33)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Event Color :"
        '
        'ColorPicker
        '
        Me.ColorPicker.BackColor = System.Drawing.Color.White
        Me.ColorPicker.Location = New System.Drawing.Point(516, 253)
        Me.ColorPicker.Name = "ColorPicker"
        Me.ColorPicker.Size = New System.Drawing.Size(299, 25)
        Me.ColorPicker.TabIndex = 23
        Me.ColorPicker.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 450)
        Me.Controls.Add(Me.ColorPicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblEventTime)
        Me.Controls.Add(Me.TimePicker)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.lblRingtone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ImageIcon)
        Me.Controls.Add(Me.EventImage)
        Me.Controls.Add(Me.TxtEventName)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.lblEventDetails)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.cmdBack)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.EventImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdBack As Button
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents lblEventDetails As Label
    Friend WithEvents lblEventDate As Label
    Friend WithEvents TxtEventName As TextBox
    Friend WithEvents EventImage As PictureBox
    Friend WithEvents ImageIcon As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRingtone As Label
    Friend WithEvents Save As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TimePicker As DateTimePicker
    Friend WithEvents lblEventTime As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ColorPicker As PictureBox
End Class
