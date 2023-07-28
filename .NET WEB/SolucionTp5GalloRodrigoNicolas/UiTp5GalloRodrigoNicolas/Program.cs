using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiTp5GalloRodrigoNicolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string create = "INSERT INTO Usuarios (Id, Nombre, Apellido,Edad) VALUES (1, ´Alan´, ´Roman´, 11)";
            string create2 = "INSERT INTO Usuarios (Id, Nombre, Apellido,Edad) VALUES (2, ´Rodrigo´, ´Gallo´, 28);";
            string create3 = "INSERT INTO Usuarios (Id, Nombre, Apellido,Edad) VALUES (3, ´Nicolas´, ´Fernandez´, 33);";

            string consulta = "Select * From Usuarios;";

            Console.ReadLine();

            DAL dal = new DAL();
            dal.Conectar(create);
            //dal.Conectar(create2);
            //dal.Conectar(create3);

            //dal.Conectar(create);


        }
    }
}
