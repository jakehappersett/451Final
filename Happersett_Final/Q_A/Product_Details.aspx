<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product_Details.aspx.cs" Inherits="Happersett_Final.Product_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="g_prod" runat="server"></asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="Add Item" OnClick="Button1_Click" />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Q_A/Happersett_A.aspx">back</asp:HyperLink>
       </div>
    </form>
</body>
</html>
