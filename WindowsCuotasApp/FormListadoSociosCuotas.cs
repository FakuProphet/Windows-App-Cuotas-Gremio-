using System;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    //FORMULARIO PARA LISTAR LOS AFILIADOS QUE EFECTUAN PAGO POR DEBITO.
    public partial class FormListadoSociosCuotas : MetroFramework.Forms.MetroForm
    {



        GestorDGV gestorDGV;

        public FormListadoSociosCuotas()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
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
            
            
                Fecha fecha = new Fecha();
            GestorTransaccion t = new GestorTransaccion();
                
                foreach  (DataGridViewRow fila in dataGridView1.Rows)
                {
                    /*
                    CuotaAfiliado c = new CuotaAfiliado();
                    c.afiliadoID = Convert.ToInt32(fila.Cells[0].Value);
                    c.anio = fecha.getAnio();
                    c.mes = fecha.getMes();
                    */
                    int id = Convert.ToInt32(fila.Cells[0].Value);
                    t.transaccionCuotaAfiliado(id,fecha.getMes(),fecha.getAnio());
                }
            
            // catch (Exception error)
            
            //    MetroFramework.MetroMessageBox.Show(this, "Error en la transacción: " + error.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
