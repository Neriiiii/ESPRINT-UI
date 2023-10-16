<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_SetUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page_SetUp))
        Me.rbShort = New System.Windows.Forms.RadioButton()
        Me.rbLong = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblFileName1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbColored = New System.Windows.Forms.RadioButton()
        Me.rbBW = New System.Windows.Forms.RadioButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbShort
        '
        Me.rbShort.AutoSize = True
        Me.rbShort.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbShort.ForeColor = System.Drawing.SystemColors.MenuText
        Me.rbShort.Location = New System.Drawing.Point(49, 85)
        Me.rbShort.Name = "rbShort"
        Me.rbShort.Size = New System.Drawing.Size(66, 25)
        Me.rbShort.TabIndex = 2
        Me.rbShort.TabStop = True
        Me.rbShort.Text = "Short"
        Me.rbShort.UseVisualStyleBackColor = True
        '
        'rbLong
        '
        Me.rbLong.AutoSize = True
        Me.rbLong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLong.ForeColor = System.Drawing.SystemColors.MenuText
        Me.rbLong.Location = New System.Drawing.Point(49, 54)
        Me.rbLong.Name = "rbLong"
        Me.rbLong.Size = New System.Drawing.Size(63, 25)
        Me.rbLong.TabIndex = 1
        Me.rbLong.TabStop = True
        Me.rbLong.Text = "Long"
        Me.rbLong.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(29, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Paper Size"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(385, 409)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(164, 72)
        Me.btnHome.TabIndex = 38
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(314, 91)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(138, 155)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 37
        Me.pictureBox2.TabStop = False
        '
        'lblFileName1
        '
        Me.lblFileName1.AutoSize = True
        Me.lblFileName1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFileName1.Location = New System.Drawing.Point(475, 156)
        Me.lblFileName1.Name = "lblFileName1"
        Me.lblFileName1.Size = New System.Drawing.Size(160, 25)
        Me.lblFileName1.TabIndex = 35
        Me.lblFileName1.Text = "(Insert File Name)"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.label2.Location = New System.Drawing.Point(478, 125)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(98, 21)
        Me.label2.TabIndex = 34
        Me.label2.Text = "File's Name:"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panel2.Controls.Add(Me.btnNext)
        Me.panel2.Controls.Add(Me.btnback)
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(935, 53)
        Me.panel2.TabIndex = 39
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNext.Location = New System.Drawing.Point(847, 9)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 36)
        Me.btnNext.TabIndex = 39
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.SystemColors.Control
        Me.btnback.Location = New System.Drawing.Point(12, 9)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(76, 36)
        Me.btnback.TabIndex = 38
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(208, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMART PRINTING MACHINE"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.rbColored)
        Me.Panel4.Controls.Add(Me.rbBW)
        Me.Panel4.Controls.Add(Me.label3)
        Me.Panel4.Location = New System.Drawing.Point(301, 265)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 125)
        Me.Panel4.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(29, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Color Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rbColored
        '
        Me.rbColored.AutoSize = True
        Me.rbColored.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbColored.ForeColor = System.Drawing.SystemColors.MenuText
        Me.rbColored.Location = New System.Drawing.Point(21, 85)
        Me.rbColored.Name = "rbColored"
        Me.rbColored.Size = New System.Drawing.Size(83, 25)
        Me.rbColored.TabIndex = 5
        Me.rbColored.TabStop = True
        Me.rbColored.Text = "Colored"
        Me.rbColored.UseVisualStyleBackColor = True
        '
        'rbBW
        '
        Me.rbBW.AutoSize = True
        Me.rbBW.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBW.ForeColor = System.Drawing.SystemColors.MenuText
        Me.rbBW.Location = New System.Drawing.Point(21, 54)
        Me.rbBW.Name = "rbBW"
        Me.rbBW.Size = New System.Drawing.Size(119, 25)
        Me.rbBW.TabIndex = 4
        Me.rbBW.TabStop = True
        Me.rbBW.Text = "Black / White"
        Me.rbBW.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.Window
        Me.label3.Location = New System.Drawing.Point(33, 14)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 25)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Color Type"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.rbShort)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.rbLong)
        Me.Panel5.Location = New System.Drawing.Point(487, 265)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(160, 125)
        Me.Panel5.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(158, 45)
        Me.Panel6.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(33, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Color Type"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Location = New System.Drawing.Point(292, 273)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 125)
        Me.Panel3.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel7.Location = New System.Drawing.Point(478, 273)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(160, 125)
        Me.Panel7.TabIndex = 8
        '
        'Page_SetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(935, 538)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.lblFileName1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Page_SetUp"
        Me.Text = "Page_SetUp"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents rbShort As RadioButton
    Private WithEvents rbLong As RadioButton
    Private WithEvents Label4 As Label
    Friend WithEvents btnHome As Button
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents lblFileName1 As Label
    Private WithEvents label2 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents btnNext As Button
    Private WithEvents btnback As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Private WithEvents Panel1 As Panel
    Private WithEvents Label5 As Label
    Private WithEvents rbColored As RadioButton
    Private WithEvents rbBW As RadioButton
    Private WithEvents label3 As Label
    Friend WithEvents Panel5 As Panel
    Private WithEvents Panel6 As Panel
    Private WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
End Class
