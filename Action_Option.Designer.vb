<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Action_Option
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Action_Option))
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Homebtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPhotocopy = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Location = New System.Drawing.Point(244, 200)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(186, 64)
        Me.btnPrint.TabIndex = 32
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panel2.Controls.Add(Me.Button1)
        Me.panel2.Controls.Add(Me.btnback)
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(935, 53)
        Me.panel2.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(847, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 36)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = False
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
        'Homebtn
        '
        Me.Homebtn.BackColor = System.Drawing.Color.Transparent
        Me.Homebtn.BackgroundImage = CType(resources.GetObject("Homebtn.BackgroundImage"), System.Drawing.Image)
        Me.Homebtn.FlatAppearance.BorderSize = 0
        Me.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Homebtn.Location = New System.Drawing.Point(385, 409)
        Me.Homebtn.Name = "Homebtn"
        Me.Homebtn.Size = New System.Drawing.Size(164, 72)
        Me.Homebtn.TabIndex = 37
        Me.Homebtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(328, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 45)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "(Choose an action)"
        '
        'btnPhotocopy
        '
        Me.btnPhotocopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnPhotocopy.FlatAppearance.BorderSize = 0
        Me.btnPhotocopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhotocopy.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhotocopy.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPhotocopy.Location = New System.Drawing.Point(505, 200)
        Me.btnPhotocopy.Name = "btnPhotocopy"
        Me.btnPhotocopy.Size = New System.Drawing.Size(186, 64)
        Me.btnPhotocopy.TabIndex = 33
        Me.btnPhotocopy.Text = "PHOTOCOPY"
        Me.btnPhotocopy.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(237, 208)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(186, 64)
        Me.FlowLayoutPanel1.TabIndex = 34
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(497, 208)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(186, 64)
        Me.FlowLayoutPanel2.TabIndex = 35
        '
        'Action_Option
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(935, 538)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Homebtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPhotocopy)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Action_Option"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Action_Option"
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrint As Button
    Private WithEvents panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Homebtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPhotocopy As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Private WithEvents Button1 As Button
    Private WithEvents btnback As Button
End Class
