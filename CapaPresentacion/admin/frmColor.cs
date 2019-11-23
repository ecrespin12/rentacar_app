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
            txtCodColor.Visible = false;
            lblTitle_template.Text = "CATALOGO DE COLORES";
        }

        DataTable dt;
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
            dgv_template.Columns[1].Visible = false;

            dgv_template.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_template.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmColor_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;

            dgv_template.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            ListColores();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    int codigo = (int)dgv_template.Rows[e.RowIndex].Cells[2].Value;
                    DataSet ds = negColor.GetColor(codigo);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        string cod = dt.Rows[0]["col_codigo"].ToString();
                        string nom = dt.Rows[0]["col_nombre"].ToString();
                        string hex = dt.Rows[0]["col_hex"].ToString();
                        pnlModal.Visible = true;
                        btnAccionModal.Text = "ACTUALIZAR";
                        txtCodColor.Text = cod;
                        txtColor.Text = nom;
                        txtHex.Text = hex;
                      
                        lblTituloModal.Text = "ACTUALIZACION DE COLOR";
                    }
                    else
                    {
                        //sin datos
                    }
                }
                catch (Exception exception) { }

            }
            else if (e.ColumnIndex == 1)
            {
                try
                {
                    int codigo = (int)dgv_template.Rows[e.RowIndex].Cells[2].Value;
                    DataSet ds = negColor.GetColor(codigo);
                    DataTable dt = ds.Tables[0];
                    int cod = Convert.ToInt32(dt.Rows[0]["col_codigo"].ToString());
                    DialogResult resp = MessageBox.Show("¿Esta seguro de eliminar este color \n " +
                        "con codigo=" + cod + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resp == DialogResult.Yes)
                    {
                        Eliminar(Convert.ToInt32(cod));
                    }
                }
                catch (Exception excepcion)
                {

                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_template_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = true;
            btnAccionModal.Text = "GUARDAR";
            lblTituloModal.Text = "CREACION DE COLOR";
        }

        private void btnCloseModal_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            txtCodColor.Text = "";
            txtColor.Text = "";
            txtHex.Text = "";
            txtSearch_template.Text = "";
            ListColores();
        }

        private void btnAccionModal_Click(object sender, EventArgs e)
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
            E_Color e_Color = new E_Color();
            try
            {

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtColor.Text))
                {
                    errorProvider1.SetError(txtColor, "Debe ingresar un nombre de color");
                    txtColor.Focus();
                    return;
                }
                errorProvider1.SetError(txtColor, "");

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtHex.Text))
                {
                    errorProvider2.SetError(txtHex, "Debe ingresar el codigo hexadecimal del color");
                    txtHex.Focus();
                    return;
                }
                errorProvider1.SetError(txtHex, "");

                e_Color.NombreColor = txtColor.Text.Trim();
                e_Color.Hexadecimal = txtHex.Text.Trim();
                negColor.InsertColor(e_Color);
                MessageBox.Show("Color regristrado correctamente");
                ListColores();
                txtCodColor.Text = "";
                txtColor.Text = "";
                txtHex.Text = "";
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
            E_Color e_Color = new E_Color();
            try
            {

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtColor.Text))
                {
                    errorProvider1.SetError(txtColor, "Debe ingresar un nombre de color");
                    txtColor.Focus();
                    return;
                }
                errorProvider1.SetError(txtColor, "");

                //error provider si es null o vacio retornar mensaje a usuario
                if (string.IsNullOrEmpty(txtHex.Text))
                {
                    errorProvider2.SetError(txtHex, "Debe ingresar el codigo hexadecimal del color");
                    txtHex.Focus();
                    return;
                }
                errorProvider1.SetError(txtHex, "");

                e_Color.Codigo = Convert.ToInt32(txtCodColor.Text.Trim());
                e_Color.NombreColor = txtColor.Text.Trim();
                e_Color.Hexadecimal = txtHex.Text.Trim();
                negColor.ActualizarColor(e_Color);
                MessageBox.Show("Color actualizado correctamente");
                ListColores();
                txtCodColor.Text = "";
                txtColor.Text = "";
                txtHex.Text = "";
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
            E_Color e_Color = new E_Color();
            try
            {
                e_Color.Codigo = cod;
                negColor.EliminarColor(e_Color);
                MessageBox.Show("Color eliminado correctamente");
                ListColores();
                txtCodColor.Text = "";
                txtColor.Text = "";
                txtHex.Text = "";
                txtSearch_template.Text = "";
                pnlModal.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
