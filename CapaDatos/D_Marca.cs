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
    public class D_Marca
    {
        //obj para la conexion
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);



        public DataTable D_ListMarcas()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_mar_marca", con);
            cmd.CommandType = CommandType.Text;
   
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void D_InsertMarca(E_Marca mar)
        {
            SqlCommand cmd = new SqlCommand("marca_insert_sp", con);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", mar.NombreMarca);
            cmd.Parameters.AddWithValue("@estatus", mar.Estatus);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void D_ActualizarMarca(E_Marca mar)
        {
            SqlCommand cmd = new SqlCommand("marca_actualizar_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", mar.NombreMarca);
            cmd.Parameters.AddWithValue("@estatus", mar.Estatus);
            cmd.Parameters.AddWithValue("@id", mar.MarcaID);

            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet D_GetMarca(int codigo)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_mar_marca WHERE mar_codigo = @codigo", con);
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
