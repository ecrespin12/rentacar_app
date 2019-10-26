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
    public partial class frmMarca : frmTemplate
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        E_Marca entMarca = new E_Marca();
        N_Marca negMarca = new N_Marca();

        //metodos

        void InsertMarca() {

            try{

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtNombre.Text)) {
                    epMarca.SetError(txtNombre, "Debe ingresar un nombre de marca");
                    txtNombre.Focus();
                    return;
                }
                epMarca.SetError(txtNombre, "");

                entMarca.NombreMarca = txtNombre.Text.Trim();
                negMarca.InsertMarca(entMarca);
                MessageBox.Show("Marca regristrada correctamente");

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


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

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;

            ListMarcas();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
        
        }

        private void BtnAccionModal_Click(object sender, EventArgs e)
        {
            InsertMarca();
        }

        private void BtnNuevo_template_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = true;
        }

        private void BtnCloseModal_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            ListMarcas();
        }
    }
}
