<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="CW_ISAD.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>

              <asp:GridView runat="server" ID="gridview" CellSpacing="2" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="First Name"></asp:BoundField>
                    <asp:BoundField DataField="LastName" HeaderText="Last Name"></asp:BoundField>
                    <asp:BoundField DataField="Gender" HeaderText="Gender"></asp:BoundField>
                    <asp:BoundField DataField="Hometown" HeaderText="Hometown"></asp:BoundField>
                    <asp:BoundField DataField="City" HeaderText="City"></asp:BoundField>
                    <asp:BoundField DataField="RelationStatus" HeaderText="Relationship Status"></asp:BoundField>
                </Columns>
            </asp:GridView>


        </div>
    </form>
</body>
</html>
