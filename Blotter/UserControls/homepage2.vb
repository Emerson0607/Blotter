Public Class homepage2
    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles flatHome.Paint

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim MainForm As New exitMessage

        MainForm.ShowDialog()

    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click

        Me.Hide()
        Dim MainForm As New blotterMenu
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub
End Class