using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCuotasApp.Clases
{
    class Anotacion
    {
        private int numero;
        private string fecha;
        private string contenido;
        private DateTime fechaLarga;

        public Anotacion()
        {
        }

       

        public int Numero { get => numero; set => numero = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public DateTime FechaLarga { get => fechaLarga; set => fechaLarga = value; }
    }
}
