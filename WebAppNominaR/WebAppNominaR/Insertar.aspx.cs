using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNominaR
{
    public partial class Insertar : System.Web.UI.Page
    {
        LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;

            }
            else
            {

                try
                {
                    oLB.InsertarEmpleado(Convert.ToInt64(TxtId.Text), TxtApellidos.Text,TxtNombres.Text,Convert.ToDouble(TxtHoras.Text),Convert.ToDouble(TxtSueldo.Text));
                    LblMsg.Text = "Empleado Insertado";

                }
                catch(Exception exc)
                {
                    LblMsg.Text = exc.Message.ToString();

                }
                finally
                {
                    oLB = null;
                }
            }
        }
    }
}