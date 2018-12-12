using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitio_web.PG.PG_sot
{
    public partial class PG_color : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string color = TextBox2.Text;
            //string id = TextBox2.Text;
            //int x;
            //int.TryParse(id, out x);
            Biblioteca.ENT.Colors cl = new Biblioteca.ENT.Colors(color);

            //Biblioteca.NEG.NEGSala.Neg_insert_Sala(sl);
            Biblioteca.NEG.NEGColor.Neg_insert_Color(cl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string color = TextBox2.Text;//n
            //string nombre = TextBox1.Text;//ca
            string id = TextBox1.Text;//id
            int a;
            int.TryParse(id, out a);
            Biblioteca.ENT.Colors sl = new Biblioteca.ENT.Colors(color, a);

            Biblioteca.NEG.NEGColor.Neg_upta_Color(sl);
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            string id = TextBox1.Text;
            string color = TextBox2.Text;
            int x;
            int.TryParse(id, out x);
            Biblioteca.ENT.Colors sl = new Biblioteca.ENT.Colors(color, x);
            Biblioteca.NEG.NEGColor.Neg_Eliminar_Color(sl);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click1(object sender, EventArgs e)
        {

        }
    }
}