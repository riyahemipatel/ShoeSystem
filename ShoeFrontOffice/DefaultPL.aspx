<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultPL.aspx.cs" Inherits="DefaultPL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shoe Sensation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" style="z-index: 1; left: 359px; top: 88px; position: absolute" />
            <asp:Label ID="lblSpecials" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 44px; top: 595px; position: absolute; height: 209px; width: 267px" Text="SPECIALS"></asp:Label>
            <asp:Label ID="lblHeels" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 54px; top: 214px; position: absolute; height: 25px; width: 130px" Text="Heels"></asp:Label>
            <asp:Label ID="lblHeeledBoots" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 57px; top: 340px; position: absolute; height: 25px; width: 130px; bottom: 299px" Text="Heeled Boots"></asp:Label>
            <asp:Label ID="lblCourtHeels" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 56px; top: 379px; position: absolute; height: 25px; width: 130px" Text="Court Heels"></asp:Label>
            <asp:Label ID="lblSockBoots" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 55px; top: 420px; position: absolute; height: 24px; width: 131px" Text="Sock Boots"></asp:Label>
            <asp:Label ID="lblClearHeels" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 55px; top: 254px; position: absolute; height: 25px; width: 130px" Text="Clear Heels"></asp:Label>
            <asp:Label ID="lblLaceUp" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 55px; top: 297px; position: absolute; height: 25px; width: 130px; bottom: 342px" Text="Lace Up Heels "></asp:Label>
        
        <asp:Label ID="lblTitle1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FF0066" style="z-index: 1; left: 78px; top: 61px; position: absolute" Text="SHOE"></asp:Label>
        <asp:Label ID="Label1" runat="server" BackColor="#FFCCCC" BorderStyle="Double" style="z-index: 1; left: 234px; top: 178px; position: absolute; height: 396px; width: 466px" Text="Label"></asp:Label>
        <asp:Button ID="btnDeleteShoe" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 844px; top: 620px; position: absolute; right: 403px;" Text="DELETE SHOE" OnClick="btnDeleteShoe_Click" />
        
        <asp:Button ID="lblAddShoe" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 707px; top: 621px; position: absolute; right: 586px;" Text="ADD SHOE" />
        
        
        <asp:Button ID="lblEditShoe" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 1025px; top: 622px; position: absolute" Text="EDIT SHOE" />
        
        
        <asp:Label ID="Label2" runat="server" BackColor="#FFCCCC" BorderStyle="Double" style="z-index: 1; left: 751px; top: 178px; position: absolute; height: 397px; width: 465px" Text="Label"></asp:Label>
        
        
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Small" style="z-index: 1; left: 944px; top: 135px; position: absolute" Text="VIEW ORDER HISTORY" />
        
        
        <asp:Label ID="Label3" runat="server" BackColor="#FFCCCC" style="z-index: -1; left: 323px; top: 598px; position: absolute; height: 210px; width: 891px" Text="Label"></asp:Label>
        
        <asp:ListBox ID="ListBoxOrder" runat="server" style="z-index: 1; left: 259px; top: 213px; position: absolute; height: 313px; width: 398px"></asp:ListBox>
        <asp:Label ID="lblTitle2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Strikeout="True" ForeColor="#FF0066" style="z-index: 1; left: 35px; top: 89px; position: absolute" Text="SENSATION"></asp:Label>
        <asp:Label ID="lblShoppingCart" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Medium" style="z-index: 1; left: 1144px; top: 73px; position: absolute; height: 27px; width: 125px;" Text="Shopping Cart"></asp:Label>
        <asp:Label runat="server" BackColor="#FFCCCC" Font-Bold="True" style="z-index: -1; left: 40px; top: 130px; position: absolute; height: 36px; width: 1211px" Text="HOME PAGE"></asp:Label>
        <asp:Label ID="lblShoes" runat="server" Font-Bold="True" style="z-index: 1; left: 250px; top: 137px; position: absolute" Text="SHOES"></asp:Label>
        <asp:Label ID="lblMyFavourites" runat="server" Font-Bold="True" style="z-index: 1; left: 424px; top: 137px; position: absolute" Text="MY FAVOURTIES"></asp:Label>
        <asp:Label ID="lblMyShoppingCart" runat="server" Font-Bold="True" style="z-index: 1; left: 690px; top: 137px; position: absolute" Text="MY SHOPPING CART"></asp:Label>
        <asp:Label ID="lblCart" runat="server" Font-Bold="True" style="z-index: 1; left: 1074px; top: 96px; position: absolute" Text="Now in your cart "></asp:Label>
        <asp:Label ID="lblItems" runat="server" Font-Bold="True" Font-Underline="True" style="z-index: 1; left: 1191px; top: 97px; position: absolute" Text="0 items"></asp:Label>
        <asp:Label ID="lblProducts" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="X-Large" style="z-index: -1; left: 43px; top: 173px; position: absolute; height: 415px; width: 172px" Text="PRODUCTS"></asp:Label>
    </form>
</body>
</html>
