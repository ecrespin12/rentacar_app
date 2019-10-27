using System;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaPresentacion.admin
{
    public partial class frmReportePagos : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);

        public frmReportePagos()
        {
            InitializeComponent();
        }

        private void frmReportePagos_Load(object sender, EventArgs e)
        {
            String sql = " select * from tbl_pag_renta_detalle " +
                        " join tbl_par_pago_renta on par_codigo = pago_id" +
                         " join tbl_usr_usuario on usr_codigo = par_codusr";
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
