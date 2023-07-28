using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace TP7GalloRodrigoNicolasEntities
{
    public class ResponseEmpleados
    {
        public ResponseEmpleados()
        {
            empleado = new Empleado();
            listado = new List<Empleado>();
        }
        public Empleado empleado { get; set; }

        public List<Empleado> listado { get; set; }

        public Exception error { get; set; }

    }
}
