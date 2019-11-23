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

namespace CapaPresentacion
{
    public partial class frmContenedorAdmin : Form
    {
        private int childFormNumber = 0;

        public frmContenedorAdmin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void TsBtnInicio_Click(object sender, EventArgs e)
        {
        
            pnlContenedor.Controls.Clear();

            frmPrincipalAdmin frm = new frmPrincipalAdmin();
            frm.MdiParent = this;
            this.pnlContenedor.Controls.Add(frm);
            frm.Show();
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmMarca frm = new frmMarca();
            frm.MdiParent = this;
            this.pnlContenedor.Controls.Add(frm);
            frm.Show();
        }

        private void Marcas2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmColor frm = new frmColor();
            frm.MdiParent = this;
            this.pnlContenedor.Controls.Add(frm);
            frm.Show();
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls.Clear();

            frmTipoAuto frm = new frmTipoAuto();
            frm.MdiParent = this;
            this.pnlContenedor.Controls.Add(frm);
            frm.Show();
        }

        private void nuevoVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuto frm = new frmAuto();
            frm.MdiParent = this;
            this.pnlContenedor.Controls.Add(frm);
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.MdiParent = this;
            this.pnlContenedor.Controls.Add(frm);
            frm.Show();
        }
    }
}
