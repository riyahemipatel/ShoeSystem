<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDeclined.aspx.cs" Inherits="PaymentDeclined" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 542px; width: 755px" Text="YOUR ORDER"></asp:Label>
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 37px; top: 503px; position: absolute" Text="BACK TO THE HOME PAGE" />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" style="z-index: 1; left: 268px; top: 439px; position: absolute" Text="Payment has been declined!"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 555px; top: 78px; position: absolute" Text="Total"></asp:Label>
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 35px; top: 74px; position: absolute" Text="Product"></asp:Label>
        </div>
    </form>
</body>
</html>
