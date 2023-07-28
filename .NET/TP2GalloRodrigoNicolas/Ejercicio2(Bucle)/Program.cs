using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Bucle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor toque una tecla para ejecutar el bucle");
            Console.ReadKey();

            int i = 1;
            while(i < 100)
            {
                int div = 0;
                int res = 0;

                div = (i / 2);
                
                res = (div * 2);

                if (res != i)
                {
                    Console.WriteLine("El numero: " + i + " no es divisible por 2");
                }
                i++;
            }

            Console.WriteLine("Muchas gracias!! presione cualquier tecla para salir");
            Console.ReadKey();

        }
    }
}
