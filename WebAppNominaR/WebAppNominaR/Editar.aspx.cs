using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNominaR
{
    public partial class Editar : System.Web.UI.Page
    {

        LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)

            {
                LlenarDatos();
            }

        }

        public void LlenarDatos()
        {

            GridView1.DataSource = oLB.MostrarEmpleado();
            GridView1.DataBind();

        }

        //en el rayito eventos le doy en row cancel editing
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            GridView1.EditIndex = -1;
            LlenarDatos();

        }


        // en el rayito le doy doble click en el evento que se llama RowEditing
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LlenarDatos();


        }

        // en el rayito le doy doble click en el evento que se llama rowUpdating
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {


            LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();
            Int64 ID = Convert.ToInt64(GridView1.DataKeys[e.RowIndex].Value.ToString());

            int result = 0;

            GridViewRow row = GridView1.Rows[e.RowIndex];
            TextBox TA = (TextBox)row.FindControl("TxtApellidos");
            TextBox TN = (TextBox)row.FindControl("TxtNombres");
            TextBox TH = (TextBox)row.FindControl("TxtHoras");
            TextBox TS = (TextBox)row.FindControl("TxtSueldo");


            try
            {
                result = oLB.EditarEmpleado(ID, TA.Text, TN.Text, Convert.ToDouble(TH.Text), Convert.ToDouble(TS.Text));
                if (result > 0)
                {

                    LblMsg.Text = "Empleado Editado";

                }

                else
                {

                    LblMsg.Text = "Empleado NO Editado";

                }
            }
            catch (Exception exc)
            {
                LblMsg.Text = exc.Message.ToString();

            }
            finally
            {
                oLB = null;

            }

            GridView1.EditIndex = -1;
            LlenarDatos();
        }
    }
}