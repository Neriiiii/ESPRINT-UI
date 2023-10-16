<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class start_up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(start_up))
        Me.pl1 = New System.Windows.Forms.Panel()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.lblSPM = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Logo_pb = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pl1.SuspendLayout()
        CType(Me.Logo_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pl1
        '
        Me.pl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pl1.Controls.Add(Me.btnAdmin)
        Me.pl1.Controls.Add(Me.lblSPM)
        Me.pl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pl1.Location = New System.Drawing.Point(0, 0)
        Me.pl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pl1.Name = "pl1"
        Me.pl1.Size = New System.Drawing.Size(935, 53)
        Me.pl1.TabIndex = 28
        '
        'btnAdmin
        '
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Image = CType(resources.GetObject("btnAdmin.Image"), System.Drawing.Image)
        Me.btnAdmin.Location = New System.Drawing.Point(877, 3)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(50, 50)
        Me.btnAdmin.TabIndex = 32
        Me.btnAdmin.UseVisualStyleBackColor = True
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
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStart.Location = New System.Drawing.Point(339, 354)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(257, 38)
        Me.btnStart.TabIndex = 30
        Me.btnStart.Text = "(TAP HERE TO START )"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Logo_pb
        '
        Me.Logo_pb.BackColor = System.Drawing.Color.Honeydew
        Me.Logo_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Logo_pb.Image = CType(resources.GetObject("Logo_pb.Image"), System.Drawing.Image)
        Me.Logo_pb.Location = New System.Drawing.Point(239, 150)
        Me.Logo_pb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Logo_pb.Name = "Logo_pb"
        Me.Logo_pb.Size = New System.Drawing.Size(469, 198)
        Me.Logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo_pb.TabIndex = 29
        Me.Logo_pb.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(331, 361)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(257, 38)
        Me.FlowLayoutPanel1.TabIndex = 31
        '
        'start_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(935, 538)
        Me.Controls.Add(Me.pl1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Logo_pb)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "start_up"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pl1.ResumeLayout(False)
        Me.pl1.PerformLayout()
        CType(Me.Logo_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pl1 As Panel
    Friend WithEvents lblSPM As Label
    Friend WithEvents btnStart As Button
    Private WithEvents Logo_pb As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAdmin As Button
End Class
