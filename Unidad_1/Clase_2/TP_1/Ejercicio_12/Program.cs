using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar la fecha y hora actual.
            DateTime fecha = DateTime.Now;
            Console.WriteLine("Fecha Actual es {0}",fecha.ToShortDateString());
        }
    }
}
