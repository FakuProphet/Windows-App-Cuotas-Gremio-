using System;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormListadoSociosCuotas : MetroFramework.Forms.MetroForm
    {
        GestorDGV gestorDGV;

        public FormListadoSociosCuotas()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
        }

        private void FormListadoSociosCuotas_Load(object sender, EventArgs e)
        {
            gestorDGV.efectosDGV(dataGridView1);
            gestorDGV.cargarDataGrid(dataGridView1, "SELECT * FROM V_LISTADO_SOCIOS_PAGO_DEBITO ORDER BY 2 ASC");
        }
    }
}
