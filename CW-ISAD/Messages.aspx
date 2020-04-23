<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Messages.aspx.cs" Inherits="CW_ISAD.Messages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="lblUser" runat="server" Text=""></asp:Label><br /><br />
             <asp:GridView ID="MessagesGV" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
