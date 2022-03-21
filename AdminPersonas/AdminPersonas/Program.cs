using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//orionpgaete/CShap - AP - 11--170

namespace AdminPersonas
{
    class Program
    {
        static void Main (string[] args)
        {

        }

        static bool Menu()
        {
            bool continuar = true;

            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("0. Salir");

            switch (Console.ReadLine().Trim())
            {
                case "1": IngresarPersona();
                    break;
                case "2": //mostrar
                    break;
                case "3": //Buscar
                    break;
                case "0": continuar = false;
                    break;
                default: Console.WriteLine("Aprete el teclado bien.....");
                    break;
            }
            return continuar;
        }

        
        static void IngresarPersona()
        {
            string nombre;
            uint telefono;
            double peso;
            double estatura;

            Console.WriteLine("Bievenido al programa ultramente BKN");

            bool esValido;

            do
            {
                Console.WriteLine("Ingrese telefono");
                string tel = Console.ReadLine().Trim();
                esValido = UInt32.TryParse(tel, out telefono);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese peso");
                string pes = Console.ReadLine().Trim();
                esValido = Double.TryParse(pes, out peso);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese estatura");
                string est = Console.ReadLine().Trim();
                esValido = Double.TryParse(est, out estatura);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine().Trim();
            } while (nombre == string.Empty);

            Persona p = new Persona();
            p.Nombre = nombre;

            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Telefono : {0}", telefono);
            Console.WriteLine("Peso : {0}", peso);
            Console.WriteLine("Estatura : {0}", estatura);
            Console.WriteLine("IMC es : {0}", peso / (estatura * estatura));
            Console.ReadKey();
        }

                
        }
    }
}
