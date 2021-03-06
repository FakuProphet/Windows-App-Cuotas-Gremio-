﻿using System;
using System.Data.SqlClient;


namespace WindowsCuotasApp.Clases
{
    class Conectar
    {
        static string cadena = "Data Source=.;Initial Catalog=cuotasDB;Integrated Security=True";


        public static string pCadena
        {
            get { return cadena; }
        }


        public static SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conectar = new SqlConnection(cadena);
                conectar.Open();
                return conectar;
            }
            catch (Exception)
            {
                throw new Exception("Error en la conexion");
            }
        }


        public static SqlConnection CerrarConexion()
        {
            SqlConnection desconectar = new SqlConnection(cadena);
            desconectar.Close();
            desconectar.Dispose();
            return desconectar;
        }
    }
}
