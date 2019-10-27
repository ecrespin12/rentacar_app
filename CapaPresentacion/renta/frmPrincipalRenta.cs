using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.admin;

namespace CapaPresentacion.renta
{
    public partial class frmPrincipalRenta : Form
    {
        public frmPrincipalRenta()
        {
            InitializeComponent();
        }

        private void NewRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmNuevaRenta frm = new frmNuevaRenta();
            frm.MdiParent = this;
            this.pnlContenedor.Controls.Add(frm);
            frm.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
