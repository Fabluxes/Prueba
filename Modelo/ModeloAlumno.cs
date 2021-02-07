using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationS2.Modelo
{
    public class ModeloAlumno
    {
        /*Linq y Lamba*/
        public static int BuscarAlumno(int carnet)
        {
            int carnedid = 0;
            PrograAvanzaBdEntities contexto = new PrograAvanzaBdEntities();
            var query1 = from x in contexto.ALUMNO
                         where x.Carnet == carnet
                         select x;
            var query2 = contexto.ALUMNO.Where(p => p.Carnet == carnet);
            if (query1.Count() > 0)
                carnedid = query1.First().Carnet;
            return carnedid;
        }
    }
}