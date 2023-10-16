Public Class Admin_Board
    Private Sub MyInfo_btn_Click(sender As Object, e As EventArgs) Handles MyInfo_btn.Click
        PnlNav.Height = MyInfo_btn.Height
        PnlNav.Top = MyInfo_btn.Top
        PnlNav.Left = MyInfo_btn.Left
        MyInfo_btn.BackColor = Color.FromArgb(240, 255, 240)
        MyInfo_btn.ForeColor = Color.FromArgb(69, 181, 214)
        Dim MyInfo As MyInfo = New MyInfo()
        MyInfo.TopLevel = False
        Content_pnl.Controls.Add(MyInfo)
        MyInfo.BringToFront()
        MyInfo.Show()
    End Sub

    Private Sub MyInfo_btn_Leave(sender As Object, e As EventArgs) Handles MyInfo_btn.Leave
        MyInfo_btn.BackColor = Color.FromArgb(47, 79, 79)
        MyInfo_btn.ForeColor = Color.FromArgb(240, 255, 240)
    End Sub

    Private Sub CusTran_btn_Click(sender As Object, e As EventArgs) Handles CusTran_btn.Click
        PnlNav.Height = CusTran_btn.Height
        PnlNav.Top = CusTran_btn.Top
        PnlNav.Left = CusTran_btn.Left
        CusTran_btn.BackColor = Color.FromArgb(240, 255, 240)
        CusTran_btn.ForeColor = Color.FromArgb(69, 181, 214)
        Dim Customer_Transaction As Customer_Transaction = New Customer_Transaction()
        Customer_Transaction.TopLevel = False
        Content_pnl.Controls.Add(Customer_Transaction)
        Customer_Transaction.BringToFront()
        Customer_Transaction.Show()
    End Sub

    Private Sub CusTran_btn_Leave(sender As Object, e As EventArgs) Handles CusTran_btn.Leave
        CusTran_btn.BackColor = Color.FromArgb(47, 79, 79)
        CusTran_btn.ForeColor = Color.FromArgb(240, 255, 240)
    End Sub

    Private Sub SalesRep_btn_Click(sender As Object, e As EventArgs) Handles SalesRep_btn.Click
        PnlNav.Height = SalesRep_btn.Height
        PnlNav.Top = SalesRep_btn.Top
        PnlNav.Left = SalesRep_btn.Left
        SalesRep_btn.BackColor = Color.FromArgb(240, 255, 240)
        SalesRep_btn.ForeColor = Color.FromArgb(69, 181, 214)
        Dim Sales_Report As Sales_Report = New Sales_Report()
        Sales_Report.TopLevel = False
        Content_pnl.Controls.Add(Sales_Report)
        Sales_Report.BringToFront()
        Sales_Report.Show()
    End Sub

    Private Sub SalesRep_btn_Leave(sender As Object, e As EventArgs) Handles SalesRep_btn.Leave
        SalesRep_btn.BackColor = Color.FromArgb(47, 79, 79)
        SalesRep_btn.ForeColor = Color.FromArgb(240, 255, 240)
    End Sub

    Private Sub Reset_btn_Click(sender As Object, e As EventArgs) Handles Reset_btn.Click
        PnlNav.Height = SalesRep_btn.Height
        PnlNav.Top = SalesRep_btn.Top
        PnlNav.Left = SalesRep_btn.Left
        Reset_btn.ForeColor = Color.FromArgb(69, 181, 214)
        Dim Admin_Form = New Admin_Form()
        Admin_Form.TopLevel = False
        Content_pnl.Controls.Add(Admin_Form)
        Admin_Form.BringToFront()
        Admin_Form.Show()

    End Sub

    Private Sub LogOut_btn_Click(sender As Object, e As EventArgs) Handles LogOut_btn.Click
        Me.Hide()
        start_up.Show()
    End Sub

    Private Sub Reset_btn_Leave(sender As Object, e As EventArgs) Handles Reset_btn.Leave
        Reset_btn.ForeColor = Color.FromArgb(240, 255, 240)
    End Sub
End Class