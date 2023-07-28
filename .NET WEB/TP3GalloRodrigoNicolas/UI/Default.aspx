<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1>TP3 Gallo Rodrigo Nicolas</h1>

        <div class="">
            <h3 class="">
                <asp:Label Text="" runat="server"  ID="lblAlert"/>
            </h3>
        </div>

         <form class="form-control" method="" action="">
            
            <div class="mb-3">
                <label for="Nombre" class="form-label">Ingrese su nombre</label>
                <asp:TextBox runat="server"  ID="txtNombre"  CssClass="form-control"  />

            </div>

            <div class="mb-3">
                <label for="Producto" class="form-label">Por favor seleccione</label>
                <div class="d-flex">

                    <asp:DropDownList runat="server" CssClass="form-control"  DataTextField="Por favor seleccione" ID="txtProducto">
                        <asp:ListItem Value="Mesa"> Mesa </asp:ListItem>
                        <asp:ListItem Value="Silla"> Silla </asp:ListItem>
                        <asp:ListItem Value="Sofá"> Sofa </asp:ListItem>
                        <asp:ListItem Value="Cama"> Cama </asp:ListItem>

                    </asp:DropDownList>

                    <!--<button class="btn btn-primary rounded-pill px-3 m-2"><i class="bi bi-cart-plus-fill"></i></button comentado-->
                    <asp:Button Text="+" CssClass="btn btn-primary rounded-pill px-3 m-2" runat="server" ID="btnAgregarCarrito" OnClick="btnAgregarCarrito_Click" />
                </div>
            </div>

            <div class="input-group">
                <asp:ListBox runat="server" ID="lstProductos" CssClass="form-control">
                </asp:ListBox>
            </div>
      
            <asp:Button Text="Comprar" runat="server" ID="btnComprar" CssClass="btn btn-primary rounded-pill px-3 my-2" OnClick="btnComprar_Click" />
   
        </form> 
    </main>

</asp:Content>
