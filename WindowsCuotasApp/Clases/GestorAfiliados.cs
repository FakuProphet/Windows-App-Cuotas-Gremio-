using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsCuotasApp.Clases
{
    class GestorAfiliados
    {
       
        public void registrarAfiliado(Afiliado a)
        {
                
           /*sujeto a cambios*/
            SqlCommand cmd = new SqlCommand("proc_insertar_afiliado",Conectar.ObtenerConexion());
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
            cmd.Parameters.Add("@nroCuenta", SqlDbType.VarChar).Value = a.cbu;
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();


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
