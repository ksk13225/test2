<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DBconnnect.aspx.vb" Inherits="Login_vb_20191216.DBconnnect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script type="text/javascript">
 //       function AdjustGrid() {
	//var parent = document.getElementById("pnl");
	//var grid = document.getElementById("grid");
	//if(parent==null || grid==null) return;
 
	//一度親のパネルをグリッドが収まるように大きなサイズに変更
	//parent.style.width="3000px"; 
 
	//offsetWidthが画面に表示される幅 20はスクロールバーの幅
	//parent.style.width=(grid.offsetWidth +20)+ "px"; 
//}
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Serchbtn" OnClick="Serchbtn_Click" runat="server" Height="71px" Text="銘柄検索" Width="196px" />
        </div>
        <div>
            <asp:Button ID="Serchbtn1" OnClick="Serchbtn1_Click" runat="server" Height="71px" Text="1月" Width="196px" />
            <asp:Button ID="Serchbtn2" OnClick="Serchbtn2_Click" runat="server" Height="71px" Text="2月" Width="196px" />
            <asp:Button ID="Serchbtn3" OnClick="Serchbtn3_Click" runat="server" Height="71px" Text="3月" Width="196px" />
            <asp:Button ID="Serchbtn4" OnClick="Serchbtn4_Click" runat="server" Height="71px" Text="4月" Width="196px" />
            <asp:Button ID="Serchbtn5" OnClick="Serchbtn5_Click" runat="server" Height="71px" Text="5月" Width="196px" />
            <asp:Button ID="Serchbtn6" OnClick="Serchbtn6_Click" runat="server" Height="71px" Text="6月" Width="196px" />
        </div>
        <div>
            <asp:Button ID="Serchbtn7" OnClick="Serchbtn7_Click" runat="server" Height="71px" Text="7月" Width="196px" />
            <asp:Button ID="Serchbtn8" OnClick="Serchbtn8_Click" runat="server" Height="71px" Text="8月" Width="196px" />
            <asp:Button ID="Serchbtn9" OnClick="Serchbtn9_Click" runat="server" Height="71px" Text="9月" Width="196px" />
            <asp:Button ID="Serchbtn10" OnClick="Serchbtn10_Click" runat="server" Height="71px" Text="10月" Width="196px" />
            <asp:Button ID="Serchbtn11" OnClick="Serchbtn11_Click" runat="server" Height="71px" Text="11月" Width="196px" />
            <asp:Button ID="Serchbtn12" OnClick="Serchbtn12_Click" runat="server" Height="71px" Text="12月" Width="196px" />
        </div>
        <%--<asp:Panel ID="pnl" runat="Server" ScrollBars="Auto">--%>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" pagesize="20" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" Height="607px" Width="1641px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="CODE" HeaderText="CODE" SortExpression="CODE" />
                <asp:BoundField DataField="CODENAME" HeaderText="CODENAME" SortExpression="CODENAME" />
                <asp:BoundField DataField="TYPE" HeaderText="TYPE" SortExpression="TYPE" />
                <asp:BoundField DataField="FLG" HeaderText="FLG" SortExpression="FLG" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <%--</asp:Panel>--%>
        <%--<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT * FROM [Table_CREDIT_BRAND]"></asp:SqlDataSource>--%>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>"></asp:SqlDataSource>
        
        
    </form>
</body>
</html>
