

using System.Data;
using System.Data.SqlClient;

namespace WindowsCuotasApp.Clases
{
    class GestorTransaccion
    {
        /*Gestionar lo referente a las cuotas del afiliado*/

        public void transaccionCuotaAfiliado(CuotaAfiliado c)
        {
            SqlCommand cmd = new SqlCommand("SP_TRANSACCION_CUOTA_AFIL", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@afiliadoID",SqlDbType.Int).Value=c.afiliadoID;
            cmd.Parameters.Add("@mes", SqlDbType.Int).Value = c.mes;
            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = c.anio;
            cmd.ExecuteNonQuery();
            //cmd.Parameters.Clear();
            Conectar.CerrarConexion();
        }


    }
}
