<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewOrderHistory.aspx.cs" Inherits="ViewOrderHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblViewOrderHistory" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 28px; top: 37px; position: absolute; height: 619px; width: 1042px" Text="VIEW ORDER HISTORY"></asp:Label>
            <asp:Label ID="lblOrderTotal" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 387px; top: 137px; position: absolute" Text="Order Total"></asp:Label>
            <asp:Label ID="lblDate" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 176px; top: 135px; position: absolute" Text="Date "></asp:Label>
            <asp:Label ID="lblOrderStatus" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 514px; top: 138px; position: absolute" Text="Order Status"></asp:Label>
            <asp:Label ID="lblShip" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 271px; top: 136px; position: absolute" Text="Ship To "></asp:Label>
            <asp:Label ID="lblOrderID" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 49px; top: 135px; position: absolute" Text="Order ID"></asp:Label>
            <asp:Button ID="btnTrack" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 932px; top: 592px; position: absolute" Text="TRACK" />
            <asp:Button ID="btnView" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 842px; top: 592px; position: absolute" Text="VIEW" />
            <asp:Button ID="btnHomePage" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 48px; top: 595px; position: absolute" Text="BACK TO HOME PAGE" />
            <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 42px; top: 90px; position: absolute; height: 31px; width: 995px" Text="View Your Order History and Track Your Orders "></asp:Label>
        </div>
    </form>
</body>
</html>
