using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationS2
{
    public partial class _Default : Page
    {
        private int conteo = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TxtContador.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Button1_Click"] != null)
            {
                conteo = (int)ViewState["Button1_Click"] + 1;
            }
           

            /*conteo++;*/
           TxtContador.Text = conteo.ToString();
            ViewState["Button1_Click"] = conteo;
        }
    }



}