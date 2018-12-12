using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.conexion;


namespace sitio_web.PG.PG_No_Logeada
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_(object sender, EventArgs e)
        {
            string rut = txtRut.Value;            
            string clave = txtClave.Value;

            
                BD_conexion.getInstance().sqlPkgDec("DAO_leer_usuario");
                BD_conexion.getInstance().sqlPkgParIn("rut", rut);                
                BD_conexion.getInstance().sqlPkgParIn("clave", clave);
                BD_conexion.getInstance().ParnOutString("@resultado", 255);
                ConeccionReturn rt = BD_conexion.getInstance().sqlPkgExe();
             
            if (rt.code == "1")
            {
                Response.Redirect("PG/PG_logeadas/PG_perfil.aspx");
            }
            else
            {
                Response.Write("<script>alert('usuario o contraseña incorrecto')</script>");
            }
            






        }
    }
}