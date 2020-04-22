<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CW_ISAD.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
</head>
<body>
    <form id="login" runat="server">
        <div>
            <asp:Label ID="Welcome" runat="server" Text="Welcome to Fakebook"></asp:Label>
        </div>
        <div>
            <asp:Label ID="User" runat="server" Text="Enter your USER NUMBER here:       "></asp:Label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" Text="GO" />
        </div>
            <asp:GridView ID="userGV" runat="server"></asp:GridView>
        <asp:Label ID="error" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
