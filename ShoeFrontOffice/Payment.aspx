<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Button" />
            <asp:Label ID="lblPayment" runat="server" BackColor="#FFCCCC" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 674px; width: 1048px; right: 222px;" Text="PAYMENT"></asp:Label>
            <asp:Label ID="lblCardHolderName" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 564px; top: 149px; position: absolute" Text="Cardholder Name:*"></asp:Label>
            <asp:Label ID="lblCardNumber" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 564px; top: 190px; position: absolute" Text="Card Number:*"></asp:Label>
            <asp:Label ID="lblExpiryDate" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 567px; top: 228px; position: absolute" Text="Expiry Date:*"></asp:Label>
            <asp:Label ID="lblCVCCode" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 567px; top: 267px; position: absolute" Text="CVV Code:*"></asp:Label>
            <asp:Label ID="lblProduct" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 25px; position: absolute; top: 107px" Text="Product"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 747px; top: 148px; position: absolute; height: 17px; width: 258px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 747px; top: 185px; position: absolute; height: 17px; width: 257px"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 811px; top: 229px; position: absolute; height: 15px; width: 54px">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 882px; top: 228px; position: absolute; height: 15px; width: 54px">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" style="z-index: 1; top: 226px; position: absolute; height: 17px; width: 54px; right: 480px">
            </asp:DropDownList>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 742px; top: 268px; position: absolute; height: 17px; width: 256px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 23px; top: 64px; position: absolute; height: 28px; width: 987px" Text="Please Enter Your Details:"></asp:Label>
        </div>
        <asp:Button ID="btnPayNow" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 869px; top: 613px; position: absolute" Text="PAY NOW" />
        <asp:Button ID="btnHomePage" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 39px; top: 616px; position: absolute" Text="BACK TO HOME PAGE" />
    </form>
</body>
</html>
