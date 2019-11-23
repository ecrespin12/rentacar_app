using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Auto
    {
        //obj para la conexion
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);



        public DataTable D_ListAuto()
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT au.aut_codigo,ma.mar_nombre,co.col_nombre,ti.tia_nombre,au.aut_codmar,au.aut_codcol,au.aut_codtia,au.aut_modelo,au.aut_anio,au.aut_placa,au.aut_estado " +
                "FROM tbl_aut_auto as au, tbl_mar_marca as ma, tbl_col_color as co, tbl_tia_tipo_auto as ti "+
                "where au.aut_codmar = ma.mar_codigo and au.aut_codcol = co.col_codigo and au.aut_codtia = ti.tia_codigo"
                , con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void D_InsertAuto(E_Auto instancia)
        {
            SqlCommand cmd = new SqlCommand("auto_insert_sp", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", instancia.estado);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void D_ActualizarAuto(E_Auto instancia)
        {
            SqlCommand cmd = new SqlCommand("auto_actualizar_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", instancia.estado);
            cmd.Parameters.AddWithValue("@id", instancia.codAuto);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void D_EliminarAuto(E_Auto instancia)
        {
            SqlCommand cmd = new SqlCommand("auto_eliminar_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", instancia.codAuto);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet D_GetAuto(int codigo)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_aut_auto WHERE tia_codigo = @codigo", con);
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


    }
}
