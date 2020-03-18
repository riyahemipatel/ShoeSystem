<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="btnAdd" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 46px; top: 63px; position: absolute; height: 486px; width: 431px" Text="ADD"></asp:Label>
        </div>
        <asp:Label ID="lblAddShoe" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 126px; top: 135px; position: absolute" Text="Are you sure you want to add this shoe?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; top: 179px; position: absolute; height: 35px; width: 57px; left: 256px" Text="NO" />
        <asp:Button ID="btnYes" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 168px; top: 179px; position: absolute; height: 33px; width: 61px;" Text="YES" />
    </form>
</body>
</html>
