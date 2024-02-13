<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UserLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextUser" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextPass" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
        </div>
    </form>
    
</body>
</html>
