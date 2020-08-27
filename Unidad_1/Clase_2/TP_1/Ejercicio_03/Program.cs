using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {

            int ladoA = 0;
            int ladoB = 0;
            int ladoC = 0;
            int perimetro = 0;
            //Dados los lados de un triangulo calcular el perímetro.
            //ingreso de datos
            Console.WriteLine("Ingrese el lado A:");
            ladoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el lado B");
            ladoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el lado C");
            ladoC = Convert.ToInt32(Console.ReadLine());
            //calculo de perimetro
            perimetro = ladoA + ladoB + ladoC;
            
            Console.Clear();//limpiamos pantalla
           
            Console.WriteLine("El Perimetro del triangulo es : {0}",perimetro);//muestra de datos

            Console.ReadKey();

        }
    }
}
