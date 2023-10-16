Public Class Action_Option
    Private Sub Homebtn_Click(sender As Object, e As EventArgs) Handles Homebtn.Click
        Me.Hide()
        start_up.Show()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        start_up.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Print_Section.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Me.Hide()
        Print_Section.Show()
    End Sub
End Class