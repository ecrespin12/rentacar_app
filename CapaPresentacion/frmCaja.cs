using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
        }
        DataTable dtR;
        DataTable dtP;
        E_Pagos entPagos = new E_Pagos();
        N_Pagos negPagos = new N_Pagos();

        void ListPagos(string estado)
        {
            //dgvListMarcas.AutoGenerateColumns = false;
            if (!String.IsNullOrEmpty(estado))
            {
                dtP = negPagos.N_List(estado);
            }
            else
            {
                dtP = negPagos.N_List();
            }

            dgvPagos.DataSource = dtP;
            dgvPagos.Refresh();

            dgvPagos.Columns[0].HeaderText = "Abonar";
            //dgv_template.Columns[1].HeaderText = "Eliminar";

            dgvPagos.Columns[1].HeaderText = "Codigo";
            dgvPagos.Columns[1].Name = "codigo";

            dgvPagos.Columns[2].HeaderText = "Usuario";
            dgvPagos.Columns[2].Name = "usuario";

            dgvPagos.Columns[3].HeaderText = "Forma Pago";
            dgvPagos.Columns[3].Name = "formaPago";

            dgvPagos.Columns[4].HeaderText = "Monto";
            dgvPagos.Columns[4].Name = "monto";

            dgvPagos.Columns[5].HeaderText = "Fecha Pago";
            dgvPagos.Columns[5].Name = "fechapago";

            dgvPagos.Columns[6].HeaderText = "Estado";
            dgvPagos.Columns[6].Name = "estado";

            dgvPagos.Columns[1].DisplayIndex = 0;
            dgvPagos.Columns[2].DisplayIndex = 1;
            dgvPagos.Columns[3].DisplayIndex = 2;
            dgvPagos.Columns[4].DisplayIndex = 3;
            dgvPagos.Columns[5].DisplayIndex = 4;
            dgvPagos.Columns[6].DisplayIndex = 5;

            dgvPagos.Columns["Abonar"].DisplayIndex = 6;
            //dgv_template.Columns["eliminar"].DisplayIndex = 6;

            dgvPagos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void ListRentas()
        {
            dtR = negPagos.N_Rentas();

            dgvRenta.DataSource = dtR;
            dgvRenta.Refresh();

            dgvRenta.Columns[0].HeaderText = "Cobrar";
            //dgv_template.Columns[1].HeaderText = "Eliminar";

            dgvRenta.Columns[1].HeaderText = "Cliente";
            dgvRenta.Columns[1].Name = "cliente";

            dgvRenta.Columns[2].HeaderText = "Auto";
            dgvRenta.Columns[2].Name = "auto";

            dgvRenta.Columns[3].HeaderText = "Desde";
            dgvRenta.Columns[3].Name = "desde";

            dgvRenta.Columns[4].HeaderText = "Hasta";
            dgvRenta.Columns[4].Name = "hasta";

            dgvRenta.Columns[1].DisplayIndex = 0;
            dgvRenta.Columns[2].DisplayIndex = 1;
            dgvRenta.Columns[3].DisplayIndex = 2;
            dgvRenta.Columns[4].DisplayIndex = 3;

            dgvRenta.Columns["cobrar"].DisplayIndex = 4;
            //dgv_template.Columns["eliminar"].DisplayIndex = 6;

            dgvRenta.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            ListPagos(null);
            ListRentas();
        }
    }
}
