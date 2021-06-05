<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRATION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRATION))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AccNumTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PinTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FNameTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OccupatioTb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressTb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PhoneTb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DobDate = New System.Windows.Forms.DateTimePicker()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EduCb = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 61)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(725, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ATM MANAGEMENT SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 577)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 15)
        Me.Panel2.TabIndex = 3
        '
        'AccNumTb
        '
        Me.AccNumTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNumTb.Location = New System.Drawing.Point(126, 138)
        Me.AccNumTb.Name = "AccNumTb"
        Me.AccNumTb.Size = New System.Drawing.Size(183, 27)
        Me.AccNumTb.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ACC NUM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PinTb
        '
        Me.PinTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PinTb.Location = New System.Drawing.Point(541, 138)
        Me.PinTb.Name = "PinTb"
        Me.PinTb.Size = New System.Drawing.Size(183, 27)
        Me.PinTb.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "PIN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "EDUCATION"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NameTb
        '
        Me.NameTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTb.Location = New System.Drawing.Point(126, 204)
        Me.NameTb.Name = "NameTb"
        Me.NameTb.Size = New System.Drawing.Size(183, 27)
        Me.NameTb.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "NAME"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FNameTb
        '
        Me.FNameTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTb.Location = New System.Drawing.Point(126, 268)
        Me.FNameTb.Name = "FNameTb"
        Me.FNameTb.Size = New System.Drawing.Size(183, 27)
        Me.FNameTb.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "FNAME"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OccupatioTb
        '
        Me.OccupatioTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OccupatioTb.Location = New System.Drawing.Point(541, 265)
        Me.OccupatioTb.Name = "OccupatioTb"
        Me.OccupatioTb.Size = New System.Drawing.Size(183, 27)
        Me.OccupatioTb.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(413, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "OCCUPATION"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AddressTb
        '
        Me.AddressTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTb.Location = New System.Drawing.Point(126, 341)
        Me.AddressTb.Multiline = True
        Me.AddressTb.Name = "AddressTb"
        Me.AddressTb.Size = New System.Drawing.Size(183, 113)
        Me.AddressTb.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "ADDRESS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PhoneTb
        '
        Me.PhoneTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTb.Location = New System.Drawing.Point(541, 325)
        Me.PhoneTb.Name = "PhoneTb"
        Me.PhoneTb.Size = New System.Drawing.Size(183, 27)
        Me.PhoneTb.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(413, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "PHONE"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(413, 389)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 21)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "DOB"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DobDate
        '
        Me.DobDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DobDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DobDate.Location = New System.Drawing.Point(541, 390)
        Me.DobDate.Name = "DobDate"
        Me.DobDate.Size = New System.Drawing.Size(183, 27)
        Me.DobDate.TabIndex = 23
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.Color.DarkOrange
        Me.SubmitBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.White
        Me.SubmitBtn.Location = New System.Drawing.Point(334, 499)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SubmitBtn.Size = New System.Drawing.Size(144, 38)
        Me.SubmitBtn.TabIndex = 25
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(366, 549)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 22)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "LOGOUT"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(290, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 24)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "NEW ACCOUNT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EduCb
        '
        Me.EduCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EduCb.FormattingEnabled = True
        Me.EduCb.Items.AddRange(New Object() {"DIPLOMA", "UG", "PG", "PHD", "UNEDUCATED"})
        Me.EduCb.Location = New System.Drawing.Point(541, 196)
        Me.EduCb.Name = "EduCb"
        Me.EduCb.Size = New System.Drawing.Size(183, 29)
        Me.EduCb.TabIndex = 26
        '
        'REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 592)
        Me.Controls.Add(Me.EduCb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DobDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PhoneTb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AddressTb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.OccupatioTb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FNameTb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NameTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PinTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AccNumTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "REGISTRATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRATION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AccNumTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PinTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FNameTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OccupatioTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressTb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DobDate As DateTimePicker
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents EduCb As ComboBox
End Class
