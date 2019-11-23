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

namespace CapaPresentacion.admin
{
    public partial class frmUsuarios : frmTemplate
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        DataTable dt;
        E_Usuario e_usuario = new E_Usuario();
        N_Usuarios n_usuarios = new N_Usuarios();


        public void ListarTodos() {
            dt = n_usuarios.Select();
            dgv_template.DataSource = dt;

            dgv_template.Columns[0].HeaderText = "Editar";
            dgv_template.Columns[1].HeaderText = "Eliminar";

            dgv_template.Columns[2].HeaderText = "Codigo";
            dgv_template.Columns[2].Name = "usr_codigo";

            dgv_template.Columns[3].HeaderText = "Nombre";
            dgv_template.Columns[3].Name = "usr_nombre";


            dgv_template.Columns[4].HeaderText = "Apellido";
            dgv_template.Columns[4].Name = "usr_apellido";

            dgv_template.Columns[5].HeaderText = "Correo";
            dgv_template.Columns[5].Name = "usr_correo";


            dgv_template.Columns[6].HeaderText = "Contraseña";
            dgv_template.Columns[6].Name = "usr_clave";


            dgv_template.Columns[7].HeaderText = "Fecha Creacion";
            dgv_template.Columns[7].Name = "usr_fecha_crea";

            dgv_template.Columns[8].HeaderText = "Codigo Aux";
            dgv_template.Columns[8].Name = "usr_codigo_aux";

            dgv_template.Columns[9].HeaderText = "Estatus";
            dgv_template.Columns[9].Name = "usr_estado_usuario";

            dgv_template.Columns[10].HeaderText = "Pais";
            dgv_template.Columns[10].Name = "usr_pais";

            dgv_template.Columns[11].HeaderText = "Estado";
            dgv_template.Columns[11].Name = "usr_estado";

            dgv_template.Columns[12].HeaderText = "Ciudad";
            dgv_template.Columns[12].Name = "usr_ciudad";

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;

            dgv_template.Columns["editar"].DisplayIndex = 12;
            dgv_template.Columns["eliminar"].DisplayIndex = 12;

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            lblTitle_template.Text = "CATALOGO DE USUARIOS";
            dgv_template.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            ListarTodos();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    int codigo = (int)dgv_template.Rows[e.RowIndex].Cells[2].Value;
                    DataSet ds = n_usuarios.ObtenerEntidad(codigo);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        string cod = dt.Rows[0]["usr_codigo"].ToString();
                        string nom = dt.Rows[0]["usr_nombre"].ToString();
                        string apellido = dt.Rows[0]["usr_apellido"].ToString();
                        string correo = dt.Rows[0]["usr_correo"].ToString();
                        string clave = dt.Rows[0]["usr_clave"].ToString();
                        string fechacreacion = dt.Rows[0]["usr_fecha_crea"].ToString();
                        string aux = dt.Rows[0]["usr_codigo_aux"].ToString();
                        string estatus = dt.Rows[0]["usr_estado_usuario"].ToString();
                        string pais = dt.Rows[0]["usr_pais"].ToString();
                        string estado = dt.Rows[0]["usr_estado"].ToString();
                        string ciudad = dt.Rows[0]["usr_ciudad"].ToString();
                        pnlModal.Visible = true;
                        btnAccionModal.Text = "EDITAR";
                        txtCodigo.Text = cod;
                        lblTituloModal.Text = "EDICION DE USUARIO";
                        txtNombre.Text = nom;
                        txtapellido.Text = apellido;
                        txtcorreo.Text = correo;
                        txtpassword.Text = clave;
                        dtpfechacreacion.Value = Convert.ToDateTime(fechacreacion);
                        txtcodigoaux.Text = aux;
                        cbestatus.Checked = estatus == "1" ? true : false;
                        txtpais.Text = pais;
                        txtestado.Text = estado;
                        txtciudad.Text = ciudad;
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
                    DialogResult resp = MessageBox.Show("¿Esta seguro de eliminar este usuario?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resp == DialogResult.Yes)
                    {

                    }
                }
                catch (Exception excepcion)
                {

                }

            }
        }


        private void btnAccionModal_Click_1(object sender, EventArgs e)
        {
            E_Usuario entity = new E_Usuario();
            entity.usr_apellido = txtapellido.Text;
            entity.usr_ciudad = txtciudad.Text;
            entity.usr_clave = txtpassword.Text;
            entity.usr_codigo_aux = txtcodigoaux.Text;
            entity.usr_correo = txtcorreo.Text;
            entity.usr_estado_usuario = cbestatus.Checked ? "1" : "0";
            entity.usr_estado = txtestado.Text;
            entity.usr_fecha_crea = dtpfechacreacion.Value;
            entity.usr_nombre = txtNombre.Text;
            entity.usr_pais = txtpais.Text;
            
            if (btnAccionModal.Text == "GUARDAR")
            {
                n_usuarios.Insertar(entity);
            }
            else
            {
                entity.usr_codigo = Convert.ToInt32(txtCodigo.Text);
                n_usuarios.Actualizar(entity);
            }
            ListarTodos();
            pnlModal.Visible = false;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtapellido.Text = "";
            txtcorreo.Text = "";
            txtpassword.Text = "";
            dtpfechacreacion.Value = DateTime.Now;
            txtcodigoaux.Text = "";
            cbestatus.Checked = true;
            txtpais.Text = "";
            txtestado.Text = "";
            txtciudad.Text = "";
        }

        private void btnNuevo_template_Click(object sender, EventArgs e)
        {
            pnlModal.Visible = true;
            btnAccionModal.Text = "GUARDAR";
            lblTituloModal.Text = "NUEVO USUARIO";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtapellido.Text = "";
            txtcorreo.Text = "";
            txtpassword.Text = "";
            dtpfechacreacion.Value = DateTime.Now;
            txtcodigoaux.Text = "";
            cbestatus.Checked = true;
            txtpais.Text = "";
            txtestado.Text = "";
            txtciudad.Text = "";
        }
    }
}
