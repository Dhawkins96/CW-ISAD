<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="CW_ISAD.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Profile</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="stylesheet" href="StyleSheet.css" />

</head>
<body >

    <form id="Info" runat="server">
        <div class="header">
            <h1>Welcome to Facebook</h1>
        </div>
              <!-- left column -->
        <div class="column left">
            <h2>
                <asp:Label ID="lblUser" runat="server" Text=""></asp:Label><br />
            </h2>

            <asp:Label ID="lblName" runat="server" Text="Full Name: " /> <asp:Label ID="lblFirstName" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblLastName" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblGen" runat="server" Text="Gender: " /><asp:Label ID="lblGender" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblHome" runat="server" Text="Hometown: " /><asp:Label ID="lblHometown" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblCurrentCity" runat="server" Text="City: " /><asp:Label ID="lblCity" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblRelStatus" runat="server" Text="Relationship Status: " /><asp:Label ID="lblRelation" runat="server" Text=""></asp:Label><br />
            <br />

            <asp:GridView ID="gvEdu" runat="server" ShowHeader="False" GridLines="None" HorizontalAlign="Center"></asp:GridView>

            <br />
            <asp:GridView ID="gvWork" runat="server" ShowHeader="False" GridLines="None" HorizontalAlign="Center"></asp:GridView>

        </div>

        <!-- middle column -->

        <div class="column middle">
            <h2>Messages</h2>

            <asp:GridView ID="MessagesGV" runat="server"></asp:GridView>

        </div>

        <!-- Right Column -->
        <div class="column right" >
            
            <h2>Friends</h2>
            <asp:GridView ID="friends" runat="server" GridLines="Horizontal" HorizontalAlign="Center"
                ShowHeader="False" style="margin-bottom:20%;">
            </asp:GridView>
                
        </div>

        <footer class="footer">
            <p>ISAD157</p>
        </footer>
    </form>
</body>

</html>
