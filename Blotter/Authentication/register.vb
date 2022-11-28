Public Class register
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Dispose()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If String.IsNullOrWhiteSpace(tbOldPassword.Text) Or String.IsNullOrWhiteSpace(tbNewPassword.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else

            reloadData("SELECT * FROM users WHERE password = '" & tbOldPassword.Text & "'")
            If dt.Rows.Count = 0 Then
                tbOldPassword.BorderColor = Color.Tomato
                wrong.Text = "Wrong Old Password!"
                MessageBox.Show("Wrong Old Password", "failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Try
                    updates("UPDATE users SET password = '" & tbNewPassword.Text & "' WHERE password = '" & tbOldPassword.Text & "'")
                    MessageBox.Show("New Password Created!")
                    Dim MainForm As New login
                    MainForm.Show()
                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                Finally

                End Try
            End If

        End If
    End Sub

    'Private Sub tbOldPassword_TextChanged(sender As Object, e As EventArgs) Handles tbOldPassword.TextChanged
    '    tbOldPassword.BorderColor = Color.DodgerBlue
    '    wrong.Text = ""
    'End Sub

    Private Sub wrong_Click(sender As Object, e As EventArgs) Handles wrong.Click

    End Sub


End Class