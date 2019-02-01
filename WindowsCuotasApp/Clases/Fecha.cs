using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCuotasApp.Clases
{
    class Fecha
    {
        private int mes { get; }

        public int getMes()
        {
            int mes = DateTime.Now.Month;
            return mes;
        }

        public int getAnio()
        {
            int anio = DateTime.Now.Year;
            return anio;
        }


        public string detalleMes(int mes)
        {
            string salida = "";
            switch (mes)
            {
                case 1:
                    salida = "ENERO";
                    break;
                case 2:
                    salida = "FEBRERO";
                    break;
                case 3:
                    salida = "MARZO";
                    break;
                case 4:
                    salida = "ABRIL";
                    break;
                case 5:
                    salida = "MAYO";
                    break;
                case 6:
                    salida = "JUNIO";
                    break;
                case 7:
                    salida = "JULIO";
                    break;
                case 8:
                    salida = "AGOSTO";
                    break;
                case 9:
                    salida = "SEPTIEMBRE";
                    break;
                case 10:
                    salida = "OCTUBRE";
                    break;
                case 11:
                    salida = "NOVIEMBRE";
                    break;
                default:
                    salida = "DICIEMBRE";
                    break;
            }

            return salida;
        }

    }
   
}
