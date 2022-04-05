using AdminPersonasModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonas { 
    public partial class Program
{
        static IPersonasDAL personasDAL = new PersonasDALArchivos();
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

            Persona p = new Persona()
            { Nombre = nombre,
                Estatura = estatura,
                Telefono = telefono,
                Peso = peso
            };

            /*  p.Nombre = nombre;
              p.Estatura = estatura;
              p.Peso = peso;
              p.Telefono = telefono;*/

            p.calcularImc();

            personasDAL.AgregarPersona(p);


        Console.WriteLine("Nombre: {0}", p.Nombre);
        Console.WriteLine("Telefono : {0}", p.Telefono);
        Console.WriteLine("Peso : {0}", p.Peso);
        Console.WriteLine("Estatura : {0}", p.Estatura);
        Console.WriteLine("IMC es : {0}", p.IMC.Texto);
        
    }

        static void MostrarPersona()
        {
            List<Persona> personas = personasDAL.ObtenerPersonas();
            for (int i=0; i < personas.Count(); i++)
            {
                Persona actual = personas[i];
                Console.WriteLine("{0}: Nombre: {1} y Peso: {2}", i, actual.Nombre, actual.Peso);
            }
        }

        static void BuscarPersona()
        {
            Console.WriteLine("Ingrese nombre a buscar");
            List<Persona> filtradas = personasDAL.FiltrarPersonas(Console.ReadLine().Trim());

            filtradas.ForEach(p => Console.WriteLine("Nombre : {0} y Peso: {1}", p.Nombre, p.Peso));

        }


}
}

