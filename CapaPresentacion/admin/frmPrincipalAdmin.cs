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

namespace CapaPresentacion.admin
{
    public partial class frmPrincipalAdmin : frmBaseCrud
    {
        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void FrmPrincipalAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir del sistema?", "SALIR DEL SISTEMA", MessageBoxButtons.YesNo);
   
 

            if (result == DialogResult.Yes)
            {


                Application.Exit();


            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
