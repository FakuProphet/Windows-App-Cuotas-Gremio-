using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCuotasApp.Clases
{
    class Afiliado
    {
         public int afiliadoID { get; set; }
         public string nombre { get; set; }
         public string apellido { get; set; }
         public int nroDoc { get; set; }
         public string fechaNac { get; set; }
         public string email { get; set; }
         public string nroTel { get; set; }
         public string direccion { get; set; }
         public string barrio { get; set; }
         public int localidad { get; set; }
         public int tipoAfiliado { get; set; }
         public int formaPago { get; set; }
         public string cbu { get; set; }
    }
}
