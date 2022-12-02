Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class agreementMenu
    Dim dbConn As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Me.Hide()
        'Dim MainForm As New CreateAgree
        'MainForm.ShowDialog()
        'Me.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(id.SelectedItem) Then
            MessageBox.Show("Select ID to delete!")
        Else

            delete("DELETE FROM agreement Where id = '" & id.SelectedItem & "'")
            MessageBox.Show("Deleted Successfully")
            Me.id.Items.Clear()

            reloadAgreement("SELECT id, agreementDate, complainant, victim, suspect, witness FROM agreement where id > 0 ORDER BY id;  ", dtg1)


        End If
    End Sub



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        selectedIDagree = id.SelectedItem
        'If String.IsNullOrWhiteSpace(selectedIDagree) Then
        '    MessageBox.Show("Select ID to edit!")
        'Else
        '    Me.Hide()
        '    Dim MainForm As New editAgree
        '    MainForm.ShowDialog()
        '    Me.Show()
        'End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        selectedIDagree = id.SelectedItem
        'If String.IsNullOrWhiteSpace(selectedIDagree) Then
        '    MessageBox.Show("Select ID to view!")
        'Else
        '    Me.Hide()
        '    Dim MainForm As New viewAgree
        '    MainForm.ShowDialog()
        '    Me.Show()
        'End If
    End Sub

    Private Sub id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id.SelectedIndexChanged
        reloadAgreement("SELECT  id, agreementDate, complainant, victim, suspect, witness FROM agreement where id > 0 ORDER BY id;  ", dtg1)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim MainForm As New home
        MainForm.ShowDialog()

    End Sub

    Private Sub agreementMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reloadAgreement("SELECT `id`, `agreementDate`, `complainant`, `victim`, `suspect`, `witness` from agreement", dtg1)

        Dim dbConn = New MySqlConnection
        dbConn.ConnectionString = "server=localhost;user id=root;port=3306;database=blotter;Persist Security Info=True;Convert Zero Datetime=True "

        Try
            dbConn.Open()
            Dim sql1 = String.Format("Select id from agreement where id > 0")

            adapter = New MySqlDataAdapter(sql1, dbConn)

            ds = New DataSet

            adapter.Fill(ds, "agreement")
            adapter.Dispose()

            If ds.Tables("agreement").Rows.Count > 0 Then
                Me.id.Items.Clear()
                Dim i As Integer
                For i = 0 To ds.Tables("agreement").Rows.Count - 1
                    With Me.id
                        .Items.Add(ds.Tables("agreement").Rows(i).Item("id"))
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


    Private Sub search_TextChanged_1(sender As Object, e As EventArgs) Handles search.TextChanged
        reloadAgreement("SELECT `id`, `agreementDate`, `complainant`, `victim`, `suspect`, `witness` from agreement where id LIKE '%" & search.Text _
                        & "%' Or  agreementDate LIKE '%" & search.Text & "%' Or complainant LIKE '%" & search.Text _
                        & "%' Or  victim LIKE '%" & search.Text & "%' Or suspect LIKE '%" & search.Text & "%'  Or witness LIKE '%" & search.Text & "%'", dtg1)

    End Sub

    Private Sub flatHome_Paint(sender As Object, e As PaintEventArgs) Handles flatHome.Paint

    End Sub
End Class