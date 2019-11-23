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

            dgv_template.Columns[3].HeaderText = "Nombre";

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;

            dgv_template.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmTipoAuto_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            lblTitle_template.Text = "CATALOGO DE TIPOS DE AUTOS";

            dgv_template.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);



            ListTipoAuto();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try {
                    int codigo = (int)dgv_template.Rows[e.RowIndex].Cells[2].Value;
                    DataSet ds = n_Tipo_Auto.GetTipoAuto(codigo);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        string cod = dt.Rows[0]["tia_codigo"].ToString();
                        string nom = dt.Rows[0]["tia_nombre"].ToString();
                        pnlModal.Visible = true;
                        btnAccionModal.Text = "ACTUALIZAR";
                        txtCodigo.Text = cod;
                        lblTituloModal.Text = "ACTUALIZACION DE TIPO DE AUTO";
                        txtNombreTipoAuto.Text = nom;
                    }
                    else
                    {
                        //sin datos
                    }
                } catch (Exception exception) { }
                
            }
            else if (e.ColumnIndex == 1)
            {
                try {
                    int codigo = (int)dgv_template.Rows[e.RowIndex].Cells[2].Value;
                    DataSet ds = n_Tipo_Auto.GetTipoAuto(codigo);
                    DataTable dt = ds.Tables[0];
                    int cod = Convert.ToInt32(dt.Rows[0]["tia_codigo"].ToString());
                    DialogResult resp = MessageBox.Show("¿Esta seguro de eliminar este tipo de auto \n " +
                        "con codigo="+cod+"?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resp == DialogResult.Yes)
                    {
                        Eliminar(Convert.ToInt32(cod));
                    }
                } catch(Exception excepcion) {
                    
                }
                
            }
        }

        private void BtnNuevo_template_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = true;
            btnAccionModal.Text = "GUARDAR";
            lblTituloModal.Text = "CREACION DE TIPO DE AUTO";

        }

        private void BtnAccionModal_Click(object sender, EventArgs e)
        {
            if (btnAccionModal.Text == "GUARDAR")
            {
                Insert();
            }
            else
            {
                Actualizar();
            }
            
        }

        void Insert()
        {
            E_Tipo_Auto e_Tipo_Auto = new E_Tipo_Auto();
            try
            {

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtNombreTipoAuto.Text))
                {
                    epErrorNombre.SetError(txtNombreTipoAuto, "Debe ingresar un nombre de tipo de auto");
                    txtNombreTipoAuto.Focus();
                    return;
                }
                epErrorNombre.SetError(txtNombreTipoAuto, "");

                e_Tipo_Auto.nombre = txtNombreTipoAuto.Text.Trim();
                n_Tipo_Auto.InsertTipoAuto(e_Tipo_Auto);
                MessageBox.Show("Tipo de auto regristrado correctamente");
                ListTipoAuto();
                txtCodigo.Text = "";
                txtNombreTipoAuto.Text = "";
                txtSearch_template.Text = "";
                pnlModal.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Eliminar(int cod)
        {
            E_Tipo_Auto e_Tipo_Auto = new E_Tipo_Auto();
            try
            {
                e_Tipo_Auto.codigo = cod;
                n_Tipo_Auto.EliminarTipoAuto(e_Tipo_Auto);
                MessageBox.Show("Tipo de auto eliminado correctamente");
                ListTipoAuto();
                txtCodigo.Text = "";
                txtNombreTipoAuto.Text = "";
                txtSearch_template.Text = "";
                pnlModal.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Actualizar()
        {
            E_Tipo_Auto e_Tipo_Auto = new E_Tipo_Auto();
            try
            {

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtNombreTipoAuto.Text))
                {
                    epErrorNombre.SetError(txtNombreTipoAuto, "Debe ingresar un nombre de tipo de Auto");
                    txtNombreTipoAuto.Focus();
                    return;
                }
                epErrorNombre.SetError(txtNombreTipoAuto, "");

                e_Tipo_Auto.nombre = txtNombreTipoAuto.Text.Trim();
                e_Tipo_Auto.codigo = Convert.ToInt32(txtCodigo.Text.Trim());
                n_Tipo_Auto.ActualizarTipoAuto(e_Tipo_Auto);
                MessageBox.Show("Tipo de auto actualizado correctamente");
                ListTipoAuto();
                txtCodigo.Text = "";
                txtNombreTipoAuto.Text = "";
                txtSearch_template.Text = "";
                pnlModal.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Buscar()
        {
            try
            {
                string nombres = "tia_nombre";

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

        private void BtnCloseModal_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            txtCodigo.Text = "";
            txtNombreTipoAuto.Text = "";
            txtSearch_template.Text = "";
            ListTipoAuto();
        }

        private void TxtSearch_template_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
