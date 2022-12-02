Public Class home


    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click

        Dim MainForm As New exitMessage

        MainForm.ShowDialog()

    End Sub



    Private Sub Guna2Shapes2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Dim MainForm As New exitMessage

        MainForm.ShowDialog()
    End Sub

    Private Sub btnBlotter_Click_1(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Me.Hide()
        Dim MainForm As New blotterMenu
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Dim MainForm As New agreementMenu
        MainForm.ShowDialog()
        Me.Show()
    End Sub
End Class