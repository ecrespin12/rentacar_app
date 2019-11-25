using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class wfReporteAutos : clPagina
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

        String sql = "select * from tbl_aut_auto " +
              " join tbl_col_color on aut_codcol = col_codigo" +
              " join tbl_mar_marca on aut_codmar = mar_codigo" +
              " join tbl_tia_tipo_auto on aut_codtia = tia_codigo";
        SqlCommand cmd = new SqlCommand(sql, cnn);
        cmd.CommandType = CommandType.Text;

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

       Microsoft.Reporting.WebForms.ReportDataSource rds = new Microsoft.Reporting.WebForms.ReportDataSource();
       rds.Name = "DataSet1";
       rds.Value = dt;

        ReportViewer1.LocalReport.DataSources.Add(rds);
        }

    }
}