using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.renta
{
    public partial class frmNuevaRenta : Form
    {
        public frmNuevaRenta()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        E_Renta entRenta = new E_Renta();
        N_Renta negRenta = new N_Renta();
        string montoTarifa = "", codigoTarifa = "";

        private void FrmNuevaRenta_Load(object sender, EventArgs e)
        {
            MostrarAutosDisponibles();
            ListaConductores();
        }



        private void ListaConductores()
        {
            cboConductor.DataSource = N_Renta.ListaConductores();
            cboConductor.DisplayMember = "NombreConductor";
            cboConductor.ValueMember = "CodigoConductor";
        }


        private void MostrarAutosDisponibles()
        {
            E_Renta insRenta = new E_Renta();



            try
            {
                DataSet ds = N_Renta.N_GetAutosDisponibles(insRenta, dgvAutosDisponibles);
                dt = ds.Tables[0];
                dgvAutosDisponibles.Visible = true;
                dgvAutosDisponibles.DataSource = dt;
                //if (dt.Rows.Count > 0)
                //{

                //}
                //else
                //{

                //}
                dgvAutosDisponibles.Columns[3].HeaderText = "#";
                dgvAutosDisponibles.Columns[4].HeaderText = "CODIGO";
                dgvAutosDisponibles.Columns[4].Name = "codigoAuto";
                dgvAutosDisponibles.Columns[5].HeaderText = "MARCA";
                dgvAutosDisponibles.Columns[6].HeaderText = "TIPO";
                dgvAutosDisponibles.Columns[7].HeaderText = "COLOR";
                dgvAutosDisponibles.Columns[8].HeaderText = "YEAR";
                dgvAutosDisponibles.Columns[9].HeaderText = "PLACA";
                dgvAutosDisponibles.Columns[10].HeaderText = "MODELO";
                dgvAutosDisponibles.Columns["diasRent"].DisplayIndex = 10;
                dgvAutosDisponibles.Columns["totalRent"].DisplayIndex = 10;


                dgvAutosDisponibles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //chk
                dgvAutosDisponibles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //txt
                dgvAutosDisponibles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //txt
                dgvAutosDisponibles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //
                dgvAutosDisponibles.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //
                dgvAutosDisponibles.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //

            }
            catch (Exception ex)
            {
                dgvAutosDisponibles.Visible = false;

                if (ex.Message.Contains("No se puede encontrar la tabla 0."))
                {
                    MessageBox.Show("LOS RECIBOS YA FUERON CANCELADOS", "INFORMACIÓN");
                }
                else
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }


        void GeTarifasAutos(int codAuto)
        {

            DataSet ds = negRenta.N_GetTarifasAuto(codAuto);
            DataTable dtMarca = ds.Tables[0];
            if (dtMarca.Rows.Count > 0)
            {
                codigoTarifa = dtMarca.Rows[0]["tra_codigo"].ToString();
                montoTarifa = dtMarca.Rows[0]["tra_monto"].ToString();
            }
            else
            {

                //sin datos
                codigoTarifa = "0";
                montoTarifa = "0";
            }

        }

        private void DgvAutosDisponibles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {


                try
                {
                    int diasIng = Convert.ToInt32(dgvAutosDisponibles.Rows[e.RowIndex].Cells[1].Value.ToString());
         
                    if (diasIng > 0)
                    {
                        int codAuto = Convert.ToInt32(dgvAutosDisponibles.Rows[e.RowIndex].Cells[4].Value);

                        GeTarifasAutos(codAuto);
                        decimal total = diasIng * Convert.ToDecimal(montoTarifa);
                    
                        dgvAutosDisponibles.Rows[e.RowIndex].Cells[2].Value = Convert.ToString(total);
                        dgvAutosDisponibles.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.SkyBlue;
                    }
                    else
                    {
                        montoTarifa = "0";
                        codigoTarifa = "0";

                        dgvAutosDisponibles.Rows[e.RowIndex].Cells[1].Value = "";
                        dgvAutosDisponibles.Rows[e.RowIndex].Cells[2].Value = "";
                        dgvAutosDisponibles.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: vuelva a intentarlo nuevamente");
                }

            


        
            }
        }


        public void Registrar()
        {

            try
            {
                E_Renta renta = new E_Renta();
                int i = 1;
                decimal valRec = 0;
                foreach (DataGridViewRow fila in dgvAutosDisponibles.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells["insertar"].Value))
                    {
                 

                        renta.CodigoAuto = Convert.ToInt32(fila.Cells[4].Value);



                        renta.CodigoUsuario = 2; //quemado
                        renta.DepositoRenta = Convert.ToDecimal(txtDeposito.Text); ;
                        renta.FechaInicioRenta = Convert.ToDateTime(dtpDesde.Text);
                        renta.FechaFinRenta = Convert.ToDateTime(dtpHasta.Text);
                        renta.CodigoConductor = Convert.ToInt32(cboConductor.SelectedValue);
                        renta.tarifaRenta = Convert.ToInt32("1"); ;
                        renta.Status = "R";


                        N_Renta.N_InsertRenta(renta, fila.Cells["codigoAuto"].Value.ToString());
                    }
         

                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }




        private void BtnProcesar_Click(object sender, EventArgs e)
        {




            decimal total = 0 ;

                 for (int i = 0; i < dgvAutosDisponibles.Rows.Count; i++){



                if (Convert.ToInt32(dgvAutosDisponibles.Rows[i].Cells["insertar"].Value) == 1)
                {
                    dgvAutosDisponibles.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
                    dgvAutosDisponibles.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.White;

                    total += Convert.ToDecimal(this.dgvAutosDisponibles.Rows[i].Cells[2].Value);

                }
                else {
                    dgvAutosDisponibles.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    dgvAutosDisponibles.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                }

                       



                 }

                     txtMontoCobrar.Text = Convert.ToString(total);
            this.btnGuardarRenta.Visible = true;

        }

        private void BtnGuardarRenta_Click(object sender, EventArgs e)
        {
            Registrar();
            this.btnGuardarRenta.Visible = false;
            txtMontoCobrar.Text = "0";
            txtDeposito.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
