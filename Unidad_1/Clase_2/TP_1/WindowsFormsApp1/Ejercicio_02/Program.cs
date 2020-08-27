using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Desarrollar una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos.

            int Numero = 0;
            int numero2 = 0;
            int i = 0;
            int Inicio = 0;
            int fin = 0;

            Console.WriteLine("Ingrese un numero por favor: ");
            Numero = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Ingrese otro numero por favor: ");
            numero2 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine(numero2 - Numero);

        }
    }
}
