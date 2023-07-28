<%@ Page Title="TP 4 Gallo Rodrigo Nicolas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UITp4GalloRodrigoNicolas._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        
        <h1>TP 4 Gallo Rodrigo Nicolas</h1>

        <div class="d-flex flex-column col-3">
            <div class="bg-primary d-inline text-white p-2">
                <label>Este panel no se actualiza</label>
            </div>

            <br />

            <asp:UpdatePanel runat="server" ID="updatePanel" class="bg-ligth d-flex flex-column">
                <ContentTemplate>
                    <asp:Label Text="Por favor presione actualizar" runat="server" ID="Label2" CssClass="bg-success d-inline text-white p-2 my-2" />
                   
                    <asp:Button Text="Actualizar con AJAX y c#" OnClick="Button1_Click" runat="server" CssClass="btn btn-secondary" />

                    <p>Por favor presione el botn ACTUALIZAR</p>

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        

        <script>

            function ActualizarLabel() {
                var MainContent_Label2 = document.getElementById('MainContent_Label2');

                MainContent_Label2.innerHTML = 'El label se actualizo con AJAX desde el lado del cliente!';
            }

        </script>




    </main>

</asp:Content>
