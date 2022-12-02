Public Class viewBlotter


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim MainForm As New blotterMenu
        MainForm.ShowDialog()
    End Sub
End Class