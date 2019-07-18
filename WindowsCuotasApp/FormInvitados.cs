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
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
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
            MiMes();
            ValidarCierreFacturacion();

        }

        private void cboMesesHabilitados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string miMes = cboMesesHabilitados.SelectedText;
            g.cargarDataGrid(dataGridView1, consulta: "select * from v_invitado_uno where Mes like '" + miMes + "' ");
            g.efectosDGV(dataGridView1);
        }

        private void ValidarCierreFacturacion()
        {
            DateTime fecha = DateTime.Now;
            int diaDelMes = fecha.Day;

            if (diaDelMes > 17)
            {
                btnFiltro.Enabled = true;
            }
        }


        private void MiMes()
        {
            DateTime hoy = DateTime.Now;
            string mes = hoy.ToString("MMMM"); //te da el nombre completo en la cultura default
            lblMesActual.Text = mes.ToUpper();
            // string mes2 = hoy.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US")); //en ingles
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string miMes = lblMesActual.Text.Trim();
            g.cargarDataGrid(dataGridView2, consulta: "select * from v_invitado_uno where Mes like '" + miMes + "' ");
            g.efectosDGV(dataGridView2);
        }

        private void txtFiltroDni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("DNI LIKE '{0}%' OR DNI LIKE '% {0}%'", txtFiltroDni.Text);

            }
            catch (Exception)
            {

               
            }

        }
    }
}
