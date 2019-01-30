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



    }
   
}
