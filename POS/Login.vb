Public Class Login
    Dim dt As New DataTable
    Dim sqlQuery As String
    Private Sub btnclose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Sub checkUser()

        sqlQuery = "SELECT * from pwmaster WHERE P1NM='" & txtUser.Text.ToUpper & "' AND P1PW='" & txtPW.Text.ToUpper & "'"
        dt = ExecuteSqlQuery(sqlQuery)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        checkUser()
        If dt.Rows.Count <> 0 Then
            DaskboardMaster.ShowDialog()
        Else
            MessageBox.Show("Input Not Correct")
            'Try
            '    sqlQuery = "INSERT INTO pwmaster(P1NM,P1PW,P1LV) VALUES ('" & txtUser.Text.ToUpper & "', '" & txtPW.Text.ToUpper & "')"
            '    ExecuteSqlQuery(sqlQuery)
            '    MessageBox.Show("Successfully.")
            'Catch ex As Exception
            '    MessageBox.Show("Error executing SQL query: " & ex.Message)
            'End Try
        End If

    End Sub
End Class