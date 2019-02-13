using System.Windows.Forms;

namespace WindowsCuotasApp
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();   
        }

       

      

        private void FormSplash_Load(object sender, System.EventArgs e)
        {
            
        }
        int contador = 0;
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            
            contador += 3;
            lblContador.Text = contador.ToString()+"%";
            if ( contador >= 100)
            {
                timer1.Stop();
                this.Hide();
                FormLogin fl = new FormLogin();
                fl.ShowDialog();
            }
        }
    }
}
