using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    //FORMULARIO PARA LISTAR LOS AFILIADOS QUE EFECTUAN PAGO POR DEBITO.
    public partial class FormListadoSociosCuotas : MetroFramework.Forms.MetroForm
    {


        GestorAfiliados gestorAfiliados;
        GestorDGV gestorDGV;



        public FormListadoSociosCuotas()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
            gestorAfiliados = new GestorAfiliados();
            mostrarMes();
        }


        private void FormListadoSociosCuotas_Load(object sender, EventArgs e)
        {
            gestorDGV.efectosDGV(dataGridView1);
            gestorDGV.cargarDataGrid(dataGridView1, "SP_LISTADO_AFIL_DEBITO");
            cargarDatosCuotasCanceladasMesAnioActual();
            inicio();
        }

        private void inicio()
        {
            if (gestorAfiliados.IsPedidoDebitosRealizada())
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }


        private void mostrarMes()
        {
            Fecha fecha = new Fecha();
            lblMes.Text = (fecha.getMes() - 1).ToString();
            lblAnio.Text = fecha.getAnio().ToString();
            lblDetalleMes.Text = fecha.detalleMes(Convert.ToInt16(fecha.getMes()-1));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormReporte nuevo = new FormReporte();
            nuevo.ShowDialog();
        }


        void cargarDatosCuotasCanceladasMesAnioActual()
        {
            gestorDGV.cargarDataGrid(dataGridView2, "SELECT * FROM V_MES_PAGOS_DEBITO_ESTADO ORDER BY 1");
            gestorDGV.efectosDGV(dataGridView2);
            gestorDGV.PersonalizarColorCeldasDGV(dataGridView2,6,"Cancelada");
        }


        private void button2_Click(object sender, EventArgs e)
        {

            Fecha fecha;
            TransaccionCuotaAfiliado t;
            Afiliado nuevo;
            int filasAfectadas=0;
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Desea registrar pagos por defecto?", "Débito de afiliado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        t = new TransaccionCuotaAfiliado();
                        nuevo = new Afiliado();
                        fecha = new Fecha();
                        nuevo.afiliadoID = Convert.ToInt32(fila.Cells[0].Value);
                        t.a = nuevo;
                        t.fecha = fecha;
                        gestorAfiliados.GenerarTransaccionCuota(t);
                        filasAfectadas++;
                    }

                    gestorAfiliados.SolicitudDebito(fecha = new Fecha());
                    MetroFramework.MetroMessageBox.Show(this, "Transacciones completadas con éxito. " + "\n" + "Cantidad de registros:" + filasAfectadas, "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatosCuotasCanceladasMesAnioActual();
                    inicio();
                }
            }

            catch (SqlException error)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en la transacción: " + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
    }
}
