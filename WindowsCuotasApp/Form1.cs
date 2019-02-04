using System;

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
    }
}
