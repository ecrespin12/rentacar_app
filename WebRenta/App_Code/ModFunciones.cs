using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Descripción breve de ModFunciones
/// </summary>
public class ModFunciones
{
    public ModFunciones()
    { }

         public IList<clVistaUsuario> getListaUsuarios(System.Data.SqlClient.SqlConnection cnn)
    {
        string sql = "SELECT  usr_codigo,usr_nombre ,usr_apellido ,usr_correo ,usr_clave ,rou_codrol ,rol_nombre" +
                        " FROM tbl_usr_usuario join tbl_rou_rol_usuario on usr_codigo = rou_codusr" +
                        " join tbl_rol_roles on rol_id = rou_codrol";

        SqlCommand cmd = new SqlCommand(sql, cnn);
        cmd.CommandType = CommandType.Text;

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return GetListByDataTable(dt);
    }

    private List<clVistaUsuario> GetListByDataTable(DataTable dt)
    {

        var convertedList = (from rw in dt.AsEnumerable()
                             select new clVistaUsuario()
                             {
                                 dbusr_codigo = Convert.ToInt32(rw["usr_codigo"]),
                                 dbusr_nombre = Convert.ToString(rw["usr_nombre"]),
                                 dbusr_apellido = Convert.ToString(rw["usr_apellido"]),
                                 dbusr_correo = Convert.ToString(rw["usr_correo"]),
                                 dbusr_clave = Convert.ToString(rw["usr_nombre"]),
                                 dbrou_codrol = Convert.ToInt32(rw["rou_codrol"]),
                                 dbrol_nombre = Convert.ToString(rw["rol_nombre"]),
                             }).ToList();

        return convertedList;
    }

}



       


