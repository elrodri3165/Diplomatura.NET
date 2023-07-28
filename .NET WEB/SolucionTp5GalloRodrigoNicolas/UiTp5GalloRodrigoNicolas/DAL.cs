using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UiTp5GalloRodrigoNicolas
{
    public class DAL
    {

        public void Conectar(string Apellido, string Nombre, int Id, int Edad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"CrearRegistros";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Apellido;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = Edad;

                cmd.ExecuteNonQuery();

                conn.Close();

            }

        }
        

        public void ListarUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ListarUsuarios";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Id: ");
                    Console.WriteLine(Convert.ToInt32(reader["Id"]));

                    Console.WriteLine("Apellido: ");
                    Console.WriteLine(Convert.ToString(reader["Apellido"]));

                    Console.WriteLine("Nombre: ");
                    Console.WriteLine(Convert.ToString(reader["Nombre"]));

                    Console.WriteLine("Edad: ");
                    Console.WriteLine(Convert.ToInt32(reader["Edad"]));

                    Console.WriteLine("***FIN DE REGISTRO***");
                }
            }

        }
        

    }

}
