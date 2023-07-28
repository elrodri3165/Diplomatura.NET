using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NETU2_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe algo para que el server te lo transforme a mayusculas");
            string mensaje = Console.ReadLine();
            Connect("127.0.0.1", mensaje);
        }

        static void Connect(String server, String message)
        {
            try
            {
                // Crear un cliente usando TcpClient
                // Para que este cliente funcione, el mismo debe estar bien configurado
                // con los datos del server, tanto la IP como el Puerto 
                // ademas se debe encontar en la misma red

                Int32 port = 16000;
                TcpClient client = new TcpClient(server, port);

                // Vamos a transferir el mensaje de string en bytes para poder ser enviado
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // obtenemos el flujo de comunmicacion para enviar y recibir datos
                 NetworkStream stream = client.GetStream();

                // y enviamos los datos 
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Enviado: {0}", message);

                // Una vez enviado esperamos por la respuesta

                // Usamos un buffer del para recibir los paquetes del server
                data = new Byte[256];
                String responseData = String.Empty;

                // Leemos el primer paquete recibido 256 caracteres
                //(si queremos seguir leyendo debemos usar un while)
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Recibido: {0}", responseData);

                // cerramos todo
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\n Presiona Enter para continuar..");
            Console.Read();
        }
    }
}
