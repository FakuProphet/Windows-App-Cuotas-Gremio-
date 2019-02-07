using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormEditarDebitos : MetroFramework.Forms.MetroForm
    {

        private string parametro;
        GestorDGV gestorDGV;
        private GestorAfiliados Gestor;

        public FormEditarDebitos()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
            Gestor = new GestorAfiliados();            
        }


        private void FormEditarDebitos_Load(object sender, EventArgs e)
        {
            gestorDGV.efectosDGV(dgvListadoSalida);
            gestorDGV.efectosDGV(dgvListadoEntrada);
            Inicio();
        }

       
        private void Inicio()
        {
           if (dgvListadoEntrada.DataSource == null)
           {
                btnEfectuarCambios.Enabled = false;
           }
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
                txtFiltrar.Clear();
                dgvListadoSalida.DataSource=null;
                txtFiltrar.Focus();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

       

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            parametro = txtFiltrar.Text;
            

            try
            {
                if (!string.IsNullOrEmpty(parametro))
                {
                    var consulta = "P_DETALLE_CUOTA_MES_ANIO_ACTUAL_POR_DNI " + parametro;
                    gestorDGV.cargarDataGrid(dgvListadoSalida, consulta);
                    
                }
                
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al efectuar la consulta", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }

        private void txtFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnEfectuarCambios_Click(object sender, EventArgs e)
        {
            TransaccionCuotaAfiliado t;
            const int condicion = 2;
            int contador = 0;
            try
            {


                foreach (DataGridViewRow fila in dgvListadoEntrada.Rows)
                {
                    t = new TransaccionCuotaAfiliado();
                    t.nro = Convert.ToInt32(fila.Cells[0].Value);
                    t.condicion = condicion;
                    Gestor.UpdateTransaccion(t);
                    contador++;
                }

                MetroFramework.MetroMessageBox.Show(this, "Se completaron con exito la transacciones: " + "\n" + "Total de registros actualizados: " + contador.ToString().ToUpper(), "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvListadoEntrada.DataSource = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al efectuar la transacción: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
