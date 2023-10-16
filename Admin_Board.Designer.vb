<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Board
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Board))
        Me.pl1 = New System.Windows.Forms.Panel()
        Me.lblSPM = New System.Windows.Forms.Label()
        Me.PnlNav = New System.Windows.Forms.Panel()
        Me.mainPanel_pl = New System.Windows.Forms.Panel()
        Me.LogOut_btn = New System.Windows.Forms.Button()
        Me.SalesRep_btn = New System.Windows.Forms.Button()
        Me.CusTran_btn = New System.Windows.Forms.Button()
        Me.MyInfo_btn = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Reset_btn = New System.Windows.Forms.Button()
        Me.Content_pnl = New System.Windows.Forms.Panel()
        Me.Logo_pb = New System.Windows.Forms.PictureBox()
        Me.pl1.SuspendLayout()
        Me.mainPanel_pl.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.Content_pnl.SuspendLayout()
        CType(Me.Logo_pb, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pl1.TabIndex = 30
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
        'PnlNav
        '
        Me.PnlNav.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PnlNav.Location = New System.Drawing.Point(3, 95)
        Me.PnlNav.Name = "PnlNav"
        Me.PnlNav.Size = New System.Drawing.Size(3, 275)
        Me.PnlNav.TabIndex = 2
        '
        'mainPanel_pl
        '
        Me.mainPanel_pl.BackColor = System.Drawing.Color.DarkSlateGray
        Me.mainPanel_pl.Controls.Add(Me.LogOut_btn)
        Me.mainPanel_pl.Controls.Add(Me.PnlNav)
        Me.mainPanel_pl.Controls.Add(Me.SalesRep_btn)
        Me.mainPanel_pl.Controls.Add(Me.CusTran_btn)
        Me.mainPanel_pl.Controls.Add(Me.MyInfo_btn)
        Me.mainPanel_pl.Controls.Add(Me.panel2)
        Me.mainPanel_pl.Dock = System.Windows.Forms.DockStyle.Left
        Me.mainPanel_pl.ForeColor = System.Drawing.Color.Honeydew
        Me.mainPanel_pl.Location = New System.Drawing.Point(0, 53)
        Me.mainPanel_pl.Name = "mainPanel_pl"
        Me.mainPanel_pl.Size = New System.Drawing.Size(180, 485)
        Me.mainPanel_pl.TabIndex = 31
        '
        'LogOut_btn
        '
        Me.LogOut_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogOut_btn.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.LogOut_btn.FlatAppearance.BorderSize = 0
        Me.LogOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut_btn.ForeColor = System.Drawing.Color.Honeydew
        Me.LogOut_btn.Location = New System.Drawing.Point(0, 429)
        Me.LogOut_btn.Name = "LogOut_btn"
        Me.LogOut_btn.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.LogOut_btn.Size = New System.Drawing.Size(180, 56)
        Me.LogOut_btn.TabIndex = 0
        Me.LogOut_btn.Text = "LOG OUT"
        Me.LogOut_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LogOut_btn.UseVisualStyleBackColor = True
        '
        'SalesRep_btn
        '
        Me.SalesRep_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SalesRep_btn.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.SalesRep_btn.FlatAppearance.BorderSize = 0
        Me.SalesRep_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesRep_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesRep_btn.ForeColor = System.Drawing.Color.Honeydew
        Me.SalesRep_btn.Location = New System.Drawing.Point(0, 200)
        Me.SalesRep_btn.Name = "SalesRep_btn"
        Me.SalesRep_btn.Size = New System.Drawing.Size(180, 60)
        Me.SalesRep_btn.TabIndex = 4
        Me.SalesRep_btn.Text = "Sales Report"
        Me.SalesRep_btn.UseVisualStyleBackColor = True
        '
        'CusTran_btn
        '
        Me.CusTran_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CusTran_btn.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.CusTran_btn.FlatAppearance.BorderSize = 0
        Me.CusTran_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CusTran_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusTran_btn.ForeColor = System.Drawing.Color.Honeydew
        Me.CusTran_btn.Location = New System.Drawing.Point(0, 140)
        Me.CusTran_btn.Name = "CusTran_btn"
        Me.CusTran_btn.Size = New System.Drawing.Size(180, 60)
        Me.CusTran_btn.TabIndex = 3
        Me.CusTran_btn.Text = "Customer Transaction"
        Me.CusTran_btn.UseVisualStyleBackColor = True
        '
        'MyInfo_btn
        '
        Me.MyInfo_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyInfo_btn.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.MyInfo_btn.FlatAppearance.BorderSize = 0
        Me.MyInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyInfo_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyInfo_btn.ForeColor = System.Drawing.Color.Honeydew
        Me.MyInfo_btn.Location = New System.Drawing.Point(0, 80)
        Me.MyInfo_btn.Name = "MyInfo_btn"
        Me.MyInfo_btn.Size = New System.Drawing.Size(180, 60)
        Me.MyInfo_btn.TabIndex = 2
        Me.MyInfo_btn.Text = "My Information"
        Me.MyInfo_btn.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.Reset_btn)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.ForeColor = System.Drawing.Color.Honeydew
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(180, 80)
        Me.panel2.TabIndex = 1
        '
        'Reset_btn
        '
        Me.Reset_btn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Reset_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.Reset_btn.FlatAppearance.BorderSize = 0
        Me.Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_btn.Image = CType(resources.GetObject("Reset_btn.Image"), System.Drawing.Image)
        Me.Reset_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Reset_btn.Location = New System.Drawing.Point(0, 0)
        Me.Reset_btn.Name = "Reset_btn"
        Me.Reset_btn.Size = New System.Drawing.Size(180, 80)
        Me.Reset_btn.TabIndex = 1
        Me.Reset_btn.Text = "             Hello, Admin!"
        Me.Reset_btn.UseVisualStyleBackColor = False
        '
        'Content_pnl
        '
        Me.Content_pnl.Controls.Add(Me.Logo_pb)
        Me.Content_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content_pnl.Location = New System.Drawing.Point(180, 53)
        Me.Content_pnl.Name = "Content_pnl"
        Me.Content_pnl.Size = New System.Drawing.Size(755, 485)
        Me.Content_pnl.TabIndex = 32
        '
        'Logo_pb
        '
        Me.Logo_pb.BackColor = System.Drawing.Color.Honeydew
        Me.Logo_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Logo_pb.Image = CType(resources.GetObject("Logo_pb.Image"), System.Drawing.Image)
        Me.Logo_pb.Location = New System.Drawing.Point(143, 143)
        Me.Logo_pb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Logo_pb.Name = "Logo_pb"
        Me.Logo_pb.Size = New System.Drawing.Size(469, 198)
        Me.Logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo_pb.TabIndex = 31
        Me.Logo_pb.TabStop = False
        '
        'Admin_Board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(935, 538)
        Me.Controls.Add(Me.Content_pnl)
        Me.Controls.Add(Me.mainPanel_pl)
        Me.Controls.Add(Me.pl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Board"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Board"
        Me.pl1.ResumeLayout(False)
        Me.pl1.PerformLayout()
        Me.mainPanel_pl.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.Content_pnl.ResumeLayout(False)
        CType(Me.Logo_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pl1 As Panel
    Friend WithEvents lblSPM As Label
    Private WithEvents PnlNav As Panel
    Private WithEvents mainPanel_pl As Panel
    Private WithEvents LogOut_btn As Button
    Private WithEvents SalesRep_btn As Button
    Private WithEvents CusTran_btn As Button
    Private WithEvents MyInfo_btn As Button
    Private WithEvents panel2 As Panel
    Private WithEvents Reset_btn As Button
    Friend WithEvents Content_pnl As Panel
    Private WithEvents Logo_pb As PictureBox
End Class
