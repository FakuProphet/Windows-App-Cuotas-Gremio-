using System;
using System.Windows.Forms;

namespace WindowsCuotasApp
{
    public partial class FormPrincipal : MetroFramework.Forms.MetroForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
