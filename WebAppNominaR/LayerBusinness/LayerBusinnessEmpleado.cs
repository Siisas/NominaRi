using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LayerBusinness
{
   public class LayerBusinnessEmpleado
    {
        LayerData.LayerDATAEmpleado DAle = new LayerData.LayerDATAEmpleado();

        public int InsertarEmpleado(Int64 Id, string Apellidos, string Nombres, double Horas, double Sueldo)
        {
            try
            {
                return DAle.InsertarEmpleado(Id, Apellidos, Nombres, Horas, Sueldo);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DAle = null;
            }


        }

        

        public DataTable MostrarEmpleado()
        {
            try
            {
                return DAle.MostrarEmpleados();
            }

            catch(Exception)
            {
                throw;

            }


            finally
            {

                DAle = null;
            }
        }


        public int EditarEmpleado(Int64 Id, string Apellidos, string Nombres, double Horas, double Sueldo)


        {

            try {

                return DAle.EditarEmpleado(Id, Apellidos, Nombres, Horas, Sueldo);

            }
            catch (Exception)

            {
                throw;

            }
            finally
            {
                DAle = null;

            }




        }


        public int EliminarEmpleado(Int64 Id)

        {


            try
            {

                return DAle.EliminarEmpleado(Id);

            }

            catch
            {

                throw;
            }

            finally
            {

                DAle = null;
            }

        }
        // copiar mostrar empleado
        public DataTable CalcularSalario()
        {
            try
            {
                return DAle.CalcularSalario();
            }

            catch (Exception)
            {
                throw;

            }


            finally
            {

                DAle = null;
            }
        }

        public DataTable CalcularSalarioTotal()
        {
            try
            {
                return DAle.CalcularSalarioTotal();
            }

            catch (Exception)
            {
                throw;

            }


            finally
            {

                DAle = null;
            }
        }




    }
}
