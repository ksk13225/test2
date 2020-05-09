Imports System.Data.SqlClient
Imports System.Configuration

Public Class DBconnnect
    Inherits System.Web.UI.Page

    '信用銘柄一覧
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GridView1.DataBind()
        DataBind()
        SqlDataSource2.DataBind()
    End Sub

    ''信用銘柄と株主優待を結合（12月）もっとある
    'Protected Sub Serchbtn_Click(sender As Object, e As EventArgs)
    '    Try
    '        Using con As New SqlConnection
    '            Dim settings As ConnectionStringSettings
    '            Dim strSQL As String = 0
    '            'Dim sb As New System.Text.StringBuilder()
    '            settings = ConfigurationManager.ConnectionStrings("connect")
    '            con.ConnectionString = settings.ConnectionString
    '            con.Open()
    '            ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_12 Y12 on CB.CODE = convert(int,LEFT(Y12.コード_名称,4))"
    '            SqlDataSource2.SelectCommand = ViewState(strSQL)
    '            con.Close()
    '            con.Dispose()

    '        End Using

    '    Catch ex As Exception

    '    End Try
    'End Sub


    '信用銘柄と株主優待を結合（01月）
    Protected Sub Serchbtn1_Click(sender As Object, e As EventArgs) Handles Serchbtn1.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_01 Y01 on CB.CODE = convert(int,LEFT(Y01.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    '2月
    Protected Sub Serchbtn2_Click(sender As Object, e As EventArgs) Handles Serchbtn2.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_02 Y02 on CB.CODE = convert(int,LEFT(Y02.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub




    Protected Sub Serchbtn_Click(sender As Object, e As EventArgs) Handles Serchbtn.Click
        Try

            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                strSQL = "select * from Table_CREDIT_BRAND"
                SqlDataSource2.SelectCommand = strSQL
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        GridView1.DataBind()
    End Sub

    Protected Sub Serchbtn3_Click(sender As Object, e As EventArgs) Handles Serchbtn3.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_03 Y03 on CB.CODE = convert(int,LEFT(Y03.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn4_Click(sender As Object, e As EventArgs) Handles Serchbtn4.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_04 Y04 on CB.CODE = convert(int,LEFT(Y04.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn5_Click(sender As Object, e As EventArgs) Handles Serchbtn5.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_05 Y05 on CB.CODE = convert(int,LEFT(Y05.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn6_Click(sender As Object, e As EventArgs) Handles Serchbtn6.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_06 Y06 on CB.CODE = convert(int,LEFT(Y06.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn7_Click(sender As Object, e As EventArgs) Handles Serchbtn7.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_07 Y07 on CB.CODE = convert(int,LEFT(Y07.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn8_Click(sender As Object, e As EventArgs) Handles Serchbtn8.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_08 Y08 on CB.CODE = convert(int,LEFT(Y08.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn9_Click(sender As Object, e As EventArgs) Handles Serchbtn9.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_09 Y09 on CB.CODE = convert(int,LEFT(Y09.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn10_Click(sender As Object, e As EventArgs) Handles Serchbtn10.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_10 Y10 on CB.CODE = convert(int,LEFT(Y10.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn11_Click(sender As Object, e As EventArgs) Handles Serchbtn11.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_11 Y11 on CB.CODE = convert(int,LEFT(Y11.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Serchbtn12_Click(sender As Object, e As EventArgs) Handles Serchbtn12.Click
        Try
            Using con As New SqlConnection
                Dim settings As ConnectionStringSettings
                Dim strSQL As String = 0
                'Dim sb As New System.Text.StringBuilder()
                settings = ConfigurationManager.ConnectionStrings("connect")
                con.ConnectionString = settings.ConnectionString
                con.Open()
                ViewState(strSQL) = "select * from Table_CREDIT_BRAND CB inner join Table_Scraiping_Yutai_12 Y12 on CB.CODE = convert(int,LEFT(Y12.コード_名称,4))"
                SqlDataSource2.SelectCommand = ViewState(strSQL)
                con.Close()
                con.Dispose()

            End Using

        Catch ex As Exception

        End Try
    End Sub
End Class