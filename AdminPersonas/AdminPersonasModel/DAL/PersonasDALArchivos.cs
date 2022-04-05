using AdminPersonas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALArchivos : IPersonasDAL
    {
        private static string archivo = "personas.txt";
        private static string ruta = Directory.GetCurrentDirectory() + "/" + archivo;
        //C:/Users/sistema/VisualStudio...../personas.txt
        public void AgregarPersona(Persona persona)
        {
            //1. crear el streamwriter
            //2. agregar una linea del archivo
            //3. cerrar el streamwriter
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    string texto = persona.Nombre + ";"   //CSV: 
                                 + persona.Estatura + ";"
                                 + persona.Telefono + ";"
                                 + persona.Peso + ";";
                    writer.WriteLine(texto);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al escribir en archivo" + ex.Message);
            }
            finally
            {

            }

        }

        public List<Persona> FiltrarPersonas(string nombre)
        {
            return ObtenerPersonas().FindAll(p => p.Nombre == nombre);
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            using(StreamReader reader = new StreamReader(ruta))
            {
                string texto;
                do
                {
                    //Leer desde el archivo hasta que no haya nada
                    texto = reader.ReadLine();
                    if (texto != null)
                    {
                        //nombre, estatura, telefono, peso
                        string[] textoarr = texto.Trim().Split(';');
                        string nombre = textoarr[0];
                        double estatura = Convert.ToDouble(textoarr[1]);
                        uint telefono = Convert.ToUInt32(textoarr[2]);
                        double peso = Convert.ToDouble(textoarr[3]);
                        //crear una persona
                        Persona p = new Persona()
                        {
                            Nombre = nombre,
                            Estatura = estatura,
                            Telefono = telefono,
                            Peso = peso
                        };
                        // calcule su IMC
                        p.calcularImc();
                        // agregar a la lista
                        personas.Add(p);
                    }        
                    
                } while (texto != null);
                
                //crear una persona
                // calcule su IMC
                // agregar a la lista
            }
            return personas;
        }
    }
}
