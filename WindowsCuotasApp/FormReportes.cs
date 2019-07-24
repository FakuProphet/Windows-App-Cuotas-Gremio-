using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormReportes : MetroFramework.Forms.MetroForm
    {
        private Validar validar;
        private GestorDGV GestorDGV;
        private GestorAfiliados GestorAfiliados;
        public FormReportes()
        {
            InitializeComponent();
            validar = new Validar();
            GestorDGV = new GestorDGV();
            GestorAfiliados = new GestorAfiliados();
        }

        private void FormReportes_Load(object sender, EventArgs e) => inicio();


        private void txtParametroDni_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            validar.soloNumeros(sender,e);
            
        }

        void inicio ()
        {  
            GestorDGV.cargarDataGrid(dataGridView3, "SELECT * FROM V_DETALLE_CUOTAS_DEL_MES_ANIO_ACTUAL ORDER BY 1");
            GestorDGV.efectosDGV(dataGridView3);
            GestorDGV.PersonalizarColorCeldasDGV(dataGridView3, 6, "Cancelada");
            GestorDGV.colorCeldasDGV(dataGridView3, Color.Aqua, 7);
            GestorDGV.colorCeldasDGV(dataGridView3, Color.IndianRed, 1);
            // GestorDGV.DeshabilitarOrdenarDGV(dataGridView3);
            MiMes();
        }


        private void MiMes()
        {
            Fecha f = new Fecha();
            DateTime hoy = DateTime.Now;
            int mes = hoy.Month - 1;
            string mesPasado = f.detalleMes(mes);
            groupBox3.Text = "Detalle de pagos año " + f.getAnio() + " para el mes de: "+mesPasado.ToUpper();        
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtParametroDni.Text))
                {
                    int dni = Convert.ToInt32(txtParametroDni.Text);
                    GestorDGV.cargarDataGrid(dataGridView1, "SP_FILTRO " + dni);
                    GestorDGV.efectosDGV(dataGridView1);
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en la consulta posibles causas: " +"\n"+ " No existe dni del afiliado " + "\n"+ " Posible error en la conexión. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtParametroDos.Text))
                {
                    int dni = Convert.ToInt32(txtParametroDos.Text);
                    GestorDGV.cargarDataGrid(dataGridView2, "SP_FILTRO_CUOTAS_POR_DNI_ANIO_PASADO " + dni);
                    GestorDGV.efectosDGV(dataGridView2);
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en la consulta posibles causas: " + "\n" + " No existe dni del afiliado " + "\n" + " Posible error en la conexión. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

     
        }

        private void txtParametroDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(sender,e);
        }
    }
}
