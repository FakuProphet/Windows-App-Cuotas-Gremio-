
using System.Threading;
using System.Windows.Forms;

namespace WindowsCuotasApp
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            //Thread t = new Thread(new ThreadStart(Splash));
            //t.Start();
            InitializeComponent();
            //string cadena = string.Empty;
            //for (int i = 0; i < 1000; i++)
            //{
            //    cadena += i.ToString();
            //}
            //t.Abort();
        }

        //void Splash()
        //{
        //    SplashScreen.SplashForm nuevo = new SplashScreen.SplashForm();
        //    nuevo.AppName = "AFIL 2";
        //    Application.Run(nuevo);
        //}

        private void FormSplash_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
