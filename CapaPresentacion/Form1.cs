using System;
using System.Windows.Forms;

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


        public bool login(string user, string pass)
        {

            bool login = ((user == "admin" && pass == "admin") || (user == "caja" && pass == "caja")) ? true : false;

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
                switch (usuario)
                {
                    case "admin":
                        frmContenedorAdmin frmAdmin = new frmContenedorAdmin();
                        this.Hide();
                        frmAdmin.ShowDialog();
                        frmAdmin.Show();
                        this.Close();
                        break;
                    case "caja":
                        frmCaja frmCaja = new frmCaja();
                        this.Hide();
                        frmCaja.ShowDialog();
                        frmCaja.Show();
                        this.Close();
                        break;
                    default:
                        //frmContenedorAdmin frmDefault = new frmContenedorAdmin();
                        //this.Hide();
                        //frmDefault.ShowDialog();
                        //frmDefault.Show();
                        //this.Close();
                        MessageBox.Show("Credenciales incorrectas o usuario no existe", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        txtUsuario.Focus();
                        break;
                }
            }
            //if (logueo == true)
            //{
            //    frmContenedorAdmin frmPrincipal = new frmContenedorAdmin();
            //    this.Hide();
            //    frmPrincipal.ShowDialog();
            //    frmPrincipal.Show();
            //    this.Close();
            //}
            //else {


            //}
        }
    }
}
