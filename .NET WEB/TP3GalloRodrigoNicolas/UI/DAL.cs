using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

namespace UI
{
    public class DAL
    {
        public void CrearCompra(int Id_Compra, string Nombre, string Producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"CrearCompra";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id_Compra", SqlDbType.Int).Value = Id_Compra;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
                cmd.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Producto;


                cmd.ExecuteNonQuery();

                conn.Close();

            }

        }
    }
}