

using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace WindowsCuotasApp.Clases.LOGUIN
{
    class GestorLoguin
    {

        SqlDataReader dr;
        SqlCommand cmd;


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


        public void GuardarIngresoSistema(User usuario)
        {

            SqlCommand cmd = new SqlCommand("sp_guardar_loguin", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.Usuario;
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();
        }

        public void GuardarAnotacion(string texto)
        {
            SqlCommand cmd = new SqlCommand("sp_agregar_anotacion", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@contenido", SqlDbType.VarChar).Value = texto;
            cmd.ExecuteNonQuery();
            Conectar.CerrarConexion();
        }


        public Anotacion GetAnotacion(int numero)
        {

            Anotacion a = null;

            cmd = new SqlCommand("sp_get_anotacion", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = numero;
           
            Dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();
            if (Dr.Read())
            {
                a = new Anotacion();
                a.Numero = Dr.GetInt32(0);
                a.Fecha = Dr.GetString(1);
                a.Contenido = Dr.GetString(2);
                a.FechaLarga = Dr.GetDateTime(3);
            }

            return a;
        }

    }
}
