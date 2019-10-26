using System;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaPresentacion.admin
{
    public partial class frmReporteRentas : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);

        public frmReporteRentas()
        {
            InitializeComponent();
        }

        private void frmReporteRentas_Load(object sender, EventArgs e)
        {
            String sql = "select * from tbl_aut_auto " +
                         " join tbl_col_color on aut_codcol = col_codigo" +
                         " join tbl_mar_marca on aut_codmar = mar_codigo" +
                         " join tbl_tia_tipo_auto on aut_codtia = tia_codigo" +
                         " join tbl_rea_renta_auto on rea_codaut = aut_codigo" +
                         " join tbl_usr_usuario on rea_codusr = usr_codigo";
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
