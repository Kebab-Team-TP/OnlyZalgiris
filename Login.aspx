<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="OnlyZalgiris.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
    <br>
    <div> Neturite paskyros? <asp:LinkButton ID="LinkRegister" href="/register" runat="server" OnClick="LinkRegister_Click">Užsiregistruoti</asp:LinkButton></div>

</asp:Content>