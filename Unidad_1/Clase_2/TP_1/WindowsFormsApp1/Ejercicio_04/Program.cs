using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados los datos necesarios de un Cuadrado calcular la superficie.
            int lado = 0;
            int superficie = 0;
            // la superficie de un cuadrado es base al cuadrado
            //Ingreso de datos
            Console.WriteLine("Ingrese la base:");
            lado = Convert.ToInt32(Console.ReadLine());

            superficie = lado * lado;//Calculo de superficie

            Console.Clear();//limpiamos pantalla

            Console.WriteLine("La superficie del cuadrado es : {0}",superficie);//muestra de datos

            Console.ReadKey();
        }
    }
}
