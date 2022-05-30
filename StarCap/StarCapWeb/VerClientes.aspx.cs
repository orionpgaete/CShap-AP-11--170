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
    public partial class VerClientes : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClienteDALObjetos(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Cliente> clientes = clientesDAL.Obtener();
                this.grillaClientes.DataSource = clientes;
                this.grillaClientes.DataBind();
            }

        }
    }
}