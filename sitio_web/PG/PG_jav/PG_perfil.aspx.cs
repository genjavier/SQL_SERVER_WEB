using Biblioteca.conexion;
using sitio_web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.conexion;
using System.Data.SqlClient;

namespace sitio_web.PG.PG_logeadas
{
    public partial class PG_perfil : System.Web.UI.Page
    {
        CLLogin xx;
        protected void Page_Load(object sender, EventArgs e)
        {
            xx = (CLLogin)Session["Usuario"];
            
            string sCnn = "Data Source=localhost;Initial Catalog=ropa;Integrated Security=True";
            string sSel = "DAO_leer_persona ';" + (xx.Usuario) + "'";
            SqlCommand cmd = new SqlCommand(sSel, sCnn);
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sSel, sCnn);
            da.Fill(dt);
            //de la fila , columna de la tabla obtenida
            txtRut.Value = dt.Rows[0][1].ToString();
            txtNombre.Value = dt.Rows[0][2].ToString();
            txtApP.Value = dt.Rows[0][3].ToString();
            txtApM.Value = dt.Rows[0][4].ToString();
            txtCorreo.Value = dt.Rows[0][5].ToString();
            txtTelefono.Value = dt.Rows[0][6].ToString();


            ////lblNombre.Text = xx.Usuario;
            //string comando = "DAO_leer_persona ';" + (xx.Usuario) + "'";
            //DataTable dt = BD_conexion.getInstance().mySQLSelect(comando);
            //txtRut.Value = dt.Rows[0][1].ToString();
            //txtNombre.Value = dt.Rows[0][2].ToString();
            //txtApP.Value = dt.Rows[0][3].ToString();
            //txtApM.Value = dt.Rows[0][4].ToString();
            //txtCorreo.Value = dt.Rows[0][5].ToString();
            //txtTelefono.Value = dt.Rows[0][6].ToString();
        }


    }
}