using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL
    {
        protected string CnnString = "\"Data Source=localhost;Initial Catalog=Compras;Integrated Security=True;\"";

        public void CrearCompra(int Id_Compra, string Nombre, string Producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: CnnString.ToString()))
            {
                conn.Open();

                string sql = @"CrearCompra";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IdCompra", SqlDbType.Int).Value = Id_Compra;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
                cmd.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Producto;
                

                cmd.ExecuteNonQuery();

                conn.Close();

            }

        }
    }
}
