

namespace WindowsCuotasApp.Clases.LOGUIN
{
    class Login
    {
        private int nro;
        private string usuario;
        private string hora;
        private string fecha;

        public Login()
        {
        }

        public Login(int nro, string usuario, string hora, string fecha)
        {
            this.Nro = nro;
            this.Usuario = usuario;
            this.Hora = hora;
            this.Fecha = fecha;
        }

        public int Nro { get => nro; set => nro = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
