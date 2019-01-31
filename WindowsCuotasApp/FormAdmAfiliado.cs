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
            cargarCombo(cboTipoAfil, "tiposAfiliado");
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

            int seleccionFormaPago = Convert.ToInt32(cboForma.SelectedValue);

            try
            {
               

               
                    Afiliado nuevo = new Afiliado();
                    nuevo.nombre = txtNombre.Text;
                    nuevo.apellido = txtApellido.Text;
                    nuevo.nroDoc = Convert.ToInt32(txtNroDoc.Text);
                    nuevo.nroTel = txtNroTel.Text;
                    nuevo.email = txtEmail.Text;
                    nuevo.fechaNac = dtpFechaNac.Value.ToShortDateString();
                    nuevo.localidad = Convert.ToInt32(cboLocalidades.SelectedValue);
                    nuevo.formaPago = Convert.ToInt32(cboForma.SelectedValue);
                    nuevo.tipoAfiliado = Convert.ToInt32(cboTipoAfil.SelectedValue);
                    nuevo.barrio = txtBarrio.Text;
                    nuevo.direccion = txtDir.Text;
                    nuevo.cbu = txtCbu.Text;

                    if (MetroFramework.MetroMessageBox.Show(this, "Desea registrar el afiliado dni nro: " + nuevo.nroDoc + "?", "Alta de afiliado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (seleccionFormaPago == 2)
                        {
                            g.registrarAfiliado(nuevo, "proc_insertar_afiliado_b");
                        }
                        else
                        {
                            g.registrarAfiliado(nuevo, "proc_insertar_afiliado_a");
                        }
                    }
                    else
                    {

                    }
                
               
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Error en el registro del afiliado: " + ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }
    }
}
