<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Login_vb_20191216.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="パスワード"></asp:Label>
            <asp:TextBox ID="TextBoxPassWord" runat="server"></asp:TextBox>
        </div>
        
        <asp:Button ID="Button1" runat="server" Text="Button" />
        
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
        
    </form>

</body>
</html>
