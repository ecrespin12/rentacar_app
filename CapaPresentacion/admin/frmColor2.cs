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
    public partial class frmColor2 : frmTemplate
    {
        public frmColor2()
        {
            InitializeComponent();
        }

        private void BtnNuevo_template_Click(object sender, EventArgs e)
        {
            MessageBox.Show("prueba");
            pnlModal.Visible = true;
        }

        private void FrmColor2_Load(object sender, EventArgs e)
        {
            pnlModal.Visible = false;
        }
    }
}
