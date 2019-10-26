using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



            DataSet ds = null;
            try
            {
                ds = new DataSet();
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);

                //Nomenclatura D= "DISPONIBLE" PARA LA RENTA
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_aut_auto INNER JOIN tbl_mar_marca ON aut_codmar = mar_codigo INNER JOIN tbl_col_color ON aut_codcol = col_codigo INNER JOIN tbl_tia_tipo_auto ON aut_codtia = tia_codigo WHERE aut_estado='D'", con);
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
    }
}


