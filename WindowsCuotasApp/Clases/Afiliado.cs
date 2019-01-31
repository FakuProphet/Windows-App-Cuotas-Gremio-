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


         
         public Afiliado() { }

        public Afiliado(int afiliadoID, string nombre, string apellido, int nroDoc, string fechaNac, string email, string nroTel, string direccion, string barrio, int localidad, int tipoAfiliado, int formaPago, string cbu)
        {
            this.afiliadoID = afiliadoID;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nroDoc = nroDoc;
            this.fechaNac = fechaNac;
            this.email = email;
            this.nroTel = nroTel;
            this.direccion = direccion;
            this.barrio = barrio;
            this.localidad = localidad;
            this.tipoAfiliado = tipoAfiliado;
            this.formaPago = formaPago;
            this.cbu = cbu;
        }
    }
}
