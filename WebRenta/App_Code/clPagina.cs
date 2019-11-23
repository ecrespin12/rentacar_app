using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.CSharp;
/// <summary>
/// Descripción breve de clPagina
/// </summary>
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
        //cnn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString);
        //cnn.Open();
    }

    private void CargarDatosUsuario()
    {
    }
}