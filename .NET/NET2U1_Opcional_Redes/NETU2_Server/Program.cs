using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace NETU2_Server
{
    class Program
    {
        public static void Main()
        {
            TcpListener server = null;
            try
            {
                // Configuremos el IP y el Puerto de nuestro Server
                Int32 port = 16000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                server = new TcpListener(localAddr, port);

                // Arrancamos el server
                server.Start();

                // Preparamos el buffer para recibir datos (voy a recibir datos de a tramos para evitar congestiones)
                Byte[] bytes = new Byte[256];
                String data = null;

                // Aca comienza el while de escucha de conexiones
                while (true)
                {
                    Console.Write("Esperando que un cliente se conecte... ");

                    // Hacemos una llamada bloqueante pare recibir clientes (El programa se queda en este punto hasta que entre un cliente)
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Cliente conectado!");

                    data = null;

                    // Obtenemos un stream (un flujo o canal de datos) para recibir info del cliente
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Hago un while para recibir data desde el cliente, mientras esto no devuelva 0 el cliente está activo.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Los datos se envian y reciben en formato byte, para que los humanos lo entendamos hay que transformarlo a string
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Recibido: {0}", data);

                        // Podemos procesar la data enviada por el cliente, en mi caso le voy a devolver todo lo que me mande pero en mayuscula
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Se lo envio por el mismo canal
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Enviado: {0}", data);
                    }

                    // Una vez que el cliente se desconecta, cierro la conexion
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Paro el servidor y dejo de escuchar conexiones (el puerto queda libre)
                server.Stop();
            }


            Console.WriteLine("Preciona enter para continuar...");
            Console.Read();
        }
    }
}


