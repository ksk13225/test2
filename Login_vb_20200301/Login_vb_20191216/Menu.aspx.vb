Public Class Menu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub YutaiButton_Click(sender As Object, e As EventArgs) Handles YutaiButton.Click
        Response.Redirect("~/DBconnnect.aspx")
    End Sub
End Class