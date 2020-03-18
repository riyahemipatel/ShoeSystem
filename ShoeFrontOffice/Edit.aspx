<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEdit" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 31px; top: 61px; position: absolute; height: 507px; width: 501px" Text="EDIT"></asp:Label>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 149px; top: 153px; position: absolute" Text="Are you sure you want to edit this shoe?"></asp:Label>
            <asp:Button ID="btnYes" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 185px; top: 199px; position: absolute; height: 33px; width: 61px; right: 1350px" Text="YES" />
            <asp:Button ID="btnNo" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 277px; top: 198px; position: absolute; height: 34px; width: 62px" Text="NO" />
        </div>
    </form>
</body>
</html>
