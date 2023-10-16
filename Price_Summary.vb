Public Class Price_Summary
    Private Sub Homebtn_Click(sender As Object, e As EventArgs) Handles Homebtn.Click
        Me.Hide()
        start_up.Show()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Page_SetUp.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Payment_Counter.Show()
    End Sub
End Class