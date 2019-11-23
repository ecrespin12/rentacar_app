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
    public class D_Tipo_Auto
    {
        //obj para la conexion
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);



        public DataTable D_ListTipoAuto()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_tia_tipo_auto", con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void D_InsertTipoAuto(E_Tipo_Auto instancia)
        {
            SqlCommand cmd = new SqlCommand("tipo_auto_insert_sp", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", instancia.nombre);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void D_ActualizarTipoAuto(E_Tipo_Auto instancia)
        {
            SqlCommand cmd = new SqlCommand("tipo_auto_actualizar_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", instancia.nombre);
            cmd.Parameters.AddWithValue("@id", instancia.codigo);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void D_EliminarTipoAuto(E_Tipo_Auto instancia)
        {
            SqlCommand cmd = new SqlCommand("tipo_auto_eliminar_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", instancia.codigo);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet D_GetTipoAuto(int codigo)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_tia_tipo_auto WHERE tia_codigo = @codigo", con);
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
