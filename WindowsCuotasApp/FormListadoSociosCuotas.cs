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
            gestorDGV.cargarDataGrid(dataGridView1, "SELECT * FROM V_LISTADO_SOCIOS_PAGO_DEBITO ORDER BY 2 ASC");
        }

        private void mostrarMes()
        {
            Fecha fecha = new Fecha();
            lblMes.Text = fecha.getMes().ToString(); 
        }
       
    }
}
