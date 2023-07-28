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

            Console.WriteLine("Ingrese su apellido");
            string Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Edad");
            int Edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su ID");
            int Id = Int32.Parse(Console.ReadLine());

            DAL dal = new DAL();
            dal.Conectar(Apellido, Nombre, Id, Edad);

            Console.WriteLine("**");

            Console.WriteLine("Lista de usuarios del sistema");
            dal.ListarUsuarios();

            Console.ReadLine();
        }
    }
}
