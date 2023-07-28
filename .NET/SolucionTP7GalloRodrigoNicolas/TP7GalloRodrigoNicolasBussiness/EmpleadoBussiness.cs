using TP7GalloRodrigoNicolasDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7GalloRodrigoNicolasEntities;

namespace TP7GalloRodrigoNicolasBussiness
{
    public class EmpleadoBussiness
    {
        public ResponseEmpleados ListarEmpleados()
        {
            return EmpleadoDAL.ListarEmpleados();
        }

        public List<Empleado> ListarEmpleadosConFiltro(string NombreCompleto)
        {
            return EmpleadoDAL.ListarEmpleadosConFiltro(NombreCompleto);
        }

        public void CrearEmpleado( string NombreCompleto, string DNI,  int Edad, bool Casado, decimal Salario)
        {
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            empleadoDAL.CrearEmpleado(NombreCompleto, DNI, Edad, Casado, Salario);
        }

        public void EditarEmpleado(int Id, string NombreCompleto, string DNI, int Edad, bool Casado, decimal Salario)
        {
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            empleadoDAL.EditarEmpleado(Id, NombreCompleto, DNI, Edad, Casado, Salario);
        }

        public static Empleado ObtenerEmpleado(int Id)
        {
            return EmpleadoDAL.ObtenerEmpleado(Id);
        }

        public static void EliminarEmpleado(int id)
        {
            EmpleadoDAL.EliminarEmpleado(id);
        }

    }
}
