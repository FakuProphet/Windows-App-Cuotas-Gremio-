using System;
using WindowsCuotasApp.Clases.DTO;

namespace WindowsCuotasApp
{
    public partial class FormPagoCuota : MetroFramework.Forms.MetroForm
    {
        private AfiliadoDTO afiliado;
        
        public FormPagoCuota(AfiliadoDTO a)
        {
            InitializeComponent();
            afiliado = a;
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



    }
}
