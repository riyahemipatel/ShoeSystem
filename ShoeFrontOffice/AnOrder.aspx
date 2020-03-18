<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblMyOrder" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 28px; top: 34px; position: absolute; height: 590px; width: 1032px" Text="ORDER"></asp:Label>
            <asp:Button ID="btnDisplayOrders" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 778px; top: 556px; position: absolute" Text="DISPLAY ORDER" />
            <asp:Button ID="btnOK" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 708px; top: 553px; position: absolute" Text="OK" />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 62px; top: 562px; position: absolute" Text="BACK TO THE HOME PAGE" />
        </p>
    </form>
</body>
</html>
