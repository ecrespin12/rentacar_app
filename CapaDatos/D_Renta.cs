using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Renta
    {

        //obj para la conexion
        


        public static DataSet D_GetAutosDisponibles(E_Renta renta, DataGridView grid)
        {
           
            grid.Columns.Clear();

            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.HeaderText = "SELECCIONAR";
            check.Name = "insertar";
            check.Width = 60;

            grid.Columns.Add(check);
            grid.Columns[grid.Columns.Count - 1].DisplayIndex = 0;


            DataGridViewTextBoxColumn txtDias = new DataGridViewTextBoxColumn();
            txtDias.HeaderText = "DIAS";
            txtDias.Name = "diasRent";
            txtDias.Width = 60;

            grid.Columns.Add(txtDias);
            grid.Columns[grid.Columns.Count - 1].DisplayIndex = 1;

            DataGridViewTextBoxColumn txtTotal = new DataGridViewTextBoxColumn();
            txtTotal.HeaderText = "TOTAL";
            txtTotal.Name = "totalRent";
            txtTotal.Width = 60;
            txtTotal.ReadOnly = true;
        
            grid.Columns.Add(txtTotal);
            grid.Columns[grid.Columns.Count - 1].DisplayIndex = 2;




            DataSet ds = null;
            try
            {
                ds = new DataSet();
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);

                //Nomenclatura D= "DISPONIBLE" PARA LA RENTA
                SqlCommand cmd = new SqlCommand("SELECT Row_Number() Over (Order By aut_codigo) As [#], aut_codigo, mar_nombre, tia_nombre,col_nombre, aut_anio, aut_placa, aut_modelo FROM tbl_aut_auto INNER JOIN tbl_mar_marca ON aut_codmar = mar_codigo INNER JOIN tbl_col_color ON aut_codcol = col_codigo INNER JOIN tbl_tia_tipo_auto ON aut_codtia = tia_codigo WHERE aut_estado='D'", con);
                cmd.CommandTimeout = 600;
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@codigo", codigo);


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {
                throw;
            }


            return ds;
        }


        public static List<E_Conductor> ListaConductores()
        {
            List<E_Conductor> lista = new List<E_Conductor>();

            SqlDataReader dr;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select con_codigo, CONCAT(usr_nombre,' ', usr_apellido) as conductor from tbl_con_conductor  inner join tbl_usr_usuario on con_codusr = usr_codigo", con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            try
            {
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }


            var leer = dr;

            while (leer.Read())
            {
                E_Conductor conductor = new E_Conductor();
                conductor.CodigoConductor = leer.GetInt32(0);
                conductor.NombreConductor = leer.GetString(1);
                lista.Add(conductor);
            }

            return lista;
        }


        public DataSet D_GetTarifasAutos(int codigo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from tbl_tra_tarifa_renta_auto where tra_codaut=@codigo", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@codigo", codigo);


            DataSet ds = null;
            try
            {
                ds = new DataSet();

                cmd.CommandTimeout = 600;

                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {
                throw;
            }

            con.Close();
            return ds;
        }



        public static void D_InsertRenta(E_Renta rent, string codAuto)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("renta_insert_sp", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codUser", rent.CodigoUsuario);
            cmd.Parameters.AddWithValue("@codAut", rent.CodigoAuto);
            cmd.Parameters.AddWithValue("@deposito", rent.DepositoRenta);
            cmd.Parameters.AddWithValue("@fecha_inicio", rent.FechaInicioRenta);
            cmd.Parameters.AddWithValue("@fecha_fin", rent.FechaFinRenta);
            cmd.Parameters.AddWithValue("@codConductor", rent.CodigoConductor);
            cmd.Parameters.AddWithValue("@status", rent.Status);
            cmd.Parameters.AddWithValue("@tarifaID", rent.tarifaRenta);
            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();


            codAuto = rent.CodigoAuto.ToString();



            cmd.ExecuteNonQuery();
            con.Close();
        }

        










    }
}


