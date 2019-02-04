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
    public partial class FormEditarDebitos : MetroFramework.Forms.MetroForm
    {

        GestorDGV gestorDGV;
        public FormEditarDebitos()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
        }

        private void FormEditarDebitos_Load(object sender, EventArgs e)
        {
           
            gestorDGV.cargarDataGrid(dgvListadoSalida, "SP_LISTADO_AFIL_DEBITO");
            gestorDGV.efectosDGV(dgvListadoSalida);
            gestorDGV.efectosDGV(dgvListadoEntrada);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvListadoSalida.SelectedRows)
            {
                string nroComprobante =  fila.Cells[2].Value.ToString();
                string nombre = fila.Cells[3].Value.ToString();
                dgvListadoEntrada.Rows.Add(nombre, nroComprobante);
            }

            //For Each ROW As DataGridViewRow In DataGridView1.SelectedRows
            //Dim id As String = ROW.Cells("ID").Value
            //Dim nombre As String = ROW.Cells("NOMBRE").Value
            //DataGridView2.Rows.Add(id, nombre)
            //Next
        }
    }
}
