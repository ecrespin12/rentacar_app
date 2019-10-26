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

        private void FrmNuevaRenta_Load(object sender, EventArgs e)
        {
            MostrarAutosDisponibles();
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
                dgvAutosDisponibles.Columns[2].Visible = false;
                dgvAutosDisponibles.Columns[3].Visible = false;
                dgvAutosDisponibles.Columns[6].Visible = false;
                dgvAutosDisponibles.Columns[7].Visible = false;
                dgvAutosDisponibles.Columns[9].Visible = false;



                dgvAutosDisponibles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAutosDisponibles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAutosDisponibles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAutosDisponibles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAutosDisponibles.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAutosDisponibles.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAutosDisponibles.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAutosDisponibles.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAutosDisponibles.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAutosDisponibles.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



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
    }
}
