using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LayerData
{
    public class LayerDATAEmpleado
    {
        public string strconn = @"Data Source=nominaricardo.database.windows.net;Initial Catalog=NominaRi;User ID=BDRicar;Password=Siis2016";

        public LayerDATAEmpleado() { }

        public int InsertarEmpleado(Int64 Id, string Apellidos, string Nombres, double Horas, double Sueldo)
        {

            using (SqlConnection cnx = new SqlConnection(strconn))

            {
                cnx.Open();
                SqlCommand OrderSql = new SqlCommand("SpInsertarEmpleado", cnx);
                OrderSql.CommandType = CommandType.StoredProcedure;
                try
                {
                    OrderSql.Parameters.AddWithValue("@Id", Id);
                    OrderSql.Parameters.AddWithValue("@Apellidos", Apellidos);
                    OrderSql.Parameters.AddWithValue("@Nombres", Nombres);
                    OrderSql.Parameters.AddWithValue("@HorasTrabajadas", Horas);
                    OrderSql.Parameters.AddWithValue("@SueldoXHora", Sueldo);
                    return OrderSql.ExecuteNonQuery();
                }

                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    OrderSql.Dispose();


                }




            }

        }

        public DataTable MostrarEmpleados()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter dAd = new SqlDataAdapter("SpMostrarEmpleados", cnx);
                dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();

                try
                {
                    dAd.Fill(ds, "Table");
                    return ds.Tables["Table"];
                }

                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    dAd.Dispose();
                    ds.Dispose();
                }
            }

        }


        public int EditarEmpleado(Int64 Id, string Apellidos, string Nombres, double Horas, double Sueldo)
        {

            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand OrderSql = new SqlCommand("SpEditarEmpleado", cnx);
                OrderSql.CommandType = CommandType.StoredProcedure;
                try
                {


                    OrderSql.Parameters.AddWithValue("@Id", Id);
                    OrderSql.Parameters.AddWithValue("@Apellidos", Apellidos);
                    OrderSql.Parameters.AddWithValue("@Nombres", Nombres);
                    OrderSql.Parameters.AddWithValue("@HorasTrabajadas", Horas);
                    OrderSql.Parameters.AddWithValue("@SueldoXHora", Sueldo);
                    return OrderSql.ExecuteNonQuery();




                }

                catch (Exception)
                {

                    throw;

                }
                finally
                {

                    cnx.Close();
                    cnx.Dispose();
                    OrderSql.Dispose();

                }








            }






        }


        public int EliminarEmpleado(Int64 Id)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand OrderSql = new SqlCommand("SpEliminarEmpleado", cnx);
                OrderSql.CommandType = CommandType.StoredProcedure;
                try

                {
                    OrderSql.Parameters.AddWithValue("@Id", Id);
                    return OrderSql.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw;

                }

                finally
                {

                    cnx.Close();
                    cnx.Dispose();
                    OrderSql.Dispose();


                }


            }

        }



        public DataTable CalcularSalario()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter dAd = new SqlDataAdapter("SpCalcularSalario", cnx);
                dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();

                try
                {
                    dAd.Fill(ds, "TableEmp");
                    return ds.Tables["TableEmp"];
                }

                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    dAd.Dispose();
                    ds.Dispose();
                }
            }

        }


        public DataTable CalcularSalarioTotal()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter dAd = new SqlDataAdapter("SpCalcularSalarioTotal", cnx);
                dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();

                try
                {
                    dAd.Fill(ds, "TableEmpTotal");
                    return ds.Tables["TableEmpTotal"];
                }

                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    dAd.Dispose();
                    ds.Dispose();
                }
            }

        }

    }


}


    




