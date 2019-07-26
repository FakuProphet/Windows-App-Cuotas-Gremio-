using System;
using System.Data;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;
using WindowsCuotasApp.Clases.LOGUIN;

namespace WindowsCuotasApp
{
    public partial class FormAnotaciones : MetroFramework.Forms.MetroForm
    {
        private const string Consulta = "select * from anotaciones order by fechaLarga desc";
        GestorAfiliados g;
        GestorLoguin gl;
        public FormAnotaciones()
        {
            InitializeComponent();
            g = new GestorAfiliados();
            gl = new GestorLoguin();
        }

        private void FormAnotaciones_Load(object sender, EventArgs e)
        {
            CargarCombo(cboFechaAnotaciones, Consulta);
        }

        private void DatosIniciales()
        {
            DateTime date = DateTime.Now;
            txtAnotacion.Text = "Anotación generada por:"+ Ingreso.descripcionUsuario;    
        }




        private void CargarCombo(ComboBox combo, string consulta)
        {
            DataTable tabla = new DataTable();
            tabla = g.Consultar(consulta);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void btnNuevaNota_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Desea crear una nueva anotación?", "Nueva anotación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnCancelar.Enabled = true;
                btnGrabarNota.Enabled = true;
                btnNuevaNota.Enabled = false;
                cboFechaAnotaciones.Enabled = false;
                lblFechaLarga.Text = "...";
                lblHora.Text = "...";
                DatosIniciales();
                txtAnotacion.Enabled = true;
                txtAnotacion.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Desea cancelar la anotación?", "Cancelar anotación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                FormAnotaciones n = new FormAnotaciones();
                n.ShowDialog();
            }
        }

        private void btnGrabarNota_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtAnotacion.Text;
                if (MetroFramework.MetroMessageBox.Show(this, "Desea registrar la anotación?", "Anotación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gl.GuardarAnotacion(texto);
                    MetroFramework.MetroMessageBox.Show(this, "Se ha registrado la anotación correctamente.", "Proceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    FormAnotaciones n = new FormAnotaciones();
                    n.ShowDialog();
                }


            }
            catch (Exception)
            {

                
            }
        }

        private void cboFechaAnotaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Anotacion nueva = new Anotacion();
                int numero = Convert.ToInt32 (cboFechaAnotaciones.SelectedValue);
                nueva = gl.GetAnotacion(numero);
                lblHora.Text = nueva.FechaLarga.ToLongTimeString();
                lblFechaLarga.Text = nueva.FechaLarga.ToLongDateString();
                txtAnotacion.Text = nueva.Contenido;
            }
            catch (Exception)
            {

                
            }
                
            
        }
    }
}
