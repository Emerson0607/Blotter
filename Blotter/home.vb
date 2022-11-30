Public Class home

    Sub switchPanel(ByVal panel As Form)
        homePanel.Controls.Clear()
        panel.TopLevel = False
        homePanel.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click

        Dim MainForm As New exitMessage

        MainForm.ShowDialog()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        switchPanel(homepage2)

    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(homepage2)
    End Sub


End Class