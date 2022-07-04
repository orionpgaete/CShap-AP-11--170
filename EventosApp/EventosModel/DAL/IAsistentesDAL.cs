using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModel.DAL
{
    public interface IAsistentesDAL
    {
        List<Asistente> ObtenerAsistentes();
        List<Asistente> ObtenerAsistentes(string estado);

        Asistente Obtener(int id);

        void AgregarAsistente(Asistente asistente);

        void EliminarAsistente(int id);
        void Actualizar(Asistente a);
    }
}
