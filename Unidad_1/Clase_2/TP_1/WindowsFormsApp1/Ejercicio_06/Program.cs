using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si la circunferencia de un círculo es pi *Diámetro, desarrollar una aplicación que dada la circunferencia calcule el diámetro.
            // Circunferencia entre Pi da el diametro
            double circunferencia = 0;
            const double PI = 3.1415926535897931;
            double diametro = 0;

            Console.WriteLine("Ingrese la Circunferencia:");
            circunferencia = Convert.ToInt32(Console.ReadLine());

            diametro = circunferencia / PI;
            
            Console.Clear();//limpiamos pantalla

            Console.WriteLine("El Diametro es : {0:N}", diametro);//muestra de datos

            Console.ReadKey();

        }
    }
}
