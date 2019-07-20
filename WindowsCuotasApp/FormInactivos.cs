using System;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormInactivos : MetroFramework.Forms.MetroForm
    {
        GestorDGV gestorDGV;
        public FormInactivos()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
        }

        private void FormInactivos_Load(object sender, EventArgs e)
        {
            gestorDGV.cargarDataGrid(dataGridView1, "sp_inactivos");
            gestorDGV.efectosDGV(dataGridView1);
        }
    }
}
