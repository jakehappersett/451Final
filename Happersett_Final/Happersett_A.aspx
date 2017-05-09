<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Happersett_A.aspx.cs" Inherits="Happersett_Final.Happersett_A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Click a product name to get details</h1>
            <br />
            <br />
        <asp:GridView runat="server" ID="ProductList" DataSourceID="final" AutoGenerateColumns="false" >
        <Columns>
            <asp:HyperLinkField HeaderText="Product" DataTextField="Name" DataNavigateUrlFields="ProductID" DataNavigateUrlFormatString="Product_Details.aspx?product_id={0}"/>
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:BoundField DataField="Price" DataFormatString="{0:c}" HtmlEncode="false" HeaderText="Price"/>
            <asp:BoundField DataField="Type" HeaderText="Type"/>
        </Columns>

    </asp:GridView>

            <asp:Label ID="Label2" runat="server" Text="number of items in cart : "></asp:Label>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>

        <asp:SqlDataSource runat="server"
            ID="final"
            SelectCommand="SELECT * FROM Product"
            ConnectionString="<%$ ConnectionStrings:Final%>" >
        </asp:SqlDataSource>

</body>
</html>
