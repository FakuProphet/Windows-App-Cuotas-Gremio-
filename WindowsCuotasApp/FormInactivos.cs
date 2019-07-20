using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
