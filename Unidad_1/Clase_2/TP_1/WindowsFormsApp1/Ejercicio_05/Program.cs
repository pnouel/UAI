using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados los datos necesarios de un Rectángulo calcular la superficie.
            // La superficie de un rectangulo se calcula con base * altura
        int baseRec = 0;
            int alturaRec = 0;
            int superficeRec = 0;
            //Ingreso de datos
            Console.WriteLine("Ingrese la base:");
            baseRec = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ingrese la altura:");
            alturaRec = Convert.ToInt32(Console.ReadLine());

            superficeRec = baseRec * alturaRec;//calculo de superfice

            Console.Clear();//limpiamos pantalla

            Console.WriteLine("La superficie del Rectangulo es : {0}", superficeRec);//muestra de datos

            Console.ReadKey();



        }
    }
}
