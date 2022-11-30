Public Class ok
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Hide()
        Dim MainForm As New homepage2
        MainForm.ShowDialog()
        Me.Show()
    End Sub
End Class