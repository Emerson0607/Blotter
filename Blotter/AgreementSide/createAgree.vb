Imports MySql.Data.MySqlClient
Public Class createAgree
    Dim dbConn As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim MainForm As New agreementMenu
        MainForm.ShowDialog()
    End Sub

    Private Sub createAgree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbConn = New MySqlConnection
        dbConn.ConnectionString = "server=localhost;user id=root;port=3306;database=blotter;Persist Security Info=True;Convert Zero Datetime=True "

        Try
            dbConn.Open()
            Dim sql1 = String.Format("Select incidentBlotter.id from incidentBlotter where id > 0")


            adapter = New MySqlDataAdapter(sql1, dbConn)

            ds = New DataSet

            adapter.Fill(ds, "incidentBlotter")
            adapter.Dispose()

            If ds.Tables("incidentBlotter").Rows.Count > 0 Then
                Me.id.Items.Clear()
                Dim i As Integer
                For i = 0 To ds.Tables("incidentBlotter").Rows.Count - 1
                    With Me.id
                        .Items.Add(ds.Tables("incidentBlotter").Rows(i).Item("id"))
                    End With
                Next
            Else
                MessageBox.Show("No data")
            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        Finally
            dbConn.Close()
        End Try
        Me.Refresh()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(id.Text) Or String.IsNullOrWhiteSpace(tbDate.Value.Date.ToString("yyyy/MM/dd")) Or String.IsNullOrWhiteSpace(tbLocation.Text) Or String.IsNullOrWhiteSpace(tbOffice.Text) _
         Or String.IsNullOrWhiteSpace(tbCname.Text) Or String.IsNullOrWhiteSpace(tbVname.Text) Or String.IsNullOrWhiteSpace(tbSname.Text) Or String.IsNullOrWhiteSpace(tbWname.Text) Then


            MessageBox.Show("Enter complete data first!")

        Else
            Try
                create("INSERT INTO agreement (`id`, `agreementDate`, `agreementLocation`, `officeName`, `complainant`, `victim`, `suspect`, `witness`, `agreement`) VALUES('" & id.Text _
                  & "','" & tbDate.Value.Date.ToString("yyyy/MM/dd") & "','" & tbLocation.Text & "', '" & tbOffice.Text & "', '" & tbCname.Text & "', '" & tbVname.Text & "', '" & tbSname.Text & "',  '" & tbWname.Text & "', '" & tbAgreement.Text & "')")

                'MessageBox.Show("Completed! New Agreement Recorded")
                'Me.Hide()
                'agreementMenu.Show()
                Dim MainForm As New agreeAdded
                MainForm.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Error, you must complete details" & ex.Message.ToString)

            End Try
        End If
    End Sub

    Private Sub id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id.SelectedIndexChanged
        dbConn = New MySqlConnection
        dbConn.ConnectionString = "server=localhost;user id=root;port=3306;database=blotter ;Persist Security Info=True;Convert Zero Datetime=True"

        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand

        Try
            dbConn.Open()
            Dim query As String
            query = "Select fullname from complainantBlotter where id = '" & id.SelectedItem & "'"

            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read
                'read database and pass the values from field into text box
                tbCname.Text = READER.GetString("fullname")
            End While
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            dbConn.Open()
            Dim query As String
            query = "Select fullname from victimBlotter where id = '" & id.SelectedItem & "'"

            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read
                'read database and pass the values from field into text box
                tbVname.Text = READER.GetString("fullname")
            End While
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            dbConn.Open()
            Dim query As String
            query = "Select fullname from suspectBlotter where id = '" & id.SelectedItem & "'"

            Command = New MySqlCommand(query, dbConn)
            READER = Command.ExecuteReader
            While READER.Read
                'read database and pass the values from field into text box
                tbSname.Text = READER.GetString("fullname")
            End While
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class