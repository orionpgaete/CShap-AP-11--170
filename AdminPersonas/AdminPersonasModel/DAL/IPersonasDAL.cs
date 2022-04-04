using AdminPersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public interface IPersonasDAL
    {
        void AgregarPersona(Persona persona);

        List<Persona> ObtenerPersonas();
        List<Persona> FiltrarPersonas(string nombre);
    }
}
