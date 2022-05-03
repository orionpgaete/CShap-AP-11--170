using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel
{
    public class Mensaje
    {
        private string nombre;
        private string tipo;
        private string texto;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Texto { get => texto; set => texto = value; }
    }
}
