using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationS2.Modelo;

namespace WebApplicationS2
{
    public partial class BuscarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            int carnet = Convert.ToInt32(txtCarnet.Text);
            int carnetID = ModeloAlumno.BuscarAlumno(carnet);

            if (carnetID == 0)
            {
                Response.Write("<script>alert(" + "'El alumno no existe'" + ")</script>");

            }
            else {
                Response.Write("<script>alert(" + "'El alumno fue encontrado'" + ")</script>");
            }

        }


        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            PrograAvanzaBdEntities db = new PrograAvanzaBdEntities();
            ALUMNO a = new ALUMNO();
            a.Carnet = Convert.ToInt32(txtCarnet.Text);
            a.Nombre = txtNombre.Text;
            db.ALUMNO.Add(a);
            db.SaveChanges();


        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}