using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wfUsuarios: clPagina
{
    protected void Page_Load(object sender, EventArgs e)
    {
        llenarRpt();
    }
    private void llenarRpt()
    {
        rptClientes.DataSource = getListaUsuarios();
        rptClientes.DataBind();
    }

    protected void rptClientes_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblcodigo = (Label)e.Item.FindControl("lblcodigo");
            Label lblNombre = (Label)e.Item.FindControl("lblNombre");
            Label lblApellido = (Label)e.Item.FindControl("lblApellido");
            Label lblRol = (Label)e.Item.FindControl("lblRol");
            Label lblCorreo = (Label)e.Item.FindControl("lblCorreo");

            clVistaUsuario Objlista = (clVistaUsuario)e.Item.DataItem;

            lblcodigo.Text = Objlista.dbusr_codigo.ToString();
            lblNombre.Text = Objlista.dbusr_nombre;
            lblApellido.Text = Objlista.dbusr_apellido;
            lblRol.Text = Objlista.dbrol_nombre;
            lblCorreo.Text = Objlista.dbusr_correo;


        }
    }
}