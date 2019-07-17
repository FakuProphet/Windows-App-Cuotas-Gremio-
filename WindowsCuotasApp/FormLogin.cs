﻿using System;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;
using WindowsCuotasApp.Clases.LOGUIN;

namespace WindowsCuotasApp
{
    public partial class FormLogin : Form
    {
        private const string V = "Error en la conexión: ";
        private GestorLoguin gestor;
        public FormLogin()
        {
            InitializeComponent();
            gestor = new GestorLoguin();         
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
                    MetroFramework.MetroMessageBox.Show(this, "El usuario o contraseña ingresados son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, V + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        

        }

      
        /*bighead2019*/
        /*Administrador*/
        //string p = "bIKfd6UP6Bg1RHudOqQbLA==";
        //lblPasEncriptada.Text = CryptorEngine.Decrypt(p, true);

    }
}
