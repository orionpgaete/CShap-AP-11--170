using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClienteDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del formulario
            string nombre = this.nombreTxt.Text.Trim();
            string rut = this.Rut.Text.Trim();
            //obtener  el valor del dropdown
            string bebidaValor = this.bebidaDdl.SelectedValue;
            //obtener el texto
            string bebidaTexto = this.bebidaDdl.SelectedItem.Text;
            int nivel = Convert.ToInt32(this.nivelRbl.SelectedValue);
            //2. construir el objeto de tipo cliente
            Bebida bebida = new Bebida()
            {
                Codigo = bebidaValor,
                Nombre = bebidaTexto
            };
            Cliente cliente = new Cliente()
            {
                Nombre = nombre,
                Rut = rut,
                Nivel = nivel,
                BebidaFavorita = bebida
            };
            //3. Llamar al DAL
            clientesDAL.Agregar(cliente);
            //4. Mostrar mensajae de exito
            this.mensajeLbl.Text = "Cliente Ingresado Exitosamente !!!";
        }
    }
}