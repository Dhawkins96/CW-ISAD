<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="CW_ISAD.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="UserDetails" runat="server">
        <div>
            <asp:Label ID="lblUser" runat="server" Text=""></asp:Label><br /><br />

            <asp:Label ID="lblFirstName" runat="server" Text="" ></asp:Label><br />
            <asp:Label ID="lblLastName" runat="server" Text="" ></asp:Label><br />
            <asp:Label ID="lblGender" runat="server" Text="" ></asp:Label><br />
            <asp:Label ID="lblHometown" runat="server" Text="" ></asp:Label><br />
            <asp:Label ID="lblCity" runat="server" Text="" ></asp:Label><br />
            <asp:Label ID="lblRelation" runat="server" Text="" ></asp:Label><br /><br />

            <asp:Label ID="lblEduName" runat="server" Text="" ></asp:Label><br />
            <asp:Label ID="lblEduDate" runat="server" Text="" ></asp:Label><br /><br />

            <asp:Label ID="lblWorkName" runat="server" Text="" ></asp:Label><br />
            <asp:Label ID="lblWorkDate" runat="server" Text="" ></asp:Label><br />
        </div>
        
    </form>
</body>
</html>
