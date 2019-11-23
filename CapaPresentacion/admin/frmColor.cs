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
    public partial class frmColor : frmTemplate
    {
        public frmColor()
        {
            InitializeComponent();
        }

        DataTable dt;
        E_Color entColor = new E_Color();
        N_Color negColor = new N_Color();

        void ListColores()
        {
            //dgvListMarcas.AutoGenerateColumns = false;

            dt = negColor.N_ListColor();
            dgv_template.DataSource = dt;



            dgv_template.Columns[0].HeaderText = "Editar";
            dgv_template.Columns[1].HeaderText = "Eliminar";

            dgv_template.Columns[2].HeaderText = "Codigo";
            dgv_template.Columns[2].Name = "codigo";

            dgv_template.Columns[3].HeaderText = "Nombres";
            dgv_template.Columns[3].Name = "nombres";

            dgv_template.Columns[4].HeaderText = "Hexadecimal";
            dgv_template.Columns[4].Name = "hexadecimal";

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;
            dgv_template.Columns[4].DisplayIndex = 2;

            dgv_template.Columns["editar"].DisplayIndex = 3;
            dgv_template.Columns["eliminar"].DisplayIndex = 4;

            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmColor2_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            ListColores();
        }
    }
}
