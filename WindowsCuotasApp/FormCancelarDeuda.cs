using System;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormCancelarDeuda : MetroFramework.Forms.MetroForm
    {
        GestorDGV gestorDGV;
        public FormCancelarDeuda()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
        }

        private void FormCancelarDeuda_Load(object sender, EventArgs e)
        {

        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDni.Text))
                {
                    int dni = Convert.ToInt32(txtDni.Text);
                    gestorDGV.cargarDataGrid(dataGridView1, "SP_FILTRO_AFIL_SEDE " + dni);
                    gestorDGV.efectosDGV(dataGridView1);
                    DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                    col.ReadOnly = false;
                    dataGridView1.Columns.Add(col);
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;

                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en la consulta posibles causas: " + "\n" + " No existe dni del afiliado " + "\n" + " El afiliado paga por otro medio " + "\n" + " Posible error en la conexión. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dataGridView1.DataSource = null;
            }
        }
    }
}
