Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Admin

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        Me.Hide()
        Admin_Board.Show()
    End Sub
    Private Sub Show_btn_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If Password_tb.UseSystemPasswordChar = True Then
            btnHide.BringToFront()
            Password_tb.UseSystemPasswordChar = False
        End If

    End Sub
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        If Password_tb.UseSystemPasswordChar = False Then
            btnShow.BringToFront()
            Password_tb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Username_tb_Enter(sender As Object, e As EventArgs) Handles Username_tb.Enter
        If Username_tb.Text = "USERNAME" Then
            Username_tb.Text = ""
            Username_tb.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Username_tb_Leave(sender As Object, e As EventArgs) Handles Username_tb.Leave
        If Username_tb.Text = "" Then
            Username_tb.Text = "USERNAME"
            Username_tb.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Password_tb_Enter(sender As Object, e As EventArgs) Handles Password_tb.Enter
        If Password_tb.Text = "PASSWORD" Then
            Password_tb.Text = ""
            Password_tb.ForeColor = Color.Black
            Password_tb.UseSystemPasswordChar = True
            btnShow.BringToFront()
        End If

    End Sub

    Private Sub Password_tb_Leave(sender As Object, e As EventArgs) Handles Password_tb.Leave
        If Password_tb.Text = "" Then
            Password_tb.Text = "PASSWORD"
            Password_tb.ForeColor = Color.Silver
        End If
    End Sub

End Class