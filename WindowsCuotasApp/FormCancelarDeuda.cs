using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormCancelarDeuda : MetroFramework.Forms.MetroForm
    {
        GestorDGV gestorDGV;
        GestorAfiliados ga;
        private ArrayList listaMesesID = new ArrayList();
        int dni = 0;
        public FormCancelarDeuda()
        {
            InitializeComponent();
            gestorDGV = new GestorDGV();
            ga = new GestorAfiliados();
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


        private void SelecccionDeMesesAPagar()
        {
            int c = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
               bool check = Convert.ToBoolean(row.Cells[2].Value) ;

                if (check)
                {
                    listaMesesID.Add(Convert.ToInt32(row.Cells[0].Value));
                    c++;         
                }    
                       
                               
            }

            if(listaMesesID.Count>0)
            {
                btnContinuar.Enabled = true;
                btnCancelar.Enabled = true;
                dni = Convert.ToInt32( txtDni.Text);
            }

            label2.Text = c.ToString();
        }


       

  
        private void button1_Click_1(object sender, EventArgs e)
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

        private void btnCargarDatos_Click(object sender, EventArgs e) => SelecccionDeMesesAPagar();

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            dni = Convert.ToInt32(txtDni.Text);
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Desea registrar el pago del afiliado, dni nro: " + dni + "?", "Confirmación de pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dni > 0)
                    {
                        foreach (Object objMes in listaMesesID)
                        {
                            int m = (Int32)objMes;
                            ga.TransaccionCancelarDeuda(m,dni);
                        }

                        this.Dispose();
                    }
                }
               
            }
            catch (Exception)
            {

                
            }
        }

        private void habilitarControles(bool x)
        {
            txtDni.Enabled = x;
            btnCargarDatos.Enabled = x;
            dataGridView1.Enabled = x;
            btnContinuar.Enabled = x;
            btnConfirmarPago.Enabled = !x;
            button1.Enabled = x;
        }


        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Desea continuar con la cancelación de la deuda de el afiliado, dni nro: " + dni + "?", "Cancelación deuda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                habilitarControles(false);
            }
            
        }
    }
}
