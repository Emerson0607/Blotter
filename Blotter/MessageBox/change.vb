Public Class change
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Hide()
        Dim MainForm As New login
        MainForm.ShowDialog()
    End Sub

    Private Sub change_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class