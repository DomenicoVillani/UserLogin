<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="UserLogin.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ciao
            <br />
            <asp:Label ID="Show" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="BtnLogout" runat="server" Text="LogOut" OnClick="BtnLogout_Click" />

        </div>
    </form>
</body>
</html>
