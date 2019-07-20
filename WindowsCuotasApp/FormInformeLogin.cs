using System;
using WindowsCuotasApp.Clases;
using WindowsCuotasApp.Clases.LOGUIN;

namespace WindowsCuotasApp
{
    public partial class FormInformeLogin : MetroFramework.Forms.MetroForm
    {
        GestorDGV gestor;
        public FormInformeLogin()
        {
            InitializeComponent();
            gestor = new GestorDGV();
        }

        private void FormInformeLogin_Load(object sender, EventArgs e)
        {
            gestor.cargarDataGrid(dataGridView1, "select * from v_ingresos");
            gestor.efectosDGV(dataGridView1);
        }

       
    }
}
