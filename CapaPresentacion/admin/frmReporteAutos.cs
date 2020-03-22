using System;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaPresentacion.admin
{
    public partial class frmReporteAutos : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);

        public frmReporteAutos()
        {
            InitializeComponent();
        }

        private void frmReporteAutos_Load(object sender, EventArgs e)
        {
            String sql = "select * from tbl_aut_auto " +
               " join tbl_col_color on aut_codcol = col_codigo" +
               " join tbl_mar_marca on aut_codmar = mar_codigo" +
               " join tbl_tia_tipo_auto on aut_codtia = tia_codigo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            this.reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.RefreshReport();
        }
    }
}
