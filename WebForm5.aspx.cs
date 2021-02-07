using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationS2
{
    public partial class WebForm5 : System.Web.UI.Page
    {
  
        protected void bPostBack_Click(object sender, EventArgs e)
        {
            txtPostBack.Text = ("OcurrioPostBack");
            Response.Write("Orcurre el evento PostBack");

        }

        protected void TbCACHE_TextChanged(object sender, EventArgs e)
        {
            TbCACHE.Text = "Ocurrio el CACHED";
            Response.Write("OCURRIO EL EVENTO CACHED<br/>");

        }

        protected void Page_PreInit(object sender, EventArgs e)
        {

            Response.Write("1) PreInit <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {

            Response.Write("2) Init <br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {

            Response.Write("3) InitComplete <br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {

            Response.Write("4) PreLoad <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("5) Load <br/>");

        }
        protected void Page_LoadCompletet(object sender, EventArgs e)
        {

            Response.Write("6) LoadComplete <br/>");
        }


        protected void Page_PreRender(object sender, EventArgs e)
        {

            Response.Write("7) PreRender <br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {

            Response.Write("8) PreRenderComplete <br/>");
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            // Response.Write("9) PageUnLoad <br/>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}