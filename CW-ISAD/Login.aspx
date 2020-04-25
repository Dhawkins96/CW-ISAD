<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CW_ISAD.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <link rel="stylesheet" href="StyleSheet.css" />

    <title>Login</title>

</head>
<body>
    <form id="login" runat="server">
        <div class="header">
            <h1>Welcome to Facebook</h1>
        </div>
        <div>
            <br />
            <br />
            <asp:Label ID="Welcome" runat="server" Text="Login Here"></asp:Label><br />
        </div>
        <div>
            <br /><asp:Label ID="lblUser" runat="server" Text="Enter your USER NUMBER here:"></asp:Label>
            &nbsp
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" Text="GO" />
        </div>
        <asp:Label ID="error" runat="server" Text=""></asp:Label>


        <footer class="footer">
            <p>ISAD157</p>
        </footer>
    </form>
</body>
</html>
