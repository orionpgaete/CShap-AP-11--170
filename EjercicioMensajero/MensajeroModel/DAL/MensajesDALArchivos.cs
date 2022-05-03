using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel.DAL
{
    public class MensajesDALArchivos : IMensajesDAL
    {
        //para implementar un patron singleton

      //  Singleton es un patrón de diseño del tipo creacional cuyo propósito es garantizar la
      //  existencia de una sola instancia de una clase.Además el acceso a esa única instancia tiene que ser global.

        //1. El contructor tiene que ser private
        private MensajesDALArchivos()
        {

        }
        //2. Debe poseer un atributo del mismo tipo de la clase y estatico
        private static MensajesDALArchivos instancia;
        //3. Tener un metodo GetIntance, que devuelve una referencia al atributo
        public static IMensajesDAL GetIntancia()
        {
            if (instancia == null)
            {
                instancia = new MensajesDALArchivos();
            }
            return instancia;
        }

        private static string url = Directory.GetCurrentDirectory();

        private static string archivo = url + "/mensajes.txt";
        public void AgregarMensaje(Mensaje mensaje)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(mensaje.Nombre + ";" + mensaje.Texto + ";" + mensaje.Tipo);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public List<Mensaje> ObtenerMensajes()
        {
            List<Mensaje> lista = new List<Mensaje>();
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    string texto = "";
                    do
                    {
                        texto = reader.ReadLine();
                        if (texto != null)
                        {
                            string[] arr = texto.Trim().Split(';');
                            Mensaje mensaje = new Mensaje()
                            {
                                Nombre = arr[0],
                                Texto = arr[1],
                                Tipo = arr[2]
                            };
                            lista.Add(mensaje);
                        }
                    } while (texto != null);
                }
            }
            catch (Exception ex)
            {
                lista = null;
            }
            return lista;
        }
    }
}
