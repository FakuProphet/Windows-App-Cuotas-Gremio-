

namespace WindowsCuotasApp.Clases
{
    public class Afiliado
    {
        /*
         La forma de pago se establece en el afiliado
         porque es una regla de negocio, por el momento
         no es un debito automatico, sino que hay afiliados a los cuales
         se los identifica como afiliados que pagan por medio de una persona
         que realiza los debitos. 
         El otro tipo de afiliado es el que paga en sede, y a este se le cobra personalmente
         en la sede gremial.
         En este ejemplo de app,  no he aplicado herencia ni composicion,
         solo se plantea el modelo de la tabla en BBDD.
         */
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
        public int estadoGremialID { get; set; }
    
        public Afiliado() { }

        public Afiliado(int afiliadoID, string nombre, string apellido, int nroDoc, string fechaNac, string email, string nroTel, string direccion, string barrio, int localidad, int tipoAfiliado, int formaPago, string cbu, int estadoGremialID)
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
            this.estadoGremialID = estadoGremialID;
        }

        public Afiliado(int nroDoc)
        {
            this.nroDoc = nroDoc;
        }
    }
}
