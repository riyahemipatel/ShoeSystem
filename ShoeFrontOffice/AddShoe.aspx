<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddShoe.aspx.cs" Inherits="AddShoe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 494px; width: 629px" Text="ADD SHOE"></asp:Label>
            <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 22px; top: 60px; position: absolute; height: 31px; width: 585px" Text="Please enter the following fields:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 103px; top: 241px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 103px; top: 197px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 99px; top: 286px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 108px; top: 149px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblBrand" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 30px; top: 148px; position: absolute" Text="Brand"></asp:Label>
            <asp:Label ID="lblSize" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 31px; top: 240px; position: absolute" Text="Size"></asp:Label>
            <asp:Label ID="lblColour" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 30px; top: 196px; position: absolute; bottom: 611px" Text="Colour"></asp:Label>
            <asp:Label ID="lblStyle" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 29px; top: 288px; position: absolute" Text="Style"></asp:Label>
            <asp:Button ID="btnAddShoe" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 454px; top: 440px; position: absolute" Text="ADD SHOE" />
            <asp:Button ID="btnHomePage" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 52px; top: 440px; position: absolute" Text="BACK TO HOME PAGE" />
        </div>
    </form>
</body>
</html>
