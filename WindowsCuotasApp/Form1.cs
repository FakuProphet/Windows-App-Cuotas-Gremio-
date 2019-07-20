using System;
using System.Windows.Forms;
using WindowsCuotasApp.Clases.LOGUIN;

namespace WindowsCuotasApp
{
    public partial class FormPrincipal : MetroFramework.Forms.MetroForm
    {
        GestorLoguin gl;
        User user;
        public FormPrincipal()
        {
            InitializeComponent();
            gl = new GestorLoguin();
            user = new User();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
                //user.Usuario = Ingreso.usuario;
                //gl.GuardarIngresoSistema(user);
           
        }

      

        private void administracionAfiliadosConDébitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoSociosCuotas nuevo = new FormListadoSociosCuotas();
            nuevo.ShowDialog();
        }

        private void generarListadoDeAfiliadosADebitarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte nuevo = new FormReporte();
            nuevo.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmAfiliados nuevo = new FormAdmAfiliados();
            nuevo.ShowDialog();
        }

        private void revisiónCuotasAfiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarDebitos formEditarDebitos = new FormEditarDebitos();
            formEditarDebitos.ShowDialog();
        }

        private void efectuarPagoCuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametroPago nuevo = new FormParametroPago();
            nuevo.ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportes nuevo = new FormReportes();
            nuevo.ShowDialog();
        }

        private void abrirVentanaInformaciónBásicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInvitados nuevo = new FormInvitados();
            nuevo.ShowDialog();
        }

        private void historialDeIngresosAlSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformeLogin nuevo = new FormInformeLogin();
            nuevo.ShowDialog();
        }

        private void registroDeActividadesYAlteracionDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActividades nuevo = new FormActividades();
            nuevo.ShowDialog();
        }
    }
}
