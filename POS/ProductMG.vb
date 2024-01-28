Public Class ProductMG
    Dim sqlQuery As String
    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Private Sub btnPDList_Click(sender As Object, e As EventArgs) Handles btnPDList.Click
        Dim dt As New DataTable
        sqlQuery = " SELECT * FROM pdmaster"
        dt = ExecuteSqlQuery(sqlQuery)
        DataGridView1.DataSource = dt
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim sqlQuery As String = "INSERT INTO pdmaster(P1PTNO, P1PTNM,P1GROUP,P1UOM,P1LOCA) VALUES ('" & txtPTNO.Text.ToUpper & "', '" & txtPTNM.Text.ToUpper & "','" & txtGROUP.Text.ToUpper & "','" & txtUOM.Text.ToUpper & "','" & txtLOCA.Text.ToUpper & "')"
        ExecuteSqlQuery(sqlQuery)
    End Sub

    Private Sub btn_MGProduct_Click(sender As Object, e As EventArgs)

    End Sub
End Class