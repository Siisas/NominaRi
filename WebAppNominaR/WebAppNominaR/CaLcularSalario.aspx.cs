using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNominaR
{
    public partial class CaLcularSalario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LLenarDatos();
            }
        }

            public void LLenarDatos()

        {

            LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();
            GridView1.DataSource = oLB.CalcularSalario();
            GridView1.DataBind();
        }

        }
    }
