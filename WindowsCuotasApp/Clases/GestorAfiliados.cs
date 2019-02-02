using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsCuotasApp.Clases
{
    class GestorAfiliados
    {
        SqlCommand cmd;
        SqlDataReader dr;
        const int tam = 1000;



        public SqlDataReader pDr
        { set { dr = value; } get { return dr; } }


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

        
        public ArrayList listadoAfiliados()
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



        public DataTable consultarTabla(string nombreTabla)
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
