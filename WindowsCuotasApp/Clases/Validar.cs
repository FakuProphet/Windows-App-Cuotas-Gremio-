﻿

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

        public void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        public void soloTexto(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


    }
}
