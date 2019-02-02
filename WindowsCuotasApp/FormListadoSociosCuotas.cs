using System;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    //FORMULARIO PARA LISTAR LOS AFILIADOS QUE EFECTUAN PAGO POR DEBITO.
    public partial class FormListadoSociosCuotas : MetroFramework.Forms.MetroForm
    {
        GestorDGV gestorDGV;

        public FormListadoSociosCuotas()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
            mostrarMes();
        }

        private void FormListadoSociosCuotas_Load(object sender, EventArgs e)
        {
            gestorDGV.efectosDGV(dataGridView1);
            gestorDGV.cargarDataGrid(dataGridView1, "EXEC SP_LISTADO_AFIL_DEBITO");
        }

        private void mostrarMes()
        {
            Fecha fecha = new Fecha();
            lblMes.Text = fecha.getMes().ToString();
            lblAnio.Text = fecha.getAnio().ToString();
            lblDetalleMes.Text = fecha.detalleMes(Convert.ToInt16(fecha.getMes().ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReporte nuevo = new FormReporte();
            nuevo.ShowDialog();
        }
    }
}
