using System;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaPresentacion.admin
{
    public partial class frmReporteUsuarios : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConexion"].ConnectionString);

        public frmReporteUsuarios()
        {
            InitializeComponent();
        }

        private void frmReporteUsuarios_Load(object sender, EventArgs e)
        {
            String sql = "select * from tbl_usr_usuario " +
               " join tbl_rou_rol_usuario on rou_codusr = usr_codigo" +
               " join tbl_rol_roles on rou_codrol = rol_id ";
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
