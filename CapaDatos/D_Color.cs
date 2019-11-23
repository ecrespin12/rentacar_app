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
   public class D_Color
    {
        //obj para la conexion
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);

        public DataTable D_ListColor()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_col_color", con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void D_InsertColor(E_Color instancia)
        {
            SqlCommand cmd = new SqlCommand("color_insert_sp", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", instancia.NombreColor);
            cmd.Parameters.AddWithValue("@codhex", instancia.Hexadecimal);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void D_ActualizarColor(E_Color instancia)
        {
            SqlCommand cmd = new SqlCommand("color_actualizar_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", instancia.Codigo);
            cmd.Parameters.AddWithValue("@nombre", instancia.NombreColor);
            cmd.Parameters.AddWithValue("@hexadecimal", instancia.Hexadecimal);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void D_EliminarColor(E_Color instancia)
        {
            SqlCommand cmd = new SqlCommand("color_eliminar_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", instancia.Codigo);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet D_GetColor(int codigo)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_col_color WHERE col_codigo = @codigo", con);
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
