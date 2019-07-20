using System;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormInformeLogin : MetroFramework.Forms.MetroForm
    {
        private const string Consulta = "select * from v_ingresos order by USUARIO";
        GestorDGV gestor;
        public FormInformeLogin()
        {
            InitializeComponent();
            gestor = new GestorDGV();
        }

        private void FormInformeLogin_Load(object sender, EventArgs e)
        {
            gestor.cargarDataGrid(dataGridView1, Consulta);
            gestor.efectosDGV(dataGridView1);
        }

       
    }
}
