using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;
using WindowsCuotasApp.Clases.DTO;

namespace WindowsCuotasApp
{
    public partial class FormParametroPago : MetroFramework.Forms.MetroForm
    {

       
        private GestorAfiliados gestorAfiliados;
        private AfiliadoDTO a;
        public FormParametroPago()
        {
            InitializeComponent();
            gestorAfiliados = new GestorAfiliados();
            
        }


        private void FormParametroPago_Load(object sender, EventArgs e)
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

        void inicio()
        {
            txtParametro.Focus();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender,e);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {

                int parametro = Convert.ToInt32(txtParametro.Text);
                int parametroDos = 1;/*debito*/
                

                if(!string.IsNullOrEmpty(txtParametro.Text))
                {
                    a = gestorAfiliados.GetAfiliado(parametro,parametroDos);
                    if(a != null)
                    {
                        btnContinuar.Enabled = true;                      
                        lblCheck.ForeColor = Color.Green;
                    }
                    else
                    {
                        btnContinuar.Enabled = false;
                        lblCheck.ForeColor = Color.Red;
                    } 
                }
            }
            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en la transacción: " + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParametro.Focus();
            }

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,"Desea proseguir con el cobro al afiliado: " + a.nombreCompleto.ToUpper() + " documento número: " + a.nroDocumento + " ?", "Cobro Cuotas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPagoCuota nuevo = new FormPagoCuota(a);
                this.Dispose();
                nuevo.ShowDialog();
            }
        }
    }
}
