Public Class home
    Private Sub btnBlotter_Click_1(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Me.Hide()
        Dim MainForm As New blotterMenu
        MainForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        'Dim MainForm As New exitMessage
        'MainForm.ShowDialog()

        Dim msg As String = "Do you want to exit?"
        Dim title As String = "EXIT"
        Dim result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Me.Hide()

            Dim MainForm As New login
            MainForm.ShowDialog()

        End If
    End Sub

    Private Sub btnAgreement_Click(sender As Object, e As EventArgs) Handles btnAgreement.Click
        Me.Hide()
        Dim MainForm As New agreementMenu
        MainForm.ShowDialog()
        Me.Show()
    End Sub
End Class