Public Class exitMessage
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Hide()
        Dim MainForm As New login
        MainForm.ShowDialog()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Dispose()
    End Sub

    Private Sub exitMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class