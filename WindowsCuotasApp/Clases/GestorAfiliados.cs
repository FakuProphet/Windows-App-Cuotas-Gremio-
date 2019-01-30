using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsCuotasApp.Clases
{
    class GestorAfiliados
    {
        /*Prueba*/
        /*prueba 3*/
        public void registrarAfiliado(Afiliado a)
        {
                /*INCOMPLETO*/
           
                SqlCommand cmd = new SqlCommand("proc_insertar_afiliado",Conectar.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = a.nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = a.apellido;
          

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
