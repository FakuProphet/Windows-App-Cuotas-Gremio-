

using System.Data;
using System.Data.SqlClient;

namespace WindowsCuotasApp.Clases.LOGUIN
{
    class GestorLoguin
    {

        SqlDataReader dr;

        public SqlDataReader Dr { get => dr; set => dr = value; }

        public User GetUsuario(string user,string pass)
        {

            User u = null;

            SqlCommand cmd = new SqlCommand("SP_GET_USUARIO_APP", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@CONTRASENIA", SqlDbType.VarChar).Value = pass;

            Dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();
            if (Dr.Read())
            {

                string usuario = Dr.GetString(0);
                string contrasenia = Dr.GetString(1);

                u = new User { Usuario = usuario, Constraseña = contrasenia };

            }

            return u;
        }
    }
}
