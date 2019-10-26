using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.admin
{
    public partial class frmTipoAuto : frmTemplate
    {
        public frmTipoAuto()
        {
            InitializeComponent();
        }

        DataTable dt;
        E_Tipo_Auto e_Tipo_Auto = new E_Tipo_Auto();
        N_Tipo_Auto n_Tipo_Auto = new N_Tipo_Auto();

        void ListTipoAuto()
        {
            //dgvListMarcas.AutoGenerateColumns = false;

            dt = n_Tipo_Auto.N_ListTipoAuto();
            dgv_template.DataSource = dt;



            dgv_template.Columns[0].HeaderText = "Editar";
            dgv_template.Columns[1].HeaderText = "Eliminar";

            dgv_template.Columns[2].HeaderText = "Codigo";
            dgv_template.Columns[2].Name = "codigo";

            dgv_template.Columns[3].HeaderText = "Nombre";
            dgv_template.Columns[3].Name = "nombres";

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;
            dgv_template.Columns["editar"].DisplayIndex = 2;
            dgv_template.Columns["eliminar"].DisplayIndex = 3;

            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmTipoAuto_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;

            ListTipoAuto();
        }
    }
}
