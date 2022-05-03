using EjercicioHebra.Hebras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioHebra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Hebras");
            for (int i=1; i<7; i++)
            {
                //contruir una clase que representa mi hebra y pasar los parametros
                HebraEjercicio he = new HebraEjercicio(i);
                //ejecuto el metodo de instancia en la hebra nueva
                Thread t = new Thread(new ThreadStart(he.ejecutar));
                t.Start();
            }
            Console.WriteLine("Hebra iniciada");
            Console.ReadKey();
        }
    }
}
