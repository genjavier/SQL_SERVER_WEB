using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sitio_web.Models
{
    public class CLLogin
    {
        public int Usuario { get; set; }
        public String Clave { get; set; }

        public CLLogin(int usuario, String clave)
        {
            Usuario = usuario;
            Clave = clave;

        }

    }
}