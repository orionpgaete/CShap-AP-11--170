using HolaMundoSocket.Comunicaciones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);

            Console.WriteLine("Inicinado Servidor en puerto {0}", puerto);
            ServerSocket servidor = new ServerSocket(puerto);

            if (servidor.Iniciar())
            {
                //OK puede conectar
                Console.WriteLine("Servidor Iniciado");
                while (true)
                {
                    Console.WriteLine("Esperando Cliente");
                    Socket socketCliente = servidor.ObtenerCliente();
                    //Construir el mecanismo para escribir y leer
                    ClienteCom cliente = new ClienteCom(socketCliente);
                    //aqui esta el protocolo de comuncacion, ambos deben conocerlo
                    cliente.Escribir("Hola Mundo cliente, dime tu nombre???");
                    string respuesta = cliente.Leer();
                    Console.WriteLine("El cliente mando: {0}", respuesta);
                    cliente.Escribir("Hasta la vista bi be " + respuesta);
                    cliente.Desconectar();
                }



            }
            else
            {
                Console.WriteLine("Errror, el puerto {0} esta en uso", puerto);
            }
        }
    }
}
