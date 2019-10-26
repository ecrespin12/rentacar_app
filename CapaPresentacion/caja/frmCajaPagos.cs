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

namespace CapaPresentacion.caja
{
    public partial class frmCajaPagos : frmPagos
    {
        public frmCajaPagos()
        {
            InitializeComponent();
        }

        DataTable dt;
        E_Pagos entPagos = new E_Pagos();
        N_Pagos negPagos = new N_Pagos();

        void ListPagos(string estado)
        {
            //dgvListMarcas.AutoGenerateColumns = false;
            if (!String.IsNullOrEmpty(estado))
            {
                dt = negPagos.N_List(estado);
            }
            else
            {
                dt = negPagos.N_List();
            }
            
            dgv_template.DataSource = dt;
            dgv_template.Refresh();

            dgv_template.Columns[0].HeaderText = "Abonar";
            //dgv_template.Columns[1].HeaderText = "Eliminar";

            dgv_template.Columns[1].HeaderText = "Codigo";
            dgv_template.Columns[1].Name = "codigo";

            dgv_template.Columns[2].HeaderText = "Usuario";
            dgv_template.Columns[2].Name = "usuario";

            dgv_template.Columns[3].HeaderText = "Forma Pago";
            dgv_template.Columns[3].Name = "formaPago";

            dgv_template.Columns[4].HeaderText = "Monto";
            dgv_template.Columns[4].Name = "monto";

            dgv_template.Columns[5].HeaderText = "Fecha Pago";
            dgv_template.Columns[5].Name = "fechapago";

            dgv_template.Columns[6].HeaderText = "Estado";
            dgv_template.Columns[6].Name = "estado";

            dgv_template.Columns[1].DisplayIndex = 0;
            dgv_template.Columns[2].DisplayIndex = 1;
            dgv_template.Columns[3].DisplayIndex = 2;
            dgv_template.Columns[4].DisplayIndex = 3;
            dgv_template.Columns[5].DisplayIndex = 4;
            dgv_template.Columns[6].DisplayIndex = 5;

            dgv_template.Columns["abonar"].DisplayIndex = 6;
            //dgv_template.Columns["eliminar"].DisplayIndex = 6;

            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void frmCajaPagos_Load(object sender, EventArgs e)
        {
            lblTitle_template.Text = "Módulo Pagos";
            cargarCombo();
            ListPagos(null);
        }

        private void cargarCombo()
        {
            List<codigoNombre> codigoNombres = new List<codigoNombre>();
            codigoNombres.Add(new codigoNombre { Codigo = "A", Nombre = "Pendientes de Pago" });
            codigoNombres.Add(new codigoNombre { Codigo = "C", Nombre = "Cancelados" });
            codigoNombres.Add(new codigoNombre { Codigo = "N", Nombre = "Anulados" });
            comboBox2.DataSource = codigoNombres;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Codigo";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = (codigoNombre)comboBox2.SelectedItem;            
            ListPagos(select.Codigo);
        }
    }
}
class codigoNombre
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
}
