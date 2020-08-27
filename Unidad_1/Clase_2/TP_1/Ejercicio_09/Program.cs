using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dadas dos frases concatenarlas y mostrar el resultado. 
            string frase1 = null;
            string frase2 = null;
            string fraseFinal = null;
            //Ingreso de datos
            Console.WriteLine("Ingrese primera Frase:");
            frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese segunda Frase:");
            frase2 = Console.ReadLine();

            fraseFinal =String.Concat(frase1, frase2);//  contatenamos las dos frases

            Console.WriteLine(fraseFinal);//mostramos resultado 
        }
    }
}
