Imports MySql.Data.MySqlClient
Public Class login


    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Dispose()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(tbPassword.Text) Or String.IsNullOrWhiteSpace(tbUsername.Text) Then
            MessageBox.Show("Enter complete data first!")
        Else
            strcon.Open()

            Try
                cmd.Connection = strcon
                cmd.CommandText = "SELECT * FROM users WHERE username = @user and password = @pass;"

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = tbUsername.Text
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPassword.Text
                da.SelectCommand = cmd
                da.Fill(dt)
                strcon.Close()
                da.Dispose()

                If dt.Rows.Count = 0 Then
                    tbUsername.BorderColor = Color.Tomato
                    tbPassword.BorderColor = Color.Tomato
                    MessageBox.Show("Invalid Username / Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'tbUsername.Text = ""
                    'tbPassword.Text = ""

                Else
                    Dim MainForm As New ok
                    MainForm.Show()

                    'MessageBox.Show("Login Success", "Welcome to SAN ISIDRO BLOTTER SYSTEM!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tbUsername.Clear()
                    tbPassword.Clear()


                    '//it shows the parent form also

                    'Me.Hide()
                    'Dim MainForm As New MenuPage
                    'MainForm.ShowDialog()
                    'Me.Show()

                End If

            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message.ToString)
            Finally
                cmd.Parameters.Clear()
            End Try
        End If
    End Sub



    'Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged
    '    tbUsername.BorderColor = Color.DodgerBlue
    'End Sub

    'Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
    '    tbPassword.BorderColor = Color.DodgerBlue
    'End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Dim MainForm As New register
        MainForm.ShowDialog()
        Me.Show()

    End Sub

    Private Sub tbUsername_Click(sender As Object, e As EventArgs) Handles tbUsername.Click

    End Sub
End Class
