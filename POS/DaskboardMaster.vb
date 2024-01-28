Imports System.Web.UI.WebControls

Public Class DaskboardMaster
    Sub swicthform(ByVal panel As Form)
        Login.Hide()
        display.Controls.Clear()
        panel.TopLevel = False
        display.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btn_Daskboard_Click(sender As Object, e As EventArgs) Handles btn_Daskboard.Click
        swicthform(Finbound)
    End Sub

    Private Sub btnMProduct_Click(sender As Object, e As EventArgs) Handles btnMProduct.Click
        swicthform(ProductMG)
    End Sub
End Class