using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dada una frase informar la cantidad de caracteres que tiene.
            string frase = null;
            //Ingreso de datos
            Console.WriteLine("Ingrese la Frase:");
            frase = Console.ReadLine();
            //mostras la longitud de la frase

            Console.WriteLine("La frase tiene una longitud de : {0} caracteres",frase.Length);
        }
    }
}
