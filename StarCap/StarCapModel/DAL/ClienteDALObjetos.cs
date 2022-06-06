using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel.DAL
{
    public class ClienteDALObjetos : IClientesDAL
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public void Agregar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public List<Cliente> Obtener()
        {
            return clientes;
        }

        public void Eliminar(string rut)
        {
            Cliente eliminando = clientes.Find(c => c.Rut == rut);
            clientes.Remove(eliminando);
        }
    }
}
