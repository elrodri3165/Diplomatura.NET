using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using UI.Models;

namespace UI
{
    public class DAL
    {
        public List<Compra> ListarUsuarios(int NumeroCompra)
        {
            List<Compra> compras = new List<Compra>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"BuscarCompra";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Numero_Compra", SqlDbType.VarChar).Value = NumeroCompra;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Compra compra = new Compra();

                    compra.Numero_Compra = Convert.ToInt32(reader["Id_compra"]);
                    compra.Nombre = Convert.ToString(reader["Nombre"]);
                    compra.Producto = Convert.ToString(reader["Producto"]);


                   compras.Add(compra);
                }
                conn.Close();
                return compras;
            }

        }
    }
}