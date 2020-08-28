using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dada una fecha mostrarla en el formato AAAAMMDD.
            DateTime fecha;
            Console.WriteLine("Ingrese una Una fecha:");
            fecha = Convert.ToDateTime(Console.ReadLine());
         
            Console.WriteLine("Fecha Actual es {0}", string.Format("{0:d}", fecha.ToString("yyyy/MM/dd")));
        }
    }
}
