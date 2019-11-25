using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.CSharp;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Descripción breve de clPagina
public class clPagina : System.Web.UI.Page

{

    protected System.Data.SqlClient.SqlConnection cnn;
    protected string _NombreUsuario;
    protected string _TipoUsuario;
    protected int _CodigoUsuario;


    public clPagina()
    {

    }
    private void Page_PreInit(object sender, System.EventArgs e)
    {

        cnn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        cnn.Open();
    }


    public String ValidarCredenciales(String correo,String clave)
    {
        string sql = "SELECT  usr_codigo,usr_nombre ,usr_apellido ,usr_correo ,usr_clave ,rou_codrol ,rol_nombre" +
                        " FROM tbl_usr_usuario join tbl_rou_rol_usuario on usr_codigo = rou_codusr" +
                        " join tbl_rol_roles on rol_id = rou_codrol where  (rou_codrol = 2 or rou_codrol = 5) and usr_correo = '" + correo + "' and usr_clave = '" + clave + "'";

        SqlCommand cmd = new SqlCommand(sql, cnn);
        cmd.CommandType = CommandType.Text;

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        List<clVistaUsuario> lista = GetListByDataTable(dt);
        if (lista.Count > 0)
        {

            Loguear(lista.FirstOrDefault());
            return "Bienvenid@ "+ lista.FirstOrDefault().dbrol_nombre;
        }
        else
        {
            return "";
        }
    }
    private void Loguear(clVistaUsuario objusr)
    {
        _NombreUsuario = objusr.dbusr_nombre + " " + objusr.dbusr_apellido;
        _CodigoUsuario = objusr.dbusr_codigo;
        _TipoUsuario = "admin";
        Session["usuario"] = _NombreUsuario;
        Session["usrcod"] = _CodigoUsuario;
        Session["usrtip"] = _TipoUsuario;

    }
    public void DesLoguear()
    {
        _NombreUsuario =  "";
        _CodigoUsuario = 0;
        _TipoUsuario = "";
        Session.Abandon();

    }
    public IList<clVistaUsuario> getListaUsuarios()
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