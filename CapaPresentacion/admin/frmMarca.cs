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

        DataTable dt;
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
    
            dt = negMarca.N_ListMarcas();
            dgv_template.DataSource = dt;

         

            dgv_template.Columns[0].HeaderText = "Editar";
            dgv_template.Columns[1].HeaderText = "Eliminar";

            dgv_template.Columns[2].HeaderText = "Codigo";
            dgv_template.Columns[2].Name = "codigo";

            dgv_template.Columns[3].HeaderText = "Nombres";
            dgv_template.Columns[3].Name = "nombres";

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;
            dgv_template.Columns["editar"].DisplayIndex = 2;
            dgv_template.Columns["eliminar"].DisplayIndex = 3;

            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        //aca busquen la manera que al buscar en la misma caja se pueda buscar por codigo, nombres, etc... similar alos datatables de js
         void Buscar()
        {
            try
            {
                string nombres = "mar_nombre";
    
                string busqueda = txtSearch_template.Text.Trim();
                DataView dv = new DataView(dt.Copy());

                dv.RowFilter = nombres + " Like '%" + busqueda + "%'";
                dgv_template.DataSource = dv;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No se encontro la informacion" + ex);
            }
        }

        void GetMarca(int codigo) {

            DataSet ds = negMarca.GetMarca(1);
            DataTable dtMarca = ds.Tables[0];
            if (dtMarca.Rows.Count > 0)
            {
                string codigoMarca = dtMarca.Rows[0]["mar_codigo"].ToString();
                string nombreMarca = dtMarca.Rows[0]["mar_nombre"].ToString();

                MessageBox.Show(codigoMarca);

                MessageBox.Show(nombreMarca);

            }
            else {

                //sin datos
            }

        }



        private void FrmMarca_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;

            ListMarcas();
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

        private void TxtSearch_template_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Prueba_editar_Click(object sender, EventArgs e)
        {
            GetMarca(1);
        }
    }
}
