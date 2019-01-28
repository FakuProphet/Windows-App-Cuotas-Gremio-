using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCuotasApp.Clases
{
    class PagoCuota
    {
        public int numero { get; set; }
        public int afiliadoID { get; set; }
        public string afiliadoDescripcion { get; set; }
        public string fecha { get; set; }
        public int formaPagoID { get; set; }
        public int mes { get; set; }
        public int anio { get; set; }
    }
}
