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

        public void Conectar(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString: ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                
            }

        }      
        

    }

}
