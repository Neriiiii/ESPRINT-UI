<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.pl1 = New System.Windows.Forms.Panel()
        Me.lblSPM = New System.Windows.Forms.Label()
        Me.Login_btn = New System.Windows.Forms.Button()
        Me.Password_tb = New System.Windows.Forms.TextBox()
        Me.Username_tb = New System.Windows.Forms.TextBox()
        Me.Admin_lb = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pl1
        '
        Me.pl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pl1.Controls.Add(Me.lblSPM)
        Me.pl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pl1.Location = New System.Drawing.Point(0, 0)
        Me.pl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pl1.Name = "pl1"
        Me.pl1.Size = New System.Drawing.Size(935, 53)
        Me.pl1.TabIndex = 29
        '
        'lblSPM
        '
        Me.lblSPM.AutoSize = True
        Me.lblSPM.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSPM.ForeColor = System.Drawing.Color.White
        Me.lblSPM.Location = New System.Drawing.Point(215, 0)
        Me.lblSPM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSPM.Name = "lblSPM"
        Me.lblSPM.Size = New System.Drawing.Size(518, 50)
        Me.lblSPM.TabIndex = 0
        Me.lblSPM.Text = "SMART PRINTING MACHINE"
        '
        'Login_btn
        '
        Me.Login_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Login_btn.FlatAppearance.BorderSize = 0
        Me.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login_btn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Login_btn.Location = New System.Drawing.Point(405, 431)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(144, 38)
        Me.Login_btn.TabIndex = 35
        Me.Login_btn.Text = "LOG-IN"
        Me.Login_btn.UseVisualStyleBackColor = False
        '
        'Password_tb
        '
        Me.Password_tb.BackColor = System.Drawing.SystemColors.Window
        Me.Password_tb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_tb.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Password_tb.Location = New System.Drawing.Point(349, 383)
        Me.Password_tb.Name = "Password_tb"
        Me.Password_tb.Size = New System.Drawing.Size(250, 25)
        Me.Password_tb.TabIndex = 34
        Me.Password_tb.Text = "PASSWORD"
        Me.Password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Username_tb
        '
        Me.Username_tb.BackColor = System.Drawing.SystemColors.Window
        Me.Username_tb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_tb.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Username_tb.Location = New System.Drawing.Point(349, 337)
        Me.Username_tb.Name = "Username_tb"
        Me.Username_tb.Size = New System.Drawing.Size(250, 25)
        Me.Username_tb.TabIndex = 33
        Me.Username_tb.Text = "USERNAME"
        Me.Username_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Admin_lb
        '
        Me.Admin_lb.AutoSize = True
        Me.Admin_lb.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_lb.Location = New System.Drawing.Point(425, 284)
        Me.Admin_lb.Name = "Admin_lb"
        Me.Admin_lb.Size = New System.Drawing.Size(99, 32)
        Me.Admin_lb.TabIndex = 32
        Me.Admin_lb.Text = "ADMIN"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.White
        Me.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.ForeColor = System.Drawing.Color.Black
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.Location = New System.Drawing.Point(569, 384)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(23, 23)
        Me.btnShow.TabIndex = 36
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.White
        Me.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Image = CType(resources.GetObject("btnHide.Image"), System.Drawing.Image)
        Me.btnHide.Location = New System.Drawing.Point(569, 384)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(23, 23)
        Me.btnHide.TabIndex = 37
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Location = New System.Drawing.Point(398, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 38)
        Me.Panel1.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Honeydew
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(240, 65)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(469, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(935, 540)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Login_btn)
        Me.Controls.Add(Me.Password_tb)
        Me.Controls.Add(Me.Username_tb)
        Me.Controls.Add(Me.Admin_lb)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.pl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.pl1.ResumeLayout(False)
        Me.pl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pl1 As Panel
    Friend WithEvents lblSPM As Label
    Private WithEvents Login_btn As Button
    Private WithEvents Password_tb As TextBox
    Private WithEvents Username_tb As TextBox
    Private WithEvents Admin_lb As Label
    Private WithEvents btnShow As Button
    Private WithEvents btnHide As Button
    Friend WithEvents Panel1 As Panel
    Private WithEvents PictureBox1 As PictureBox
End Class
