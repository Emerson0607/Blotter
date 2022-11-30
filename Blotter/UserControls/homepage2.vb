Public Class homepage2
    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles flatHome.Paint

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim MainForm As New exitMessage

        MainForm.ShowDialog()

    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click

        Me.Hide()
        Dim MainForm As New BlotterMenu
        MainForm.ShowDialog()
        Me.Show()
    End Sub
End Class