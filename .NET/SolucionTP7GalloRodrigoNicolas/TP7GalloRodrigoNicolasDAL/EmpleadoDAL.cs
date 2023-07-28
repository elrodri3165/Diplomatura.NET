using TP7GalloRodrigoNicolasEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;

namespace TP7GalloRodrigoNicolasDAL
{
    public class EmpleadoDAL
    {
        public static ResponseEmpleados ListarEmpleados()
        {
            ResponseEmpleados response = new ResponseEmpleados();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
                {
                    conn.Open();

                    string sql = @"ListarEmpleados";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        response.listado.Add(GenerarEmpleado(reader));
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                response.error = ex;
                return response;
            }
        }

        public static List<Empleado> ListarEmpleadosConFiltro(string NombreCompleto)
        {

            List<Empleado> list = new List<Empleado>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ListarEmpleadosConFiltro";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = NombreCompleto;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(GenerarEmpleado(reader));
                }
            }

            return list;
        }


        public static Empleado GenerarEmpleado(SqlDataReader reader)
        {
            Empleado empleado = new Empleado();

            empleado.Id = Convert.ToInt32(reader["Id"]);
            empleado.NombreCompleto = Convert.ToString(reader["NombreCompleto"]);
            empleado.DNI = Convert.ToString(reader["DNI"]);
            empleado.Edad = Convert.ToInt32(reader["Edad"]);
            empleado.Salario = Convert.ToDecimal(reader["Salario"]);

            return empleado;
        }


        private static Empleado ObtenerEmpleado(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }



        public void CrearEmpleado(string NombreCompleto, string DNI, int Edad, bool Casado, decimal Salario)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
                {
                    conn.Open();

                    string sql = @"CrearEmpleado";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = NombreCompleto;
                    cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = DNI;
                    cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = Edad;
                    cmd.Parameters.Add("@Casado", SqlDbType.Bit).Value = Casado;
                    cmd.Parameters.Add("@Salario", SqlDbType.Decimal).Value = Salario;

                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception Ex)
            {
                //return Ex;

            }
        }

        public void EditarEmpleado(int Id, string NombreCompleto, string DNI, int Edad, bool Casado, decimal Salario)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
                {
                    conn.Open();

                    string sql = @"EditarEmpleado";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
                    cmd.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = NombreCompleto;
                    cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = DNI;
                    cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = Edad;
                    cmd.Parameters.Add("@Casado", SqlDbType.Bit).Value = Casado;
                    cmd.Parameters.Add("@Salario", SqlDbType.Decimal).Value = Salario;

                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception Ex)
            {
                //return Ex;

            }
        }

        public static Empleado ObtenerEmpleado(int id)
        {
            Empleado empleado = new Empleado();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
            {
                conn.Open();

                string sql = @"ObtenerEmpleado";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    empleado = GenerarEmpleado(reader);
                }
            }

            return empleado;
        }

        public static void EliminarEmpleado(int id)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ToString()))
                {
                    conn.Open();
                    string sql = @"EliminarEmpleado";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception Ex)
            {

            }
        }
    }
}