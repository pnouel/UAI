using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular el factorial de 6.
            const int num = 6;
            int acumulador = num;


            for (int i = num-1; i > 0; i--)// hacemos un cliclo decreciente y valor inicial de i  igual al num -1
            {
                
                acumulador = acumulador * i;
            }

            Console.WriteLine("Factorial de 6 es : {0}",acumulador);

        }
    }
}
