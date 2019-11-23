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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool logueo = false;
        string usuario = "", password = "";


        public bool login(string user, string pass){

           bool login = (user == "admin" && pass == "admin") ? true : false;

            return login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text.Trim();
            password = txtPassword.Text.Trim();


            logueo = login(usuario, password);

            if (logueo == true)
            {
                frmContenedorAdmin frmPrincipal = new frmContenedorAdmin();
                this.Hide();
                frmPrincipal.ShowDialog();
                frmPrincipal.Show();
                this.Close();
            }
            else {

                MessageBox.Show("Credenciales incorrectas o usuario no existe", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Focus();
            }
        }
    }
}
