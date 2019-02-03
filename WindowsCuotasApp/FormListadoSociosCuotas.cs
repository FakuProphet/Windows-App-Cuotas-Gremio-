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
            gestorDGV.cargarDataGrid(dataGridView1, "EXEC SP_LISTADO_AFIL_DEBITO");
        }

        private void mostrarMes()
        {
            Fecha fecha = new Fecha();
            lblMes.Text = fecha.getMes().ToString();
            lblAnio.Text = fecha.getAnio().ToString();
            lblDetalleMes.Text = fecha.detalleMes(Convert.ToInt16(fecha.getMes().ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReporte nuevo = new FormReporte();
            nuevo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            try
            {
                Fecha fecha;
                TransaccionCuotaAfiliado t;
                Afiliado nuevo;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    t = new TransaccionCuotaAfiliado();
                    nuevo = new Afiliado();
                    fecha = new Fecha();
                    nuevo.afiliadoID = Convert.ToInt32(fila.Cells[0].Value);
                    t.a = nuevo;
                    fecha.getAnio();
                    fecha.getMes();
                    t.fecha = fecha;
                    gestorAfiliados.generarTransaccionCuota(t);
                }
            }

            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en la transacción: " + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Conectar.CerrarConexion();
            }


        }
    }
}
