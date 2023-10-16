Public Class Print_Section
    Private Sub btnOnline_Click(sender As Object, e As EventArgs) Handles btnOnline.Click
        Me.Hide()
        Online_Form.Show()
    End Sub

    Private Sub btnOffline_Click(sender As Object, e As EventArgs) Handles btnOffline.Click
        Me.Hide()
        Page_SetUp.Show()
    End Sub

    Private Sub Homebtn_Click(sender As Object, e As EventArgs) Handles Homebtn.Click
        Me.Hide()
        start_up.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Action_Option.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Page_SetUp.Show()
    End Sub
End Class