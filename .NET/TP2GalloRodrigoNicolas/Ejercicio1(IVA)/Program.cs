using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_IVA_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!");
            Console.WriteLine("Por favor ingrese un valor para calcular el total con IVA agregado");

            int numero = int.Parse(Console.ReadLine());

            int Total = CalcularIVA(numero);
            Console.WriteLine("El valor total es: " + Total);
            Console.ReadKey();
        }

        static int CalcularIVA(int Bruto)
        {
            int Iva = (Bruto * 21) / 100;
            return Iva + Bruto;
        }

    }
}
