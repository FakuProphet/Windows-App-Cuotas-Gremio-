using System;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormLogin : Form
    {
       
        public FormLogin()
        {
            InitializeComponent();
            
            
        }

        private void FormLogin_Load(object sender, EventArgs e) => Inicio();


        void Inicio()
        {
            txtUsuario.Focus();
        }

        
        
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string entrada = txtUsuario.Text;
            lblMuestraEncriptado.Text = CryptorEngine.Encrypt(entrada, true);
            txtPass.Text = CryptorEngine.Decrypt(lblMuestraEncriptado.Text, true);
        }
    }
}
