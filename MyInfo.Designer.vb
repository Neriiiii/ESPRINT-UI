<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyInfo
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
        Me.label9 = New System.Windows.Forms.Label()
        Me.PassSave_btn = New System.Windows.Forms.Button()
        Me.NewPass_tb = New System.Windows.Forms.TextBox()
        Me.ConnfirmPass_tb = New System.Windows.Forms.TextBox()
        Me.OldPass_tb = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Address_tb = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.ContactName_tb = New System.Windows.Forms.TextBox()
        Me.LastName_tb = New System.Windows.Forms.TextBox()
        Me.EmailAdress_tb = New System.Windows.Forms.TextBox()
        Me.FirstName_tb = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.MyInfo_lb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(36, 254)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(152, 21)
        Me.label9.TabIndex = 41
        Me.label9.Text = "Change Password :"
        '
        'PassSave_btn
        '
        Me.PassSave_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PassSave_btn.FlatAppearance.BorderSize = 0
        Me.PassSave_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PassSave_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassSave_btn.ForeColor = System.Drawing.Color.Honeydew
        Me.PassSave_btn.Location = New System.Drawing.Point(597, 371)
        Me.PassSave_btn.Name = "PassSave_btn"
        Me.PassSave_btn.Size = New System.Drawing.Size(76, 30)
        Me.PassSave_btn.TabIndex = 40
        Me.PassSave_btn.Text = "Save"
        Me.PassSave_btn.UseVisualStyleBackColor = False
        '
        'NewPass_tb
        '
        Me.NewPass_tb.Location = New System.Drawing.Point(68, 371)
        Me.NewPass_tb.Name = "NewPass_tb"
        Me.NewPass_tb.Size = New System.Drawing.Size(261, 20)
        Me.NewPass_tb.TabIndex = 39
        '
        'ConnfirmPass_tb
        '
        Me.ConnfirmPass_tb.Location = New System.Drawing.Point(412, 312)
        Me.ConnfirmPass_tb.Name = "ConnfirmPass_tb"
        Me.ConnfirmPass_tb.Size = New System.Drawing.Size(261, 20)
        Me.ConnfirmPass_tb.TabIndex = 38
        '
        'OldPass_tb
        '
        Me.OldPass_tb.Location = New System.Drawing.Point(68, 312)
        Me.OldPass_tb.Name = "OldPass_tb"
        Me.OldPass_tb.Size = New System.Drawing.Size(261, 20)
        Me.OldPass_tb.TabIndex = 37
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(409, 284)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(125, 17)
        Me.label8.TabIndex = 36
        Me.label8.Text = "Confirm Password :"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(68, 343)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(104, 17)
        Me.label7.TabIndex = 35
        Me.label7.Text = "New Password :"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(68, 284)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(98, 17)
        Me.label6.TabIndex = 34
        Me.label6.Text = "Old Password :"
        '
        'Address_tb
        '
        Me.Address_tb.Location = New System.Drawing.Point(68, 221)
        Me.Address_tb.Name = "Address_tb"
        Me.Address_tb.Size = New System.Drawing.Size(605, 20)
        Me.Address_tb.TabIndex = 33
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(68, 193)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(64, 17)
        Me.label13.TabIndex = 32
        Me.label13.Text = "Address :"
        '
        'ContactName_tb
        '
        Me.ContactName_tb.Location = New System.Drawing.Point(412, 162)
        Me.ContactName_tb.Name = "ContactName_tb"
        Me.ContactName_tb.Size = New System.Drawing.Size(261, 20)
        Me.ContactName_tb.TabIndex = 31
        '
        'LastName_tb
        '
        Me.LastName_tb.Location = New System.Drawing.Point(412, 103)
        Me.LastName_tb.Name = "LastName_tb"
        Me.LastName_tb.Size = New System.Drawing.Size(261, 20)
        Me.LastName_tb.TabIndex = 30
        '
        'EmailAdress_tb
        '
        Me.EmailAdress_tb.Location = New System.Drawing.Point(68, 162)
        Me.EmailAdress_tb.Name = "EmailAdress_tb"
        Me.EmailAdress_tb.Size = New System.Drawing.Size(261, 20)
        Me.EmailAdress_tb.TabIndex = 29
        '
        'FirstName_tb
        '
        Me.FirstName_tb.Location = New System.Drawing.Point(68, 103)
        Me.FirstName_tb.Name = "FirstName_tb"
        Me.FirstName_tb.Size = New System.Drawing.Size(261, 20)
        Me.FirstName_tb.TabIndex = 28
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(409, 75)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(81, 17)
        Me.label12.TabIndex = 27
        Me.label12.Text = "Last  name :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(68, 134)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 17)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Email Address :"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(409, 134)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(116, 17)
        Me.label11.TabIndex = 24
        Me.label11.Text = "Contact Number :"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(68, 75)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(79, 17)
        Me.label10.TabIndex = 22
        Me.label10.Text = "First name :"
        '
        'MyInfo_lb
        '
        Me.MyInfo_lb.AutoSize = True
        Me.MyInfo_lb.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyInfo_lb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.MyInfo_lb.Location = New System.Drawing.Point(34, 32)
        Me.MyInfo_lb.Name = "MyInfo_lb"
        Me.MyInfo_lb.Size = New System.Drawing.Size(195, 32)
        Me.MyInfo_lb.TabIndex = 21
        Me.MyInfo_lb.Text = "My Information"
        '
        'MyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(755, 485)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.PassSave_btn)
        Me.Controls.Add(Me.NewPass_tb)
        Me.Controls.Add(Me.ConnfirmPass_tb)
        Me.Controls.Add(Me.OldPass_tb)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.Address_tb)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.ContactName_tb)
        Me.Controls.Add(Me.LastName_tb)
        Me.Controls.Add(Me.EmailAdress_tb)
        Me.Controls.Add(Me.FirstName_tb)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.MyInfo_lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MyInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label9 As Label
    Private WithEvents PassSave_btn As Button
    Private WithEvents NewPass_tb As TextBox
    Private WithEvents ConnfirmPass_tb As TextBox
    Private WithEvents OldPass_tb As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents Address_tb As TextBox
    Private WithEvents label13 As Label
    Private WithEvents ContactName_tb As TextBox
    Private WithEvents LastName_tb As TextBox
    Private WithEvents EmailAdress_tb As TextBox
    Private WithEvents FirstName_tb As TextBox
    Private WithEvents label12 As Label
    Private WithEvents label3 As Label
    Private WithEvents label11 As Label
    Private WithEvents label10 As Label
    Private WithEvents MyInfo_lb As Label
End Class
