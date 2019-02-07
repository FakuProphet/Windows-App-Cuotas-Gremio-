

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsCuotasApp.Clases
{
    class Validar
    {
        SqlCommand cmd;



        public bool EsEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        public bool existeDocumento(int doc)
        {

            bool bandera = false ;
            SqlDataReader dr;
            cmd = new SqlCommand("SP_EXISTE_DNI_AFILIADO", Conectar.ObtenerConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NRODOC", SqlDbType.Int).Value = doc;
            dr = cmd.ExecuteReader();
            Conectar.CerrarConexion();

            if (dr.Read())
            {
                bandera = true;
            }

            return bandera;
        }


        public bool validarCampos(GroupBox groupBox)
        {
            bool bandera = true;
            foreach (TextBox t in groupBox.Controls)
            {
                if (string.IsNullOrEmpty(t.Text))
                {
                    MessageBox.Show("El campo esta vacio","Campo vacio");
                    t.Focus();
                    bandera = false;
                }
            }
            return bandera;
        }

    }
}
