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
        
        N_Marca negMarca = new N_Marca();
 
        //metodos

        void InsertMarca() {
            E_Marca entMarca = new E_Marca();
            try
            {

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtNombre.Text)) {
                    epMarca.SetError(txtNombre, "Debe ingresar un nombre de marca");
                    txtNombre.Focus();
                    return;
                }
                if (cbestatus.SelectedIndex == -1) {
                    MessageBox.Show("Seleccione un estatus");
                    cbestatus.Focus();
                    return;
                }
                epMarca.SetError(txtNombre, "");

                entMarca.NombreMarca = txtNombre.Text.Trim();
                entMarca.Estatus = cbestatus.SelectedItem.ToString();
                negMarca.InsertMarca(entMarca);
                MessageBox.Show("Marca regristrada correctamente");

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ActualizarMarca()
        {
            E_Marca entMarca = new E_Marca();
            try
            {

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    epMarca.SetError(txtNombre, "Debe ingresar un nombre de marca");
                    txtNombre.Focus();
                    return;
                }
                epMarca.SetError(txtNombre, "");

                entMarca.NombreMarca = txtNombre.Text.Trim();
                entMarca.MarcaID = Convert.ToInt32(txtMarcaId.Text.Trim());
                entMarca.Estatus = cbestatus.SelectedItem.ToString();
                negMarca.ActualizarMarca(entMarca);
                MessageBox.Show("Marca actualiza correctamente");

            }
            catch (Exception ex)
            {

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

            dgv_template.Columns[4].HeaderText = "Estatus";
            dgv_template.Columns[4].Name = "estatus";

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;
            dgv_template.Columns[4].DisplayIndex = 2;
            dgv_template.Columns["editar"].DisplayIndex = 3;
            dgv_template.Columns["eliminar"].DisplayIndex = 4;

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

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            dgv_template.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            ListMarcas();
            lblTitle_template.Text = "CATALOGO DE MARCAS";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int codigo = (int)dgv_template.Rows[e.RowIndex].Cells[2].Value;
                DataSet ds = negMarca.GetMarca(codigo);
                DataTable dtMarca = ds.Tables[0];
                if (dtMarca.Rows.Count > 0)
                {
                    string codigoMarca = dtMarca.Rows[e.RowIndex]["mar_codigo"].ToString();
                    string nombreMarca = dtMarca.Rows[e.RowIndex]["mar_nombre"].ToString();
                    string estatus = dtMarca.Rows[e.RowIndex]["mar_estatus"].ToString();
                    pnlModal.Visible = true;
                    btnAccionModal.Text = "ACTUALIZAR";
                    cbestatus.SelectedItem = estatus;
                    txtMarcaId.Text = codigoMarca;
                    lblTituloModal.Text = "ACTUALIZACION DE MARCA";
                    txtNombre.Text = nombreMarca;
                }
                else
                {
                    //sin datos
                }
            }
            else if (e.ColumnIndex == 1) {
                int codigo = (int)dgv_template.Rows[e.RowIndex].Cells[2].Value;
                DialogResult resp = MessageBox.Show("Esta seguro de eliminar esta marca", "Confirmacion", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (resp == DialogResult.Yes) {


                }
            }
        }



        private void BtnAccionModal_Click(object sender, EventArgs e)
        {
            if (btnAccionModal.Text == "GUARDAR")
            {
                InsertMarca();
            }
            else {
                ActualizarMarca();
            }
            
        }

        private void BtnNuevo_template_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = true;
            btnAccionModal.Text = "GUARDAR";
            lblTituloModal.Text = "CREACION DE MARCA";
            cbestatus.SelectedItem = "ALTA";
        }

        private void BtnCloseModal_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            txtMarcaId.Text = "";
            txtNombre.Text = "";
            ListMarcas();
        }

        private void TxtSearch_template_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
