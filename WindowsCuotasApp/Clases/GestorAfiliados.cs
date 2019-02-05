﻿using System.Collections;
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
        { set { dr = value; } get { return dr; } }


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


        public void registrarAfiliado(Afiliado a , string nombreProc )
        {
                
          
            SqlCommand cmd = new SqlCommand(nombreProc,Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = a.nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = a.apellido;
            cmd.Parameters.Add("@nroDoc", SqlDbType.Int).Value = a.nroDoc;
            cmd.Parameters.Add("@fechaNac", SqlDbType.VarChar).Value = a.fechaNac;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = a.email;
            cmd.Parameters.Add("@nroTel", SqlDbType.VarChar).Value = a.nroTel;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = a.direccion;
            cmd.Parameters.Add("@barrio", SqlDbType.VarChar).Value = a.barrio;
            cmd.Parameters.Add("@localidad", SqlDbType.Int).Value = a.localidad;
            cmd.Parameters.Add("@tipoAfiliado", SqlDbType.Int).Value = a.tipoAfiliado;
            cmd.Parameters.Add("@metodoPagoID", SqlDbType.Int).Value = a.formaPago;
            if (a.formaPago == 2)
            {
                cmd.Parameters.Add("@nroCuenta", SqlDbType.VarChar).Value = a.cbu;
            }
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();


        }


        public void registrarPago(string procedimiento)
        {
            SqlCommand cmd = new SqlCommand(procedimiento,Conectar.ObtenerConexion());
        }

        
        public ArrayList ListadoAfiliados()
        {
            ArrayList listado = new ArrayList();
            Afiliado nuevo;
            cmd = new SqlCommand("select * from afiliados order by 4", Conectar.ObtenerConexion());
            
            dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();
            while(dr.Read())
            {
                int idAfiliado = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                string apellido = dr.GetString(2);
                int nroDoc = dr.GetInt32(3);
                string fechaNac = dr.GetString(4);
                string email = dr.GetString(5);
                string nroTel = dr.GetString(6);
                string direccion = dr.GetString(7);
                string barrio = dr.GetString(8);
                int idLocalidad = dr.GetInt32(9);
                int tipoAfilID = dr.GetInt32(10);
                int metodoPagoID = dr.GetInt32(11);
                string nroCuenta = dr.GetString(12);
                int estadoGremialID = dr.GetInt32(13);

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
            dr =cmd.ExecuteReader();
            Conectar.CerrarConexion();
            if (dr.Read())
            {
                
                string nombreCompleto = dr.GetString(0);
                int nroDoc = dr.GetInt32(1);
                string tipoAfiliado = dr.GetString(2);
                string estado = dr.GetString(3);
                string formaPago = dr.GetString(4);
                int codigo = dr.GetInt32(5);

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

        public bool IsMesPago(int afiliadoID,int anio)
        {
            bool flag = false;
            cmd = new SqlCommand("SP_IS_PAGADO_MES", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AFILIADOID", SqlDbType.Int).Value = afiliadoID;
            cmd.Parameters.Add("@ANIO", SqlDbType.Int).Value = anio;
            dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();

            if (dr.Read())
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
