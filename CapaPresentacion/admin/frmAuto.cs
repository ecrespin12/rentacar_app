﻿using System;
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
            dgv_template.Columns[2].Name = "codigo";

            dgv_template.Columns[3].HeaderText = "Nombre";
            dgv_template.Columns[3].Name = "nombres";

            dgv_template.Columns[2].DisplayIndex = 0;
            dgv_template.Columns[3].DisplayIndex = 1;
            dgv_template.Columns["editar"].DisplayIndex = 2;
            dgv_template.Columns["eliminar"].DisplayIndex = 3;

            dgv_template.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmAuto_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
            lblTitle_template.Text = "CATALOGO DE AUTOS";

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
                        txtEstado.Text = nom;
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
                if (string.IsNullOrEmpty(txtEstado.Text))
                {
                    epErrorEstado.SetError(txtEstado, "Debe ingresar un estado para el vehiculo");
                    txtEstado.Focus();
                    return;
                }
                epErrorEstado.SetError(txtEstado, "");

                e_Auto.estado = txtEstado.Text.Trim();
                n_Auto.InsertAuto(e_Auto);
                MessageBox.Show("Vehiculo regristrado correctamente");
                ListAuto();
                txtCodigo.Text = "";
                txtEstado.Text = "";
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
                txtEstado.Text = "";
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
                if (string.IsNullOrEmpty(txtEstado.Text))
                {
                    epErrorEstado.SetError(txtEstado, "Debe ingresar un estado para el vehiculo");
                    txtEstado.Focus();
                    return;
                }
                epErrorEstado.SetError(txtEstado, "");

                e_Auto.estado = txtEstado.Text.Trim();
                e_Auto.codAuto = Convert.ToInt32(txtCodigo.Text.Trim());
                n_Auto.ActualizarAuto(e_Auto);
                MessageBox.Show("Vehiculo actualizado correctamente");
                ListAuto();
                txtCodigo.Text = "";
                txtEstado.Text = "";
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
            txtEstado.Text = "";
            txtSearch_template.Text = "";
            ListAuto();
        }

        private void TxtSearch_template_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
