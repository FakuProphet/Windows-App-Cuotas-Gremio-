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
            /*Si la cuota existe, no se muestra el formulario de pago*/
            Fecha fecha = new Fecha();
            bool condicion = gestorAfiliados.IsMesPago(afiliado.codigo, fecha.getAnio());
            if(condicion)
            {
                MetroFramework.MetroMessageBox.Show(this, "El afiliado documento nro: " +afiliado.nroDocumento + " ha cancelado la cuotas del mes"  ,afiliado.nombreCompleto.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblCodigoAfil.Text = afiliado.codigo.ToString();
                lblNombreAfil.Text = afiliado.nombreCompleto;
                lblTipoAfiliado.Text = afiliado.tipoAfiliado;
                lblNroDoc.Text = afiliado.nroDocumento.ToString();
                lblEstadoAfil.Text = afiliado.estado;
                MiMes();
            }
        }

        private void MiMes()
        {
            Fecha f = new Fecha();
            DateTime hoy = DateTime.Now;
            int mes = hoy.Month - 1;
            string mesPasado = f.detalleMes(mes);
            lblMes.Text = mesPasado;
            //string mes = hoy.ToString("MMMM"); //te da el nombre completo en la cultura default
            //lblMes.Text = mes.ToUpper();
            // string mes2 = hoy.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US")); //en ingles
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
                    if (MetroFramework.MetroMessageBox.Show(this, "Desea continuar con el pago de la cuota del afiliado", "Pago cuota en sede", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gestorAfiliados.GenerarTransaccionCuota(t);
                        MetroFramework.MetroMessageBox.Show(this, "Transaccion completada con éxito.", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }

                catch (Exception error)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error en la transacción: " + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
                    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
