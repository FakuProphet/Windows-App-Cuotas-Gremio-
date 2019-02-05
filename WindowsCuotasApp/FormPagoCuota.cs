using System;
using System.Windows.Forms;
using WindowsCuotasApp.Clases;
using WindowsCuotasApp.Clases.DTO;

namespace WindowsCuotasApp
{
    public partial class FormPagoCuota : MetroFramework.Forms.MetroForm
    {
        private AfiliadoDTO afiliado;
        GestorAfiliados gestorAfiliados;
        public FormPagoCuota(AfiliadoDTO a)
        {
            InitializeComponent();
            afiliado = a;
            gestorAfiliados = new GestorAfiliados();
        }

        private void FormPagoCuota_Load(object sender, EventArgs e) => inicio();

        private void inicio()
        {
            lblCodigoAfil.Text = afiliado.codigo.ToString();
            lblNombreAfil.Text = afiliado.nombreCompleto;
            lblTipoAfiliado.Text = afiliado.tipoAfiliado;
            lblNroDoc.Text = afiliado.nroDocumento.ToString();
            lblEstadoAfil.Text = afiliado.estado;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            Fecha fecha;
            TransaccionCuotaAfiliado t;
            Afiliado nuevo;
            
            try
            {
               
                    t = new TransaccionCuotaAfiliado();
                    nuevo = new Afiliado();
                    fecha = new Fecha();
                    nuevo.afiliadoID = afiliado.codigo;
                    t.a = nuevo;
                    t.fecha = fecha;
                    gestorAfiliados.GenerarTransaccionCuota(t);
                    MetroFramework.MetroMessageBox.Show(this, "Transaccion completada con éxito.", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error en la transacción: " + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
