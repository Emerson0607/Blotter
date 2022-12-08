Imports MySql.Data.MySqlClient
Public Class login
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
                    tbUsername.BorderColor = System.Drawing.Color.Tomato
                    tbPassword.BorderColor = System.Drawing.Color.Tomato
                    MessageBox.Show("Invalid Username / Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim MainForm As New ok
                    MainForm.Show()
                    tbUsername.BorderColor = System.Drawing.Color.DodgerBlue
                    tbPassword.BorderColor = System.Drawing.Color.DodgerBlue
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

    Public Sub closeAll()
        For Each aForm As Form In Me.MdiChildren
            aForm.Close()
        Next
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Dim MainForm As New register
        MainForm.ShowDialog()
        Me.Show()
    End Sub
    Private Sub tbUsername_Click(sender As Object, e As EventArgs) Handles tbUsername.Click
        tbUsername.BorderColor = System.Drawing.Color.DodgerBlue
    End Sub
    Private Sub tbPassword_Click(sender As Object, e As EventArgs) Handles tbPassword.Click
        tbPassword.BorderColor = System.Drawing.Color.DodgerBlue
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closeAll()
    End Sub
End Class
