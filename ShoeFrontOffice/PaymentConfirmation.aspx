<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentConfirmation.aspx.cs" Inherits="PaymentConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblYourOrder" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 38px; top: 18px; position: absolute; height: 576px; width: 658px; right: 584px;" Text="YOUR ORDER"></asp:Label>
            <asp:Label ID="lblProduct" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 62px; top: 85px; position: absolute; right: 1167px;" Text="Product"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 434px; top: 86px; position: absolute; height: 22px; width: 110px" Text="Total"></asp:Label>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 208px; top: 491px; position: absolute" Text="Payment has been successful!"></asp:Label>
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 63px; top: 546px; position: absolute" Text="BACK TO THE HOME PAGE" />
        </div>
    </form>
</body>
</html>
