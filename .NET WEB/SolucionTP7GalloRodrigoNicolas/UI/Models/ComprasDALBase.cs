using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace UI.Models
{
    public class ComprasDALBase
    {

        public Compra ListarCompras(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ListarCompras";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Compra compra = new Compra();

                    compra.Id = Convert.ToInt32(reader["Id"]);
                    compra.Numero_Compra = Convert.ToInt32(reader["Numero_compra"]);
                    compra.Nombre = Convert.ToString(reader["Nombre"]);
                    compra.Producto = Convert.ToString(reader["Producto"]);

                    return compra;
                }
            }

        }
    }
}