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

        private void RellenarBuscar()
        {
            try
            {
                lblError.Text = "";
                Conexion con = new Conexion();
                string sCnn = con.conec();
                string sSel = "NEG_USUARIO_BUSCAR ';" + int.Parse(txtRut.value) + "'";
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
                //de la fila , columna de la tabla obtenida
                txtNombre.Text = dt.Rows[0][1].ToString();
                txtApellido.Text = dt.Rows[0][2].ToString();

                sSel = "NEG_TELEFONOCELULAR_BUSCAR ';" + int.Parse(txtRut0.Text) + "'";
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
                //de la fila , columna de la tabla obtenida
                txtCelular.Text = dt.Rows[0][2].ToString();

            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }
    }
}