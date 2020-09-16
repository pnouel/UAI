using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Informar cuantos días faltan para el 25/12/2020.
            
            DateTime thisFecha = new DateTime(2020, 12, 25);
            TimeSpan daysDiff;
            int diferenciaEntera;
            
           
           daysDiff = ( thisFecha.Subtract(DateTime.Now));
           diferenciaEntera = Math.Abs( Convert.ToInt32(daysDiff.TotalDays)); 

            Console.WriteLine("Los Dias que faltan hasta 2020/12/25 son : {0}" ,  diferenciaEntera);
        }
    }
}
