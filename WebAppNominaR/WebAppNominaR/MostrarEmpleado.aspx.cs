using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNominaR
{
    public partial class MostrarEmpleado : System.Web.UI.Page
    {
        LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                LlenarDatos1();
            }

        }


        public void LlenarDatos1()
        {
            GridView1.DataSource = oLB.MostrarEmpleado();
            GridView1.DataBind();
          
        }

    
    }
}