using System.Collections;
using System.Data;
using System.Data.SqlClient;
using WindowsCuotasApp.Clases.DTO;

namespace WindowsCuotasApp.Clases
{
    class GestorAfiliados
    {
        SqlCommand cmd;
        SqlDataReader dr;
        //const int tam = 1000;



        public SqlDataReader pDr
        { set { Dr = value; } get { return Dr; } }

        public SqlDataReader Dr { get => dr; set => dr = value; }

        public void GenerarTransaccionCuota(TransaccionCuotaAfiliado t)
        {
            SqlCommand cmd = new SqlCommand("SP_TRANSACCION_CUOTA_AFIL", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AFILIADOID", SqlDbType.Int).Value = t.a.afiliadoID;
            cmd.Parameters.Add("@ANIO", SqlDbType.Int).Value = t.fecha.getAnio();
            cmd.Parameters.Add("@MES", SqlDbType.Int).Value = t.fecha.getMes();
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();
        }

        public void UpdateTransaccion(TransaccionCuotaAfiliado t)
        {
            SqlCommand cmd = new SqlCommand("SP_TRANSACCION_CUOTA_AFIL_UPDATE", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NROCOMPROBANTE", SqlDbType.Int).Value = t.nro;
            cmd.Parameters.Add("@CONDICION", SqlDbType.Int).Value = t.condicion;
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();
        }

        public void SolicitudDebito(Fecha fecha )
        {
            SqlCommand cmd = new SqlCommand("SP_SOLICITUD_DEBITO", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ANIO", SqlDbType.Int).Value = fecha.getAnio();
            cmd.Parameters.Add("@MES", SqlDbType.Int).Value = fecha.getMes();
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();
        }


        public void RegistrarAfiliado(Afiliado a ,string sp, int evento)
        {
                
            SqlCommand cmd = new SqlCommand(sp,Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = a.nombre;
            cmd.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = a.apellido;
            cmd.Parameters.AddWithValue("@nroDoc", SqlDbType.Int).Value = a.nroDoc;
            cmd.Parameters.AddWithValue("@fechaNac", SqlDbType.VarChar).Value = a.fechaNac;
            cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = a.email;
            cmd.Parameters.AddWithValue("@nroTel", SqlDbType.VarChar).Value = a.nroTel;
            cmd.Parameters.AddWithValue("@direccion", SqlDbType.VarChar).Value = a.direccion;
            cmd.Parameters.AddWithValue("@barrio", SqlDbType.VarChar).Value = a.barrio;
            cmd.Parameters.AddWithValue("@localidad", SqlDbType.Int).Value = a.localidad;
            cmd.Parameters.AddWithValue("@tipoAfiliadoID", SqlDbType.Int).Value = a.tipoAfiliado;
            cmd.Parameters.AddWithValue("@metodoPagoID", SqlDbType.Int).Value = a.formaPago;
            cmd.Parameters.AddWithValue("@nroCuenta", SqlDbType.VarChar).Value = a.cbu;

            /*Update*/
            if (evento==2)
            {
                cmd.Parameters.AddWithValue("@estadoGremialID", SqlDbType.Int).Value = a.estadoGremialID;
                cmd.Parameters.AddWithValue("@afiliadoID", SqlDbType.Int).Value = a.afiliadoID;
                
            }
           
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();

        }

       


        public void RegistrarPago(string procedimiento)
        {
            SqlCommand cmd = new SqlCommand(procedimiento,Conectar.ObtenerConexion());
        }

        
        public ArrayList ListadoAfiliados()
        {
            ArrayList listado = new ArrayList();
            Afiliado nuevo;
            cmd = new SqlCommand("select * from afiliados order by 4", Conectar.ObtenerConexion());
            
            Dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();
            while(Dr.Read())
            {
                int idAfiliado = Dr.GetInt32(0);
                string nombre = Dr.GetString(1);
                string apellido = Dr.GetString(2);
                int nroDoc = Dr.GetInt32(3);
                string fechaNac = Dr.GetString(4);
                string email = Dr.GetString(5);
                string nroTel = Dr.GetString(6);
                string direccion = Dr.GetString(7);
                string barrio = Dr.GetString(8);
                int idLocalidad = Dr.GetInt32(9);
                int tipoAfilID = Dr.GetInt32(10);
                int metodoPagoID = Dr.GetInt32(11);
                string nroCuenta = Dr.GetString(12);
                int estadoGremialID = Dr.GetInt32(13);

                nuevo = new Afiliado(idAfiliado,nombre,apellido,nroDoc,fechaNac,email,nroTel,
                                    direccion,barrio,idLocalidad,tipoAfilID,metodoPagoID,nroCuenta,estadoGremialID);
                listado.Add(nuevo);
            }

            return listado;
        }

        public AfiliadoDTO GetAfiliado(int parametroDoc,int parametroMetodoPago)
        {

            AfiliadoDTO afiliado = null;
            
            cmd = new SqlCommand("P_GET_AFILIADO_POR_DNI_MET_PAGO", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NRODOC", SqlDbType.Int).Value = parametroDoc;
            cmd.Parameters.Add("@METODOPAGO", SqlDbType.Int).Value = parametroMetodoPago;
            Dr =cmd.ExecuteReader();
            Conectar.CerrarConexion();
            if (Dr.Read())
            {
                
                string nombreCompleto = Dr.GetString(0);
                int nroDoc = Dr.GetInt32(1);
                string tipoAfiliado = Dr.GetString(2);
                string estado = Dr.GetString(3);
                string formaPago = Dr.GetString(4);
                int codigo = Dr.GetInt32(5);

                afiliado = new AfiliadoDTO
                {
                    codigo = codigo,
                    nombreCompleto = nombreCompleto,
                    nroDocumento = nroDoc,
                    tipoAfiliado = tipoAfiliado,
                    estado = estado,
                    formaPago = formaPago
                };
            }
            
            return afiliado;
        }

        /*Mediante un procedimiento se obtienen las cantidades actuales de lo solicitado*/
        public int Get(string parametroSP)
        {

            int cantidad = 0;

            cmd = new SqlCommand(parametroSP, Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
           
            Dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();
            if (Dr.Read())
            {
                cantidad = Dr.GetInt32(0);
            }

            return cantidad;
        }



        public Afiliado GetAfiliadoPorDni(int parametroDoc)
        {

            Afiliado afiliado = null;

            cmd = new SqlCommand("SP_GET_AFIL_DNI", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@DOC", SqlDbType.Int).Value = parametroDoc;
           
            Dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();
            if (Dr.Read())
            {

                int nroDoc = Dr.GetInt32(0);
                afiliado = new Afiliado(nroDoc);
               
            }

            return afiliado;
        }


        public bool IsPedidoDebitosRealizada()
        {
            bool flag = false;
            Fecha fecha = new Fecha();
            cmd = new SqlCommand("SP_AUDITORIA_CONSULTA", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MES", SqlDbType.Int).Value =  fecha.getMes();
            cmd.Parameters.Add("@ANIO", SqlDbType.Int).Value = fecha.getAnio();
            Dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();

            if (Dr.Read())
            {
                flag = true;
            }

            return flag;
        }

        public bool IsMesPago(int afiliadoID,int anio)
        {
            bool flag = false;
            cmd = new SqlCommand("SP_IS_PAGADO_MES", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AFILIADOID", SqlDbType.Int).Value = afiliadoID;
            cmd.Parameters.Add("@ANIO", SqlDbType.Int).Value = anio;
            Dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();

            if (Dr.Read())
            {
                flag = true;
            }
            
            return flag;
        }


        


        public DataTable ConsultarTabla(string nombreTabla)
        {       
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = new SqlCommand("SELECT * FROM " + nombreTabla, Conectar.ObtenerConexion());
            da.Fill(ds);
            dt = ds.Tables[0];
            Conectar.CerrarConexion();
            return dt;
        }
    }
}
