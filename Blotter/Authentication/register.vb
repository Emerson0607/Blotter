Public Class register

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If String.IsNullOrWhiteSpace(tbOldPassword.Text) Or String.IsNullOrWhiteSpace(tbNewPassword.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else

            reloadData("SELECT * FROM users WHERE password = '" & tbOldPassword.Text & "'")
            If dt.Rows.Count = 0 Then
                tbOldPassword.BorderColor = System.Drawing.Color.Tomato
                wrong.Text = "Wrong Old Password!"
            Else

                Try
                    updates("UPDATE users SET password = '" & tbNewPassword.Text & "' WHERE password = '" & tbOldPassword.Text & "'")
                    'Me.Hide()

                    'Dim MainForm As New change
                    'MainForm.Show()
                    Dim MainForm As New change
                    MainForm.Show()
                    tbOldPassword.BorderColor = System.Drawing.Color.DodgerBlue
                    wrong.Text = ""
                    tbNewPassword.Text = ""
                    tbOldPassword.Text = ""

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                Finally

                End Try
            End If

        End If
    End Sub


    Private Sub tbOldPassword_Click(sender As Object, e As EventArgs) Handles tbOldPassword.Click
        tbOldPassword.BorderColor = System.Drawing.Color.DodgerBlue

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class