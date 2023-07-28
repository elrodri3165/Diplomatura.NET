<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:Button Text="Ver HOLA MUNDO" ID="btnHolaMundo" OnClick="btnHolaMundo_Click" runat="server" />



        <div class="container">
            <h1>
                <asp:Label Text="" ID="lblResultado" runat="server" />
            </h1>
        </div>

    </main>

</asp:Content>
