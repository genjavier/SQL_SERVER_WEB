using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.conexion;

namespace sitio_web.PG.PG_No_Logeada
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar(object sender, EventArgs e)
        {
            string rut = txtRut.Value;
            string nombre = txtNombre.Value;
            string apP = txtApPaterno.Value;
            string apM = txtApMaterno.Value;
            string correo = txtCorreo.Value;
            string telefono = txtTelefono.Value;
            string clave = txtClave.Value;
            string clave_2 = txtClave2.Value;

            if (clave == clave_2)
            {
                BD_conexion.getInstance().sqlPkgDec("NEG_crear_usuario");
                BD_conexion.getInstance().sqlPkgParIn("rut", rut);
                BD_conexion.getInstance().sqlPkgParIn("nombre", nombre);
                BD_conexion.getInstance().sqlPkgParIn("apellido_paterno", apP);
                BD_conexion.getInstance().sqlPkgParIn("apellido_materno", apM);
                BD_conexion.getInstance().sqlPkgParIn("correo", correo);
                BD_conexion.getInstance().sqlPkgParIn("telefono", telefono);
                BD_conexion.getInstance().sqlPkgParIn("usuario", rut);
                BD_conexion.getInstance().sqlPkgParIn("clave", clave);
                BD_conexion.getInstance().ParnOutString("@resultado", 255);
                ConeccionReturn rt = BD_conexion.getInstance().sqlPkgExe();
                Response.Write(rt.code);
            }
            else
            {
                Response.Write("<script>alert('Las contraseñas deven considir')</script>");
            }


        }
    }
}