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
    public partial class frmMarca2 : frmTemplate
    {
        public frmMarca2()
        {
            InitializeComponent();
        }

        E_Marca entMarca = new E_Marca();
        N_Marca negMarca = new N_Marca();

        void ListMarcas()
        {
            //dgvListMarcas.AutoGenerateColumns = false;

            DataTable dt = negMarca.N_ListMarcas();
            dgv_template.DataSource = dt;



            dgv_template.Columns[0].HeaderText = "Editar";
            dgv_template.Columns[1].HeaderText = "Eliminar";
            dgv_template.Columns[2].HeaderText = "Codigo";
            dgv_template.Columns[3].HeaderText = "Nombres";

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;
            dgv_template.Columns["editar"].DisplayIndex = 2;
            dgv_template.Columns["eliminar"].DisplayIndex = 3;

            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmMarca2_Load(object sender, EventArgs e)
        {
            ListMarcas();
        }
    }
}
