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
    public class DataHelper<T>
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);
        public void ExecuteProcedure(string procedureName, IDictionary<string, object> parameters) {
            SqlCommand cmd = new SqlCommand(procedureName, con);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (var item in parameters)
            {
                cmd.Parameters.AddWithValue("@"+item.Key, item.Value);
            }
            if (con.State == ConnectionState.Open)
                con.Close();

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable getAll(string query) {

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataSet getEntity(string query, IDictionary<string, object> parameters)
        {

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            foreach (var item in parameters)
            {
                cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
            }

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
