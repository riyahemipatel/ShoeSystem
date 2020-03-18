<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDelete" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 35px; top: 66px; position: absolute; height: 500px; width: 511px" Text="DELETE"></asp:Label>
            <asp:Label ID="lblDeleteShoe" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 145px; top: 150px; position: absolute; height: 24px; width: 293px" Text="Are you sure you want to delete this shoe? "></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 184px; top: 192px; position: absolute; height: 33px; width: 61px" Text="YES" />
        <asp:Button ID="btnNo" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; top: 192px; position: absolute; left: 292px; height: 33px; width: 61px" Text="NO" />
    </form>
</body>
</html>
