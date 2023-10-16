<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Report
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
        Me.CustomerOs_tbl = New System.Windows.Forms.TableLayoutPanel()
        Me.Amount_lb = New System.Windows.Forms.Label()
        Me.OrderID_lb = New System.Windows.Forms.Label()
        Me.SystemE_lb = New System.Windows.Forms.Label()
        Me.Date_lb = New System.Windows.Forms.Label()
        Me.Transactions_lb = New System.Windows.Forms.Label()
        Me.Search_btn = New System.Windows.Forms.Button()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SearchH_lb = New System.Windows.Forms.Label()
        Me.CusTran_lb = New System.Windows.Forms.Label()
        Me.total_tbl = New System.Windows.Forms.TableLayoutPanel()
        Me.TSFD_lb = New System.Windows.Forms.Label()
        Me.CustomerOs_tbl.SuspendLayout()
        Me.total_tbl.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerOs_tbl
        '
        Me.CustomerOs_tbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerOs_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.CustomerOs_tbl.ColumnCount = 4
        Me.CustomerOs_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CustomerOs_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CustomerOs_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CustomerOs_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CustomerOs_tbl.Controls.Add(Me.Amount_lb, 3, 0)
        Me.CustomerOs_tbl.Controls.Add(Me.OrderID_lb, 1, 0)
        Me.CustomerOs_tbl.Controls.Add(Me.SystemE_lb, 2, 0)
        Me.CustomerOs_tbl.Controls.Add(Me.Date_lb, 0, 0)
        Me.CustomerOs_tbl.Location = New System.Drawing.Point(71, 178)
        Me.CustomerOs_tbl.Name = "CustomerOs_tbl"
        Me.CustomerOs_tbl.RowCount = 2
        Me.CustomerOs_tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.93801!))
        Me.CustomerOs_tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.062!))
        Me.CustomerOs_tbl.Size = New System.Drawing.Size(641, 232)
        Me.CustomerOs_tbl.TabIndex = 21
        '
        'Amount_lb
        '
        Me.Amount_lb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Amount_lb.AutoSize = True
        Me.Amount_lb.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_lb.ForeColor = System.Drawing.Color.Black
        Me.Amount_lb.Location = New System.Drawing.Point(484, 1)
        Me.Amount_lb.Name = "Amount_lb"
        Me.Amount_lb.Size = New System.Drawing.Size(153, 29)
        Me.Amount_lb.TabIndex = 3
        Me.Amount_lb.Text = "Amount"
        Me.Amount_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderID_lb
        '
        Me.OrderID_lb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderID_lb.AutoSize = True
        Me.OrderID_lb.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderID_lb.ForeColor = System.Drawing.Color.Black
        Me.OrderID_lb.Location = New System.Drawing.Point(164, 1)
        Me.OrderID_lb.Name = "OrderID_lb"
        Me.OrderID_lb.Size = New System.Drawing.Size(153, 29)
        Me.OrderID_lb.TabIndex = 0
        Me.OrderID_lb.Text = "Order ID"
        Me.OrderID_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SystemE_lb
        '
        Me.SystemE_lb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SystemE_lb.AutoSize = True
        Me.SystemE_lb.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemE_lb.ForeColor = System.Drawing.Color.Black
        Me.SystemE_lb.Location = New System.Drawing.Point(324, 1)
        Me.SystemE_lb.Name = "SystemE_lb"
        Me.SystemE_lb.Size = New System.Drawing.Size(153, 29)
        Me.SystemE_lb.TabIndex = 1
        Me.SystemE_lb.Text = "System Error"
        Me.SystemE_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Date_lb
        '
        Me.Date_lb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_lb.AutoSize = True
        Me.Date_lb.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_lb.ForeColor = System.Drawing.Color.Black
        Me.Date_lb.Location = New System.Drawing.Point(4, 1)
        Me.Date_lb.Name = "Date_lb"
        Me.Date_lb.Size = New System.Drawing.Size(153, 29)
        Me.Date_lb.TabIndex = 4
        Me.Date_lb.Text = "Date"
        Me.Date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Transactions_lb
        '
        Me.Transactions_lb.AutoSize = True
        Me.Transactions_lb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transactions_lb.ForeColor = System.Drawing.Color.Black
        Me.Transactions_lb.Location = New System.Drawing.Point(67, 147)
        Me.Transactions_lb.Name = "Transactions_lb"
        Me.Transactions_lb.Size = New System.Drawing.Size(113, 21)
        Me.Transactions_lb.TabIndex = 20
        Me.Transactions_lb.Text = "Transactions :"
        '
        'Search_btn
        '
        Me.Search_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Search_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_btn.ForeColor = System.Drawing.Color.White
        Me.Search_btn.Location = New System.Drawing.Point(300, 115)
        Me.Search_btn.Name = "Search_btn"
        Me.Search_btn.Size = New System.Drawing.Size(72, 22)
        Me.Search_btn.TabIndex = 19
        Me.Search_btn.Text = "SEARCH"
        Me.Search_btn.UseVisualStyleBackColor = False
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePicker1.Location = New System.Drawing.Point(71, 115)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(223, 22)
        Me.dateTimePicker1.TabIndex = 18
        '
        'SearchH_lb
        '
        Me.SearchH_lb.AutoSize = True
        Me.SearchH_lb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchH_lb.ForeColor = System.Drawing.Color.Black
        Me.SearchH_lb.Location = New System.Drawing.Point(67, 84)
        Me.SearchH_lb.Name = "SearchH_lb"
        Me.SearchH_lb.Size = New System.Drawing.Size(169, 21)
        Me.SearchH_lb.TabIndex = 17
        Me.SearchH_lb.Text = "Search Date History :"
        '
        'CusTran_lb
        '
        Me.CusTran_lb.AutoSize = True
        Me.CusTran_lb.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusTran_lb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.CusTran_lb.Location = New System.Drawing.Point(34, 42)
        Me.CusTran_lb.Name = "CusTran_lb"
        Me.CusTran_lb.Size = New System.Drawing.Size(156, 32)
        Me.CusTran_lb.TabIndex = 16
        Me.CusTran_lb.Text = "Sales Report"
        '
        'total_tbl
        '
        Me.total_tbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.total_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.total_tbl.ColumnCount = 3
        Me.total_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.69512!))
        Me.total_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.30488!))
        Me.total_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318.0!))
        Me.total_tbl.Controls.Add(Me.TSFD_lb, 0, 0)
        Me.total_tbl.Location = New System.Drawing.Point(71, 414)
        Me.total_tbl.Name = "total_tbl"
        Me.total_tbl.RowCount = 1
        Me.total_tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.total_tbl.Size = New System.Drawing.Size(641, 49)
        Me.total_tbl.TabIndex = 22
        '
        'TSFD_lb
        '
        Me.TSFD_lb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSFD_lb.AutoSize = True
        Me.TSFD_lb.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFD_lb.ForeColor = System.Drawing.Color.Black
        Me.TSFD_lb.Location = New System.Drawing.Point(4, 1)
        Me.TSFD_lb.Name = "TSFD_lb"
        Me.TSFD_lb.Size = New System.Drawing.Size(152, 47)
        Me.TSFD_lb.TabIndex = 5
        Me.TSFD_lb.Text = "  Total Sales :  "
        Me.TSFD_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sales_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(755, 485)
        Me.Controls.Add(Me.CustomerOs_tbl)
        Me.Controls.Add(Me.Transactions_lb)
        Me.Controls.Add(Me.Search_btn)
        Me.Controls.Add(Me.dateTimePicker1)
        Me.Controls.Add(Me.SearchH_lb)
        Me.Controls.Add(Me.CusTran_lb)
        Me.Controls.Add(Me.total_tbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sales_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales_Report"
        Me.CustomerOs_tbl.ResumeLayout(False)
        Me.CustomerOs_tbl.PerformLayout()
        Me.total_tbl.ResumeLayout(False)
        Me.total_tbl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents CustomerOs_tbl As TableLayoutPanel
    Private WithEvents Amount_lb As Label
    Private WithEvents OrderID_lb As Label
    Private WithEvents SystemE_lb As Label
    Private WithEvents Date_lb As Label
    Private WithEvents Transactions_lb As Label
    Private WithEvents Search_btn As Button
    Private WithEvents dateTimePicker1 As DateTimePicker
    Private WithEvents SearchH_lb As Label
    Private WithEvents CusTran_lb As Label
    Private WithEvents total_tbl As TableLayoutPanel
    Private WithEvents TSFD_lb As Label
End Class
