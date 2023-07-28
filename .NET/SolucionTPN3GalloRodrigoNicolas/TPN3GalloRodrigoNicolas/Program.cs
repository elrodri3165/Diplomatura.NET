using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN3GalloRodrigoNicolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Por favor ingrese el nombre del empleado");
            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su sueldo, solo números enteros");
            int sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor especifique su sexo, ¿es masculino?");
            Console.WriteLine("Presione S para SI, N o cualquier otra letra para NO.");
            string sexo = Console.ReadLine();

            if (sexo == "S" || sexo == "s")
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Femenino";
            }

            Console.WriteLine("Por favor especifique su peso en kilogramos (kg).");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Por favor especifique su altura en metros (m).");
            float altura = float.Parse(Console.ReadLine());

            Persona Per = new Persona(nombre, sueldo, sexo, peso, altura);
            Console.WriteLine("Nombre: " + Per.GetNombre());
            Console.WriteLine("Email: " + Per.GetEmail());
            Console.WriteLine("Sueldo: " + Per.GetSueldo() + "ARS");
            Console.WriteLine("Sexo: " + Per.GetSexo());
            Console.WriteLine("Peso: " + Per.GetPeso() + "kg(B)");
            Console.WriteLine("Altura: " + Per.GetAltura() + "m");

            Console.WriteLine("Por favor presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
