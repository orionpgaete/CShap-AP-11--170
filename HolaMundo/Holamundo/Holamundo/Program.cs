using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holamundo
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Edad: ");
            string edadtx = Console.ReadLine().Trim();
            //TrimStart(); Quita espacios al inicio
            //TrimEnd(); Quita espacios al final
            Console.WriteLine("Su nombre es {0}", nombre);    
            Console.ReadKey();
        }
    }
}
