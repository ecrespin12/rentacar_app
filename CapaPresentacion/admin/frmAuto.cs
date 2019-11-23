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
    public partial class frmAuto : frmTemplate
    {
        public frmAuto()
        {
            InitializeComponent();
        }

        DataTable dt;
        E_Auto e_Auto = new E_Auto();
        N_Auto n_Auto = new N_Auto();

        void ListAuto()
        {
            dt = n_Auto.N_ListAuto();
            dgv_template.DataSource = dt;

            dgv_template.Columns[0].HeaderText = "Editar";
            dgv_template.Columns[1].HeaderText = "Eliminar";
            dgv_template.Columns[2].HeaderText = "Codigo";
            dgv_template.Columns[3].HeaderText = "Marca";
            dgv_template.Columns[4].HeaderText = "Color";
            dgv_template.Columns[5].HeaderText = "Tipo";
            dgv_template.Columns[6].HeaderText = "codmar";
            dgv_template.Columns[7].HeaderText = "codcol";
            dgv_template.Columns[8].HeaderText = "codtia";
            dgv_template.Columns[9].HeaderText = "Modelo";
            dgv_template.Columns[10].HeaderText = "Año";
            dgv_template.Columns[11].HeaderText = "Placa";
            dgv_template.Columns[12].HeaderText = "Estado";

            dgv_template.Columns[6].Visible=false;
            dgv_template.Columns[7].Visible=false;
            dgv_template.Columns[8].Visible = false;

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;
            dgv_template.Columns[4].DisplayIndex = 2;
            dgv_template.Columns[5].DisplayIndex = 3;
            dgv_template.Columns[6].DisplayIndex = 4;
            dgv_template.Columns[7].DisplayIndex = 5;
            dgv_template.Columns[8].DisplayIndex = 6;
            dgv_template.Columns[9].DisplayIndex = 7;
            dgv_template.Columns[10].DisplayIndex = 8;
            dgv_template.Columns[11].DisplayIndex = 9;
            dgv_template.Columns[12].DisplayIndex = 10;
            dgv_template.Columns[0].DisplayIndex = 11;
            dgv_template.Columns[1].DisplayIndex = 12;

            dgv_template.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmAuto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_AlquilerAutosDataSetTipoAuto.tbl_tia_tipo_auto' Puede moverla o quitarla según sea necesario.
            this.tbl_tia_tipo_autoTableAdapter.Fill(this.bD_AlquilerAutosDataSetTipoAuto.tbl_tia_tipo_auto);
            // TODO: esta línea de código carga datos en la tabla 'bD_AlquilerAutosDataSet1.tbl_col_color' Puede moverla o quitarla según sea necesario.
            this.tbl_col_colorTableAdapter.Fill(this.bD_AlquilerAutosDataSet1.tbl_col_color);
            // TODO: esta línea de código carga datos en la tabla 'bD_AlquilerAutosDataSet.tbl_mar_marca' Puede moverla o quitarla según sea necesario.
            this.tbl_mar_marcaTableAdapter.Fill(this.bD_AlquilerAutosDataSet.tbl_mar_marca);
            pnlModal.Visible = false;
            lblTitle_template.Text = "CATALOGO DE VEHICULOS";

            dgv_template.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);



            ListAuto();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try {
                    int codigo = (int)dgv_template.Rows[e.RowIndex].Cells[2].Value;
                    DataSet ds = n_Auto.GetAuto(codigo);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        string cod = dt.Rows[0]["aut_codigo"].ToString();
                        string nom = dt.Rows[0]["aut_estado"].ToString();
                        pnlModal.Visible = true;
                        btnAccionModal.Text = "ACTUALIZAR";
                        txtCodigo.Text = cod;
                        lblTituloModal.Text = "ACTUALIZACIÓN DE VEHICULO";
                        //txtEstado.Text = nom;
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
                    DataSet ds = n_Auto.GetAuto(codigo);
                    DataTable dt = ds.Tables[0];
                    int cod = Convert.ToInt32(dt.Rows[0]["aut_codigo"].ToString());
                    DialogResult resp = MessageBox.Show("¿Esta seguro de eliminar este auto \n " +
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
            lblTituloModal.Text = "CREACION DE VEHICULO";

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
            E_Auto e_Auto = new E_Auto();
            try
            {

                //error provider si es null o vacio retornar mensaje a usuario
                //if (string.IsNullOrEmpty(txtEstado.Text))
                //{
                //    epErrorEstado.SetError(txtEstado, "Debe ingresar un estado para el vehiculo");
                //    txtEstado.Focus();
                //    return;
                //}
                //epErrorEstado.SetError(txtEstado, "");

                //e_Auto.estado = txtEstado.Text.Trim();
                n_Auto.InsertAuto(e_Auto);
                MessageBox.Show("Vehiculo regristrado correctamente");
                ListAuto();
                txtCodigo.Text = "";
                //txtEstado.Text = "";
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
            E_Auto e_Auto = new E_Auto();
            try
            {
                e_Auto.codAuto = cod;
                n_Auto.EliminarAuto(e_Auto);
                MessageBox.Show("Vehiculo eliminado correctamente");
                ListAuto();
                txtCodigo.Text = "";
                //txtEstado.Text = "";
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
            E_Auto e_Auto = new E_Auto();
            try
            {

                //error provider si es null o vacio retornar mensaje a usuario
                //if (string.IsNullOrEmpty(txtEstado.Text))
                //{
                //    epErrorEstado.SetError(txtEstado, "Debe ingresar un estado para el vehiculo");
                //    txtEstado.Focus();
                //    return;
                //}
                //epErrorEstado.SetError(txtEstado, "");

                //e_Auto.estado = txtEstado.Text.Trim();
                e_Auto.codAuto = Convert.ToInt32(txtCodigo.Text.Trim());
                n_Auto.ActualizarAuto(e_Auto);
                MessageBox.Show("Vehiculo actualizado correctamente");
                ListAuto();
                txtCodigo.Text = "";
                //txtEstado.Text = "";
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
                string nombres = "aut_estado";

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
            //txtEstado.Text = "";
            txtSearch_template.Text = "";
            ListAuto();
        }

        private void TxtSearch_template_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void LblEstado_Click(object sender, EventArgs e)
        {

        }

        private void TxtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
