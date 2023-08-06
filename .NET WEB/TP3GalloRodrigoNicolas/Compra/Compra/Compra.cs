using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAL;

namespace Compra
{
    public class Compra
    {
        public int Id { get; set; }
        public int Id_Compra { get; set; }

        public string Nombre { get; set; }

        public string Producto { get; set; }

        public void CrearCompra()
        {
            DAL dal = new DAL();
            dal.CrearCompra(this.Id_Compra, this.Nombre, this.Producto);
        }
    }
}

