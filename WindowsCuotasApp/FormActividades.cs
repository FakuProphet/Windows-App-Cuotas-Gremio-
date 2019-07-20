using System;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormActividades : MetroFramework.Forms.MetroForm
    {
        private const string Consulta = "select * from v_act_sistema order by DNI";
        GestorDGV gestor;
        public FormActividades()
        {
            InitializeComponent();
            gestor = new GestorDGV();
        }

        private void FormActividades_Load(object sender, EventArgs e)
        {
            gestor.cargarDataGrid(dataGridView1, Consulta);
            gestor.efectosDGV(dataGridView1);
        }
    }
}
