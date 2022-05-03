using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioHebra.Hebras
{
   public class HebraEjercicio
    {
        private int numero;

        public HebraEjercicio(int n)
        {
            this.numero = n;
        }

        public void ejecutar()
        {
            Thread.Sleep(this.numero * 1000);
            Console.WriteLine("Hola desde {0}", numero);
        }

    }
}
