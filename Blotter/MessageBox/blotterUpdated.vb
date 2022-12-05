Public Class blotterUpdated
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Panel1_Click(sender As Object, e As EventArgs) Handles Guna2Panel1.Click
        Me.Hide()
        Dim MainForm As New blotterMenu
        MainForm.ShowDialog()
    End Sub
End Class