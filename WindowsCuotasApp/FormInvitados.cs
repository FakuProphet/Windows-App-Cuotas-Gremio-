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
    public partial class FormInvitados : MetroFramework.Forms.MetroForm
    {
        GestorDGV g;
        GestorAfiliados ga;
        public FormInvitados()
        {
            InitializeComponent();
            g = new GestorDGV();
            ga = new GestorAfiliados();
        }

        private void FormInvitados_Load(object sender, EventArgs e)
        {
            g.efectosDGV(dataGridView1);
            ga.CargarCombo(cboMesesHabilitados);
        }

        
    }
}
