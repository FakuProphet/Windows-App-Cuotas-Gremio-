

using System.Data;
using System.Data.SqlClient;

namespace WindowsCuotasApp.Clases
{
    class GestorTransaccion
    {
        /*Gestionar lo referente a las cuotas del afiliado*/

        public void transaccionCuotaAfiliado(int id,int mes,int anio)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CUOTAS (afiliadoID,mes,anio) values ("+id+","+mes+","+anio+")", Conectar.ObtenerConexion());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@afiliadoID",SqlDbType.Int).Value=c.afiliadoID;
            //cmd.Parameters.Add("@mes", SqlDbType.Int).Value = c.mes;
            //cmd.Parameters.Add("@anio", SqlDbType.Int).Value = c.anio;
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();
        }


    }
}
