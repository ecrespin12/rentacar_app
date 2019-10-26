using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Pagos
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);

        public DataTable D_List()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_par_pago_renta", con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_List(string estado)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_par_pago_renta WHERE par_estado = @est", con);
            cmd.Parameters.Add("est", SqlDbType.VarChar, 1).Value = estado;
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
