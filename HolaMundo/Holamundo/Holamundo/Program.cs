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
            int edad = -1;
            bool esValido = Int32.TryParse(edadtx, out edad);

            if (edad == -1) //if (!esValido) es decir If (esvalido == true) 
            {
                Console.WriteLine("Ingrese bien la edad");
            }
            else
            {
                Console.WriteLine("Su nombre es {0} y su edad es {1}", nombre, edad);
            }
              
            Console.ReadKey();
        }
    }
}




//TrimStart(); Quita espacios al inicio
//TrimEnd(); Quita espacios al final

// EXPLICACION
/*
string num = "12";
int num2;

bool esValido = int.TryParse(num, out num2);

try
{
    string num = "12";
    int num2 = Convert.ToInt32(num);
    return true;
}catch (Exception ex)
{
    return false;
}
*/