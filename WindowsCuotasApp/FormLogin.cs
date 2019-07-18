using System;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;
using WindowsCuotasApp.Clases.LOGUIN;

namespace WindowsCuotasApp
{
    public partial class FormLogin : Form
    {
        private const string V = "Error en la conexión: ";
        private GestorLoguin gestor;
        private bool bandera;
        public FormLogin()
        {
            InitializeComponent();
            gestor = new GestorLoguin();
            bandera = false;
        }

        private void FormLogin_Load(object sender, EventArgs e) => Inicio();


        void Inicio()
        {
            txtUsuario.Focus();
           // lblPasEncriptada.Visible = true;
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

            try
            {
                if (!bandera)
                {
                    string entradaUser = txtUsuario.Text.Trim();
                    string entradaPass = txtPass.Text.Trim();
                    string usuarioEncriptado = CryptorEngine.Encrypt(entradaUser, true);
                    string passEncriptada = CryptorEngine.Encrypt(entradaPass, true);
                    if (gestor.GetUsuario(usuarioEncriptado, passEncriptada) != null)
                    {
                        this.Hide();
                        FormPrincipal nuevo = new FormPrincipal();
                        nuevo.Show();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "El usuario o contraseña del administrador son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    string entradaUserInvitado = txtUsuario.Text.Trim();
                    string entradaPassInvitado = txtPass.Text.Trim();

                    if (gestor.GetUsuario(entradaUserInvitado, entradaPassInvitado) != null)
                    {
                        this.Hide();
                        FormPrincipal nuevo = new FormPrincipal();
                        nuevo.afiliadoToolStripMenuItem.Enabled = false;
                        nuevo.cuotasToolStripMenuItem.Enabled = false;
                        nuevo.reportesToolStripMenuItem.Enabled = false;
                        nuevo.Show();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "El usuario o contraseña del usuario invitado son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, V + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                bandera = true;
                
            }
            else
            {
                bandera = false;
                
            }
        }


        /*bighead2019*/
        /*Administrador*/
        //string p = "bIKfd6UP6Bg1RHudOqQbLA==";
        //lblPasEncriptada.Text = CryptorEngine.Decrypt(p, true);

    }
}
