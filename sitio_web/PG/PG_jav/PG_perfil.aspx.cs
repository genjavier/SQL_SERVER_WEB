using Biblioteca.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitio_web.PG.PG_logeadas
{
    public partial class PG_perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void perfil()
        {

            DataTable dt = BD_conexion.getInstance().mySQLSelect("DAO_leer_usuario");
            txtRut.value = dt.Rows[0][1].ToString();
            txtNombre.value = dt.Rows[0][2].ToString();
            txtApP.value = dt.Rows[0][3].ToString();
            txtApM.value = dt.Rows[0][4].ToString();
            txtCorreo.value = dt.Rows[0][5].ToString();
            txtTelefono.value = dt.Rows[0][6].ToString();           


        }
    }
}