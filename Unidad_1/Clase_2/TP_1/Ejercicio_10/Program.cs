using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dada una frase cualquiera llamada x, mostrar como resultado una frase formada por la segunda mitad de x más la primer mitad de x. (usar el método substring)

            string frase = null;
            //solicitamos datos
            Console.WriteLine("Ingrese primera Frase:");
            frase = Console.ReadLine();
            // usamos el metodo subString para concatenar la segunda  y primera mitad de la frase
            Console.WriteLine( frase.Substring(frase.Length / 2) + frase.Substring(0, frase.Length / 2)); 

        }
    }
}
