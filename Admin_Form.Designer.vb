<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Form))
        Me.Logo_pb = New System.Windows.Forms.PictureBox()
        CType(Me.Logo_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Admin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(755, 485)
        Me.Controls.Add(Me.Logo_pb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Form"
        CType(Me.Logo_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Logo_pb As PictureBox
End Class
