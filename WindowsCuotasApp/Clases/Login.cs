using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCuotasApp.Clases
{
    class Login
    {
        string myHash = "f0xle@rn";

        public string Encriptar(string entrada)
        {
            string salida = string.Empty;
            byte[] datos = UTF8Encoding.UTF8.GetBytes(entrada);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = UTF8Encoding.UTF8.GetBytes(myHash);
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() {Key=keys,Mode= CipherMode.ECB, Padding = PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] resultado = transform.TransformFinalBlock(datos,0,datos.Length);
                    salida = Convert.ToBase64String(resultado,0,resultado.Length);
                }
            }

            return salida;
        }
    }
}
