Public Class ok
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Hide()
        Dim MainForm As New home
        MainForm.ShowDialog()

    End Sub
End Class