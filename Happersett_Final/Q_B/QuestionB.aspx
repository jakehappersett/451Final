<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionB.aspx.cs" Inherits="Happersett_Final.QuestionB" MasterPageFile="~/Happersett.Master"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1> product information</h1>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Input product ID"></asp:Label>
            <input id="Text1" type="text" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" />
            <br />
            <asp:GridView ID="grbProduct" runat="server"></asp:GridView>
        </div>
    </asp:Content>
