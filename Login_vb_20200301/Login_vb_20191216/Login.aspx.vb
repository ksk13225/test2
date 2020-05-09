Imports System.Data.SqlClient
Imports System.Configuration

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()

                'strSQL = "select * from Table_LOGIN"
                strSQL = "SELECT * FROM Table_LOGIN WHERE ID = '" & TextBoxID.Text & "' AND PASSWORD = '" & TextBoxPassWord.Text & "'"
                Dim cmd As New SqlCommand(strSQL, con)

                Dim dr As SqlDataReader = cmd.ExecuteReader()

                'While dr.Read()
                '    Return
                'End While

                'If dr.FieldCount = 0 Then
                '    Return
                'End If
                If dr.HasRows = True Then
                    Response.Redirect("~/Menu.aspx")
                Else
                    Label1.Text = "正しいIDとパスワードを入力してください"
                End If



                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub
End Class