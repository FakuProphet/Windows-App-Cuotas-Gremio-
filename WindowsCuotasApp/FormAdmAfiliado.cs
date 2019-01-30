using System;
using System.Data;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;

namespace WindowsCuotasApp
{
    public partial class FormAdmAfiliados : MetroFramework.Forms.MetroForm
    {

        GestorAfiliados g;
        public FormAdmAfiliados()
        {
            InitializeComponent();
            g = new GestorAfiliados();
        }

        private void FormAdmAfiliado_Load(object sender, EventArgs e)
        {
            cargarTodosLosCombos();
            comprobarLista();
        }

        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = g.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = 0;
        }


        private void cargarTodosLosCombos()
        {
            cargarCombo(cboLocalidades, "localidades");
            cargarCombo(cboForma, "formasPago");
            cargarCombo(cboTipoSocio, "tiposAfiliado");
            combosPorDefecto();
        }


        private void comprobarLista()
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Lista Vacia.");
                btnActualizar.Enabled = false;
            }
            else
                listBox1.SelectedIndex = 0;
        }


        private void combosPorDefecto()
        {

            if (cboLocalidades.Items.Count != 0)
            {
                cboLocalidades.SelectedValue = 59;
            }
           
            txtEmail.Text = "@";
        }



        private void seleccionCombo()
        {
            if(cboForma.SelectedIndex==1)
            {
                txtCbu.Enabled = true;
            }
            else
            {
                txtCbu.Enabled = false;
            }
        }



        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
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

        private void soloTexto(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender,e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender,e);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionCombo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }
    }
}
