using System.Data;
using System.Data.SqlClient;


namespace WindowsCuotasApp.Clases
{
    class GestorAfiliados
    {
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
