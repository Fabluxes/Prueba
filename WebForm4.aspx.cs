using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationS2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private int conteo=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtContador.Text = "0";
            }

            if (Session["click"] != null)
            {
                txtContador.Text = ((int)Session["click"]).ToString();
            }
        }

  

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["click"] != null)
            {
                conteo = (int)Session["click"] + 1;
            }

            txtContador.Text = conteo.ToString();

            Session["click"] = conteo;


            /*
            conteo++;
            txtContador.Text = conteo.ToString();

            */
        }
    }
}