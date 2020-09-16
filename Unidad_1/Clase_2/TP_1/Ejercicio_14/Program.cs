using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {

           // Dadas dos fechas calcular la diferencia en días entre una y la otra
            DateTime primeraFecha;
            DateTime segundaFecha;
            TimeSpan daysDiff;
            int diferenciaEntera;
            Console.WriteLine("Ingresela primera fecha:");
            primeraFecha = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Ingresela primera fecha:");
            segundaFecha = Convert.ToDateTime(Console.ReadLine());
           
            daysDiff = ( primeraFecha.Subtract(segundaFecha));
           diferenciaEntera = Math.Abs( Convert.ToInt32(daysDiff.TotalDays)); 

            Console.WriteLine(diferenciaEntera);



        }
    }
}
