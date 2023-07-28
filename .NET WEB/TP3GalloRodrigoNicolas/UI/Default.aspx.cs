using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string producto = txtProducto.Text;

            if (Session["Nombre"] == null)
            {
                Session["Nombre"] = nombre;
                Session["NumeroCompra"] = 1;
            }

            if (Session["Nombre"].ToString() != nombre)
            {
                Session["NumeroCompra"] = ((int)Session["NumeroCompra"]) + 1;
            }

            Session["Nombre"] = nombre;

            if (nombre == "" || producto == "")
            {
                lblAlert.Text = "Debe completar un nombre y elegir un producto";
                lblAlert.CssClass = "bg-danger text-white d-inline";
            }
            else
            {
                lblAlert.Text = "";
                string campo = "Compra N" + Session["NumeroCompra"] + " - " + Session["Nombre"] + ", " + producto;
                lstProductos.Items.Add(campo);
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
                                                //cambiar esta ruta por la correspondiente para su pc
            using (StreamWriter outputFile = new StreamWriter("C:\\Users\\elrod\\Desktop\\archivo.txt"))
            {
                foreach (var item in lstProductos.Items)
                {
                    try
                    {
                        outputFile.WriteLine(item);
                    }
                    catch (Exception)
                    {
                        lblAlert.Text = "Ocurrio un error!";
                        lblAlert.CssClass = "bg-danger text-white d-inline";
                        throw;
                    }
                    
                }
                lstProductos.Items.Clear();
                txtNombre.Text = "";
                lblAlert.Text = "La operacion se realizo correctamente! muchas gracias!";
                lblAlert.CssClass = "bg-success text-white d-inline";
            }
            
        }
    }
}