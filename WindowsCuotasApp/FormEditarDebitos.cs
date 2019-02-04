using System;
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
            gestorDGV.cargarDataGrid(dgvListadoSalida, "SELECT * FROM V_DETALLE_CUOTAS_DEL_MES_ANIO_ACTUAL ORDER BY 1");
            gestorDGV.efectosDGV(dgvListadoSalida);
            gestorDGV.efectosDGV(dgvListadoEntrada);
        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
         
        }



        private void dgvListadoEntrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Borrar una fila del DGV*/
            if (dgvListadoEntrada.CurrentRow.Index != -1)
            {
                int fila = dgvListadoEntrada.CurrentRow.Index;
                dgvListadoEntrada.Rows.RemoveAt(fila);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvListadoSalida.SelectedRows)
            {
                string nroComprobante = fila.Cells[0].Value.ToString();
                string nombreCompleto = fila.Cells[1].Value.ToString();
                string nroDoc = fila.Cells[2].Value.ToString();
                dgvListadoEntrada.Rows.Add(nroComprobante, nombreCompleto, nroDoc);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
