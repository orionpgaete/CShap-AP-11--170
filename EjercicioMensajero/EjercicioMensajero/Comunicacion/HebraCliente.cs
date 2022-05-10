using MensajeroModel;
using MensajeroModel.DAL;
using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMensajero.Comunicacion
{
    class HebraCliente
    {
        private IMensajesDAL mensajesDAL = MensajesDALArchivos.GetIntancia();
        private ClienteCom clienteCom;

        public HebraCliente(ClienteCom clienteCom)
        {
            this.clienteCom = clienteCom;
        }

        public void Ejecutar()
        {
            clienteCom.Escribir("Ingrese nombre: ");
            string nombre = clienteCom.Leer();
            clienteCom.Escribir("Ingrese texto: ");
            string texto = clienteCom.Leer();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "TCP"
            };
            lock (mensajesDAL)
            {
                mensajesDAL.AgregarMensaje(mensaje);
            }
            clienteCom.Desconectar();
        }
    }
}
